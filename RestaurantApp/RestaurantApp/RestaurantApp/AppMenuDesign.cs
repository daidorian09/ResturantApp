using System;
using System.Windows.Forms;
using RestaurantApp.Model;
using RestaurantApp.Services;
using RestaurantApp.Utilities;

namespace RestaurantApp
{
    public partial class AppMenuDesign : Form, IWindowsFormServices

    {
        private CategoryServices _categoryServices = new CategoryServices();
        private ProductServices _productServices = new ProductServices();
        private int _productId = 0, _categoryId = 0;
        public AppMenuDesign()
        {
            InitializeComponent();
        }
        private void AppMenuDesign_Load(object sender, EventArgs e)
        {
            MaximizeScreen();
            FillCategoryGridViewColumns();
            FillCategoryGridViewRows();
            FillProductGridViewColumns();
            FillProductGridViewRows();
            FillCategoryComboBox();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            AppMenu appMenu = new AppMenu();
            appMenu.Show();
        }
        public void MaximizeScreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
        private void FillCategoryGridViewColumns()
        {
            categoryGridView.Columns.Add("ID", "id");
            categoryGridView.Columns.Add("name", "Adı");
            categoryGridView.Columns.Add("created_at", "Kayıt Tarihi");
            categoryGridView.Columns["ID"].Visible = false;
        }
        private void FillCategoryGridViewRows()
        {
            var categoryList= _categoryServices.FilterEntityByName(q=>q.name);
            foreach (var item in categoryList)
            {
                categoryGridView.Rows.Add(item.id, item.name, item.createdAt);
            }
        }
        private void FillProductGridViewColumns()
        {
            productGridView.Columns.Add("ID", "id");
            productGridView.Columns.Add("name", "Adı");
            productGridView.Columns.Add("category", "Kategorisi");
            productGridView.Columns.Add("created_at", "Kayıt Tarihi"); ;
            productGridView.Columns["ID"].Visible = false;
        }
        private void FillProductGridViewRows()
        {
            var productList = _productServices.FilterEntityByName(q => q.category.name);
            foreach (var item in productList)
            {
                productGridView.Rows.Add(item.id, item.name, item.category.name, item.createdAt);
            }
        }

        private void productGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            makeProductGroupBoxVisibilityTrue();
            _productId = Convert.ToInt32(productGridView.Rows[e.RowIndex].Cells["id"].Value.ToString());
            FillProductRelatedComponents(_productId);
        }
        private void makeProductGroupBoxVisibilityFalse()
        {
            productGroupBox.Visible = false;
        }
        private void makeProductGroupBoxVisibilityTrue()
        {
            productGroupBox.Visible = true;
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            CompleteAddProduct();
        }

        private void FillCategoryComboBox()
        {
            var categoryList = _categoryServices.FilterEntityByName(q => q.name);
            foreach (var item in categoryList)
            {
                cmbCategory.Items.Add(new ComboBoxWithProps(item.id, item.name));
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
           CompleteEditProduct();
        }

        private void RefreshProductGridView()
        {
            productGridView.Rows.Clear();
            productGridView.Columns.Clear();
            FillProductGridViewColumns();
            FillProductGridViewRows();
        }
        private void RefreshCategoryGridView()
        {
            categoryGridView.Rows.Clear();
            categoryGridView.Columns.Clear();
            FillCategoryGridViewColumns();
            FillCategoryGridViewRows();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var product = _productServices.Where(q => q.id == _productId);
                foreach (var item in product)
                {
                    _productServices.Remove(item);
                }
                _productServices.saveChanges();
                RefreshProductGridView();
                makeProductGroupBoxVisibilityFalse();
            }
            catch(Exception)
            {
                DisplayProductOnTheUse();
            }
        }
        private void DisplayProductOnTheUse()
        {
            MessageBox.Show($"Ürün Şu Anda Kullanılmaktadır", "Hata",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
        }

        private void CompleteAddProduct()
        {
            InitiateProductObjectForInsert();
            RefreshProductGridView();
            makeProductGroupBoxVisibilityFalse();
        }
        private void CompleteEditProduct()
        {
            InitiateProductObjectForEdit();
            RefreshProductGridView();
            makeProductGroupBoxVisibilityFalse();
        }

         private void InitiateProductObjectForInsert()
        {
            _categoryId = ((ComboBoxWithProps)cmbCategory.SelectedItem).Id;
            _productServices.Insert(new Products
            {
                price = float.Parse(txtProductPrice.Text),
                name = txtProductName.Text,
                createdAt = DateTime.Now,
                category = _productServices.Context.categories.Find(_categoryId)
            });
            _productServices.saveChanges();
        }
        
        private void InitiateProductObjectForEdit()
        {
            _categoryId = ((ComboBoxWithProps)cmbCategory.SelectedItem).Id;
            var product = _productServices.Context.products.Find(_productId);
            product.price = float.Parse(txtProductPrice.Text);
            product.name = txtProductName.Text;
            product.createdAt = DateTime.Now;
            product.category = _productServices.Context.categories.Find(_categoryId);
            _productServices.saveChanges();
        }
        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            CompleteAddCategory();
        }

        private void CompleteAddCategory()
        {
            _categoryServices.Insert(new Categories
            {
                name = txtCategoryName.Text,
                createdAt = DateTime.Now,
            });
            _categoryServices.saveChanges();
            RefreshCategoryGridView();
            makeCategoryGroupBoxVisibilityFalse();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            CompleteEditCategory();
            RefreshProductGridView();
        }
        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            var category = _categoryServices.Where(q => q.id == _categoryId);
            foreach (var item in category)
            {
                _categoryServices.Remove(item);
            }
            _categoryServices.saveChanges();
            RefreshCategoryGridView();
            makeCategoryGroupBoxVisibilityFalse();
        }

        private void CompleteEditCategory()
        {
            InitiateCategoryObjectForEdit();
            RefreshCategoryGridView();
            makeCategoryGroupBoxVisibilityFalse();
        }
        private void InitiateCategoryObjectForEdit()
        {
            var category = _categoryServices.Context.categories.Find(_categoryId);
            category.name = txtCategoryName.Text;
            category.createdAt = DateTime.Now;
            _categoryServices.saveChanges();
        }

        private void categoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            makeCategoryGroupBoxVisibilityTrue();
            _categoryId = Convert.ToInt32(categoryGridView.Rows[e.RowIndex].Cells["id"].Value.ToString());
            FillCategoryRelatedComponent();
        }

        private void makeCategoryGroupBoxVisibilityFalse()
        {
            categoryGroupBox.Visible = false;
        }
        private void makeCategoryGroupBoxVisibilityTrue()
        {
            categoryGroupBox.Visible = true;
        }
        private void FillCategoryRelatedComponent()
        {
            var category = _categoryServices.Context.categories.Find(_categoryId);
            txtCategoryName.Text = category.name;
        }

        private void FillProductRelatedComponents(int productId)
        {
            var product = _productServices.Context.products.Find(productId);
            txtProductName.Text = product.name;
            txtProductPrice.Text = product.price.ToString();
            SetCategoryNameForProduct(product.category.name);
        }

        private void SetCategoryNameForProduct(string categoryName)
        {
            cmbCategory.SelectedIndex = cmbCategory.FindStringExact(categoryName);
        }
    }
}
