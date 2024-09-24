namespace WaterRefillingSystem.Models
{
    public class UserAccounts
    {
        public int UserId { get; set; }            // Primary Key
        public string Username { get; set; }        // Username for the admin
        public string PasswordHash { get; set; }    // Hashed password for security
        public string Role { get; set; }            // Role of the user (e.g., "admin", "cashier")
    }
}