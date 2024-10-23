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

namespace WaterRefillingSystem.NewViews
{
    public partial class Dashboard2 : Form
    {
        private readonly SalesRepository _salesRepository;
        private readonly ExpenseRepository _expenseRepository;
        public UserAccounts UserAccounts { get; set; }
        public Dashboard2()
        {
            InitializeComponent();
            _salesRepository = new SalesRepository(Commons.ConnectionString);
            _expenseRepository = new ExpenseRepository(Commons.ConnectionString);
            UserAccounts = new UserAccounts();
        }

        // --------------------- Event Handlers ---------------------//
        
        private void Dashboard2_Load(object sender, EventArgs e)
        {
            LoadForm(new HomePage(pnlMain));
            // Load all of the labels from the shit
            LoadLabels();
            LoadCredentialLabels();
        }
        
        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadLabels();
            LoadForm(new HomePage(pnlMain));
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            LoadLabels();
            LoadForm(new NewCustomerPage(pnlMain));
        }

        private void btnSalesAndExpenses_Click(object sender, EventArgs e)
        {
            LoadLabels();
            LoadForm(new SalesAndExpensesPage());
        }
        
        private void btnReturnGallon_Click(object sender, EventArgs e)
        {
            LoadLabels();
            LoadForm(new ReturnGallonsPage(pnlMain));
        }
        
        // --------------------- Helper Functions ---------------------//
        
        private void LoadForm(object form)
        {
            if (pnlMain.Controls.Count > 0)
                pnlMain.Controls.RemoveAt(0);

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(f);
            pnlMain.Tag = f;
            f.Show();
        }

        public async void LoadLabels()
        {
            try
            {
                var totalSales = await _salesRepository.GetTotalSalesAsync();
                lblTotalSales.Text = totalSales.ToString("C", System.Globalization.CultureInfo.CurrentCulture);
            }
            catch (Exception exception)
            {
                lblTotalSales.Text = 0.ToString("C", System.Globalization.CultureInfo.CurrentCulture);
            }

            try
            {
                var totalExpenses = await _expenseRepository.GetTotalExpensesAsync();
                lblTotalExpenses.Text = totalExpenses.ToString("C", System.Globalization.CultureInfo.CurrentCulture);
            }
            catch (Exception exception)
            {
                lblTotalExpenses.Text = 0.ToString("C", System.Globalization.CultureInfo.CurrentCulture);
            }
        }

        private void LoadCredentialLabels()
        {
            lblUsername.Text = char.ToUpper(UserAccounts.Username[0]) + UserAccounts.Username.Substring(1).ToLower();
            lblRole.Text = char.ToUpper(UserAccounts.Role[0]) + UserAccounts.Role.Substring(1).ToLower();
        }
    }
}
