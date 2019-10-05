using System;
using System.Linq;
using System.Windows.Forms;
using RestaurantApp.Services;

namespace RestaurantApp
{
    public partial class Login : Form, IWindowsFormServices, ILogin
    {
        private StaffServices _staffServices = new StaffServices();
        public static int id = 0;
        public Login()
        {
            InitializeComponent();
        }

        public void MaximizeScreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MaximizeScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(isUserValidated(txtEmail.Text, _staffServices.SHA512(txtPassword.Text)))
            {
                id = GetUserId();
                this.Hide();
                AppMenu appMenu = new AppMenu();
                appMenu.Show();
            }
            else
            {
                DisplayUserValidationError();
            }
        }
        
        private bool isUserValidated(string email, string password)
        {
            var user = _staffServices.Where(q => q.email == email && q.password == password);
            foreach (var item in user)
            {
                id = item.id;
            }
            return user.Count() > 0 ? true : false;
        }
        private void DisplayUserValidationError()
        {
            MessageBox.Show(txtEmail.Text +$"  Adında Bir Kullanıcı Bulunamadı.", "Hata",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
        }
        public int GetUserId()
        {
            return id;
        }
        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }
    }
}
