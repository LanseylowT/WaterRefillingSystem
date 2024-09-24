using System.Collections.Generic;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WaterRefillingSystem.Models;

namespace WaterRefillingSystem.Repository
{
    // TODO: [DONE] Test Table Lookup Operations for ItemType Repository
    public class ItemTypeRepository : BaseRepository<ItemType>
    {
        public ItemTypeRepository(string connectionString) : base(connectionString)
        {
        }

        protected override async Task<ItemType> MapReaderToEntityAsync(MySqlDataReader reader)
        {
            return await Task.Run(() => new ItemType
            {
                ItemId = (int)reader["Item_Id"],
                ItemName = reader["Item_Name"].ToString()
            });
        }

        // Using stored procedure for fetching all item types
        public Task<List<ItemType>> GetAllItemTypesAsyncSP() =>
            GetAllWithParamsAsync("GetAllItemTypes", new MySqlParameter[] { });



        // Using stored procedure for adding a new item type
        public Task AddItemTypeAsyncSP(ItemType itemType) =>
            AddWithParamsAsync("AddItemType",
                new[]
                {
                    new MySqlParameter("p_item_id", itemType.ItemName),
                });



        // Using stored procedure for updating an existing item type
        public Task UpdateItemTypeAsyncSP(ItemType itemType) =>
            UpdateWithParamsAsync("UpdateItemType",
                new[]
                {
                    new MySqlParameter("p_item_id", itemType.ItemId),
                    new MySqlParameter("p_item_name", itemType.ItemName),
                });



        // Using stored procedure for deleting an item type
        public Task DeleteItemTypeAsyncSP(int itemId) =>
            DeleteWithParamsAsync("DeleteItemType",
                new[]
                {
                    new MySqlParameter("p_item_id", itemId)
                });



        // Using stored procedure for fetching an item type by ID
        public Task<ItemType> GetItemTypeByIdAsyncSP(int itemId) =>
            GetByIdWithParamsAsync("GetItemTypeById",
                new[]
                {
                    new MySqlParameter("p_item_id", itemId)
                });


    }
}
