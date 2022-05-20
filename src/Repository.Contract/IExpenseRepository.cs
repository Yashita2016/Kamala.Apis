using Contract.Models;

namespace Repository.Contract
{
    public interface IExpenseRepository
    {
        Task Create(IList<ExpenseDto> request);
    }
}
