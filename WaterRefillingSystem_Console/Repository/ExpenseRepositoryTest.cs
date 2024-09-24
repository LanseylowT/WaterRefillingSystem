using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;
using WaterRefillingSystem.Repository;

namespace WaterRefilling_Console.Repository
{
    public class ExpenseRepositoryTest
    {
        private readonly string _connectionString = 
            "Server=localhost;Database=waterrefilling_system;User ID=root;Password=Lansilot@123;";

        public async Task ExpenseTest()
        {
            // Initialize repository
            ExpenseRepository expenseRepository = new ExpenseRepository(_connectionString);

            // Test fetching all expenses
            var expenses = await expenseRepository.GetAllExpensesAsyncSP();
            PrintExpenses(expenses);
            Console.WriteLine("\n\n");

            // Uncomment to test adding, updating, and deleting an expense
            // await AddNewExpenseTest(expenseRepository);
            // await UpdateExpenseTest(expenseRepository);
            await DeleteExpenseTest(expenseRepository);
            
            // Print the customers again to see the updates
            expenses = await expenseRepository.GetAllExpensesAsyncSP();
            PrintExpenses(expenses);
        }

        // Test: Add a new expense
        public async Task AddNewExpenseTest(ExpenseRepository expenseRepository)
        {
            var newExpense = new Expense
            {
                Title = "Stationery",
                Amount = 50.75M,
                Date = DateTime.Now
            };
            await expenseRepository.AddExpenseAsyncSP(newExpense);
            Console.WriteLine("New expense added successfully.");
        }

        // Test: Update an existing expense
        public async Task UpdateExpenseTest(ExpenseRepository expenseRepository)
        {
            // Fetch an existing expense to update
            var expenses = await expenseRepository.GetAllExpensesAsyncSP();

            if (expenses.Count > 0)
            {
                var expenseToUpdate = expenses[0];
                expenseToUpdate.Title = "Updated Stationery";
                expenseToUpdate.Amount = 75.00M;
                expenseToUpdate.Date = DateTime.Now;

                await expenseRepository.UpdateExpenseAsyncSP(expenseToUpdate);
                Console.WriteLine("Expense updated successfully.");
            }
            else
            {
                Console.WriteLine("No expenses found for updating.");
            }
        }

        // Test: Delete an expense
        public async Task DeleteExpenseTest(ExpenseRepository expenseRepository)
        {
            // Fetch an existing expense to delete
            var expenses = await expenseRepository.GetAllExpensesAsyncSP();

            if (expenses.Count > 0)
            {
                var expenseToDelete = expenses[0];

                await expenseRepository.DeleteExpenseAsyncSP(expenseToDelete.ExpenseId);
                Console.WriteLine($"Expense with ID {expenseToDelete.ExpenseId} deleted successfully.");
            }
            else
            {
                Console.WriteLine("No expenses found for deletion.");
            }
        }

        private static void PrintExpenses(List<Expense> expenses)
        {
            foreach (var expense in expenses)
            {
                Console.WriteLine($"Expense ID: {expense.ExpenseId}, Title: {expense.Title}");
                Console.WriteLine($"Amount: {expense.Amount}, Date: {expense.Date}");
                Console.WriteLine("-----------------------------------------------------");
            }
        }
    }
}
