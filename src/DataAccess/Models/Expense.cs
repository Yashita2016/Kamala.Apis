using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Expense
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }

        public virtual Type Type { get; set; } = null!;
    }
}
