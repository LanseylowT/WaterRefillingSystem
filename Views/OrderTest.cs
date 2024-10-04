using System.Windows.Forms;
using WaterRefillingSystem.Models;

namespace WaterRefillingSystem.Views
{
    public partial class OrderTest : Form
    {
        private Customer Customer { get; set; }
        public OrderTest(Customer customer)
        {
            InitializeComponent();

            Customer = customer;
            
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
    }
}