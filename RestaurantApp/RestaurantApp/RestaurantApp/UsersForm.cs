using System;
using System.Windows.Forms;
using RestaurantApp.Services;
using RestaurantApp.Utilities;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace RestaurantApp
{ 
    public partial class UsersForm : Form, IWindowsFormServices
    {
        private Login _loginObject = new Login();
        private DepartmentServices _departmentServices = new DepartmentServices();
        private StaffServices _staffServices = new StaffServices();
        public UsersForm()
        {
            InitializeComponent();
        }
        private void UsersForm_Load(object sender, EventArgs e)
        {
            MaximizeScreen();
            GetUserDataOnLoad();
            FillComboBoxForDepartments();
            GetUserDataOnLoad();
        }

        public void MaximizeScreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void FillComboBoxForDepartments()
        {
            var departmentList = _departmentServices.FilterEntityByName(q => q.name);
            foreach (var item in departmentList)
            {
                cmbDepartment.Items.Add(new ComboBoxWithProps(item.id, item.name));
            }
        }

        private void GetUserDataOnLoad()
        {
            var staff = _staffServices.Context.staffs.Find(_loginObject.GetUserId());
            txtName.Text = staff.name;
            txtLastName.Text = staff.lastName;
            txtAddress.Text = staff.adress;
            txtEmail.Text = staff.email;
            txtTel.Text = staff.phoneNumber;
            jobBeginningDatePicker.Value = staff.beginingDate;
            FindExactMatchForDepartmentComboBox(staff.department.name);
        }
        private void FindExactMatchForDepartmentComboBox(string departmentName)
        {
            cmbDepartment.SelectedIndex = cmbDepartment.FindStringExact(departmentName);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ReturnAppMenu();
        }
        private void ReturnAppMenu()
        {
            AppMenu appMenu = new AppMenu();
            appMenu.Show();
            this.Hide();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            var staff = _staffServices.Context.staffs.Find(_loginObject.GetUserId());
            staff.name = txtName.Text;
            staff.lastName = txtLastName.Text;
            staff.email = txtEmail.Text;
            staff.adress = txtAddress.Text;
            staff.phoneNumber = txtTel.Text;
            staff.department = _staffServices.Context.departments.Find(((ComboBoxWithProps)cmbDepartment.SelectedItem).Id);
            _staffServices.Edit(staff);
            _staffServices.saveChanges();
            DisplayEditSuccessfulMessage();
        }
        
        private void DisplayEditSuccessfulMessage()
        {
            MessageBox.Show($"Kullanıcı Başarılı Bir Şekilde Güncellendi", "Mesaj",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
        }
        
        private bool isEmailValid(string email)
        {
            if (txtEmail.Text != string.Empty)
            {
                var emailAddress = new System.Net.Mail.MailAddress(email);
                return emailAddress.Address == email ? true : false;
            }
            else
            {
                return false;
            }
        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtName.Text == string.Empty)
                MessageBox.Show("Kullanıcının Adı Zorunludur");
        }

        private void txtLastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtLastName.Text == string.Empty)
                MessageBox.Show("Kullanıcının Soy Adı Zorunludur");
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(!isEmailValid(txtEmail.Text))
            { 
                MessageBox.Show("Kullanıcının Email Adresi Geçersizdir");
            }
            else if(txtEmail.Text == string.Empty)
            {
                MessageBox.Show("Kullanıcının Email Adresi Zorunludur");
            }
        }

        private void txtTel_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex telPattern = new Regex(@"[0-9]{4}\s+[0-9]{3}\s+[0-9]{2}\s+[0-9]{2}");
            if (txtTel.Text == string.Empty)
                MessageBox.Show("Kullanıcının Telefon Numarası Zorunludur");
            if (!telPattern.IsMatch(txtTel.Text))
                MessageBox.Show("Kullanıcının Telefon Numarası Geçersizdir");

        }

        private void txtAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtAddress.Text == string.Empty)
                MessageBox.Show("Kullanıcının Adresi Zorunludur");
        }

        private void chckPassword_CheckedChanged(object sender, EventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword();
            resetPassword.Show();
            this.Hide();
        }
    }
}
