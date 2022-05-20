using Repository.Models;

namespace Repository;
public class ExpenseRepository
{
    private readonly ExpenseTrackerContext _expenseTrackerContext;

    public ExpenseRepository(ExpenseTrackerContext expenseTrackerContext)
    {
        _expenseTrackerContext = expenseTrackerContext;
    }

}
