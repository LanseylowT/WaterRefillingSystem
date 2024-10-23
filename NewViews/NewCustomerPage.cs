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
    public partial class NewCustomerPage : Form
    {
        private Customer Customers { get; set; }
        private CustomerRepository _customerRepository;
        private Panel _pnlMain;
        private DataGridViewRow row;
        public NewCustomerPage(Panel panel)
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository(Commons.ConnectionString);
            _pnlMain = panel;
        }
        
        // --------------------- Event Handlers ---------------------//
        
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
                DisplayCustomerInDataGrid();
            }
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // TODO: Make a EditCustomer page
            if (row == null)
            {
                MessageBox.Show("Please select a customer to edit");
                return;
            }
            LoadForm(new EditCustomer(_pnlMain, Customers));
        }

        private void btnReturnGallons_Click(object sender, EventArgs e)
        {
        }
        
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            
            if (row == null)
            {
                MessageBox.Show("Please select a customer to edit");
                return;
            }
            
            // Delete the customer
            try
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer " + Customers.Name, MessageBoxButtons.YesNo);
                if (confirm == DialogResult.No)
                {
                    return;
                }
                _customerRepository.DeleteCustomerAsyncSP(Customers.CustomerId);
                MessageBox.Show("Customer deleted successfully!");
                DisplayCustomerInDataGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show("There is an error deleting the customer");
            }
        }

        private void NewCustomerPage_Load(object sender, EventArgs e)
        {
            SetupDataGrid();
            DisplayCustomerInDataGrid();
        }

        private void dtgCustomerItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = dtgCustomerItems.Rows[e.RowIndex];
                Customers = new Customer
                {
                    CustomerId = Convert.ToInt32(row.Cells[0].Value),
                    Name = row.Cells[1].Value.ToString(),
                    Contact = row.Cells[2].Value.ToString(),
                    Address = row.Cells[3].Value.ToString(),
                    FacebookAccount = row.Cells[4].Value.ToString(),
                    IsDealer = Convert.ToBoolean(row.Cells[5].Value)
                };
            }
        }
        
        
        // --------------------- Helper Functions ---------------------//
        
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

        private void SetupDataGrid()
        {
            // Set the column header style
            dtgCustomerItems.EnableHeadersVisualStyles = false;
            dtgCustomerItems.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
            dtgCustomerItems.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgCustomerItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Example Data: Add columns and rows for demonstration purposes
            dtgCustomerItems.Columns.Add("CustomerId", "Customer Id");
            dtgCustomerItems.Columns.Add("Name", "Name");
            dtgCustomerItems.Columns.Add("Contact", "Contact");
            dtgCustomerItems.Columns.Add("Address", "Address");
            dtgCustomerItems.Columns.Add("FacebookLink", "Facebook Link");
            dtgCustomerItems.Columns.Add("IsDealer", "Dealer");
            // Add a scroll bar
            dtgCustomerItems.ScrollBars = ScrollBars.Both;
        }

        private async void DisplayCustomerInDataGrid()
        {
            try
            {
                var customers = await _customerRepository.GetAllCustomersAsyncSP();
                dtgCustomerItems.Rows.Clear();

                // Add Rows to the Data Grid View
                if (customers != null)
                {
                    foreach (var customer in customers)
                    {
                        dtgCustomerItems.Rows.Add(
                            customer.CustomerId,
                            customer.Name,
                            customer.Contact,
                            customer.Address,
                            customer.FacebookAccount,
                            customer.IsDealer
                        );
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("There is an error loading customer data");
            }
        }
        
        private bool VerifyFormInputs()
        {
            return !string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                   !string.IsNullOrWhiteSpace(txtIdNumber.Text);
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
