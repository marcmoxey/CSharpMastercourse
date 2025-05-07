using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetLibrary.Models
{
    public class MonthlyExpenseModel
    {
        public string ExpenseName { get; set; }
        public decimal ExpenseCost { get; set; }   
        
        public string ExpenseDisplayValue => $"{ExpenseName} - {ExpenseCost:C}";
    }
}
