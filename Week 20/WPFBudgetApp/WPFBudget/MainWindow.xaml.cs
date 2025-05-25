using BudgetLibrary.Interface;
using BudgetLibrary.Logic;
using BudgetLibrary.Models;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFBudget
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IBudget
    {
        private readonly BudgetService _service;
        BindingList<MonthlyExpenseModel> expenses = new BindingList<MonthlyExpenseModel>();
        public MainWindow()
        {
            InitializeComponent();
            _service = new BudgetService();
            expensesListBox.ItemsSource = expenses;
        }

        public void AddExpense(MonthlyExpenseModel expense)
        {
            expenses.Add(expense);
            UpdateTotalMonthlyExpenses();
            UpdateTotalIncomeExpenses();
            UpdateSavings();
            UpdateBudgetPerCheck();
            Update6MonthFund();
            Update2MonthExpenses();


        }
        private void totalPerPaycheckTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            decimal.TryParse(totalPerPaycheckTextBox.Text, out decimal totalPerPaycheck);

            decimal totalPerMonth = _service.CalculateTotalPerMonth(totalPerPaycheck);
            totalPerMonthTextBlock.Text = totalPerMonth.ToString("$#,0.00;-$#,0.00");


            UpdateTotalIncomeExpenses();
            UpdateSavings();
            UpdateBudgetPerCheck();
      


        }

        private void monthlyAllowanceTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateSavings();
            UpdateBudgetPerCheck();
    
        }

        private void addExpense_Click(object sender, RoutedEventArgs e)
        {
            ExpenseEntry entry = new ExpenseEntry(this);
            entry.Show();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
           decimal.TryParse(totalPerPaycheckTextBox.Text, out decimal totalPerPaycheck);
            decimal.TryParse(monthlyAllowanceTextBox.Text, out decimal monthlyAllowance);
            BudgetModel budget = new BudgetModel
            {
                TotalPerPaycheck = totalPerPaycheck,
                MonthlyAllowance = monthlyAllowance
                

            };
        }
        private void UpdateTotalMonthlyExpenses()
        {
            var allExpenses = expensesListBox.Items.OfType<MonthlyExpenseModel>().ToList();
            decimal total = _service.CalculateTotalMonthlyExpenses(allExpenses);
            totalMonthlyExpensesTextBlock.Text = total.ToString("$#,0.00;-$#,0.00");
        }

        private void UpdateTotalIncomeExpenses()
        {
            decimal.TryParse(totalPerPaycheckTextBox.Text, out decimal totalPerPaycheck);
            decimal totalPerMonth = _service.CalculateTotalPerMonth(totalPerPaycheck);

            var allExpenses = expensesListBox.Items.OfType<MonthlyExpenseModel>().ToList();
            decimal totalMonthlyExpenses = _service.CalculateTotalMonthlyExpenses(allExpenses);

            decimal netIncome = _service.CalculateTotalIncomeExpenses(totalPerMonth, totalMonthlyExpenses);
            totalIncomeExpensesTextBlock.Text = netIncome.ToString("$#,0.00;-$#,0.00");
        }

        private void UpdateSavings()
        {
            if (decimal.TryParse(totalIncomeExpensesTextBlock.Text,
                                 NumberStyles.Currency,
                                 CultureInfo.CurrentCulture,
                                 out decimal totalIncomeExpenses) &&
                decimal.TryParse(monthlyAllowanceTextBox.Text, out decimal monthlyAllowance))
            {
                decimal savings = _service.CalculateSavings(totalIncomeExpenses, monthlyAllowance);
                totalSavingsTextBlock.Text = savings.ToString("$#,0.00;-$#,0.00");
            }
            else
            {
                totalSavingsTextBlock.Text = 0.ToString("$#,0.00;-$#,0.00");
            }
        }


        private void UpdateBudgetPerCheck()
        {
            var allExpenses = expensesListBox.Items.OfType<MonthlyExpenseModel>().ToList();
            decimal totalMonthlyExpenses = _service.CalculateTotalMonthlyExpenses(allExpenses);

            decimal.TryParse(totalPerPaycheckTextBox.Text, out decimal totalPerPaycheck);
            decimal totalPerMonth = _service.CalculateTotalPerMonth(totalPerPaycheck);
            decimal netIncome = _service.CalculateTotalIncomeExpenses(totalPerMonth, totalMonthlyExpenses);

            decimal.TryParse(monthlyAllowanceTextBox.Text, out decimal monthlyAllowance);
            decimal spendingPerCheck = _service.CalculateBudgetPerCheck(monthlyAllowance);
            spendingFirstCheckTextBlock.Text = spendingPerCheck.ToString("$#,0.00;-$#,0.00");
            spendingSecondCheckTextBlock.Text = spendingPerCheck.ToString("$#,0.00;-$#,0.00");
            spendingTotalTextBlock.Text = monthlyAllowance.ToString("$#,0.00;-$#,0.00");

            decimal billsPerCheck = _service.CalculateBudgetPerCheck(totalMonthlyExpenses);
            billPayFirstCheckTextBlock.Text = billsPerCheck.ToString("$#,0.00;-$#,0.00");
            billPaySecondCheckTextBlock.Text = billsPerCheck.ToString("$#,0.00;-$#,0.00");
            billPayTotalTextBlock.Text = totalMonthlyExpenses.ToString("$#,0.00;-$#,0.00");

            decimal savings = _service.CalculateSavings(netIncome, monthlyAllowance);
            decimal savingsPerCheck = _service.CalculateBudgetPerCheck(savings);
            savingsFirstCheckTextBlock.Text = savingsPerCheck.ToString("$#,0.00;-$#,0.00");
            savingsSecondCheckTextBlock.Text = savingsPerCheck.ToString("$#,0.00;-$#,0.00");
            savingsTotalTextBlock.Text = savings.ToString("$#,0.00;-$#,0.00");
        }

        private void Update6MonthFund()
        {
            var allExpenses = expensesListBox.Items.OfType<MonthlyExpenseModel>().ToList();
            decimal total = _service.CalculateTotalMonthlyExpenses(allExpenses);

            decimal.TryParse(totalMonthlyExpensesTextBlock.Text, out  decimal totalMonthlyExpenses);
            decimal sixMonthFund = total * 6;
            sixMonthExpensesTextBlock.Text = sixMonthFund.ToString("$#,0.00;-$#,0.00");
        }

        private void Update2MonthExpenses()
        {
            var allExpenses = expensesListBox.Items.OfType<MonthlyExpenseModel>().ToList();
            decimal total = _service.CalculateTotalMonthlyExpenses(allExpenses);

            decimal.TryParse(totalMonthlyExpensesTextBlock.Text, out decimal totalMonthlyExpenses);
            decimal twoMonthExpenses = total * 2;
            twoMonthExpensesTextBlock.Text = twoMonthExpenses.ToString("$#,0.00;-$#,0.00");
        }

        private void editExpense_Click(object sender, RoutedEventArgs e)
        {
            if(expensesListBox.SelectedItem is MonthlyExpenseModel selectedExpense)
            {
                ExpenseEntry entry = new ExpenseEntry(this, selectedExpense);
                entry.ShowDialog(); // Wait for edit
                expensesListBox.Items.Refresh(); // Refresh UI
                UpdateTotalMonthlyExpenses();
                UpdateTotalIncomeExpenses();
                UpdateSavings();
                UpdateBudgetPerCheck();
                Update6MonthFund();
                Update2MonthExpenses();
            }else
            {
                MessageBox.Show("Please select an expense to edit", "Invalid Expense", MessageBoxButton.OK);
            }
        }

        private void deleteExpense_Click(object sender, RoutedEventArgs e)
        {
            if (expensesListBox.SelectedItem is MonthlyExpenseModel selectedExpense)
            {
                if (MessageBox.Show($"Are You sure you want to delete {selectedExpense.ExpenseName}?", "Confirm Delete", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    expenses.Remove(selectedExpense);
                    UpdateTotalMonthlyExpenses();
                    UpdateTotalIncomeExpenses();
                    UpdateSavings();
                    UpdateBudgetPerCheck();
                    Update6MonthFund();
                    Update2MonthExpenses();

                }
            }
            else
            {
                MessageBox.Show("Please select an expense to delete", "Invalid Expense", MessageBoxButton.OK);
            }

        }
    }
}