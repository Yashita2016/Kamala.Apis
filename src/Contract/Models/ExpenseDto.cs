using System;

namespace Contract.Models
{
    public class ExpenseDto
    {
        public TypeDto ExpenseType { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
