using System;
using System.Windows.Forms;
using RestaurantApp.Utilities;
using RestaurantApp.Services;

namespace RestaurantApp
{
    public partial class SwapTable : Form, IWindowsFormServices
    {
        private TableServices _tableServices = new TableServices();
        private CheckOutServices _checkOutServices = new CheckOutServices();
        public SwapTable()
        {
            InitializeComponent();
        }

        public void MaximizeScreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void SwapTable_Load(object sender, EventArgs e)
        {
            DisplayFullTables();
            DisplayEmptyTables();
        }
        
        private void DisplayFullTables()
        {
            var fullTableList = _tableServices.Where(q => q.tableStatus.id == (int)RestaurantAppEnum.TableFull);
            listFullTables.DataSource = fullTableList;
            foreach (var item in fullTableList)
            {
                listFullTables.DisplayMember = "publicName";
                listFullTables.ValueMember = "id";
            }
        }
        private void DisplayEmptyTables()
        {
            var emptyTableList = _tableServices.Where(q => q.tableStatus.id == (int)RestaurantAppEnum.TableEmpty);
            listEmptyTables.DataSource = emptyTableList;
            foreach (var item in emptyTableList)
            {
                listEmptyTables.DisplayMember = "publicName";
                listEmptyTables.ValueMember = "id";
            }
        }

        private void btnSwapNow_Click(object sender, EventArgs e)
        {
            int fullTableId = Convert.ToInt32(listFullTables.SelectedValue);
            int emptyTableId = Convert.ToInt32(listEmptyTables.SelectedValue);

            SwapTables(fullTableId, emptyTableId);
            EditTableForCheckOut(fullTableId, emptyTableId);

            RefreshListBoxes();
        }

        private void SwapTables(int fullTableId, int emptyTableId)
        {
            var fullTableList = _tableServices.Context.tables.Find(fullTableId);
            fullTableList.tableStatus = _tableServices.Context.tableStatus.Find((int)RestaurantAppEnum.TableEmpty);
            _tableServices.saveChanges();

            var emptyTableList = _tableServices.Context.tables.Find(emptyTableId);
            emptyTableList.tableStatus = _tableServices.Context.tableStatus.Find((int)RestaurantAppEnum.TableFull);
            _tableServices.saveChanges();
        }

        private void EditTableForCheckOut(int oldTableId,int newTableId)
        {
            var checkOutList = _checkOutServices.Where(q => q.table.id == oldTableId);
            foreach (var item in checkOutList)
            {
                item.table = _checkOutServices.Context.tables.Find(newTableId);
            }
            _checkOutServices.saveChanges();
        }

        private void RefreshListBoxes()
        {
            listFullTables.DataSource = null;
            listEmptyTables.DataSource = null;
            DisplayFullTables();
            DisplayEmptyTables();

        }

        private void btnReturnToDisplayMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DisplayTables displayTables = new DisplayTables();
            displayTables.Show();
        }
    }
}
