using System;

namespace WaterRefillingSystem.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }          // Primary Key
        public int OrderId { get; set; }            // Foreign Key to Order
        public decimal AmountPaid { get; set; }
        public decimal Balance { get; set; }        // If there's a remaining balance
        public DateTime PaymentDate { get; set; }
        
        // Navigation property for related Order
        public Order Order { get; set; }
    }
}