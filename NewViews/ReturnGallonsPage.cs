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
    public partial class ReturnGallonsPage : Form
    {
        private Panel _pnlMain;
        private Customer Customers { get; set; }
        private Order Order { get; set; }
        private OrderRepository _orderRepository;
        private CustomerRepository _customerRepository;
        private GallonInventoryRepository _gallonInventoryRepository;
        private DataGridViewRow _selectedRow;

        public ReturnGallonsPage(Panel panel)
        {
            InitializeComponent();
            _orderRepository = new OrderRepository(Commons.ConnectionString);
            _customerRepository = new CustomerRepository(Commons.ConnectionString);
            _gallonInventoryRepository = new GallonInventoryRepository(Commons.ConnectionString);
            _pnlMain = panel;
        }

        // --------------------- Event Handlers ---------------------//
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadForm(new HomePage(_pnlMain));
        }
        
        private async void btnReturn_Click(object sender, EventArgs e)
        {
            // TODO: Implement the return gallons logic
            // Get the data from the text boxes
            int gallonToReturn = Convert.ToInt32(cmbBorrowedContainer.SelectedItem);
            int newBorrowedGallons = Order.BorrowedGallons - gallonToReturn;
            int ownGallons = Order.OwnGallons - gallonToReturn;
            int customerId = Order.CustomerId;

            if (_selectedRow == null)
            {
                MessageBox.Show("Please select an order to return gallons");
                return;
            }
            
            var gallonInventory = new GallonInventory
            {
                CustomerId = customerId,
                BorrowedGallons = newBorrowedGallons
            };

            await _gallonInventoryRepository.UpdateBorrowedGallon(gallonInventory);
            MessageBox.Show("Gallons returned successfully");
            DisplayOrderDetails();
        }
        

        // --------------------- Helper Functions ---------------------//
        
        private async void DisplayOrderDetails()
        {
            try
            {
                var orders = await _orderRepository.GetAllOrdersAsyncSP();
                // Clear the data grid view
                dtgOrderItems.Rows.Clear();
                foreach (var order in orders)
                {
                    var customer = await _customerRepository.GetCustomerByIdAsyncSP(order.CustomerId);
                    var gallonInventory = await _gallonInventoryRepository.GetInventoryByCustomerIdAsyncSP(order.CustomerId);
                    string itemType = "";
                    string serviceOption = "";
                    // If the itemid is 1, it is a slim container
                    if (order.ItemId == 1)
                    {
                        itemType = "Slim Container";
                    }
                    else
                    {
                        itemType = "Round Container";
                    }

                    // if service option is 1: Deliver, 2: Pick-up, 3: Buy
                    if (order.ServiceId == 1)
                    {
                        serviceOption = "Deliver";
                    }
                    else if (order.ServiceId == 2)
                    {
                        serviceOption = "Pick-up";
                    }
                    else if (order.ServiceId == 3)
                    {
                        serviceOption = "Buy";
                    }

                    dtgOrderItems.Rows.Add(order.OrderId, order.CustomerId, customer.Name, itemType, serviceOption,
                        gallonInventory.OwnedGallons, gallonInventory.BorrowedGallons, order.Date.Date);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("There is an error loading order data");
                Console.WriteLine(e.Message);
            }
        }

        private void SetupDataGrid()
        {
            // Set the column header style
            dtgOrderItems.EnableHeadersVisualStyles = false;
            dtgOrderItems.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            dtgOrderItems.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgOrderItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Example Data: Add columns and rows for demonstration purposes
            dtgOrderItems.Columns.Add("OrderId", "Order Id");
            dtgOrderItems.Columns.Add("CustomerId", "Customer Id");
            dtgOrderItems.Columns.Add("CustomerName", "Customer Name");
            dtgOrderItems.Columns.Add("ItemType", "Item Type");
            dtgOrderItems.Columns.Add("ServiceOption", "Service Option");
            dtgOrderItems.Columns.Add("OwnGallons", "Own Gallons");
            dtgOrderItems.Columns.Add("BorrowedGallons", "Borrowed Gallons");
            dtgOrderItems.Columns.Add("Date", "Date");

            // Add a scroll bar
            dtgOrderItems.ScrollBars = ScrollBars.Both;
        }

        private void ReturnGallonsPage_Load(object sender, EventArgs e)
        {
            SetupDataGrid();
            DisplayOrderDetails();
        }

        private void dtgOrderItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedRow = dtgOrderItems.Rows[e.RowIndex];
                Order = new Order
                {
                    OrderId = Convert.ToInt32(_selectedRow.Cells[0].Value),
                    CustomerId = Convert.ToInt32(_selectedRow.Cells[1].Value),
                    OwnGallons = Convert.ToInt32(_selectedRow.Cells[5].Value),
                    BorrowedGallons = Convert.ToInt32(_selectedRow.Cells[6].Value),
                    Date = Convert.ToDateTime(_selectedRow.Cells[7].Value)
                };

                txtCustomerName.Text = _selectedRow.Cells[2].Value.ToString();
                txtItemType.Text = _selectedRow.Cells[3].Value.ToString();
                txtCustomerId.Text = _selectedRow.Cells[1].Value.ToString();
                // Dynamically set the data source of the borrowed gallons to the order own gallons
                cmbBorrowedContainer.DataSource = Enumerable.Range(0, Order.BorrowedGallons + 1).ToList();
            }
        }
        
        private void LoadForm(object form)
        {
            if (_pnlMain.Controls.Count > 0)
                _pnlMain.Controls.RemoveAt(0);

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            _pnlMain.Controls.Add(f);
            _pnlMain.Tag = f;
            f.Show();
        }


        
    }
}