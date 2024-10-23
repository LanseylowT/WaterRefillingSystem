using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefillingSystem.NewViews
{
    public partial class CustomerPage : Form
    {
        private Timer _debounceTimer;
        public Customer SelectedCustomer { get; private set; }  // Expose the selected customer to the main menu
        private int _selectedCustomerId = -1;  // Store the selected customer ID
        private CustomerRepository _customerRepository;
        public CustomerPage()
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository(Commons.ConnectionString);
            _debounceTimer = new Timer();
            _debounceTimer.Interval = 500;
            _debounceTimer.Tick += Debounce_Tick;
        }
        
        // --------------------- Event Handlers ---------------------//
        
        private async void btnSelect_Click(object sender, EventArgs e)
        {
            if (_selectedCustomerId != -1)
            {
                // Fetch the selected customer details
                SelectedCustomer = await _customerRepository.GetCustomerByIdAsyncSP(_selectedCustomerId);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please select a customer first");
            }
        }
        
        private void dtgCustomerView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid row (not the header)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgCustomerView.Rows[e.RowIndex];
                _selectedCustomerId = Convert.ToInt32(row.Cells["CustomerId"].Value);
                Console.WriteLine(_selectedCustomerId);
            }
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }
        
        // --------------------- Helper Functions ---------------------//
        
        private async void LoadCustomerData()
        {
            try
            {
                var customers = await _customerRepository.GetAllCustomersAsyncSP();
                dtgCustomerView.DataSource = customers;
            
                dtgCustomerView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgCustomerView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dtgCustomerView.ScrollBars = ScrollBars.Vertical;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error loading customers");
            }
            
        }
        
        private void LoadFilterCustomers(string filterBy, string searchValue)
        {
            // Set up the connection to the database
            using (MySqlConnection conn = new MySqlConnection(Commons.ConnectionString))
            {
                conn.Open();
                
                // Define the stores procedures
                using (MySqlCommand cmd = new MySqlCommand("FilterCustomers", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("filterBy", filterBy);
                    cmd.Parameters.AddWithValue("searchValue", searchValue);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        
                        // Rename columns here if needed to match your expected column names
                        if (dt.Columns.Contains("customer_id"))
                            dt.Columns["customer_id"].ColumnName = "CustomerId";
                        
                        
                        // Bind the data to the DataGridView
                        dtgCustomerView.DataSource = dt;
                    }
                }
            }
        }
        
        private void Debounce_Tick(object sender, EventArgs e)
        {
            _debounceTimer.Stop(); // Stop the timer so that it doesn't fire again

            string filterBy = cmbFilterType.SelectedItem.ToString();
            string searchValue = tbSearchField.Text;
            
            // Call the method to load the filtered data
            if (filterBy != "All")
            {
                LoadFilterCustomers(filterBy, searchValue);
            }
        }


        private void tbSearchField_TextChanged(object sender, EventArgs e)
        {
            // Reset the debounce timer
            _debounceTimer.Stop();
            _debounceTimer.Start();
        }
    }
}
