using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefilling_Console.Repository
{
    public class GallonInventoryRepositoryTest
    {
        private readonly string _connectionString = 
            "Server=localhost;Database=waterrefilling_system;User ID=root;Password=Lansilot@123;";

        public async Task GallonInventoryTest()
        {
            // Initialize repository
            GallonInventoryRepository gallonInventoryRepository = new GallonInventoryRepository(_connectionString);

            // Test fetching all gallon inventory
            var inventories = await gallonInventoryRepository.GetAllGallonInventoryAsyncSP();
            PrintGallonInventories(inventories);
            Console.WriteLine("\n\n");

            // Uncomment to test adding, updating, and deleting gallon inventory
            // await AddNewGallonInventoryTest(gallonInventoryRepository);
            // await UpdateGallonInventoryTest(gallonInventoryRepository);
            await DeleteGallonInventoryTest(gallonInventoryRepository);
            
            inventories = await gallonInventoryRepository.GetAllGallonInventoryAsyncSP();
            PrintGallonInventories(inventories);
        }

        // Test: Add a new gallon inventory
        public async Task AddNewGallonInventoryTest(GallonInventoryRepository gallonInventoryRepository)
        {
            var newInventory = new GallonInventory
            {
                CustomerId = 1,  // Use a valid customer ID
                OwnedGallons = 10,
                BorrowedGallons = 5
            };
            await gallonInventoryRepository.AddInventoryAsyncSP(newInventory);
            Console.WriteLine("New gallon inventory added successfully.");
        }

        // Test: Update an existing gallon inventory
        public async Task UpdateGallonInventoryTest(GallonInventoryRepository gallonInventoryRepository)
        {
            // Fetch an existing gallon inventory to update
            var inventories = await gallonInventoryRepository.GetAllGallonInventoryAsyncSP();

            if (inventories.Count > 0)
            {
                var inventoryToUpdate = inventories[0];
                inventoryToUpdate.OwnedGallons = 15;
                inventoryToUpdate.BorrowedGallons = 3;

                await gallonInventoryRepository.UpdateInventoryAsyncSP(inventoryToUpdate);
                Console.WriteLine("Gallon inventory updated successfully.");
            }
            else
            {
                Console.WriteLine("No gallon inventories found for updating.");
            }
        }

        // Test: Delete a gallon inventory
        public async Task DeleteGallonInventoryTest(GallonInventoryRepository gallonInventoryRepository)
        {
            // Fetch an existing gallon inventory to delete
            var inventories = await gallonInventoryRepository.GetAllGallonInventoryAsyncSP();

            if (inventories.Count > 0)
            {
                var inventoryToDelete = inventories[0];

                await gallonInventoryRepository.DeleteInventoryAsyncSP(inventoryToDelete.InventoryId);
                Console.WriteLine($"Gallon inventory with ID {inventoryToDelete.InventoryId} deleted successfully.");
            }
            else
            {
                Console.WriteLine("No gallon inventories found for deletion.");
            }
        }

        private static void PrintGallonInventories(List<GallonInventory> inventories)
        {
            foreach (var inventory in inventories)
            {
                Console.WriteLine($"Inventory ID: {inventory.InventoryId}, Customer ID: {inventory.CustomerId}");
                Console.WriteLine($"Owned Gallons: {inventory.OwnedGallons}, Borrowed Gallons: {inventory.BorrowedGallons}");
                Console.WriteLine("-----------------------------------------------------");
            }
        }
    }
}
