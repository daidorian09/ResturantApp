using System;
using System.Windows.Forms;
using RestaurantApp.Services;

namespace RestaurantApp
{
    public partial class AppMenu : Form, IWindowsFormServices
    {
        private RegisterServices _registerServices = new RegisterServices();
        public AppMenu()
        {
            InitializeComponent();
        }
        public void MaximizeScreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }
        private void AppMenu_Load(object sender, EventArgs e)
        {
            MaximizeScreen();
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
        private void btnTables_Click(object sender, EventArgs e)
        {
            DisplayTables displayTables = new DisplayTables();
            displayTables.Show();
            this.Dispose();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            AppMenuDesign menuDesign = new AppMenuDesign();
            menuDesign.Show();
            this.Dispose();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            DisplayTodaysTotalRevenue();
        }
        private void DisplayTodaysTotalRevenue()
        {
            MessageBox.Show($"Bugünkü Toplam Kazanç : "+" "+ _registerServices.SumDailyCash().ToString()+" TL", "Bilgilendirme",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            UsersForm userForm = new UsersForm();
            userForm.Show();
            this.Dispose();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            ReturnLoginForm();
        }
        private void ReturnLoginForm()
        {
            Login login = new Login();
            login.Show();
            this.Dispose();
        }
    }
}
