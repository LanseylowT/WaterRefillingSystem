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
    public partial class OrderPage : Form
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
        private readonly GallonInventoryRepository _gallonInventoryRepository;
        private int OrderId;
        private Panel _pnlMain;

        public OrderPage(Customer customer, Panel panel)
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
            _gallonInventoryRepository = new GallonInventoryRepository(Commons.ConnectionString);
            _pnlMain = panel;
        }

        private async void btnAddToCart_Click(object sender, EventArgs e)
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
                        serviceOption = 3;
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
                    PaymentStatusId = 2,
                    Date = DateTime.Now,
                };

                order.TotalPrice = CalculateTotalPrice(order);

                // This is only if the order is new and not from the Cart/Order not paid
                await _orderRepository.AddOrderAsyncSP(order);
                MessageBox.Show("New Order added successfully!");
                DisplayOrdersInDataGrid();
            }
        }

        private async void btnOrder_Click(object sender, EventArgs e)
        {
            var order = new Order();
            var gallonInventory = new GallonInventory();

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
                        serviceOption = 3;
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
                    PaymentStatusId = 2,
                    Date = DateTime.Now,
                };

                gallonInventory = new GallonInventory
                {
                    CustomerId = Customer.CustomerId,
                    OwnedGallons = ownGallons,
                    BorrowedGallons = borrowedGallons,
                };

                order.TotalPrice = CalculateTotalPrice(order);

                // This is only if the order is new and not from the Cart/Order not paid
                await _orderRepository.AddOrderAsyncSP(order);
                await _gallonInventoryRepository.AddInventoryAsyncSP(gallonInventory);
                MessageBox.Show("New Order added successfully!");
            }
            else if (Orders.PaymentStatusId == 1)
            {
                MessageBox.Show("Order is already paid!");
                return;
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
            PaymentPage payment = new PaymentPage(order, _pnlMain);
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

        private async void dtgOrderQueue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedRow = dtgOrderQueue.Rows[e.RowIndex];

                var id = Convert.ToInt32(_selectedRow.Cells["OrderId"].Value);
                Orders = await _orderRepository.GetOrderByOrderIdAsyncSP(id);
                Customer = await _customerRepository.GetCustomerByIdAsyncSP(Orders.CustomerId);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Orders = null;
            _selectedRow = null;
        }

        private void OrderPage_Load(object sender, EventArgs e)
        {
            SetupDataGrid();
            DisplayOrdersInDataGrid();
            DisplayCustomerDetails();
            cmbBorrowedGallon.SelectedIndex = 0;
            cmbOwnGallon.SelectedIndex = 0;
        }


        private async void DisplayOrdersInDataGrid()
        {
            try
            {
                var orders = await _orderRepository.GetAllOrdersAsyncSP();
                var gallonInventory = new GallonInventory();
                dtgOrderQueue.Rows.Clear();

                // Add Rows to the Data Grid View
                if (orders != null)
                {
                    foreach (var order in orders)
                    {
                        // The order is already paid
                        var customer = await _customerRepository.GetCustomerByIdAsyncSP(order.CustomerId);
                        gallonInventory = await _gallonInventoryRepository.GetInventoryByCustomerIdAsyncSP(order.CustomerId);
                        if (gallonInventory == null)
                        {
                            gallonInventory = new GallonInventory
                            {
                                CustomerId = order.CustomerId,
                                OwnedGallons = 0,
                                BorrowedGallons = 0
                            };
                        }

                        dtgOrderQueue.Rows.Add(
                            order.OrderId,
                            customer.Name,
                            order.ItemId == 1 ? "Slim Container" : "Round Container",
                            order.ServiceId == 1 ? "Deliver" : "Buy",
                            gallonInventory.OwnedGallons,
                            gallonInventory.BorrowedGallons,
                            order.TotalPrice,
                            order.PaymentStatusId == 1 ? "Paid" : "Pending",
                            order.Date
                        );
                    }
                    //dtgOrderQueue.DataSource = orders;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Console.WriteLine(ex);
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

        private void DisplayCustomerDetails()
        {
            txtCustomerName.Text = Customer.Name;
            txtCustomerId.Text = Customer.CustomerId.ToString();
            txtCustomerContact.Text = Customer.Contact;
            txtIsDealer.Text = Customer.IsDealer ? "Dealer" : "Customer";
            txtCustomerAddress.Text = Customer.Address;
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
    }
}