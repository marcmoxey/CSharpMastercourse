<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
=======
﻿using System;
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
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
