using System;
using System.Collections.Generic;

namespace WaterRefillingSystem.Models
{
    public class Order
    {
        public int OrderId { get; set; }                // Primary Key
        public int CustomerId { get; set; }             // Foreign Key to Customer
        public int ItemId { get; set; }                 // Foreign Key to ItemType
        public int ServiceId { get; set; }              // Foreign Key to ServiceOption
        public int OwnGallons { get; set; }             // Number of gallons owned by the customer
        public int BorrowedGallons { get; set; }        // Number of gallons borrowed by the customer
        public decimal TotalPrice { get; set; }         // Total price of the order
        public int PaymentStatusId { get; set; }        // Foreign Key to PaymentStatus
        public DateTime Date { get; set; }

        // Navigation properties
        public Customer Customer { get; set; }           // Linked Customer
        public ItemType Item { get; set; }               // Linked ItemType
        public ServiceOption ServiceOption { get; set; } // Linked ServiceOption
        public PaymentStatus PaymentStatus { get; set; } // Linked PaymentStatus
        public List<Payment> Payments { get; set; } = new List<Payment>(); // Linked payments
    }
}