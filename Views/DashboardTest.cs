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

namespace WaterRefillingSystem.Views
{
    // TODO: Fix the fucking dtgCustomerSummary, copy the shit from the car rental please
    public partial class DashboardTest : Form
    {
        private CustomerRepository customerRepository;
        private OrderRepository orderRepository;
        private Customer _customer;
        private Order _order;
        private OrderRepository _orderRepository;
        public DashboardTest()
        {
            InitializeComponent();
            
            customerRepository = new CustomerRepository(Commons.ConnectionString);
            orderRepository = new OrderRepository(Commons.ConnectionString);
            _orderRepository = new OrderRepository(Commons.ConnectionString);
            //LoadCustomerData();
        }

        private async void ShowLatestIncrementId()
        {
            string latestIncrementId = $"{await _orderRepository.GetLatestAutoIncrementFromOrders()}";
        }

        private async void LoadCustomerData()
        {
            try
            {
                var customers = await customerRepository.GetAllCustomersAsyncSP();  // Fetch customers from 
                dtgCustomerSummary.DataSource = customers;
                // string latestIncrementId = $"{await _orderRepository.GetLatestAutoIncrementFromOrders()}";
                //MessageBox.Show(latestIncrementId);
            }
            catch
            {
                MessageBox.Show("There is an error loading customer data");
            }
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
            dtgCustomerSummary.Refresh();
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
                // MessageBox.Show($@"{selectedCustomer.CustomerId}");
                LoadCustomerOrderDetails(selectedCustomer.CustomerId);
            }
        }

        private async void LoadCustomerOrderDetails(int customerId)
        {
            Order selectedOrder = await orderRepository.GetOrderByCustomerIdAsyncSp(customerId);
            var orders = await orderRepository.GetOrderByCustomerIdAsyncSP(customerId);
            _customer = await customerRepository.GetCustomerByIdAsyncSP(customerId);
            // MessageBox.Show(selectedOrder.ItemType.ItemName);
            // _order = orders[0];

            if (selectedOrder != null)
            {
                var orderDetails = new[]
                {
                    new
                    {
                        _customer.Name,
                        _customer.Address,
                        selectedOrder.ItemType.ItemName,
                        selectedOrder.OwnGallons,
                        selectedOrder.BorrowedGallons,
                        TotalGallons = selectedOrder.OwnGallons + selectedOrder.BorrowedGallons
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
            
            /*if (orders != null && orders.Any())
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
            }*/
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
                OrderTest orderTest = new OrderTest(new Customer());
                orderTest.ShowDialog();
                // MessageBox.Show("Please Select a customer first before ordering");
            }
            
        }

        private void dtgCustomerSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SetupDataGridView()
        {
            // Set the column header style
            dtgCustomerSummary.EnableHeadersVisualStyles = false;
            /*dtgAvailableCars.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            dtgAvailableCars.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;*/
            dtgCustomerSummary.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            dtgCustomerSummary.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Optional: Set the grid's border style
            // dtgAvailableCars.BorderStyle = BorderStyle.None;

            // Set the dock style to fill
            //dtgAvailableCars.Dock = DockStyle.Fill;

            /*// Set row styling
            dtgAvailableCars.RowsDefaultCellStyle.BackColor = Color.White; // White background for rows
            dtgAvailableCars.RowsDefaultCellStyle.ForeColor = Color.Black; // Black text for rows
            dtgAvailableCars.RowsDefaultCellStyle.SelectionBackColor =
                Color.LightGray; // Row selection background color
            dtgAvailableCars.RowsDefaultCellStyle.SelectionForeColor = Color.Black; // Row selection text color

            // Set alternating row style
            dtgAvailableCars.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; // Alternating row background*/

            dtgCustomerSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Example Data: Add columns and rows for demonstration purposes
            dtgCustomerSummary.Columns.Add("CarID", "Car ID");
            dtgCustomerSummary.Columns.Add("Brand", "Brand");
            dtgCustomerSummary.Columns.Add("Model", "Model");
            dtgCustomerSummary.Columns.Add("Price", "Price");
            dtgCustomerSummary.Columns.Add("Status", "Status");
        }

        private void DashboardTest_Load(object sender, EventArgs e)
        {
            //ShowSummaryGrid(); 
            //SetupDataGridView();
            // ShowLatestIncrementId();
            // LoadCustomerData();
        }
    }
}
