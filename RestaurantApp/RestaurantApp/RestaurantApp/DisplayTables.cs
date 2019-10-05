using System;
using System.Windows.Forms;
using RestaurantApp.Utilities;
using RestaurantApp.Services;

namespace RestaurantApp
{
    public partial class DisplayTables : Form, IWindowsFormServices
    {
        public static int tableId;
        private TableOrder _tableOrderObject = new TableOrder();
        private CheckOutServices _checkOutServices = new CheckOutServices();
        private TableServices _tableServices = new TableServices();

        public DisplayTables()
        {
            InitializeComponent();
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            MaximizeScreen();
            DisplayTableStatusOnLoad();
            DisplaySumOfTablesOnLoad();
        }
        private void DisplayTableStatusOnLoad()
        {
            var tableList = _tableServices.GetAll();
            foreach (var item in tableList)
            {
                DisplayFullTables(item.name, item.tableStatus.id);
                DisplayEmptyTables(item.name, item.tableStatus.id);
            }
        }
        private void DisplaySumOfTablesOnLoad()
        {
            var checkOutList = _checkOutServices.GetAll();
            foreach (var item in checkOutList)
            {
                DisplaySumOfTablesLabels(item.table.labelPriceTag, _checkOutServices.SumOfTable(item.table.id));
            }
        }
        private void DisplayFullTables(string tableName, int tableStatusId)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    DisplayFullButton((Button)control, tableName, tableStatusId);
                }
            }
        }
        private void DisplayEmptyTables(string tableName, int tableStatusId)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    DisplayEmptyButton((Button)control, tableName, tableStatusId);
                }
            }
        }
        private void DisplayFullButton(Button control, string tableName, int tableStatusId)
        {
            if (control.Name == tableName && tableStatusId == (int)RestaurantAppEnum.TableFull)
            {
                control.BackgroundImage = Properties.Resources.table_full;
            }
        }
        private void DisplayEmptyButton(Button control, string tableName, int tableStatusId)
        {
            if (control.Name == tableName && tableStatusId == (int)RestaurantAppEnum.TableEmpty)
            {
                control.BackgroundImage = Properties.Resources.table_empty;
            }
        }
        private void DisplaySumOfTablesLabels(string tableLabel, float totalOfTable)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    DisplaySumOfTablesOnLoad((Label)control, tableLabel, totalOfTable);
                }
            }
        }
        private void DisplaySumOfTablesOnLoad(Label control, string tableName, float total)
        {
            if (control.Name == tableName)
            {
                control.Text = total.ToString() + " TL";
            }
        }
        private void tableBtn1_Click(object sender, EventArgs e)
        {
            tableId = (int)RestaurantAppEnum.Table1;
            _tableOrderObject.Show();
            this.Dispose();
        }

        private void tableBtn2_Click(object sender, EventArgs e)
        {
            tableId = (int)RestaurantAppEnum.Table2;
            _tableOrderObject.Show();
            this.Dispose();
        }

        private void tableBtn3_Click(object sender, EventArgs e)
        {
            tableId = (int)RestaurantAppEnum.Table3;
            _tableOrderObject.Show();
            this.Dispose();
        }

        private void tableBtn4_Click(object sender, EventArgs e)
        {
            tableId = (int)RestaurantAppEnum.Table4;
            _tableOrderObject.Show();
            this.Dispose();
        }

        private void tableBtn5_Click(object sender, EventArgs e)
        {
            tableId = (int)RestaurantAppEnum.Table5;
            _tableOrderObject.Show();
            this.Dispose();
        }

        private void tableBtn6_Click(object sender, EventArgs e)
        {
            tableId = (int)RestaurantAppEnum.Table6;
            _tableOrderObject.Show();
            this.Dispose();
        }

        private void tableBtn7_Click(object sender, EventArgs e)
        {
            tableId = (int)RestaurantAppEnum.Table7;
            _tableOrderObject.Show();
            this.Dispose();
        }

        private void tableBtn8_Click(object sender, EventArgs e)
        {
            tableId = (int)RestaurantAppEnum.Table8;
            _tableOrderObject.Show();
            this.Dispose();
        }

        private void tableBtn9_Click(object sender, EventArgs e)
        {
            tableId = (int)RestaurantAppEnum.Table9;
            _tableOrderObject.Show();
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show($"Uygulamayı Kapatmak İstiyor Musunuz ?", "",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning);
            if (message == DialogResult.Yes)
            { 
                this.Dispose();
                Application.Exit();
            }
        }
        public void MaximizeScreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
        private void btnSwapTable_Click(object sender, EventArgs e)
        {
            SwapTable swapTable = new SwapTable();
            swapTable.Show();
            this.Dispose();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            AppMenu appMenu = new AppMenu();
            appMenu.Show();
            this.Dispose();
        }
    }
}