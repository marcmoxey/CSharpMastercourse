<<<<<<< HEAD
﻿using BudgetLibrary.Interface;
using BudgetLibrary.Models;
using BudgetLibrary.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget
{
    public partial class MonthlyExpenseEntry : Form
    {
        IBudget _budget;
        public MonthlyExpenseEntry(IBudget budget)
        {
            InitializeComponent();
            _budget = budget;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            MonthlyExpenseModel expense = new MonthlyExpenseModel
            {
                ExpenseName = expenseNameTextBox.Text,
                ExpenseCost = decimal.Parse(expenseCostTextBox.Text),
            };

            var service = new BudgetService();  
            if(!service.ValidateMonthlyExpense(expense))
            {
                MessageBox.Show("Please fill in all the fields.", "Invalid Expense", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _budget.AddExpense(expense);
                this.Close();
            }

           

        }
    }
}
=======
﻿using BudgetLibrary.Interface;
using BudgetLibrary.Models;
using BudgetLibrary.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget
{
    public partial class MonthlyExpenseEntry : Form
    {
        IBudget _budget;
        public MonthlyExpenseEntry(IBudget budget)
        {
            InitializeComponent();
            _budget = budget;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            MonthlyExpenseModel expense = new MonthlyExpenseModel
            {
                ExpenseName = expenseNameTextBox.Text,
                ExpenseCost = decimal.Parse(expenseCostTextBox.Text),
            };

            var service = new BudgetService();  
            if(!service.ValidateMonthlyExpense(expense))
            {
                MessageBox.Show("Please fill in all the fields.", "Invalid Expense", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _budget.AddExpense(expense);
                this.Close();
            }

           

        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
