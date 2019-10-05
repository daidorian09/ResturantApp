using System;
using System.Linq;
using System.Net.Mail;
using System.Windows.Forms;
using RestaurantApp.Model;
using RestaurantApp.Services;

namespace RestaurantApp
{
    public partial class ForgotPassword : Form, IWindowsSMTPMessage, IWindowsFormSecureWithSHA512
    {
        private MailMessage _email = null;
        private SmtpClient _smtp = null;
        private StaffRecoverTokenServices _staffRecoverTokenServices = new StaffRecoverTokenServices();
        private StaffServices _staffServices = new StaffServices();
        private string _recoveryToken = null;
        public ForgotPassword()
        {
            InitializeComponent();
        }

        public void SendMessageForForgottenPassword()
        {
            _email = InitiateMailMessageObject();
            AttachFrom();
            AttachUser();
            AttachSubject();
            _recoveryToken = GetRecoveryToken();
            AttachBody();
            _smtp = InitiateSMTPObject();
            ConfigureSMTPCredentials();
            CompleteSendMessage();
            OpenRecoverPasswordForm();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (isEmailExistent(txtForgottenEmail.Text))
                SendMessageForForgottenPassword();
            else
                DisplayUserNotExistentMessage();

        }

        private void DisplayUserNotExistentMessage()
        {
            MessageBox.Show(txtForgottenEmail.Text+$" isimli bir email adresi bulunamadı", "Hata",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
            ResetTextField();
        }
        private void ResetTextField()
        {
            txtForgottenEmail.Text = "";
        }

        private MailMessage InitiateMailMessageObject()
        {
            MailMessage emailObject = new MailMessage();
            return emailObject;
        }
        private void AttachFrom()
        {
            _email.From = new MailAddress("Your Email Address", txtForgottenEmail.Text);
        }
        private void AttachUser()
        {
            _email.To.Add(txtForgottenEmail.Text);
        }
        private void AttachSubject()
        {
            _email.Subject = "Şifre Kurtarma";
        }
        private void AttachBody()
        {
            _email.Body = txtForgottenEmail.Text + " Şifrenizi Kurtarmak İçin Oluşturulan Kodunuz "+_recoveryToken;
        }
        public string GetRecoveryToken()
        {
            return  SHA512(txtForgottenEmail.Text).Substring(0, 10);
        }

        public string SHA512(string email)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(email + DateTime.Now.ToString()+ "19291b001d");
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }
        private SmtpClient InitiateSMTPObject()
        {
            SmtpClient smtpObject = new SmtpClient();
            return smtpObject;
        }
        private void ConfigureSMTPCredentials()
        {
            _smtp.Credentials = new System.Net.NetworkCredential("Your Email Address", "Your Email Password");
            _smtp.Port = 587;
            _smtp.Host = "smtp.gmail.com";
            _smtp.EnableSsl = true;
        }
        private void CompleteSendMessage()
        {
            try
            {
                _smtp.SendAsync(_email, (object) _email);
                InsertRequestIntoDB();
                DisplaySendingMessageSuccessful();
            }
            catch (SmtpException)
            {
                DisplaySendingMessageError();
            }
        }
        private void DisplaySendingMessageError()
        {
            MessageBox.Show($"Mesaj Gönderilirken Bir Hata Oluştu", "Hata",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
        }
        private void DisplaySendingMessageSuccessful()
        {
            MessageBox.Show($"Mesaj Başarılı Bir Şekilde Gönderildi\n"+txtForgottenEmail.Text+$" Lütfen Eposta Adresinizi Kontrol Ediniz", "Mesaj",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
        }
        private void InsertRequestIntoDB()
        {
            try
            {
                _staffRecoverTokenServices.Insert(new StaffRecoverTokens
                {
                    email = txtForgottenEmail.Text,
                    token = _recoveryToken,
                    requestedAt = DateTime.Now,
                });
                _staffRecoverTokenServices.saveChanges();
            }
            catch (Exception ex)
            {
                DisplayDatabaseError(ex);
            }
        }
        private void DisplayDatabaseError(Exception ex)
        {
            MessageBox.Show($"Database Ekleme Sırasında Hata Oluştu\n"+ex.Message.ToString(), "Hata",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
        }
        private bool isEmailExistent(string email)
        {
            var user = _staffServices.Where(q => q.email == email);
            return user.Count() > 0 ? true : false;
        }
        private void OpenRecoverPasswordForm()
        {
            RecoverPassword recoverPassword = new RecoverPassword();
            recoverPassword.Show();
            this.Dispose();
        }
       
    }
}
