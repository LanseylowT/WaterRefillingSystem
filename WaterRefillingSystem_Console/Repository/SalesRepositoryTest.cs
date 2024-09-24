using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefilling_Console.Repository
{
    public class SalesRepositoryTest
    {
        private readonly string _connectionString = 
            "Server=localhost;Database=waterrefilling_system;User ID=root;Password=Lansilot@123;";

        public async Task SalesTest()
        {
            // Initialize repository
            SalesRepository salesRepository = new SalesRepository(_connectionString);

            // Test fetching all sales
            var sales = await salesRepository.GetAllSalesAsyncSP();
            PrintSales(sales);
            Console.WriteLine("\n\n");

            // Uncomment to test adding, updating, and deleting sales records
            // await AddNewSaleTest(salesRepository);
            // await UpdateSaleTest(salesRepository);
            await DeleteSaleTest(salesRepository);
            
            sales = await salesRepository.GetAllSalesAsyncSP();
            PrintSales(sales);
        }

        // Test: Add a new sale
        public async Task AddNewSaleTest(SalesRepository salesRepository)
        {
            var newSale = new Sales
            {
                CustomerId = 1,  // Use a valid customer ID
                OrderId = 1,     // Use a valid order ID
                Date = DateTime.Now,
                TotalAmount = 120.00M
            };
            await salesRepository.AddSaleAsyncSP(newSale);
            Console.WriteLine("New sale added successfully.");
        }

        // Test: Update an existing sale
        public async Task UpdateSaleTest(SalesRepository salesRepository)
        {
            // Fetch an existing sale to update
            var sales = await salesRepository.GetAllSalesAsyncSP();

            if (sales.Count > 0)
            {
                var saleToUpdate = sales[0];
                saleToUpdate.Date = DateTime.Now.AddDays(-1); // Example update

                await salesRepository.UpdateSaleAsyncSP(saleToUpdate);
                Console.WriteLine("Sale updated successfully.");
            }
            else
            {
                Console.WriteLine("No sales found for updating.");
            }
        }

        // Test: Delete a sale
        public async Task DeleteSaleTest(SalesRepository salesRepository)
        {
            // Fetch an existing sale to delete
            var sales = await salesRepository.GetAllSalesAsyncSP();

            if (sales.Count > 0)
            {
                var saleToDelete = sales[0];

                await salesRepository.DeleteSaleAsyncSP(saleToDelete.SaleId);
                Console.WriteLine($"Sale with ID {saleToDelete.SaleId} deleted successfully.");
            }
            else
            {
                Console.WriteLine("No sales found for deletion.");
            }
        }

        private static void PrintSales(List<Sales> sales)
        {
            foreach (var sale in sales)
            {
                Console.WriteLine($"Sale ID: {sale.SaleId}, Customer ID: {sale.CustomerId}, Order ID: {sale.OrderId}, Date: {sale.Date}");
                Console.WriteLine($"Total Sales: {sale.TotalAmount}");
                Console.WriteLine("-----------------------------------------------------");
            }
        }
    }
}
