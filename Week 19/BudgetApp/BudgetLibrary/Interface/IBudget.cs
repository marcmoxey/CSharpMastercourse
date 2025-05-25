using BudgetLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetLibrary.Interface
{
    public interface IBudget
    {
        public void AddExpense(MonthlyExpenseModel expense);

        //void DeleteExpense(string expenseName);

        //void UpdateExpense(string expenseName, decimal newExpenseCost);

    }
}
