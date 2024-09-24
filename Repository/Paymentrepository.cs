using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WaterRefillingSystem.Models;

namespace WaterRefillingSystem.Repository
{
    public class PaymentRepository : BaseRepository<Payment>
    {
        public PaymentRepository(string connectionString) : base(connectionString)
        {
        }

        protected override async Task<Payment> MapReaderToEntityAsync(MySqlDataReader reader)
        {
            return new Payment
            {
                PaymentId = (int)reader["Payment_Id"],
                OrderId = (int)reader["Order_Id"],
                AmountPaid = (decimal)reader["Amount_Paid"],
                PaymentDate = (DateTime)reader["Payment_Date"]
            };
        }

        // Using stored procedure for fetching all payments
        public Task<List<Payment>> GetAllPaymentsAsyncSP() =>
            GetAllWithParamsAsync("GetAllPayments", new MySqlParameter[] { });

        // Using the old method for fetching all payments
        public Task<List<Payment>> GetAllPaymentsAsync() =>
            GetAllAsync("SELECT * FROM Payment");

        // Using stored procedure for adding a payment
        public Task AddPaymentAsyncSP(Payment payment) =>
            AddWithParamsAsync("AddPayment",
                new[]
                {
                    new MySqlParameter("p_order_id", payment.OrderId),     // Match stored procedure parameter name
                    new MySqlParameter("p_amount_paid", payment.AmountPaid), // Match stored procedure parameter name
                    new MySqlParameter("p_payment_date", payment.PaymentDate) // Match stored procedure parameter name
                });

        // Using the old method for adding a payment
        public Task AddPaymentAsync(Payment payment) =>
            AddAsync(
                "INSERT INTO Payment (Order_Id, Amount_Paid, Balance, Payment_Date) VALUES (@OrderId, @AmountPaid, @PaymentDate)",
                new[]
                {
                    new MySqlParameter("p_order_id", payment.OrderId),
                    new MySqlParameter("p_amount_paid", payment.AmountPaid),
                    new MySqlParameter("p_payment_date", payment.PaymentDate)
                });

        // Using stored procedure for updating a payment
        public Task UpdatePaymentAsyncSP(Payment payment) =>
            UpdateWithParamsAsync("UpdatePayment",
                new[]
                {
                    new MySqlParameter("p_payment_id", payment.PaymentId),
                    new MySqlParameter("p_order_id", payment.OrderId),
                    new MySqlParameter("p_amount_paid", payment.AmountPaid),
                    new MySqlParameter("p_payment_date", payment.PaymentDate)
                });

        // Using the old method for updating a payment
        public Task UpdatePaymentAsync(Payment payment) =>
            UpdateAsync(
                "UPDATE Payments SET Order_Id = @OrderId, Amount_Paid = @AmountPaid, Payment_Date = @PaymentDate WHERE Payment_Id = @PaymentId",
                new[]
                {
                    new MySqlParameter("p_payment_id", payment.PaymentId),
                    new MySqlParameter("@OrderId", payment.OrderId),
                    new MySqlParameter("@AmountPaid", payment.AmountPaid),
                    new MySqlParameter("@PaymentDate", payment.PaymentDate)
                });

        // Using stored procedure for deleting a payment
        public Task DeletePaymentAsyncSP(int paymentId) =>
            DeleteWithParamsAsync("DeletePayment",
                new[]
                {
                    new MySqlParameter("p_payment_id", paymentId)
                });

        // Using the old method for deleting a payment
        public Task DeletePaymentAsync(int paymentId) =>
            DeleteAsync(
                "DELETE FROM Payments WHERE Payment_Id = @PaymentId",
                new[]
                {
                    new MySqlParameter("@PaymentId", paymentId)
                });

        // Using stored procedure for fetching payments by order ID
        public Task<List<Payment>> GetPaymentsByOrderAsyncSP(int orderId) =>
            GetAllWithParamsAsync("GetPaymentsByOrder",
                new[]
                {
                    new MySqlParameter("p_order_id", orderId)
                });

        // Using the old method for fetching payments by order ID
        public async Task<List<Payment>> GetPaymentsByOrderAsync(int orderId)
        {
            var payments = new List<Payment>();

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM Payment WHERE Order_Id = @OrderId", conn))
                {
                    cmd.Parameters.AddWithValue("@OrderId", orderId);
                    using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            payments.Add(await MapReaderToEntityAsync(reader));
                        }
                    }
                }
            }

            return payments;
        }
    }
}
