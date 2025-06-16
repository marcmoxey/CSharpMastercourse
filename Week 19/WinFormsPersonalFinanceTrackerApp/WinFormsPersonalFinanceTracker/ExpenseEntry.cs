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
    public partial class ExpenseEntry : Form
    {
        IPersonalFinance _finance;
        public ExpenseEntry(IPersonalFinance finance)
        {
            InitializeComponent();
            _finance = finance;
            expenseCategoiresComboBox.DataSource = Enum.GetValues(typeof(SpendingCategories));
        }

        private void addExpenseBtn_Click(object sender, EventArgs e)
        {
            decimal.TryParse(expenseAmountTextBox.Text, out decimal amount);
            Enum.TryParse(expenseCategoiresComboBox.Text, out SpendingCategories category);
            ExpenseModel expense = new ExpenseModel
            {
                Date = DateOnly.FromDateTime(expenseMonthCalendar.SelectionStart),
                Amount = amount,
                Category = category
            };

            _finance.AddExpense(expense);
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
    public partial class ExpenseEntry : Form
    {
        IPersonalFinance _finance;
        public ExpenseEntry(IPersonalFinance finance)
        {
            InitializeComponent();
            _finance = finance;
            expenseCategoiresComboBox.DataSource = Enum.GetValues(typeof(SpendingCategories));
        }

        private void addExpenseBtn_Click(object sender, EventArgs e)
        {
            decimal.TryParse(expenseAmountTextBox.Text, out decimal amount);
            Enum.TryParse(expenseCategoiresComboBox.Text, out SpendingCategories category);
            ExpenseModel expense = new ExpenseModel
            {
                Date = DateOnly.FromDateTime(expenseMonthCalendar.SelectionStart),
                Amount = amount,
                Category = category
            };

            _finance.AddExpense(expense);
            this.Close();
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
