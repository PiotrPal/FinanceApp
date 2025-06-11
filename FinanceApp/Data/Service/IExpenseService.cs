using FinanceApp.Models;

namespace FinanceApp.Data.Service
{
    public interface IExpenseService
    {
        Task <IEnumerable<Expense>> GetAll();
        Task Add(Expense expense);

    }
}
