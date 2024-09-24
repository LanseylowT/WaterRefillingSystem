using System;

namespace WaterRefillingSystem.Models
{
    public class Sales
    {
        public int SaleId { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime Date { get; set; }
        
        // Navigation properties
        public Customer Customer { get; set; }
        public Order Order { get; set; }
    }
}