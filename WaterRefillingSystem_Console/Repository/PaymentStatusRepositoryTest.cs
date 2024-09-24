using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefilling_Console.Repository
{
    public class PaymentStatusRepositoryTest
    {
        private readonly string _connectionString = 
            "Server=localhost;Database=waterrefilling_system;User ID=root;Password=Lansilot@123;";

        public async Task PaymentStatusTest()
        {
            // Initialize repository
            PaymentStatusRepository paymentStatusRepository = new PaymentStatusRepository(_connectionString);

            // Test fetching all payment statuses
            var statuses = await paymentStatusRepository.GetAllPaymentStatusesAsyncSP();
            PrintPaymentStatuses(statuses);
            Console.WriteLine("\n\n");

            // Uncomment to test adding, updating, and deleting payment statuses
            // await AddNewPaymentStatusTest(paymentStatusRepository);
            // await UpdatePaymentStatusTest(paymentStatusRepository);
            // await DeletePaymentStatusTest(paymentStatusRepository);
            
            statuses = await paymentStatusRepository.GetAllPaymentStatusesAsyncSP();
            PrintPaymentStatuses(statuses);
        }

        // Test: Add a new payment status
        public async Task AddNewPaymentStatusTest(PaymentStatusRepository paymentStatusRepository)
        {
            var newStatus = new PaymentStatus
            {
                StatusName = "Paid"
            };
            await paymentStatusRepository.AddPaymentStatusAsyncSP(newStatus);
            Console.WriteLine("New payment status added successfully.");
        }

        // Test: Update an existing payment status
        public async Task UpdatePaymentStatusTest(PaymentStatusRepository paymentStatusRepository)
        {
            // Fetch an existing payment status to update
            var statuses = await paymentStatusRepository.GetAllPaymentStatusesAsyncSP();

            if (statuses.Count > 0)
            {
                var statusToUpdate = statuses[0];
                statusToUpdate.StatusName = "Pending";  // Example update

                await paymentStatusRepository.UpdatePaymentStatusAsyncSP(statusToUpdate);
                Console.WriteLine("Payment status updated successfully.");
            }
            else
            {
                Console.WriteLine("No payment statuses found for updating.");
            }
        }

        // Test: Delete a payment status
        public async Task DeletePaymentStatusTest(PaymentStatusRepository paymentStatusRepository)
        {
            // Fetch an existing payment status to delete
            var statuses = await paymentStatusRepository.GetAllPaymentStatusesAsyncSP();

            if (statuses.Count > 0)
            {
                var statusToDelete = statuses[0];

                await paymentStatusRepository.DeletePaymentStatusAsyncSP(statusToDelete.StatusId);
                Console.WriteLine($"Payment status with ID {statusToDelete.StatusId} deleted successfully.");
            }
            else
            {
                Console.WriteLine("No payment statuses found for deletion.");
            }
        }

        private static void PrintPaymentStatuses(List<PaymentStatus> statuses)
        {
            foreach (var status in statuses)
            {
                Console.WriteLine($"Status ID: {status.StatusId}, Status Name: {status.StatusName}");
                Console.WriteLine("-----------------------------------------------------");
            }
        }
    }
}
