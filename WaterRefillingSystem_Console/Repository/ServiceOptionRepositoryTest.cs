using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefilling_Console.Repository
{
    public class ServiceOptionRepositoryTest
    {
        private readonly string _connectionString = 
            "Server=localhost;Database=waterrefilling_system;User ID=root;Password=Lansilot@123;";

        public async Task ServiceOptionTest()
        {
            // Initialize repository
            ServiceOptionRepository serviceOptionRepository = new ServiceOptionRepository(_connectionString);

            // Test fetching all service options
            var serviceOptions = await serviceOptionRepository.GetAllServiceOptionsAsyncSP();
            PrintServiceOptions(serviceOptions);
            Console.WriteLine("\n\n");

            // Uncomment to test adding, updating, and deleting service options
            // await AddNewServiceOptionTest(serviceOptionRepository);
            // await UpdateServiceOptionTest(serviceOptionRepository);
            // await DeleteServiceOptionTest(serviceOptionRepository);
        }

        // Test: Add a new service option
        public async Task AddNewServiceOptionTest(ServiceOptionRepository serviceOptionRepository)
        {
            var newServiceOption = new ServiceOption
            {
                ServiceName = "Delivery"
            };
            await serviceOptionRepository.AddServiceOptionAsyncSP(newServiceOption);
            Console.WriteLine("New service option added successfully.");
        }

        // Test: Update an existing service option
        public async Task UpdateServiceOptionTest(ServiceOptionRepository serviceOptionRepository)
        {
            // Fetch an existing service option to update
            var serviceOptions = await serviceOptionRepository.GetAllServiceOptionsAsyncSP();

            if (serviceOptions.Count > 0)
            {
                var serviceOptionToUpdate = serviceOptions[0];
                serviceOptionToUpdate.ServiceName = "Updated Delivery";

                await serviceOptionRepository.UpdateServiceOptionAsyncSP(serviceOptionToUpdate);
                Console.WriteLine("Service option updated successfully.");
            }
            else
            {
                Console.WriteLine("No service options found for updating.");
            }
        }

        // Test: Delete a service option
        public async Task DeleteServiceOptionTest(ServiceOptionRepository serviceOptionRepository)
        {
            // Fetch an existing service option to delete
            var serviceOptions = await serviceOptionRepository.GetAllServiceOptionsAsyncSP();

            if (serviceOptions.Count > 0)
            {
                var serviceOptionToDelete = serviceOptions[0];

                await serviceOptionRepository.DeleteServiceOptionAsyncSP(serviceOptionToDelete.ServiceId);
                Console.WriteLine($"Service option with ID {serviceOptionToDelete.ServiceId} deleted successfully.");
            }
            else
            {
                Console.WriteLine("No service options found for deletion.");
            }
        }

        private static void PrintServiceOptions(List<ServiceOption> serviceOptions)
        {
            foreach (var serviceOption in serviceOptions)
            {
                Console.WriteLine($"Service ID: {serviceOption.ServiceId}, Service Name: {serviceOption.ServiceName}");
                Console.WriteLine("-----------------------------------------------------");
            }
        }
    }
}
