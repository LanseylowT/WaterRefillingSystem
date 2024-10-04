using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefillingSystem.Views
{
    public partial class DashboardTest : Form
    {
        private CustomerRepository customerRepository;
        private OrderRepository orderRepository;
        private Customer _customer;
        private Order _order;
        public DashboardTest()
        {
            InitializeComponent();
            // ShowSummaryGrid();
            customerRepository = new CustomerRepository("Server=localhost;Database=waterrefilling_system;User ID=root;Password=Lansilot@123;");
            orderRepository = new OrderRepository("Server=localhost;Database=waterrefilling_system;User ID=root;Password=Lansilot@123;");
            // LoadCustomerData();
        }

        private async void LoadCustomerData()
        {
            var customers = await customerRepository.GetAllCustomersAsyncSP();  // Fetch customers from database
            dtgCustomerSummary.DataSource = customers;
        }

        private async void ShowSummaryGrid()
        {
            // CustomerRepository customerRepository = new CustomerRepository("Server=localhost;Database=waterrefilling_system;User ID=root;Password=Lansilot@123;");
            // OrderRepository orderRepository = new OrderRepository("Server=localhost;Database=waterrefilling_system;User ID=root;Password=Lansilot@123;");
            var customers = await customerRepository.GetAllCustomersAsyncSP();
            var orders = await orderRepository.GetAllOrdersAsyncSP();
            var customerSummaries = customers.Select(customer => new
            {
                CustomerId = customer.CustomerId,
                Name = customer.Name,
                Contact = customer.Contact,
                Address = customer.Address,
                FacebookAccount= customer.FacebookAccount,
                // IsDealer= customer.IsDealer
            }).ToList();
            var orderSummaries = orders.Select(order => new
            {
                order.ItemType.ItemName,
                order.OwnGallons,
                order.BorrowedGallons,
                TotalGallons = order.BorrowedGallons + order.OwnGallons
            }).ToList();
            

            dtgCustomerSummary.DataSource = orderSummaries;
            dtgCustomerSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgCustomerSummary.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgCustomerSummary.ScrollBars = ScrollBars.Vertical;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            // Open the customer details form
            using (CustomerTest customerTestForm = new CustomerTest())
            {
                // Show the customer form as a dialog and check if data is returned
                if (customerTestForm.ShowDialog() == DialogResult.OK)
                {
                    Console.WriteLine("Selected Customer Name: " + customerTestForm.SelectedCustomer.Name);
                    DisplayCustomerDetails(customerTestForm.SelectedCustomer);
                }
            }
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
            var orders = await orderRepository.GetOrderByCustomerIdAsyncSP(customerId);
            _customer = await customerRepository.GetCustomerByIdAsyncSP(customerId);
            // _order = orders[0];
            
            if (orders != null && orders.Any())
            {
                var orderDetails = orders.Select(order => new
                {
                    order.ItemType.ItemName,
                    order.OwnGallons,
                    order.BorrowedGallons,
                    TotalGallons = order.BorrowedGallons + order.OwnGallons
                }).ToList();
                
                dtgCustomerSummary.DataSource = orderDetails;
                dtgCustomerSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgCustomerSummary.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dtgCustomerSummary.ScrollBars = ScrollBars.Vertical;
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            // Open the New Customer form
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // Check if the _customer variable is null or not
            if (_customer != null)
            {
                OrderTest orderTest = new OrderTest(_customer);
                orderTest.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select a customer first before ordering");
            }
            
        }
    }
}
