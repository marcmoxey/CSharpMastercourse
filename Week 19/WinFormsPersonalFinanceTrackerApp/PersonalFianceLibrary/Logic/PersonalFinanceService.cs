<<<<<<< HEAD
﻿using PersonalFianceLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFianceLibrary.Logic
{
    public class PersonalFinanceService
    {
        public decimal CalculateRemaining(List<ExpenseModel> expenses, decimal budget)
        {
            decimal remainingTotal = 0;
            decimal expensesTotal = 0;

            foreach(var expense in expenses)
            {
                expensesTotal += expense.Amount;
            }

            remainingTotal = budget - Math.Round(expensesTotal, 2);

            return remainingTotal;
        }

        public decimal CalculateAllTransactions(List<ExpenseModel> expenses)
        {
            decimal total = 0;
            foreach (var expense in expenses)
            {
                total += expense.Amount;
            }

            total = Math.Round(total, 2);
            return total;
        }

        public decimal CalculateNewBudget(IncomeModel income, decimal budget)
        {
            decimal total = 0;
            total = income.Amount + budget;
            decimal output = Math.Round(total, 2);
            return output;

        }

     
    }
}
=======
﻿using PersonalFianceLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFianceLibrary.Logic
{
    public class PersonalFinanceService
    {
        public decimal CalculateRemaining(List<ExpenseModel> expenses, decimal budget)
        {
            decimal remainingTotal = 0;
            decimal expensesTotal = 0;

            foreach(var expense in expenses)
            {
                expensesTotal += expense.Amount;
            }

            remainingTotal = budget - Math.Round(expensesTotal, 2);

            return remainingTotal;
        }

        public decimal CalculateAllTransactions(List<ExpenseModel> expenses)
        {
            decimal total = 0;
            foreach (var expense in expenses)
            {
                total += expense.Amount;
            }

            total = Math.Round(total, 2);
            return total;
        }

        public decimal CalculateNewBudget(IncomeModel income, decimal budget)
        {
            decimal total = 0;
            total = income.Amount + budget;
            decimal output = Math.Round(total, 2);
            return output;

        }

     
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
