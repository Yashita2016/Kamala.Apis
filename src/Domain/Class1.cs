using Contract;
using Contract.Models;
using System;
using System.Threading.Tasks;

namespace Domain
{
    public class ExpenseService : IExpenseService
    {
        public Task Create(CreateExpenseInput expenseInput)
        {
            throw new NotImplementedException();
        }
    }
}
