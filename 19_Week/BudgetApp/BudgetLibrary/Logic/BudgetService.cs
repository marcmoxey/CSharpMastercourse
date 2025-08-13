<<<<<<< HEAD
﻿using BudgetLibrary.Interface;
using BudgetLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetLibrary.Logic
{
    public class BudgetService
    {

        public decimal CalculateTotalPerMonth(decimal totalPerPaycheck)
        {
            decimal output;
            output = totalPerPaycheck * 2;
            return Math.Round(output, 2);
        }

        public decimal CalculateTotalMonthlyExpenses(List<MonthlyExpenseModel> expenses)
        {
            decimal total = 0;
            foreach (var expense in expenses)
            {
              
                total += expense.ExpenseCost;
            }
            return Math.Round(total, 2);
        }

        public decimal CalculateTotalIncomeExpenses(decimal totalPerMonth, decimal totalMonthlyExpenses)
        {
            decimal output;
            output = totalPerMonth - totalMonthlyExpenses;
            return Math.Round(output, 2);
        }

        public decimal CalculateSavings(decimal totalIncomeExpenses, decimal monthlyAllowance)
        {
            decimal output;
            output = totalIncomeExpenses - monthlyAllowance;
            return Math.Round(output, 2);
        }

        public decimal CalculateBudgetPerCheck(decimal total)
        {

            decimal output;
            output = total / 2;
            return Math.Round(output,2);
        }

        public bool ValidateMonthlyExpense(MonthlyExpenseModel monthlyExpense)
        {
            return monthlyExpense != null && !string.IsNullOrWhiteSpace(monthlyExpense.ExpenseName) && monthlyExpense.ExpenseCost > 0;
        }

     

       

 

    }
}
=======
﻿using BudgetLibrary.Interface;
using BudgetLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetLibrary.Logic
{
    public class BudgetService
    {

        public decimal CalculateTotalPerMonth(decimal totalPerPaycheck)
        {
            decimal output;
            output = totalPerPaycheck * 2;
            return Math.Round(output, 2);
        }

        public decimal CalculateTotalMonthlyExpenses(List<MonthlyExpenseModel> expenses)
        {
            decimal total = 0;
            foreach (var expense in expenses)
            {
              
                total += expense.ExpenseCost;
            }
            return Math.Round(total, 2);
        }

        public decimal CalculateTotalIncomeExpenses(decimal totalPerMonth, decimal totalMonthlyExpenses)
        {
            decimal output;
            output = totalPerMonth - totalMonthlyExpenses;
            return Math.Round(output, 2);
        }

        public decimal CalculateSavings(decimal totalIncomeExpenses, decimal monthlyAllowance)
        {
            decimal output;
            output = totalIncomeExpenses - monthlyAllowance;
            return Math.Round(output, 2);
        }

        public decimal CalculateBudgetPerCheck(decimal total)
        {

            decimal output;
            output = total / 2;
            return Math.Round(output,2);
        }

        public bool ValidateMonthlyExpense(MonthlyExpenseModel monthlyExpense)
        {
            return monthlyExpense != null && !string.IsNullOrWhiteSpace(monthlyExpense.ExpenseName) && monthlyExpense.ExpenseCost > 0;
        }

       


 

    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
