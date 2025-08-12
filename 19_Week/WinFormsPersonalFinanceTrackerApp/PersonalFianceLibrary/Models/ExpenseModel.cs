<<<<<<< HEAD
﻿using PersonalFianceLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFianceLibrary.Models
{
    public class ExpenseModel
    {
        public DateOnly Date { get; set; }
        public decimal Amount { get; set; }
        public SpendingCategories Category { get; set; }

        public string ExpenseDisplayValue => $"{Category}: {Amount:C}";
    }
}
=======
﻿using PersonalFianceLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFianceLibrary.Models
{
    public class ExpenseModel
    {
        public DateOnly Date { get; set; }
        public decimal Amount { get; set; }
        public SpendingCategories Category { get; set; }

        public string ExpenseDisplayValue => $"{Category}: {Amount:C}";
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
