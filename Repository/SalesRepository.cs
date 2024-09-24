using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WaterRefillingSystem.Models;

namespace WaterRefillingSystem.Repository
{
    // TODO: [DONE] Test CRUD Operations for Sales Repository
    public class SalesRepository : BaseRepository<Sales>
    {
        public SalesRepository(string connectionString) : base(connectionString)
        {
        }

        protected override async Task<Sales> MapReaderToEntityAsync(MySqlDataReader reader)
        {
            return await Task.Run(() => new Sales
            {
                SaleId = (int)reader["Sale_Id"],
                CustomerId = (int)reader["Customer_Id"],
                OrderId = (int)reader["Order_Id"],
                TotalAmount = reader.GetDecimal(reader.GetOrdinal("Total_Amount")),
                Date = (DateTime)reader["Date"],
            });
        }

        // Using stored procedure for fetching all sales
        public Task<List<Sales>> GetAllSalesAsyncSP() =>
            GetAllWithParamsAsync("GetAllSales", new MySqlParameter[] { });
        

        // Using stored procedure for adding a new sale
        public Task AddSaleAsyncSP(Sales sale) =>
            AddWithParamsAsync("AddSale",
                new[]
                {
                    new MySqlParameter("p_customer_id", sale.CustomerId),
                    new MySqlParameter("p_order_id", sale.OrderId),
                    new MySqlParameter("p_total_amount", sale.TotalAmount),
                    new MySqlParameter("p_date", sale.Date),
                });



        // Using stored procedure for updating an existing sale
        public Task UpdateSaleAsyncSP(Sales sale) =>
            UpdateWithParamsAsync("UpdateSale",
                new[]
                {
                    new MySqlParameter("p_sale_id", sale.SaleId),
                    new MySqlParameter("p_customer_id", sale.CustomerId),
                    new MySqlParameter("p_order_id", sale.OrderId),
                    new MySqlParameter("p_total_amount", sale.TotalAmount),
                    new MySqlParameter("p_date", sale.Date),
                });



        // Using stored procedure for deleting a sale
        public Task DeleteSaleAsyncSP(int saleId) =>
            DeleteWithParamsAsync("DeleteSale",
                new[]
                {
                    new MySqlParameter("p_sale_id", saleId)
                });



        // Using stored procedure for fetching sales by customer ID
        public Task<Sales> GetSalesByCustomerIdAsyncSP(int customerId) =>
            GetByIdWithParamsAsync("GetSalesByCustomerId",
                new[]
                {
                    new MySqlParameter("p_customer_id", customerId)
                });
    }
}
