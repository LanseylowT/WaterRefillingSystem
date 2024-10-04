using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WaterRefillingSystem.Models;

namespace WaterRefillingSystem.Repository
{
    // TODO: [DONE] Test CRUD Operations for Customer Repository
    public class CustomerRepository : BaseRepository<Customer>
    {
        public CustomerRepository(string connectionString): base(connectionString) {}

        protected override async Task<Customer> MapReaderToEntityAsync(MySqlDataReader reader)
        {
            return await Task.Run(() => new Customer
            {
                CustomerId = (int)reader["customer_id"],
                Name = reader["name"].ToString(),
                Contact = reader["contact"].ToString(),
                Address = reader["address"].ToString(),
                FacebookAccount = reader["facebook_account"].ToString(),
                IsDealer = (bool)reader["is_dealer"]
            });
        }

        // Using the new stored procedure method for fetching all customers
        public Task<List<Customer>> GetAllCustomersAsyncSP() =>
            GetAllWithParamsAsync("GetAllCustomers", new MySqlParameter[] { });

        // Using stored procedure for adding a customer
        public Task AddCustomerAsyncSP(Customer customer) =>
            AddWithParamsAsync("AddCustomer", 
                new[]
                {
                    new MySqlParameter("p_name", customer.Name),
                    new MySqlParameter("p_contact", customer.Contact),
                    new MySqlParameter("p_address", customer.Address),
                    new MySqlParameter("p_facebook_account", customer.FacebookAccount),
                    new MySqlParameter("p_is_dealer", customer.IsDealer)
                });


        // Using stored procedure for updating a customer
        public Task UpdateCustomerAsyncSP(Customer customer) =>
            UpdateWithParamsAsync("UpdateCustomer", 
                new[]
                {
                    new MySqlParameter("p_customer_id", customer.CustomerId),
                    new MySqlParameter("p_name", customer.Name),
                    new MySqlParameter("p_contact", customer.Contact),
                    new MySqlParameter("p_address", customer.Address),
                    new MySqlParameter("p_facebook_account", customer.FacebookAccount),
                    new MySqlParameter("p_is_dealer", customer.IsDealer)
                });


        // Using stored procedure for deleting a customer
        public Task DeleteCustomerAsyncSP(int customerId) =>
            DeleteWithParamsAsync("DeleteCustomer", 
                new[]
                {
                    new MySqlParameter("p_customer_id", customerId)
                });
        

        // Using stored procedure for fetching a customer by ID
        public Task<Customer> GetCustomerByIdAsyncSP(int customerId) =>
            GetByIdWithParamsAsync("GetCustomerById", 
                new[]
                {
                    new MySqlParameter("p_customer_id", customerId)
                });

        public async Task<List<Customer>> FilterCustomerAsyncSP(string filterBy, string searchValue)
        {
            var customers = new List<Customer>();

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand("FilterCustomers", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("filterBy", filterBy);
                    cmd.Parameters.AddWithValue("searchValue", searchValue);

                    using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            customers.Add(await MapReaderToEntityAsync(reader));  // Ensure MySqlDataReader is expected here
                        }
                    }
                }
            }

            return customers;
        }

        // TODO: Make a procedure for this shit
        // TODO: Make it dynamic so that it retrieves any shit from any table with only 1 query
        public Task<int> GetCustomerMaxIdAsyncSP()=>
            GetMaxValueAsyncSP("GetMaxValue", new []
            {
                new MySqlParameter("columnName", "customer_id"),
                new MySqlParameter("tableName", "customer")
            });
    }
}