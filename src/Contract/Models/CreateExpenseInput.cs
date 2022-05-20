using System.Collections.Generic;

namespace Contract.Models
{
    public class CreateExpenseInput
    {
        public CreateExpenseInput(IList<Expense> expenses)
        {
            Expenses = expenses;
        }

        public IList<Expense> Expenses { get; }
    }
}
