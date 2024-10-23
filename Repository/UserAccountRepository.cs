using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WaterRefillingSystem.Data;
using WaterRefillingSystem.Models;

// TODO: [DONE] Test Authentication and CRUD Operations for UserAccount
namespace WaterRefillingSystem.Repository
{
    public class UserAccountRepository : BaseRepository<UserAccounts>
    {
        public UserAccountRepository(string connectionString) : base(connectionString) {}

        protected override async Task<UserAccounts> MapReaderToEntityAsync(MySqlDataReader reader)
        {
            return await Task.Run(() => new UserAccounts
            {
                UserId = (int)reader["user_id"],
                Username = reader["username"].ToString(),
                PasswordHash = reader["password_hash"].ToString(),
                Role = reader["role"].ToString(),
            });
        }

        // Fetch all user accounts using stored procedure
        public Task<List<UserAccounts>> GetAllUserAccountsAsyncSP() =>
            GetAllWithParamsAsync("GetAllUserAccounts", new MySqlParameter[] { });

        // Add a new user account using stored procedure
        public Task AddUserAccountAsyncSP(UserAccounts userAccount) =>
            AddWithParamsAsync("AddUserAccount",
                new[]
                {
                    new MySqlParameter("p_username", userAccount.Username),
                    new MySqlParameter("p_password_hash", userAccount.PasswordHash),
                    new MySqlParameter("p_role", userAccount.Role),
                });

        // Update a user account using stored procedure
        public Task UpdateUserAccountAsyncSP(UserAccounts userAccount) =>
            UpdateWithParamsAsync("UpdateUserAccount",
                new[]
                {
                    new MySqlParameter("p_user_id", userAccount.UserId),
                    new MySqlParameter("p_username", userAccount.Username),
                    new MySqlParameter("p_password_hash", userAccount.PasswordHash),
                    new MySqlParameter("p_role", userAccount.Role),
                });

        // Delete a user account using stored procedure
        public Task DeleteUserAccountAsyncSP(int userId) =>
            DeleteWithParamsAsync("DeleteUserAccount",
                new[]
                {
                    new MySqlParameter("p_user_id", userId)
                });

        // Fetch user account by ID using stored procedure
        public Task<UserAccounts> GetUserAccountByIdAsyncSP(int userId) =>
            GetByIdWithParamsAsync("GetUserAccountById",
                new[]
                {
                    new MySqlParameter("p_user_id", userId)
                });
        
        public async Task<UserAccounts> GetUserByUsernameAsync(string username)
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.ConnectionString))
            {
                await conn.OpenAsync();

                using (MySqlCommand cmd = new MySqlCommand("GetUserByUsername", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add username as a parameter
                    cmd.Parameters.AddWithValue("p_username", username);

                    using (MySqlDataReader reader = (MySqlDataReader) await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            // Map the result to a User object
                            return new UserAccounts
                            {
                                UserId = Convert.ToInt32(reader["user_id"]),
                                Username = reader["username"].ToString(),
                                Role = reader["role"].ToString()
                            };
                        }
                    }
                }
            }
            return null; // Return null if no user is found
        }
    }
}