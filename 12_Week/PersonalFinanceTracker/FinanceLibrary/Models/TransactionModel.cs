using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceLibrary.Models
{
    public class TransactionModel
    {
        public decimal Amount { get; set; }
        public Categories Category { get; set; }
        public bool IsIncome { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public TransactionModel(decimal amount, Categories category, bool isIncome, DateTime date, string description = "")
        {
            Amount = amount;    
            Category = category;
            IsIncome = isIncome;
            Date = date;
            Description = description;
        }
    }
}
