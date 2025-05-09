using PersonalFianceLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFianceLibrary.Models
{
    public class IncomeModel
    {
        public DateOnly Date { get; set; }
        public decimal Amount { get; set; }
        public IncomeCategories Category { get; set; }
    }
}
