using System;
using System.Windows.Forms;
using RestaurantApp.Services;

namespace RestaurantApp
{
    public partial class ResetPassword : Form
    {
        private StaffServices _staffServices = new StaffServices();
        private Login _loginObject = new Login();
        public ResetPassword()
        {
            InitializeComponent();
        }
        private void DisplayPasswordFieldEmptyMessage()
        {
            MessageBox.Show($"Şifre Alanı Zorunludur", "Hata",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
        }
        private void DisplayPasswordChangedMessage()
        {
            MessageBox.Show($"Şifreniz Başarılı Bir Şekilde Güncellendi", "Mesaj",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
        }
        private void ReturnAppMenu()
        {
            AppMenu appMenu = new AppMenu();
            appMenu.Show();
            this.Dispose();
        }
        private void CompletePasswordChangeRequest()
        {
            var user = _staffServices.Context.staffs.Find(_loginObject.GetUserId());
            user.password = _staffServices.SHA512(txtNewPassword.Text);
            user.modifiedAt = DateTime.Now;
            _staffServices.saveChanges();
        }

        private void btnBackAppMenu_Click(object sender, EventArgs e)
        {
            ReturnAppMenu();
        }

        private void btnEditPassword_Click_1(object sender, EventArgs e)
        {
                CompletePasswordChangeRequest();
                DisplayPasswordChangedMessage();
                ReturnAppMenu();
        }

        private void txtNewPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtNewPassword.Text == string.Empty)
                DisplayPasswordFieldEmptyMessage();
        }
    }
}
