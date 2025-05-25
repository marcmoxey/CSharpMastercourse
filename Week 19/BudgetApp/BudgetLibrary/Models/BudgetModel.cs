using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetLibrary.Models
{
    public class BudgetModel
    {
        public decimal TotalPerPaycheck { get; set; }
        public decimal MonthlyAllowance { get; set; }   

        public List<MonthlyExpenseModel> MonthlyExpenses { get; set; } = new List<MonthlyExpenseModel>();
    }
}
