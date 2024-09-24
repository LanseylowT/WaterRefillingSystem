using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefilling_Console.Repository
{
    public class OrderRepositoryTest
    {
        public OrderRepositoryTest()
        {
            
        }
        private  readonly string _connectionString =
            "Server=localhost;Database=waterrefilling_system;User ID=root;Password=Lansilot@123;";

        public  async Task OrderTest()
        {
            // Initialize repository
            OrderRepository orderRepository = new OrderRepository(_connectionString);

            // Test fetching all orders
            var orders = await orderRepository.GetAllOrdersAsyncSP();
            PrintOrders(orders);
            Console.WriteLine("\n\n");

            // await AddNewOrderTest(orderRepository);
            // await UpdateOrderTest(orderRepository);
            // await DeleteOrderTest(orderRepository);

            // PrintOrders(orders);
        }
        
        // Test: Add a new order
        public async Task AddNewOrderTest(OrderRepository orderRepository)
        {
            var newOrder = new Order
            {
                CustomerId = 2,
                ItemId = 1,
                ServiceId = 1,
                OwnGallons = 2,
                BorrowedGallons = 5,
                TotalPrice = 150.00M,
                PaymentStatusId = 2,
                Date = DateTime.Now,
            };
            await orderRepository.AddOrderAsyncSP(newOrder);
            Console.WriteLine("Your new order added successfully");
        }
        
        // Test: Update order an existing order
        public async Task UpdateOrderTest(OrderRepository orderRepository)
        {
            // Fetch an existing order to update
            var existingOrder = await orderRepository.GetOrderByCustomerIdAsyncSP(2);

            if (existingOrder.Count > 0)
            {
                var orderToUpdate = existingOrder[0];
                // Console.WriteLine($"Order ID: {orderToUpdate.OrderId}");
                // Console.WriteLine($"Customer ID: {orderToUpdate.CustomerId}");
                // Console.WriteLine($"Item ID: {orderToUpdate.ItemId}");
                // Console.WriteLine($"Service ID: {orderToUpdate.ServiceId}");
                // Console.WriteLine($"Own Gallons: {orderToUpdate.OwnGallons}");
                // Console.WriteLine($"Borrowed Gallons: {orderToUpdate.BorrowedGallons}");
                // Console.WriteLine($"Total Price: {orderToUpdate.TotalPrice}");
                // Console.WriteLine($"Payment Status ID: {orderToUpdate.PaymentStatusId}");
                // Console.WriteLine($"Date: {orderToUpdate.Date}");
                orderToUpdate.OwnGallons = 23;
                orderToUpdate.BorrowedGallons = 7;
                orderToUpdate.TotalPrice = 125.00M;
                orderToUpdate.PaymentStatusId = 1;
                orderToUpdate.Date = DateTime.Now;

                await orderRepository.UpdateOrderAsyncSP(orderToUpdate);
                Console.WriteLine("Order updated successfully");
            }

            else
            {
                Console.WriteLine("No orders found for updating");
            }
        }
        
        // Test: Delete an order
        public async Task DeleteOrderTest(OrderRepository orderRepository)
        {
            // Fetch an existing order to update
            var existingOrder = await orderRepository.GetOrderByCustomerIdAsyncSP(10);

            if (existingOrder.Count > 0)
            {
                var orderToDelete = existingOrder[0];

                await orderRepository.DeleteOrderAsyncSP(orderToDelete.OrderId);
                Console.WriteLine($"Order with ID {orderToDelete.OrderId} deleted successfully");
            }
            else
            {
                Console.WriteLine("No orders found for deletion");
            }
        }
        
        private static void PrintOrders(List<Order> orders)
        {
            foreach (var order in orders)
            {
                Console.WriteLine($"Order ID: {order.OrderId}, Customer ID: {order.CustomerId}, Item: {order.ItemId}");
                Console.WriteLine($"Service Option: {order.ServiceId}, Own Gallons: {order.OwnGallons}, Borrowed Gallons: {order.BorrowedGallons}");
                Console.WriteLine($"Total Price: {order.TotalPrice}, Payment Status: {order.PaymentStatusId}, Date: {order.Date}");
                Console.WriteLine("-----------------------------------------------------");
            }
        }
    }
}