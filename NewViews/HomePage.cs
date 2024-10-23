using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefillingSystem.NewViews
{
    public partial class HomePage : Form
    {
        private CustomerRepository customerRepository;
        private Customer _customer;
        private Order _order;
        private OrderRepository _orderRepository;
        private Panel pnlMain;
        public HomePage(Panel panel)
        {
            InitializeComponent();
            customerRepository = new CustomerRepository(Commons.ConnectionString);
            _orderRepository = new OrderRepository(Commons.ConnectionString);
            pnlMain = panel;
        }

        // --------------------- Event Handlers ---------------------//
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            using(CustomerPage customerPage = new CustomerPage())
            {
                if (customerPage.ShowDialog() == DialogResult.OK)
                {
                    DisplayCustomerDetails(customerPage.SelectedCustomer);
                }
            }
        }
        
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (_customer != null)
            {
                OrderPage orderPage = new OrderPage(_customer, pnlMain);
                LoadForm(orderPage);
            }
            else
            {
                OrderPage orderPage = new OrderPage(new Customer(), pnlMain);
                LoadForm(orderPage);
            }
        }
        
        private void HomePage_Load(object sender, EventArgs e)
        {
            // SetupDataGridView();
        }
        
        // --------------------- Helper Functions ---------------------//

        private void SetupDataGridView()
        {
            // Set the column header style
            dtgCustomerSummary.EnableHeadersVisualStyles = false;
            dtgCustomerSummary.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            dtgCustomerSummary.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgCustomerSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Example Data: Add columns and rows for demonstration purposes
            dtgCustomerSummary.Columns.Add("CarID", "Car ID");
            dtgCustomerSummary.Columns.Add("Brand", "Brand");
            dtgCustomerSummary.Columns.Add("Model", "Model");
            dtgCustomerSummary.Columns.Add("Price", "Price");
            dtgCustomerSummary.Columns.Add("Status", "Status");
        }
        
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

        private void DisplayCustomerDetails(Customer selectedCustomer)
        {
            if (selectedCustomer != null)
            {
                LoadCustomerOrderDetails(selectedCustomer.CustomerId);
            }
        }
        
        private async void LoadCustomerOrderDetails(int customerId)
        {
            //Order selectedOrder = await _orderRepository.GetOrderByCustomerIdAsyncSp(customerId);
            _customer = await customerRepository.GetCustomerByIdAsyncSP(customerId);

            if (_customer != null)
            {
                var orderDetails = new[]
                {
                    new
                    {
                        _customer.Name,
                        _customer.Address,
                        _customer.Contact,
                        _customer.FacebookAccount,
                        _customer.IsDealer,
                    }
                }.ToList();
                
                dtgCustomerSummary.DataSource = orderDetails;
                dtgCustomerSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgCustomerSummary.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dtgCustomerSummary.ScrollBars = ScrollBars.Vertical;
                dtgCustomerSummary.Refresh();
            }
            else
            {
                MessageBox.Show("Orders is null");
            }
        }
    }
}