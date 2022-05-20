using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public partial class Type
    {
        public Type()
        {
            Expenses = new HashSet<Expense>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
