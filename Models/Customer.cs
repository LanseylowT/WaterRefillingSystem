using System.Collections.Generic;


namespace WaterRefillingSystem.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string FacebookAccount { get; set; }
        public bool IsDealer { get; set; }
        
        // Navigation property for related Orders
        public List<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new List<Order>();
        }
    }
}