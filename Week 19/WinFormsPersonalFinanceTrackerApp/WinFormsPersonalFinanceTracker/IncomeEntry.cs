<<<<<<< HEAD
﻿using PersonalFianceLibrary.Enums;
using PersonalFianceLibrary.Interfaces;
using PersonalFianceLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPersonalFinanceTracker
{
    public partial class IncomeEntry : Form
    {
        IPersonalFinance _finance;
        IncomeCategories categories;
        public IncomeEntry(IPersonalFinance finance)
        {
            InitializeComponent();
            _finance = finance;
            incomeCategoiresComboBox.DataSource = Enum.GetValues(typeof(IncomeCategories));
        }

        private void addIncomeBtn_Click(object sender, EventArgs e)
        {
            decimal.TryParse(incomeAmountTextBox.Text, out decimal amount);
            Enum.TryParse(incomeCategoiresComboBox.Text, out IncomeCategories category);
           IncomeModel income = new IncomeModel
            {
                Date = DateOnly.FromDateTime(incomeMonthCalendar.SelectionStart),
                Amount = amount,
                Category = category
            };

            _finance.AddIncome(income);
            this.Close();
        }

       
    }
}
=======
﻿using PersonalFianceLibrary.Enums;
using PersonalFianceLibrary.Interfaces;
using PersonalFianceLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsPersonalFinanceTracker
{
    public partial class IncomeEntry : Form
    {
        IPersonalFinance _finance;
        IncomeCategories categories;
        public IncomeEntry(IPersonalFinance finance)
        {
            InitializeComponent();
            _finance = finance;
            incomeCategoiresComboBox.DataSource = Enum.GetValues(typeof(IncomeCategories));
        }

        private void addIncomeBtn_Click(object sender, EventArgs e)
        {
            decimal.TryParse(incomeAmountTextBox.Text, out decimal amount);
            Enum.TryParse(incomeCategoiresComboBox.Text, out IncomeCategories category);
           IncomeModel income = new IncomeModel
            {
                Date = DateOnly.FromDateTime(incomeMonthCalendar.SelectionStart),
                Amount = amount,
                Category = category
            };

            _finance.AddIncome(income);
            this.Close();
        }

       
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
