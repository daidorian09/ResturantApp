using System;
using System.Linq;
using System.Windows.Forms;
using RestaurantApp.Services;

namespace RestaurantApp
{
    public partial class RecoverPassword : Form
    {
        private StaffRecoverTokenServices _staffRecoverTokenServices = new StaffRecoverTokenServices();
        private StaffServices _staffServices = new StaffServices();
        private string _email = null;
        private int _id = 0;
        public RecoverPassword()
        {
            InitializeComponent();
        }

        private void btnRecoverPassword_Click(object sender, EventArgs e)
        {
            if (isTokenValid(txtRecoveryToken.Text))
            {
                RecoverForgottenPassword();
                DisplayPasswordRecoveredSuccessfully();
                ReturnLoginForm();
            }
            else
            {
                DisplayTokenNotValidMessage();
            }
        }
        private bool isTokenValid(string token)
        {
            var recoverToken = _staffRecoverTokenServices.Where(q => q.token == token);
            return recoverToken.Count() > 0 ? true : false;
        }
        private string GetEmailAddress()
        {
            var user = _staffRecoverTokenServices.Where(q => q.token == txtRecoveryToken.Text);
            foreach (var item in user)
            {
                _email = item.email;
            }
            return _email;
        }
        private int GetUserId()
        {
            _email = GetEmailAddress();
            var user = _staffServices.Where(q => q.email == _email);
            foreach (var item in user)
            {
                _id = item.id;
            }
            return _id;
        }
        private void RecoverForgottenPassword()
        {
            _id = GetUserId();
            var user = _staffServices.Context.staffs.Find(_id);
            user.password = _staffServices.SHA512(txtNewPassword.Text);
            user.modifiedAt = DateTime.Now;
            _staffServices.saveChanges();
        }
        private void DisplayPasswordRecoveredSuccessfully()
        {
            MessageBox.Show($"Şifreniz Başarılı Bir Şekilde Güncellendi", "Mesaj",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
        }
        private void DisplayTokenNotValidMessage()
        {
            MessageBox.Show(txtRecoveryToken.Text+$" Kod Geçersizdir", "Hata",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
        }
        private void ReturnLoginForm()
        {
            Login login = new Login();
            login.Show();
            this.Dispose();
        }
    }
}
