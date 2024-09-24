using System.Collections.Generic;
using System.Data.SqlClient;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefillingSystem.Data
{
    public class AppDbContext
    {
        private readonly string _connectionString;

        public AppDbContext()
        {
            _connectionString = "Data Source=your_server;Initial Catalog=your_database;Integrated Security=True;";
        }

        
        // Example method to get all customers
        public List<Customer> GetCustomers()
        {
            var customers = new List<Customer>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customers.Add(new Customer
                            {
                                CustomerId = (int)reader["CustomerId"],
                                Name = reader["Name"].ToString(),
                                Contact = reader["Contact"].ToString(),
                                Address = reader["Address"].ToString()
                            });
                        }
                    }
                }
            }

            return customers;
        }

        
        public void AddCustomer(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd =
                       new SqlCommand(
                           "INSERT INTO Customers (Name, Contact, Address) VALUES (@Name, @Contact, @Address)", conn))
                {
                    cmd.Parameters.AddWithValue("@Name", customer.Name);
                    cmd.Parameters.AddWithValue("@Contact", customer.Contact);
                    cmd.Parameters.AddWithValue("@Address", customer.Address);

                    cmd.ExecuteNonQuery();
                }
                
            }
        }
        
        
        public void UpdateCustomer(Customer customer)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd =
                       new SqlCommand(
                           "UPDATE Customers SET Name = @Name, Contact = @Contact, Address = @Address, WHERE CustomerId = @CustomerId",
                           conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customer.CustomerId);
                    cmd.Parameters.AddWithValue("@Name", customer.Name);
                    cmd.Parameters.AddWithValue("@Contact", customer.Contact);
                    cmd.Parameters.AddWithValue("@Address", customer.Address);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        
        public void DeleteCustomer(int customerId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Customers WHERE CustomerId = @CustomerId", conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}