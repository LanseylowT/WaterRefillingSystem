using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefilling_Console.Repository
{
    public class CustomerRepositoryTest
    {
        private readonly string _connectionString =
            "Server=localhost;Database=waterrefilling_system;User ID=root;Password=Lansilot@123;";  // Update this

        public async Task CustomerTest()
        {
            // Initialize repository
            CustomerRepository customerRepository = new CustomerRepository(_connectionString);

            // Test fetching all customers
            var customers = await customerRepository.GetAllCustomersAsyncSP();
            PrintCustomers(customers);
            Console.WriteLine("\n\n");

            // Uncomment the test you want to run
            // await AddNewCustomerTest(customerRepository);
            // await UpdateCustomerTest(customerRepository);
            // await DeleteCustomerTest(customerRepository);

            // Print customers again to see the changes
            customers = await customerRepository.GetAllCustomersAsyncSP();
            PrintCustomers(customers);
        }
        
        // Test: Add a new customer
        public async Task AddNewCustomerTest(CustomerRepository customerRepository)
        {
            var newCustomer = new Customer
            {
                Name = "Lance Sebastian",
                Contact = "09123456789",
                Address = "456 Main St",
                FacebookAccount = "lansilot.FB",
                IsDealer = false
            };
            await customerRepository.AddCustomerAsyncSP(newCustomer);
            Console.WriteLine("New customer added successfully.");
        }
        
        // Test: Update an existing customer
        public async Task UpdateCustomerTest(CustomerRepository customerRepository)
        {
            // Fetch an existing customer to update
            var existingCustomer = await customerRepository.GetCustomerByIdAsyncSP(5); // Assuming customer with ID 1 exists

            if (existingCustomer != null)
            {
                existingCustomer.Name = "Lance Updated";
                existingCustomer.Contact = "09876543210";
                existingCustomer.Address = "789 Updated St";
                existingCustomer.FacebookAccount = "lansilotupdatedFB";
                existingCustomer.IsDealer = true;

                await customerRepository.UpdateCustomerAsyncSP(existingCustomer);
                Console.WriteLine("Customer updated successfully.");
            }
            else
            {
                Console.WriteLine("No customer found for updating.");
            }
        }
        
        // Test: Delete a customer
        public async Task DeleteCustomerTest(CustomerRepository customerRepository)
        {
            // Delete a customer by ID
            await customerRepository.DeleteCustomerAsyncSP(5);  // Assuming customer with ID 1 exists
            Console.WriteLine("Customer deleted successfully.");
        }

        // Helper method to print customers
        private static void PrintCustomers(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine($"Customer ID: {customer.CustomerId}, Name: {customer.Name}, Contact: {customer.Contact}");
                Console.WriteLine($"Address: {customer.Address}, Facebook: {customer.FacebookAccount}, IsDealer: {customer.IsDealer}");
                Console.WriteLine("-----------------------------------------------------");
            }
        }
    }
}
