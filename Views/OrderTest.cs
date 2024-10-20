using System;
using System.Windows.Forms;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefillingSystem.Views
{
    public partial class OrderTest : Form
    {
        private Customer Customer { get; set; }
        private readonly CustomerRepository _customerRepository;
        private readonly OrderRepository _orderRepository;
        private readonly ItemTypeRepository _itemTypeRepository;
        private readonly ServiceOptionRepository _serviceOptionRepository;
        private readonly PaymentStatusRepository _paymentStatusRepository;
        private readonly PaymentRepository _paymentRepository;
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

        private void btnOrder_Click(object sender, System.EventArgs e)
        {
            int itemType = cmbItemTitle.SelectedItem.ToString() == "Round Container" ? 0 : 1;
            int serviceOption = -1;
            switch (cmbServiceOption.SelectedItem.ToString())
            {
                case "Delivery":
                    serviceOption = 0;
                    break;

                case "Pick-up":
                    serviceOption = 1;
                    break;

                case "Buy":
                    serviceOption = 2;
                    break;
            }
            int ownGallons = Convert.ToInt32(cmbOwnGallon.SelectedItem.ToString());
            int borrowedGallons = Convert.ToInt32(cmbBorrowedGallon.SelectedItem.ToString());


            var order = new Order
            {
                CustomerId = Customer.CustomerId,
                ItemId = itemType,
                ServiceId = serviceOption,
                OwnGallons = ownGallons,
                BorrowedGallons = borrowedGallons,
                TotalPrice = itemType == 0 ? 30m : 25m,
                PaymentStatusId = 1,
                Date = DateTime.Now,
                Customer = _customerRepository.GetCustomerByIdAsyncSP(Customer.CustomerId).Result,
            };

            // TODO: Test the order transaction
            _orderRepository.AddOrderAsyncSP(order);

            // TODO: Get the latest auto_increment id from table orders

            Payment payment = new Payment();
            var result = payment.ShowDialog();
        }

        private bool ValidateFormInputs()
        {
            return false;
        }
    }
}