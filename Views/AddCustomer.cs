using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefillingSystem.Views
{
    public partial class AddCustomer : Form
    {
        private Customer Customers { get; set; }
        private CustomerRepository _customerRepository;
        public AddCustomer()
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository("Server=localhost;Database=waterrefilling_system;User ID=root;Password=Lansilot@123;");
            
        }
        
        // Functions to disallow typing or pasting numbers into the contact text box
        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (like Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void txtContactNumber_TextChange(object sender, EventArgs e)
        {
            // Remove any non-digit characters from the pasted text
            txtContactNumber.Text = new string(txtContactNumber.Text.Where(char.IsDigit).ToArray());
            
            // Set the cursor position to the end of the text
            txtContactNumber.SelectionStart = txtContactNumber.Text.Length;
            
            // Check for valid length
            int length = txtContactNumber.Text.Length;

            if (length < 10 || length > 11)
            {
                lblErrorMessage.Text = "Contact number must be 10 or 11 digits long.";
                lblErrorMessage.ForeColor = Color.Red;
                lblErrorMessage.Visible = true;
            }
            else
            {
                lblErrorMessage.Visible = false;  // Hide error message if valid
            }
        }
        
        

        // Getter for the Customer object
        private Customer GetCustomer()
        {
            return Customers;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get values from the text boxes
            string customerName = txtCustomerName.Text.Trim();
            string contactNumber = txtContactNumber.Text.Trim();
            string address = txtAddress.Text.Trim();
            string facebookLink = txtFacebookLink.Text.Trim();
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
                SaveCustomerData(customer);
            }
        }

        private async void SaveCustomerData(Customer customer)
        {
            try
            {
                await _customerRepository.AddCustomerAsyncSP(customer);
                MessageBox.Show("Customer added successfully!");
            }
            catch (Exception e)
            {
                MessageBox.Show("There is an error adding Customer to the database");
            }
        }

        private void txtFacebookLink_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^https:\/\/www\.facebook\.com\/[A-Za-z0-9\.\/]+$";
            if (!Regex.IsMatch(txtFacebookLink.Text.Trim(), pattern))
            {
                lblErrorMessage.Text = "Invalid Facebok profile link";
                lblErrorMessage.ForeColor = Color.Red;
                lblErrorMessage.Visible = true;
            }
            else
            {
                lblErrorMessage.Visible = false;  // Hide error message if valid
            }
        }

        private async void AddCustomer_Load(object sender, EventArgs e)
        {
            txtIdNumber.Enabled = false;  // Disable the ID number field
            rdIsDealer.Checked = false;

            // Set next customer ID
            await SetNextCustomerIdAsync();
        }

        private async Task SetNextCustomerIdAsync()
        {
            int nextCustomerId = 0;
            
            // Assuming you have a repository method to get the max customer Id
            int maxCustomerId = await _customerRepository.GetCustomerMaxIdAsyncSP();
            nextCustomerId = maxCustomerId + 1;
            
            // Display the next ID
            txtIdNumber.Text = nextCustomerId.ToString();
        }
    }
}
