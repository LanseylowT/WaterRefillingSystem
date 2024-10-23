using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefillingSystem.NewViews
{
    public partial class EditCustomer : Form
    {
        private string result;
        private CustomerRepository _customerRepository;
        private Panel _pnlMain;
        private Customer Customer { get; set; }

        public EditCustomer(Panel panel, Customer customer)
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository(Commons.ConnectionString);
            result = "";
            _pnlMain = panel;
            Customer = customer;
        }

        // --------------------- Event Handlers ---------------------//

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get values from the text boxes
            string customerName = txtCustomerName.Text.Trim();
            string contactNumber = txtContactNumber.Text.Trim();
            string address = txtAddress.Text.Trim();
            string facebookLink = txtFacebookLink.Text.Trim();
            int customerId = Convert.ToInt32(txtIdNumber.Text);
            bool isDealer = rdIsDealer.Checked;
            
            // Initialize a list to collect error messages
            List<String> errorMessages = new List<string>();
            
            // Check if Customer Name is empty
            if (string.IsNullOrWhiteSpace(customerName))
            {
                errorMessages.Add("Customer Name cannot be empty");
            }
            
            // Check if Contact Number is empty
            if (string.IsNullOrWhiteSpace(contactNumber))
            {
                errorMessages.Add("Contact Number cannot be empty");
            }
            
            // Check if Address is empty
            if (string.IsNullOrWhiteSpace(address))
            {
                errorMessages.Add("Address cannot be empty");
            }
            
            // Check if the Facebook Link is empty, if yes then set the value into an empty string
            if (string.IsNullOrWhiteSpace(facebookLink))
            {
                facebookLink = "";
            }
            
            // Setting the individual values into the model Customer
            Customer customer = new Customer
            {
                CustomerId = customerId,
                Name = customerName,
                Contact = contactNumber,
                Address = address,
                FacebookAccount = facebookLink,
                IsDealer = isDealer
            };
            
            // If there are any errors, show them in the error message label
            if (errorMessages.Count > 0)
            {
                lblErrorMessage.Text = string.Join("\n", errorMessages); // Display error messages as a new-line-separated string
                lblErrorMessage.ForeColor = Color.Red;
                lblErrorMessage.Visible = true;
            }
            else
            {
                // Hide the error message if no errors are found
                lblErrorMessage.Visible = false;
                EditCustomerData(customer);
                result = "OK";
                LoadForm(new NewCustomerPage(_pnlMain));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            result = "Cancel";
            LoadForm(new NewCustomerPage(_pnlMain));
        }
        
        private void EditCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomerData(Customer);
        }


        // --------------------- Helper Functions ---------------------//

        private async void EditCustomerData(Customer customer)
        {
            try
            {
                await _customerRepository.UpdateCustomerAsyncSP(customer);
                MessageBox.Show("Customer updated successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                MessageBox.Show("An error occurred while updating the customer. Please try again.");
                throw;
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
        
        private void LoadCustomerData(Customer customer)
        {
            txtCustomerName.Text = customer.Name;
            txtContactNumber.Text = customer.Contact;
            txtAddress.Text = customer.Address;
            txtFacebookLink.Text = customer.FacebookAccount;
            txtIdNumber.Text = customer.CustomerId.ToString();
            rdIsDealer.Checked = customer.IsDealer;
        }

        public string GetResult()
        {
            return result;
        }

        
    }
}