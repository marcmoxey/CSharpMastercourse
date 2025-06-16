using FinanceLibrary.Interfaces;
using FinanceLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceLibrary
{
    public class FinanceManager : IFinanceManager
    {
        private List<TransactionModel> transactions = new List<TransactionModel>();

        public void AddTransaction(decimal amount, Categories category, bool isIncome, DateTime date, string description = "")
        {
            transactions.Add(new TransactionModel(amount, category, isIncome, date, description));
            Console.WriteLine("Transaction added successfully\n");
        }

        public void GetSummary()
        {
            decimal totalIncome = transactions.Where(t => t.IsIncome).Sum(t => t.Amount);
            decimal totalExpenses = transactions.Where(t => !t.IsIncome).Sum(t => t.Amount);
            decimal balance = totalIncome - totalExpenses;

            Console.WriteLine($"Total Income: ${totalIncome}");
            Console.WriteLine($"Total Expenses: ${totalExpenses}");
            Console.WriteLine($"Balance: ${balance}\n");
        }

        public List<TransactionModel> GetTransactions(Categories? category = null, DateTime? date = null)
        {
            var filteredTransactions = transactions.AsEnumerable();

            if (category.HasValue)
            {
                // Filter by category (enum comparison)
                filteredTransactions = filteredTransactions.Where(t => t.Category == category.Value);
            }

            if (date.HasValue)
            {
                // Filter by date
                filteredTransactions = filteredTransactions.Where(t => t.Date.Date == date.Value.Date);
            }

            return filteredTransactions.ToList();
        }

    }
}
