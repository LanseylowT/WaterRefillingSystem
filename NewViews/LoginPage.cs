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
using WaterRefillingSystem.Repository;
using WaterRefillingSystem.Services;

namespace WaterRefillingSystem.NewViews
{
    public partial class LoginPage : Form
    {
        
        private AuthenticationServices _authenticationServices;
        private UserAccountRepository _userAccountRepository;
        public LoginPage()
        {
            InitializeComponent();
            _authenticationServices = new AuthenticationServices(Commons.ConnectionString);
            _userAccountRepository = new UserAccountRepository(Commons.ConnectionString);
        }
        
        // ------------------------- Listener Functions ------------------------- \\

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!VerifyFormInputs())
            {
                MessageBox.Show("Fields must not be empty!");
                return;
            }

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (await _authenticationServices.Login(username, password))
            {
                var userAccount = await _userAccountRepository.GetUserByUsernameAsync(username);
                MessageBox.Show("Login Successful!");
                Dashboard2 dashboard2 = new Dashboard2();
                Hide();
                dashboard2.UserAccounts.Username = userAccount.Username;
                dashboard2.UserAccounts.Role = userAccount.Role;
                dashboard2.ShowDialog();
                Close();
            }

            else
            {
                MessageBox.Show("Login Failed!");
            }
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();
            RegisterPage registerPage = new RegisterPage();
            registerPage.ShowDialog();
            if (registerPage.DialogResult == DialogResult.OK)
            {
                registerPage.Close();
                Show();
            }
            else
            {
                registerPage.Close();
                Show();
            }
        }
        
        
        // ------------------------- Helper Functions ------------------------- \\
        private bool VerifyFormInputs()
        {
            return !string.IsNullOrWhiteSpace(txtPassword.Text) ||
                   !string.IsNullOrWhiteSpace(txtUsername.Text);
        }
    }
}
