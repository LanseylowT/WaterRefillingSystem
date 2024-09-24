using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefilling_Console.Repository
{
    
    // TODO: [DONE] Test CRUD Operations for Payment Repository
    public class PaymentRepositoryTest
    {
        private readonly string _connectionString = "Server=localhost;Database=waterrefilling_system;User ID=root;Password=Lansilot@123;";

        public async Task PaymentTest()
        {
            // Initialize repository
            PaymentRepository paymentRepository = new PaymentRepository(_connectionString);
            
            // Test fetching all payments
            var payments = await paymentRepository.GetAllPaymentsAsyncSP();
            PrintCustomers(payments);
            Console.WriteLine("\n\n");
            
            // Uncomment the test we want to run
            // await AddNewPaymentTest(paymentRepository);
            // await UpdatePaymentTest(paymentRepository);
            await DeletePaymentTest(paymentRepository);
            
            // Print the customers again to see the updates
            payments = await paymentRepository.GetAllPaymentsAsyncSP();
            PrintCustomers(payments);
        }
        
        // Test: Add a new payment
        private static async Task AddNewPaymentTest(PaymentRepository paymentRepository)
        {
            var newPayment = new Payment
            {
                PaymentDate = DateTime.Now,
                AmountPaid = 500.0m,
                OrderId = 2
            };
            await paymentRepository.AddPaymentAsyncSP(newPayment);
            Console.WriteLine("Payment Added Successfully");
        }

        
        // Task: Update an existing payment
        private static async Task UpdatePaymentTest(PaymentRepository paymentRepository)
        {
            // Fetch an existing payment by Order ID
            var existingPayments = await paymentRepository.GetPaymentsByOrderAsyncSP(1);


            if (existingPayments.Count > 0)
            {
                var paymentToUpdate = existingPayments[0];
                paymentToUpdate.AmountPaid = 120.00M;
                paymentToUpdate.PaymentDate = DateTime.Now;

                await paymentRepository.UpdatePaymentAsyncSP(paymentToUpdate);
                Console.WriteLine("Payment updated successfully");
            }
            else
            {
                Console.WriteLine("No payments found for updating");
            }
            
        }
        
        
        // Task: Delete a payment
        public async Task DeletePaymentTest(PaymentRepository paymentRepository)
        {
            // Fetch an existing payment to delete
            var existingPayments = await paymentRepository.GetPaymentsByOrderAsyncSP(1);

            if (existingPayments.Count > 0)
            {
                var paymentToDelete = existingPayments[0];

                await paymentRepository.DeletePaymentAsyncSP(paymentToDelete.PaymentId);
                Console.WriteLine($"Payment with ID {paymentToDelete.PaymentId} deleted successfully.");
            }
            else
            {
                Console.WriteLine("No payments found for deletion.");
            }
        }
        
        
        // Helper method to print payments
        private static void PrintCustomers(List<Payment> payments)
        {
            foreach (var payment in payments)
            {
                Console.WriteLine($"Customer ID: {payment.PaymentId}, Amount Paid: {payment.AmountPaid}, Payment Date: {payment.PaymentDate}");
                Console.WriteLine("-----------------------------------------------------");
            }
        }
    }
}