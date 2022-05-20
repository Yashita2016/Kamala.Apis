using System;

namespace Contract.Models
{
    public class Expense
    {
        public Type ExpenseType { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
