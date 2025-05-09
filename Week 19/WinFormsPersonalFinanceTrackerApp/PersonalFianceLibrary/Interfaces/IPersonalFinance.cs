using PersonalFianceLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFianceLibrary.Interfaces
{
    public  interface IPersonalFinance
    {
        void AddIncome(IncomeModel income);
        void AddExpense(ExpenseModel expense);
    }
}
