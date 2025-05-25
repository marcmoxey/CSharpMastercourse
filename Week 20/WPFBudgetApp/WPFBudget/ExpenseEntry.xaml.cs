using BudgetLibrary.Interface;
using BudgetLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFBudget
{
    /// <summary>
    /// Interaction logic for ExpenseEntry.xaml
    /// </summary>
    public partial class ExpenseEntry : Window
    {
        IBudget _budget;    
        public ExpenseEntry(IBudget budget)
        {
            InitializeComponent();
            _budget = budget;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            decimal.TryParse(expenseAmountTextBox.Text, out decimal expenseAmount);
            MonthlyExpenseModel expense = new MonthlyExpenseModel
            {
                ExpenseName = expenseNameTextBox.Text,
                ExpenseCost = expenseAmount
            };

            _budget.AddExpense(expense);
            this.Close();
        }
    }
}
