using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefillingSystem.Views
{
    public partial class CustomerTest : Form
    {
        private Timer debounceTimer;
        public Customer SelectedCustomer { get; private set; }  // Expose the selected customer to the main menu
        private int selectedCustomerId = -1;  // Store the selected customer ID
        private CustomerRepository _customerRepository;
        public CustomerTest()
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository("Server=localhost;Database=waterrefilling_system;User ID=root;Password=Lansilot@123;");
            cmbFilterType.SelectedIndex = 0;
            LoadCustomerData();
            dtgCustomerView.CellClick += dtgCustomerView_CellContentClick;
            debounceTimer = new Timer();
            debounceTimer.Interval = 500;
            debounceTimer.Tick += Debounce_Tick;
            tbSearchField.TextChanged += tbSearchField_TextChanged;
        }
        
        
        // TODO: Implement other functions to make the search shit working
        private void LoadFilterCustomers(string filterBy, string searchValue)
        {
            // Set up the connection to the database
            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Database=waterrefilling_system;User ID=root;Password=Lansilot@123;"))
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

        private void dtgCustomerView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid row (not the header)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgCustomerView.Rows[e.RowIndex];
                selectedCustomerId = Convert.ToInt32(row.Cells["CustomerId"].Value);
                Console.WriteLine(selectedCustomerId);
            }
        }

        private async void btnSelect_Click(object sender, EventArgs e)
        {
            
            if (selectedCustomerId != -1)
            {
                // Fetch the selected customer details
                SelectedCustomer = await _customerRepository.GetCustomerByIdAsyncSP(selectedCustomerId);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please select a customer first");
            }
        }

        private async void LoadCustomerData()
        {
            var customers = await _customerRepository.GetAllCustomersAsyncSP();
            dtgCustomerView.DataSource = customers;
            
            dtgCustomerView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgCustomerView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgCustomerView.ScrollBars = ScrollBars.Vertical;
        }

        private void tbSearchField_TextChanged(object sender, EventArgs e)
        {
            // Reset the debounce timer
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private void Debounce_Tick(object sender, EventArgs e)
        {
            debounceTimer.Stop(); // Stop the timer so that it doesn't fire again

            string filterBy = cmbFilterType.SelectedItem.ToString();
            string searchValue = tbSearchField.Text;
            
            // Call the method to load the filtered data
            if (filterBy != "All")
            {
                LoadFilterCustomers(filterBy, searchValue);
            }
        }
    }
}