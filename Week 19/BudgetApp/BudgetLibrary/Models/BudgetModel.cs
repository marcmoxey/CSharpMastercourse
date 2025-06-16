<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
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
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
