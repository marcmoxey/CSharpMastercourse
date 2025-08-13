using FinanceLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace FinanceLibrary.Interfaces
{
    public interface IFinanceManager
    {
        void AddTransaction(decimal amount, Categories category, bool isIncome, DateTime date, string description = "");
        List<TransactionModel> GetTransactions(Categories? category = null , DateTime? date = null);
        void GetSummary(); 
    }
}
