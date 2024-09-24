using System;

namespace WaterRefillingSystem.Models
{
    public class Expense
    {
        public int ExpenseId { get; set; }      // Primary Key
        public string Title { get; set; }       // Description of the expense
        public decimal Amount { get; set; }     // Amount spent
        public DateTime Date { get; set; }      // Date of the expense
    }
}