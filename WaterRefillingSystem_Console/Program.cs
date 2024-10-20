using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WaterRefilling_Console.Repository;
using WaterRefillingSystem.Repository;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Serivces;
using WaterRefillingSystem.Services;

namespace WaterRefilling_Console
{
    internal class Program
    {
        static private CustomerRepository _customerRepository;
        static private OrderRepository _orderRepository;
        public static async Task Main(string[] args)
        {
            // Testing the Customer Repository
            Customer customer = new Customer();
            _customerRepository = new CustomerRepository("Server=localhost;Database=waterrefilling_system;User ID=root;Password=Lansilot@123;");
            _orderRepository = new OrderRepository(Commons.ConnectionString);
            AuthenticationServices service = new AuthenticationServices();
            // Console.WriteLine(service.HashPassword("hashed_password_two"));
            OrderRepositoryTest orderTest = new OrderRepositoryTest();
            CustomerRepositoryTest customerTest = new CustomerRepositoryTest();
            PaymentRepositoryTest paymentTest = new PaymentRepositoryTest();
            ExpenseRepositoryTest expenseTest = new ExpenseRepositoryTest();
            GallonInventoryRepositoryTest inventoryTest = new GallonInventoryRepositoryTest();
            SalesRepositoryTest salesTest = new SalesRepositoryTest();
            PaymentStatusRepositoryTest paymentStatusTest = new PaymentStatusRepositoryTest();
            Console.WriteLine(await _orderRepository.GetLatestAutoIncrementFromOrders());
        } 

        public static async Task<List<Customer>> GetAllCustomers()
        {
            _customerRepository =
                new CustomerRepository(
                    "Server=localhost;Database=waterrefilling_system;User ID=root;Password=Lansilot@123;");
            return await _customerRepository.GetAllCustomersAsyncSP();
        }
    }
}