using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefilling_Console.Repository
{
    public class ItemTypeRepositoryTest
    {
        private readonly string _connectionString = 
            "Server=localhost;Database=waterrefilling_system;User ID=root;Password=Lansilot@123;";

        public async Task ItemTypeTest()
        {
            // Initialize repository
            ItemTypeRepository itemTypeRepository = new ItemTypeRepository(_connectionString);

            // Test fetching all item types
            var itemTypes = await itemTypeRepository.GetAllItemTypesAsyncSP();
            PrintItemTypes(itemTypes);
            Console.WriteLine("\n\n");

            // Uncomment to test adding, updating, and deleting item types
            // await AddNewItemTypeTest(itemTypeRepository);
            // await UpdateItemTypeTest(itemTypeRepository);
            // await DeleteItemTypeTest(itemTypeRepository);
        }

        // Test: Add a new item type
        public async Task AddNewItemTypeTest(ItemTypeRepository itemTypeRepository)
        {
            var newItemType = new ItemType
            {
                ItemName = "Round Container"
            };
            await itemTypeRepository.AddItemTypeAsyncSP(newItemType);
            Console.WriteLine("New item type added successfully.");
        }

        // Test: Update an existing item type
        public async Task UpdateItemTypeTest(ItemTypeRepository itemTypeRepository)
        {
            // Fetch an existing item type to update
            var itemTypes = await itemTypeRepository.GetAllItemTypesAsyncSP();

            if (itemTypes.Count > 0)
            {
                var itemTypeToUpdate = itemTypes[0];
                itemTypeToUpdate.ItemName = "Updated Container";

                await itemTypeRepository.UpdateItemTypeAsyncSP(itemTypeToUpdate);
                Console.WriteLine("Item type updated successfully.");
            }
            else
            {
                Console.WriteLine("No item types found for updating.");
            }
        }

        // Test: Delete an item type
        public async Task DeleteItemTypeTest(ItemTypeRepository itemTypeRepository)
        {
            // Fetch an existing item type to delete
            var itemTypes = await itemTypeRepository.GetAllItemTypesAsyncSP();

            if (itemTypes.Count > 0)
            {
                var itemTypeToDelete = itemTypes[0];

                await itemTypeRepository.DeleteItemTypeAsyncSP(itemTypeToDelete.ItemId);
                Console.WriteLine($"Item type with ID {itemTypeToDelete.ItemId} deleted successfully.");
            }
            else
            {
                Console.WriteLine("No item types found for deletion.");
            }
        }

        private static void PrintItemTypes(List<ItemType> itemTypes)
        {
            foreach (var itemType in itemTypes)
            {
                Console.WriteLine($"Item ID: {itemType.ItemId}, Item Name: {itemType.ItemName}");
                Console.WriteLine("-----------------------------------------------------");
            }
        }
    }
}
