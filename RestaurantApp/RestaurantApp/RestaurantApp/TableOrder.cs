using System;
using System.Windows.Forms;
using RestaurantApp.Utilities;
using RestaurantApp.Services;
using RestaurantApp.Model;
using RestaurantApp.DAL;
namespace RestaurantApp
{
    public partial class TableOrder : Form, IWindowsFormServices
    {
        private CategoryServices _categoryServices = new CategoryServices();
        private ProductServices _productServices = new ProductServices();
        private CheckOutServices _checkOutServices = new CheckOutServices();
        private TableServices _tableServices = new TableServices();
        private RegisterServices _registerServices = new RegisterServices();
        private int _orderId = 0;
        private float _total = 0;
        public TableOrder()
        {
            InitializeComponent();
        }
        private void TableOrder_Load(object sender, EventArgs e)
        {
                FillComboBoxForCategories();
                FillOrderGridViewColumns();
                FillOrderGridViewRows();
                MaximizeScreen();
        }
        private void FillComboBoxForCategories()
        {
            var categoryList = _categoryServices.FilterEntityByName(q => q.name);
            foreach (var item in categoryList)
            {
                cmbCategory.Items.Add(new ComboBoxWithProps(item.id,item.name));
            }
        }
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbProduct.Items.Clear();
                var productList = _productServices.Where(q => q.category.id == ((ComboBoxWithProps)cmbCategory.SelectedItem).Id);
                foreach (var item in productList)
                {
                    cmbProduct.Items.Add(new ComboBoxWithProps(item.id, item.name));
                }
            }
            catch (Exception)
            {
                DisplayEmptySelectedComboBoxMessage();
            }
        }
        private void DisplayEmptySelectedComboBoxMessage()
        {
            MessageBox.Show($"Kategori Seçiniz", "Hata",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
        }
        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = _productServices.Context.products.Find(((ComboBoxWithProps)cmbProduct.SelectedItem).Id);
            txtProductPrice.Text =product.price.ToString()+" TL";
        }
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                _checkOutServices.Insert(new Checkouts
                {
                    quantity = Convert.ToInt32(txtQuantity.Text),
                    product = _checkOutServices.Context.products.Find(((ComboBoxWithProps)cmbProduct.SelectedItem).Id),
                    table = _checkOutServices.Context.tables.Find(DisplayTables.tableId),
                    orderedAt = DateTime.Now,
                });
                _checkOutServices.saveChanges();
                RefreshOrderGridView();
                MakeTableStatusFull();
            }
            catch (Exception)
            {
                MessageBox.Show($"Sipariş Eksik Alınmıştır", "Hata",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                ClearWindowsFormComponentsOnThisForm();
            }
        }
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            var order = _checkOutServices.Where(q => q.id == _orderId);
            foreach (var item in order)
            {
                _checkOutServices.Remove(item);
            }
            _checkOutServices.saveChanges();
            RefreshOrderGridView();
            makeTableGroupBoxVisibilityFalse();
        }
        private void btnOrderCanceled_Click(object sender, EventArgs e)
        {
            ClearWindowsFormComponentsOnThisForm();
        }
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show($"Masa " + DisplayTables.tableId + " Hesap Al", "Masa Hesap Sorgulama",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Information);
            ConfirmDialogResultYes();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            ReturnDisplayTableWindow();
        }
     
        private void ConfirmDialogResultYes()
        {
            MessageBox.Show($"Masa " + DisplayTables.tableId + " Toplam Hesap : " + _checkOutServices.SumOfTable(DisplayTables.tableId).ToString() + " TL");
            InsertCashIntoRegister();
            CheckOutTableReceipt();
            MakeTableStatusEmpty();
        }
        private void InsertCashIntoRegister()
        {
                _registerServices.Insert(new Register
                {
                    dailySumCash = CalculateDailyCashFlow(),
                    registeredAt = DateTime.Now
                });
                _registerServices.saveChanges();
        }
        private float CalculateDailyCashFlow()
        {
            return _total + _checkOutServices.SumOfTable(DisplayTables.tableId);
        }
        private void ReturnDisplayTableWindow()
        {
            DisplayTables displayTables = new DisplayTables();
            displayTables.Show();
            this.Hide();
        }
        private void CheckOutTableReceipt()
        {
            EmptyTableWithReceipt();
            ClearWindowsFormComponentsOnThisForm();
            RefreshOrderGridView();
        }
        private void EmptyTableWithReceipt()
        {
            var table = _checkOutServices.Where(q => q.table.id == DisplayTables.tableId);
            foreach (var item in table)
            {
                _checkOutServices.Remove(item);
            }
            _checkOutServices.saveChanges();
        }
        public void ClearWindowsFormComponentsOnThisForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    control.Text = null;
                if (control is ComboBox)
                    control.ResetText();
            }
        }
        private void FillOrderGridViewRows()
        {
            var tableOrderList = _checkOutServices.Where(q => q.table.id == DisplayTables.tableId);
            foreach (var item in tableOrderList)
            {
                orderGridView.Rows.Add(item.id, item.product.name, item.quantity, item.product.price, item.orderedAt, item.quantity * item.product.price);
            }
        }

        private void FillOrderGridViewColumns()
        {
            orderGridView.Columns.Add("ID", "id");
            orderGridView.Columns.Add("product", "Ürün");
            orderGridView.Columns.Add("quantity", "Sipariş Adeti");
            orderGridView.Columns.Add("price", "Ürün Fiyatı");
            orderGridView.Columns.Add("ordered_at", "Sipariş Tarihi");
            orderGridView.Columns.Add("total", "Toplam");
            orderGridView.Columns["ID"].Visible = false;
        }
        public void RefreshOrderGridView()
        {
            orderGridView.Rows.Clear();
            orderGridView.Columns.Clear();
            FillOrderGridViewColumns();
            FillOrderGridViewRows();
        }
        public void MakeTableStatusFull()
        {
            var table = _tableServices.Context.tables.Find(Convert.ToInt32(DisplayTables.tableId));
            table.tableStatus = _tableServices.Context.tableStatus.Find((int)RestaurantAppEnum.TableFull);
            _tableServices.Edit(table);
            _tableServices.saveChanges();
        }
        public void MakeTableStatusEmpty()
        {
            var tableList = _tableServices.Context.tables.Find(Convert.ToInt32(DisplayTables.tableId));
            tableList.tableStatus = _tableServices.Context.tableStatus.Find((int)RestaurantAppEnum.TableEmpty);
            _tableServices.Edit(tableList);
            _tableServices.saveChanges();
        }
        private void txtQuantity_Validated(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantity.Text))
            {
                if (Convert.ToInt32(txtQuantity.Text) < 0)
                {
                    MessageBox.Show($"Ürün Adeti Yanlış Girilmiştir", "Hata",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                    btnAddOrder.Enabled = false;
                }
                else
                {
                    btnAddOrder.Enabled = Enabled;
                }
            }
            else
            {
                txtQuantity.Text = "";
            }
        }
        public void MaximizeScreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
        private void orderGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cmbSelectedCategory.Items.Clear();
                _orderId = Convert.ToInt32(orderGridView.Rows[e.RowIndex].Cells["id"].Value.ToString());
                tableGroupBox.Visible = true;
                FillComboBoxForSelectedCategories();
                FillOrderGroupBox(_orderId);
            }
            catch (Exception)
            {
                MessageBox.Show($"Masadan Henüz Sipariş Alınmamıştır", "Hata",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
            }
        }
        private void FillComboBoxForSelectedCategories()
        {
            var categoryList = _categoryServices.FilterEntityByName(q => q.name);
            foreach (var item in categoryList)
            {
                cmbSelectedCategory.Items.Add(new ComboBoxWithProps(item.id, item.name));
            }
        }
        private void cmbSelectedProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = _productServices.Context.products.Find(((ComboBoxWithProps)cmbSelectedProduct.SelectedItem).Id);
            txtSelectedProductPrice.Text = product.price.ToString() + " TL";
        }
        private void cmbSelectedCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSelectedProduct.Items.Clear();
            var productList = _productServices.Where(q => q.category.id == ((ComboBoxWithProps)cmbSelectedCategory.SelectedItem).Id);
            foreach (var item in productList)
            {
                cmbSelectedProduct.Items.Add(new ComboBoxWithProps(item.id, item.name));

            }
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            var order = _checkOutServices.Context.checkouts.Find(_orderId);
            order.product = _checkOutServices.Context.products.Find(((ComboBoxWithProps)cmbSelectedProduct.SelectedItem).Id);
            order.quantity = Convert.ToInt32(txtSelectedProductQuantity.Text);
            order.orderedAt = DateTime.Now;
            order.table = _checkOutServices.Context.tables.Find(DisplayTables.tableId);
            _checkOutServices.saveChanges();
            RefreshOrderGridView();
            makeTableGroupBoxVisibilityFalse();
        }

        private void FillOrderGroupBox(int orderId)
        {
            var order = _checkOutServices.Where(q => q.id == orderId);
            foreach (var item in order)
            {
                cmbSelectedCategory.SelectedIndex = cmbSelectedCategory.FindStringExact(item.product.category.name);
                cmbSelectedProduct.SelectedIndex = cmbSelectedProduct.FindStringExact(item.product.name);
                txtSelectedProductPrice.Text = item.product.price.ToString();
                txtSelectedProductQuantity.Text = item.quantity.ToString();
            }
        }
        private void makeTableGroupBoxVisibilityFalse()
        {
            tableGroupBox.Visible = false;
        }
        private void makeTableGroupBoxVisibilityTrue()
        {
            tableGroupBox.Visible = true;
        }
    }
}
