using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefillingSystem.Data
{
    public class AppDbContextAsync
    {
        private readonly CustomerRepository _customerRepository;

        public AppDbContextAsync()
        {
            _customerRepository =
                new CustomerRepository(
                    "Data Source=your_server;Initial Catalog=your_database;Integrated Security=True;");
        }
        
        // For the Customer Model
        public Task<List<Customer>> GetCustomerAsync => _customerRepository.GetAllCustomersAsyncSP();
        public Task AddCustomerAsync(Customer customer) => _customerRepository.AddCustomerAsyncSP(customer);
        public Task UpdateCustomerAsync(Customer customer) => _customerRepository.UpdateCustomerAsyncSP(customer);
        public Task DeleteCustomerAsync(int customerId) => _customerRepository.DeleteCustomerAsyncSP(customerId);
    }
}