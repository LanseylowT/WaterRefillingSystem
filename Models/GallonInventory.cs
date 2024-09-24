namespace WaterRefillingSystem.Models
{
    public class GallonInventory
    {
        public int InventoryId { get; set; }        // Primary Key
        public int CustomerId { get; set; }         // Foreign Key to Customer
        public int OwnedGallons { get; set; }       // Total number of gallons owned by the customer
        public int BorrowedGallons { get; set; }    // Total number of borrowed gallons
        
        // Navigation property for related Customer
        public Customer Customer { get; set; }
    }
}