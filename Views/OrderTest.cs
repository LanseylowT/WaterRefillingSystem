using System;
using System.Drawing;
using System.Windows.Forms;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefillingSystem.Views
{
    public partial class OrderTest : Form
    {
        private Customer Customer { get; set; }
        private DataGridViewRow _selectedRow;
        private Order Orders { get; set; }
        private readonly CustomerRepository _customerRepository;
        private readonly OrderRepository _orderRepository;
        private readonly ItemTypeRepository _itemTypeRepository;
        private readonly ServiceOptionRepository _serviceOptionRepository;
        private readonly PaymentStatusRepository _paymentStatusRepository;
        private readonly PaymentRepository _paymentRepository;
        private readonly SalesRepository _salesRepository;
        private int OrderId;
        public OrderTest(Customer customer)
        {
            InitializeComponent();

            Customer = customer;
            _customerRepository = new CustomerRepository(Commons.ConnectionString);
            _orderRepository = new OrderRepository(Commons.ConnectionString);
            _itemTypeRepository = new ItemTypeRepository(Commons.ConnectionString);
            _serviceOptionRepository = new ServiceOptionRepository(Commons.ConnectionString);
            _paymentRepository = new PaymentRepository(Commons.ConnectionString);
            _paymentStatusRepository = new PaymentStatusRepository(Commons.ConnectionString);
            _salesRepository = new SalesRepository(Commons.ConnectionString);
            DisplayCustomerDetails();
        }
        
        // Method to display customer details in the OrderForm
        private void DisplayCustomerDetails()
        {
            txtCustomerName.Text = Customer.Name;
            txtCustomerId.Text = Customer.CustomerId.ToString();
            txtCustomerContact.Text = Customer.Contact;
            txtIsDealer.Text = Customer.IsDealer ? "Dealer" : "Customer";
            txtCustomerAddress.Text = Customer.Address;
        }

        private void txtCustomerContact_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void txtIsDealer_TextChanged(object sender, System.EventArgs e)
        {

        }

        private async void btnOrder_Click(object sender, System.EventArgs e)
        {
            var order = new Order();
            if (Orders == null)
            {
                // Order is new
                int itemType = cmbItemTitle.SelectedItem.ToString() == "Round Container" ? 1 : 2;
                int serviceOption = 0;

                switch (cmbServiceOption.SelectedItem.ToString())
                {
                    case "Deliver":
                        serviceOption = 1;
                        break;

                    case "Pick-up":
                        serviceOption = 2;
                        break;

                    case "Buy":
                        serviceOption = 2;
                        break;
                }
                int ownGallons = Convert.ToInt32(cmbOwnGallon.SelectedItem.ToString());
                int borrowedGallons = Convert.ToInt32(cmbBorrowedGallon.SelectedItem.ToString());
                
                order = new Order
                {
                    CustomerId = Customer.CustomerId,
                    ItemId = itemType,
                    ServiceId = serviceOption,
                    OwnGallons = ownGallons,
                    BorrowedGallons = borrowedGallons,
                    PaymentStatusId = 1,
                    Date = DateTime.Now,
                };

                order.TotalPrice = CalculateTotalPrice(order);

                // This is only if the order is new and not from the Cart/Order not paid
                // await _orderRepository.AddOrderAsyncSP(order);
                MessageBox.Show("New Order added successfully!");
            } 
            else if (Orders != null && _selectedRow != null)
            {
                order = Orders;
            }
            else
            {
                MessageBox.Show("Please select a customer from the list first!");
            }
            // TODO: Get the latest auto_increment id from table orders
            PaymentTest payment = new PaymentTest(order);
            Hide();
            var result = payment.ShowDialog();

            if (result == DialogResult.OK)
            {
                DisplayOrdersInDataGrid();
                // Update the Payment Status
                var payments = payment.GetPayment();
                OrderId = payments.OrderId;
                // Update
                await _orderRepository.UpdatePaymentStatusAsyncSP(OrderId, 1);
                // Add sales
                var sales = new Sales
                {
                    OrderId = OrderId,
                    CustomerId = Customer.CustomerId,
                    TotalAmount = payments.AmountPaid,
                    Date = payments.PaymentDate
                };

                // Add
                await _salesRepository.AddSaleAsyncSP(sales);
            }
        }

        private void UpdateOrderStatus()
        {

        }

        private decimal CalculateTotalPrice(Order order)
        {
            // If Slim Container, price is 25 else 30, multiplied if own gallons > 0 or if borrowed gallons > 0 else multiplied by both
            // There is an additional charge of 10 if the service option is Deliver
            // Base price: 25 for Slim Container (ItemId 1), otherwise 30.
            decimal pricePerGallon = (order.ItemId == 1) ? 25m : 30m;

            // Calculate total gallons (OwnGallons + BorrowedGallons)
            decimal totalGallons = order.OwnGallons + order.BorrowedGallons;

            // Multiply base price by the total gallons
            decimal totalPrice = pricePerGallon * totalGallons;

            // Add additional charge of 10 if ServiceId is 1 (Deliver)
            if (order.ServiceId == 1)
            {
                totalPrice += 10m;
            }

            return totalPrice;
        }

        private bool ValidateFormInputs()
        {
            return false;
        }

        private async void DisplayOrdersInDataGrid()
        {
            try
            {
                var orders = await _orderRepository.GetAllOrdersAsyncSP();
                dtgOrderQueue.Rows.Clear();

                // Add Rows to the Data Grid View
                if (orders != null)
                {
                    foreach (var order in orders)
                    {
                        var customer = await _customerRepository.GetCustomerByIdAsyncSP(order.CustomerId);
                        dtgOrderQueue.Rows.Add(
                            order.OrderId,
                            customer.Name,
                            order.ItemId == 1 ? "Slim Container" : "Round Container",
                            order.ServiceId == 1 ? "Deliver" : "Buy",
                            order.OwnGallons,
                            order.BorrowedGallons,
                            order.TotalPrice,
                            order.PaymentStatusId == 1 ? "Pending" : "Paid",
                            order.Date
                            );
                    }
                    //dtgOrderQueue.DataSource = orders;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Orders is null");
            }
        }

        private void SetupDataGrid()
        {
            // Set the column header style
            dtgOrderQueue.EnableHeadersVisualStyles = false;
            dtgOrderQueue.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            dtgOrderQueue.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgOrderQueue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Example Data: Add columns and rows for demonstration purposes
            dtgOrderQueue.Columns.Add("OrderId", "Order Id");
            dtgOrderQueue.Columns.Add("Name", "Name");
            dtgOrderQueue.Columns.Add("ItemType", "Item Type");
            dtgOrderQueue.Columns.Add("SerivceOption", "Service Option");
            dtgOrderQueue.Columns.Add("OwnGallons", "Own Gallons");
            dtgOrderQueue.Columns.Add("BorrowedGallons", "Borrowed Gallons");
            dtgOrderQueue.Columns.Add("TotalPrice", "Total Price");
            dtgOrderQueue.Columns.Add("PaymentStatus", "Payment Status");
            dtgOrderQueue.Columns.Add("Date", "Date");
        }


        private async void dtgOrderQueue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedRow = dtgOrderQueue.Rows[e.RowIndex];

                var id = Convert.ToInt32(_selectedRow.Cells["OrderId"].Value);
                Orders = await _orderRepository.GetOrderByOrderIdAsyncSP(id);
            }
        }

        private async void OrderTest_Load(object sender, EventArgs e)
        {
            //MessageBox.Show($"{await _orderRepository.GetLatestAutoIncrementFromOrders()}");
            SetupDataGrid();
            DisplayOrdersInDataGrid();
            // Orders = new Order();
            cmbBorrowedGallon.SelectedIndex = 0;
            cmbOwnGallon.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Orders = null;
            _selectedRow = null;
        }
    }
}