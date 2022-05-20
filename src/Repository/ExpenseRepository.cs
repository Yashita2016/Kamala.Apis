using Contract.Models;
using DataAccess.Models;
using Repository.Contract;

namespace Repository;
public class ExpenseRepository : IExpenseRepository
{
    private readonly ExpenseTrackerContext _expenseTrackerContext;

    public ExpenseRepository(ExpenseTrackerContext expenseTrackerContext)
    {
        _expenseTrackerContext = expenseTrackerContext;
    }

    public Task Create(IList<ExpenseDto> request)
    {
        throw new NotImplementedException();
    }
}
