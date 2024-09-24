using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WaterRefillingSystem.Models;

namespace WaterRefillingSystem.Repository
{
    // TODO: [DONE] Test CRUD Operations for Order Repository
    public class OrderRepository : BaseRepository<Order>
    {
        private readonly CustomerRepository _customerRepository;

        public OrderRepository(string connectionString) : base(connectionString)
        {
            _customerRepository = new CustomerRepository(connectionString);
        }

        protected override async Task<Order> MapReaderToEntityAsync(MySqlDataReader reader)
        {
            var order = new Order
            {
                OrderId = (int)reader["order_id"],
                CustomerId = (int)reader["customer_id"],
                ItemId = (int)reader["item_id"],
                ServiceId = (int)reader["service_id"],
                OwnGallons = (int)reader["own_gallons"],
                BorrowedGallons = (int)reader["borrowed_gallons"],
                TotalPrice = (decimal)reader["total_price"],
                PaymentStatusId = (int)reader["payment_status_id"],
                Date = (DateTime)reader["date"],
            };

            // Fetch and set the Customer
            order.Customer = await _customerRepository.GetCustomerByIdAsyncSP(order.CustomerId);

            return order;
        }

        // Using stored procedure for fetching all orders
        public Task<List<Order>> GetAllOrdersAsyncSP() =>
            GetAllWithParamsAsync("GetAllOrders", new MySqlParameter[] { });

        // Using the old method for fetching all orders
        public Task<List<Order>> GetAllOrdersAsync() =>
            GetAllAsync("SELECT * FROM Orders");

        // Using stored procedure for adding an order
        public Task AddOrderAsyncSP(Order order) =>
            AddWithParamsAsync("AddOrder", 
                new[]
                {
                    new MySqlParameter("p_customer_id", order.CustomerId),
                    new MySqlParameter("p_item_id", order.ItemId),
                    new MySqlParameter("p_service_id", order.ServiceId),
                    new MySqlParameter("p_own_gallons", order.OwnGallons),
                    new MySqlParameter("p_borrowed_gallons", order.BorrowedGallons),
                    new MySqlParameter("p_total_price", order.TotalPrice),
                    new MySqlParameter("p_payment_status_id", order.PaymentStatusId),
                    new MySqlParameter("p_date", order.Date)
                });



        // Using stored procedure for updating an order
        public Task UpdateOrderAsyncSP(Order order) =>
            UpdateWithParamsAsync("UpdateOrder", 
                new[]
                {
                    new MySqlParameter("p_order_id", order.OrderId),
                    new MySqlParameter("p_customer_id", order.CustomerId),
                    new MySqlParameter("p_item_id", order.ItemId),
                    new MySqlParameter("p_service_id", order.ServiceId),
                    new MySqlParameter("p_own_gallons", order.OwnGallons),
                    new MySqlParameter("p_borrowed_gallons", order.BorrowedGallons),
                    new MySqlParameter("p_total_price", order.TotalPrice),
                    new MySqlParameter("p_payment_status_id", order.PaymentStatusId),
                    new MySqlParameter("p_date", order.Date)
                });



        
        // Using stored procedure for deleting an order
        public Task DeleteOrderAsyncSP(int orderId) =>
            DeleteWithParamsAsync("DeleteOrder", 
                new[]
                {
                    new MySqlParameter("p_order_id", orderId)
                });



        // Using stored procedure for fetching orders by customer ID
        public Task<List<Order>> GetOrderByCustomerIdAsyncSP(int customerId) =>
            GetAllWithParamsAsync("GetOrdersByCustomerId", 
                new[]
                {
                    new MySqlParameter("p_customer_id", customerId)
                });
        

        // Using stored procedure for fetching orders by payment status
        public Task<List<Order>> GetOrderByPaymentStatusAsyncSP(string paymentStatus) =>
            GetAllWithParamsAsync("GetOrdersByPaymentStatus", 
                new[]
                {
                    new MySqlParameter("p_payment_status", paymentStatus)
                });
        
    }
}
