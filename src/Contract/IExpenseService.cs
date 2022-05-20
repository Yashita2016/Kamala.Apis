using Contract.Models;
using System.Threading.Tasks;

namespace Contract
{
    public interface IExpenseService
    {
        public Task Create(CreateExpenseInput expenseInput);
    }
}
