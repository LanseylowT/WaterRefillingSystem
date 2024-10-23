using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Services;

namespace WaterRefillingSystem.NewViews
{
    public partial class RegisterPage : Form
    {
        private AuthenticationServices _authenticationServices;
        public RegisterPage()
        {
            InitializeComponent();
            _authenticationServices = new AuthenticationServices(Commons.ConnectionString);
        }


        // ------------------------- Listener Functions ------------------------- \\

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (!VerifyFormInputs())
            {
                lblErrorMessage.Text = "All fields must be filled out.";
                lblErrorMessage.ForeColor = Color.Red;
                lblErrorMessage.Visible = true;
                return;
            }

            var userAccount = new UserAccounts
            {
                Username = txtUsername.Text,
                PasswordHash = txtPassword.Text,
                Role = cmbRole.SelectedItem.ToString()
            };
            
            await _authenticationServices.SignUp(userAccount);
            ClearFields();
            MessageBox.Show("User Signed up Successfully");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ------------------------- Helper Functions ------------------------- \\

        private bool VerifyFormInputs()
        {
            return !string.IsNullOrWhiteSpace(txtPassword.Text) ||
                   !string.IsNullOrWhiteSpace(txtUsername.Text) ||
                   !string.IsNullOrWhiteSpace(txtVerifyPassword.Text) ||
                   !string.IsNullOrWhiteSpace(cmbRole.SelectedItem.ToString());
        }

        private void ClearFields()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = String.Empty;
            txtVerifyPassword.Text = String.Empty;
        }

        private void txtVerifyPassword_TextChanged(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            string verify = txtVerifyPassword.Text;

            if (verify != password)
            {
                lblErrorMessage.Text = "Passwords do not match";
                lblErrorMessage.ForeColor = Color.Red;
                lblErrorMessage.Visible = true;
                btnRegister.Enabled = false;
                return;
            }

            if (string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(verify))
            {
                lblErrorMessage.Text = "Please enter password first";
                lblErrorMessage.ForeColor = Color.Red;
                lblErrorMessage.Visible = true;
                btnRegister.Enabled = false;
            }

            lblErrorMessage.Visible = false;
            btnRegister.Enabled = true;
        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 0;
        }
    }
}