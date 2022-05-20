using System.Collections.Generic;

namespace Contract.Models
{
    public class CreateExpenseInput
    {
        public CreateExpenseInput(IList<ExpenseDto> expenses)
        {
            Expenses = expenses;
        }

        public IList<ExpenseDto> Expenses { get; }
    }
}
