using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;

namespace WaterRefillingSystem.Repository
{
    // TODO: [DONE] Test CRUD Operations for Expense Repository
    public class ExpenseRepository : BaseRepository<Expense>
    {
        public ExpenseRepository(string connectionString) : base(connectionString) {}

        protected override async Task<Expense> MapReaderToEntityAsync(MySqlDataReader reader)
        {
            return await Task.Run(() => new Expense
            {
                ExpenseId = (int)reader["Expense_Id"],
                Title = reader["Title"].ToString(),
                Amount = (decimal)reader["Amount"],
                Date = (DateTime)reader["Date"]
            });
        }

        // Using stored procedure for fetching an expense by ID
        public Task<Expense> GetExpenseByIdAsyncSP(int expenseId) =>
            GetByIdWithParamsAsync("GetExpenseById",
                new[]
                {
                    new MySqlParameter("p_expense_id", expenseId)
                });

        // Using the old method for fetching an expense by ID
        public Task<Expense> GetExpenseByIdAsync(int expenseId) =>
            GetByIdAsync("SELECT * FROM Expense WHERE Expense_Id = @ExpenseId",
                new[]
                {
                    new MySqlParameter("@ExpenseId", expenseId)
                });

        // Using stored procedure for fetching all expenses
        public Task<List<Expense>> GetAllExpensesAsyncSP() =>
            GetAllWithParamsAsync("GetAllExpenses", new MySqlParameter[] { });

        // Using the old method for fetching all expenses
        public Task<List<Expense>> GetAllExpensesAsync() =>
            GetAllAsync("SELECT * FROM Expense");

        // Using stored procedure for adding a new expense
        public Task AddExpenseAsyncSP(Expense expense) =>
            AddWithParamsAsync("AddExpense",
                new[]
                {
                    new MySqlParameter("p_title", expense.Title),
                    new MySqlParameter("p_amount", expense.Amount),
                    new MySqlParameter("p_date", expense.Date),
                });

        // Using the old method for adding a new expense
        public Task AddExpenseAsync(Expense expense) =>
            AddAsync("INSERT INTO Expense (Title, Amount, Date) VALUES (@Title, @Amount, @Date)",
                new[]
                {
                    new MySqlParameter("p_title", expense.Title),
                    new MySqlParameter("p_amount", expense.Amount),
                    new MySqlParameter("p_date", expense.Date),
                });

        // Using stored procedure for updating an existing expense
        public Task UpdateExpenseAsyncSP(Expense expense) =>
            UpdateWithParamsAsync("UpdateExpense",
                new[]
                {
                    new MySqlParameter("p_expense_id", expense.ExpenseId),
                    new MySqlParameter("p_title", expense.Title),
                    new MySqlParameter("p_amount", expense.Amount),
                    new MySqlParameter("p_date", expense.Date),
                });

        // Using the old method for updating an existing expense
        public Task UpdateExpenseAsync(Expense expense) =>
            UpdateAsync("UPDATE Expense SET Title = @Title, Amount = @Amount, Date = @Date WHERE Expense_Id = @ExpenseId",
                new[]
                {
                    new MySqlParameter("@ExpenseId", expense.ExpenseId),
                    new MySqlParameter("@Title", expense.Title),
                    new MySqlParameter("@Amount", expense.Amount),
                    new MySqlParameter("@Date", expense.Date),
                });

        // Using stored procedure for deleting an expense by ID
        public Task DeleteExpenseAsyncSP(int expenseId) =>
            DeleteWithParamsAsync("DeleteExpense",
                new[]
                {
                    new MySqlParameter("p_expense_id", expenseId)
                });

        // Using the old method for deleting an expense by ID
        public Task DeleteExpenseAsync(int expenseId) =>
            DeleteAsync("DELETE FROM Expense WHERE Expense_Id = @ExpenseId",
                new[]
                {
                    new MySqlParameter("@ExpenseId", expenseId)
                });
        
        public Task<List<Expense>> GetExpensesByDateFilter(string filterBy) =>
            GetAllWithParamsAsync("GetExpensesByDateFilter",
                new[]
                {
                    new MySqlParameter("p_filter", filterBy)
                });
        
        public async Task<decimal> GetTotalExpensesAsync()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.ConnectionString))
            {
                await conn.OpenAsync();

                using (MySqlCommand cmd = new MySqlCommand("GetTotalExpenses", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            // Read the total_expenses result from the stored procedure
                            return Convert.ToDecimal(reader["total_expenses"]);
                        }
                    }
                }
            }
            return 0; // Return 0 if no expenses are found
        }
    }
}
