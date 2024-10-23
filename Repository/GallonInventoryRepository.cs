using System.Collections.Generic;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WaterRefillingSystem.Models;

namespace WaterRefillingSystem.Repository
{
    // TODO: [DONE] Test CRUD Operations for GallonInventory Repository
    public class GallonInventoryRepository : BaseRepository<GallonInventory>
    {
        public GallonInventoryRepository(string connectionString) : base(connectionString) { }

        protected override async Task<GallonInventory> MapReaderToEntityAsync(MySqlDataReader reader)
        {
            return await Task.Run(() => new GallonInventory
            {
                InventoryId = (int)reader["Inventory_Id"],
                CustomerId = (int)reader["Customer_Id"],
                OwnedGallons = (int)reader["Owned_Gallons"],
                BorrowedGallons = (int)reader["Borrowed_Gallons"]
            });
        }

        // Using stored procedure for fetching all gallon inventories
        public Task<List<GallonInventory>> GetAllGallonInventoryAsyncSP() =>
            GetAllWithParamsAsync("GetAllGallonInventory", new MySqlParameter[] { });
        

        // Using stored procedure for adding a gallon inventory
        public Task AddInventoryAsyncSP(GallonInventory inventory) =>
            AddWithParamsAsync("AddInventory", 
                new[]
                {
                    new MySqlParameter("p_customer_id", inventory.CustomerId),
                    new MySqlParameter("p_owned_gallons", inventory.OwnedGallons),
                    new MySqlParameter("p_borrowed_gallons", inventory.BorrowedGallons),
                });
        

        // Using stored procedure for updating a gallon inventory
        public Task UpdateInventoryAsyncSP(GallonInventory inventory) =>
            UpdateWithParamsAsync("UpdateInventory",
                new[]
                {
                    new MySqlParameter("p_inventory_id", inventory.InventoryId),
                    new MySqlParameter("p_customer_id", inventory.CustomerId),
                    new MySqlParameter("p_owned_gallons", inventory.OwnedGallons),
                    new MySqlParameter("p_borrowed_gallons", inventory.BorrowedGallons),
                });

        

        // Using stored procedure for deleting a gallon inventory
        public Task DeleteInventoryAsyncSP(int inventoryId) =>
            DeleteWithParamsAsync("DeleteInventory",
                new[]
                {
                    new MySqlParameter("p_inventory_id", inventoryId)
                });
        
        public Task UpdateBorrowedGallon(GallonInventory inventory) =>
            UpdateWithParamsAsync("UpdateBorrowedGallons", new[]
            {
                new MySqlParameter("p_customer_id", inventory.CustomerId),
                new MySqlParameter("p_new_borrowed_gallon", inventory.BorrowedGallons)
            });

        // Using stored procedure for fetching gallon inventory by customer ID
        public Task<GallonInventory> GetInventoryByCustomerIdAsyncSP(int customerId) =>
            GetByIdWithParamsAsync("GetInventoryByCustomerId", 
                new[]
                {
                    new MySqlParameter("p_customer_id", customerId),
                });
    }
}
