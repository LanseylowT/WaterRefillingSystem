using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WaterRefillingSystem.Models;


namespace WaterRefillingSystem.Services
{
    public class AuthenticationServices
    {
        private readonly string _connectionString;

        public AuthenticationServices(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Method to sign up (register a new user using stored procedure)
        public async Task SignUp(UserAccounts userAccounts)
        {
            string passwordHash = HashPassword(userAccounts.PasswordHash);

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand("AddUserAccount", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_username", userAccounts.Username);
                    cmd.Parameters.AddWithValue("p_password_hash", passwordHash);
                    cmd.Parameters.AddWithValue("p_role", userAccounts.Role);
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        // Method for login using stored procedure to verify user credentials
        public async Task<bool> Login(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                await conn.OpenAsync();
                using (MySqlCommand cmd = new MySqlCommand("GetUserPasswordHashByUsername", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_username", username);

                    using (MySqlDataReader reader = (MySqlDataReader)await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            string storedHash = reader["password_hash"].ToString();
                            return VerifyPassword(password, storedHash);
                        }
                    }
                }
            }

            return false;
        }

        // Hash the password using SHA-256
        public string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        // Verify entered password against stored hash
        public bool VerifyPassword(string enteredPassword, string storedHash)
        {
            string enteredHash = HashPassword(enteredPassword);
            return enteredHash == storedHash;
        }
    }
}