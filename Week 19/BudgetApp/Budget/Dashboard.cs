<<<<<<< HEAD
using BudgetLibrary.Interface;
using BudgetLibrary.Logic;
using BudgetLibrary.Models;
using System.ComponentModel;
using System.Globalization;

namespace Budget
{
    public partial class Dashboard : Form, IBudget
    {
        private readonly BudgetService _service;
        private BindingList<MonthlyExpenseModel> expenses = new BindingList<MonthlyExpenseModel>();
        public Dashboard()
        {
            InitializeComponent();
            _service = new BudgetService();
            monthlyExpensesListBox.DataSource = expenses;
            monthlyExpensesListBox.DisplayMember = nameof(MonthlyExpenseModel.ExpenseDisplayValue);
        }
        private void addMonthlyExpenseBtn_Click(object sender, EventArgs e)
        {
            // Go to Expense Form to add a new expense
            MonthlyExpenseEntry entry = new MonthlyExpenseEntry(this);
            entry.Show();
        }

        private void totalPerPaycheckTextBox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(totalPerPaycheckTextBox.Text, out decimal totalPerPaycheck))
            {
                totalPerMonthResultLabel.Text = _service
                    .CalculateTotalPerMonth(totalPerPaycheck)
                    .ToString("$#,0.00;-$#,0.00");

                UpdateTotalIncomeMinusExpenses();
                UpdateSavings();
                UpdateBudgetPerCheck();
            }
            else
            {
                totalPerMonthResultLabel.Text = 0.ToString("$#,0.00;-$#,0.00");
            }



        }

        private void monthlyAllowanceTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSavings();
            UpdateBudgetPerCheck(); 
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public void AddExpense(MonthlyExpenseModel expense)
        {
            expenses.Add(expense);
            UpdateTotalMonthlyExpenses();
            UpdateTotalIncomeMinusExpenses();

        }

        private void UpdateTotalMonthlyExpenses()
        {
            var allExpenses = monthlyExpensesListBox.Items.OfType<MonthlyExpenseModel>().ToList();

            decimal total = _service.CalculateTotalMonthlyExpenses(allExpenses);

            totalMonthlyExpensesResultLabel.Text = total.ToString("$#,0.00;-$#,0.00");
        }

        private void UpdateTotalIncomeMinusExpenses()
        {
            if (decimal.TryParse(totalPerMonthResultLabel.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal totalPerMonth) &&
                decimal.TryParse(totalMonthlyExpensesResultLabel.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal totalMonthlyExpenses))
            {
                decimal netIncome = _service.CalculateTotalIncomeExpenses(totalPerMonth, totalMonthlyExpenses);

                // Use minus sign formatting, and no parentheses
                totalIncomeExpensesResultLabel.Text = netIncome.ToString("$#,0.00;-$#,0.00");

                // Change label color based on value
                if (netIncome < 0)
                {
                    totalIncomeExpensesResultLabel.ForeColor = Color.Red;
                }
                else
                {
                    totalIncomeExpensesResultLabel.ForeColor = SystemColors.ControlText; // Default label color
                }
            }
            else
            {
                totalIncomeExpensesResultLabel.Text = "$0.00";
                totalIncomeExpensesResultLabel.ForeColor = SystemColors.ControlText;
            }
        }


        private void UpdateSavings()
        {
            if (decimal.TryParse(totalIncomeExpensesResultLabel.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal totalIncomeExpenses) &&
                decimal.TryParse(monthlyAllowanceTextBox.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal monthlyAllowance))
            {
                decimal savings = _service.CalculateSavings(totalIncomeExpenses, monthlyAllowance);
                savingsResultLabel.Text = savings.ToString("$#,0.00;-$#,0.00");
            }
            else
            {
                savingsResultLabel.Text = 0.ToString("$#,0.00;-$#,0.00");
            }
        }

        private void UpdateBudgetPerCheck()
        {
            // SpendingPerCheck
            decimal.TryParse(monthlyAllowanceTextBox.Text, NumberStyles.Currency, CultureInfo.CurrentCulture,  out decimal monthlyAllowanceCheck);
            decimal SpendingPerCheck = _service.CalculateBudgetPerCheck(monthlyAllowanceCheck);
            firstCheckSpendingLabel.Text = SpendingPerCheck.ToString("$#,0.00;-$#,0.00");
            secondCheckSpendingLabel.Text = SpendingPerCheck.ToString("$#,0.00;-$#,0.00");
            spendingTotalResultLabel.Text = monthlyAllowanceCheck.ToString("$#,0.00;-$#,0.00");


            // Bill PayPerCheck
            decimal.TryParse(totalMonthlyExpensesResultLabel.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal totalMonthlyExpensesCheck);
            decimal BillPayPerCheck = _service.CalculateBudgetPerCheck(totalMonthlyExpensesCheck);
            firstCheckBillPayLabel.Text = BillPayPerCheck.ToString("$#,0.00;-$#,0.00");
            secondCheckBillPayLabel.Text = BillPayPerCheck.ToString("$#,0.00;-$#,0.00");
            billPayTotalResultLabel.Text = totalMonthlyExpensesCheck.ToString("$#,0.00;-$#,0.00");



            // SavingsPerCheck
            decimal.TryParse(savingsResultLabel.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal savingsCheck);
            decimal SavingsPerCheck = _service.CalculateBudgetPerCheck(savingsCheck);
            firstCheckSavingsLabel.Text = SavingsPerCheck.ToString("$#,0.00;-$#,0.00");
            secondCheckSavingsLabel.Text = SavingsPerCheck.ToString("$#,0.00;-$#,0.00");
            savingsTotalResultLabel.Text = savingsCheck.ToString("$#,0.00;-$#,0.00");


        }


    }
}
=======
using BudgetLibrary.Interface;
using BudgetLibrary.Logic;
using BudgetLibrary.Models;
using System.ComponentModel;
using System.Globalization;

namespace Budget
{
    public partial class Dashboard : Form, IBudget
    {
        private readonly BudgetService _service;
        private BindingList<MonthlyExpenseModel> expenses = new BindingList<MonthlyExpenseModel>();
        public Dashboard()
        {
            InitializeComponent();
            _service = new BudgetService();
            monthlyExpensesListBox.DataSource = expenses;
            monthlyExpensesListBox.DisplayMember = nameof(MonthlyExpenseModel.ExpenseDisplayValue);
        }
        private void addMonthlyExpenseBtn_Click(object sender, EventArgs e)
        {
            // Go to Expense Form to add a new expense
            MonthlyExpenseEntry entry = new MonthlyExpenseEntry(this);
            entry.Show();
        }

        private void totalPerPaycheckTextBox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(totalPerPaycheckTextBox.Text, out decimal totalPerPaycheck))
            {
                totalPerMonthResultLabel.Text = _service
                    .CalculateTotalPerMonth(totalPerPaycheck)
                    .ToString("$#,0.00;-$#,0.00");

                UpdateTotalIncomeMinusExpenses();
                UpdateSavings();
                UpdateBudgetPerCheck();
            }
            else
            {
                totalPerMonthResultLabel.Text = 0.ToString("$#,0.00;-$#,0.00");
            }



        }

        private void monthlyAllowanceTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateSavings();
            UpdateBudgetPerCheck(); 
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }

        public void AddExpense(MonthlyExpenseModel expense)
        {
            expenses.Add(expense);
            UpdateTotalMonthlyExpenses();
            UpdateTotalIncomeMinusExpenses();

        }

        private void UpdateTotalMonthlyExpenses()
        {
            var allExpenses = monthlyExpensesListBox.Items.OfType<MonthlyExpenseModel>().ToList();

            decimal total = _service.CalculateTotalMonthlyExpenses(allExpenses);

            totalMonthlyExpensesResultLabel.Text = total.ToString("$#,0.00;-$#,0.00");
        }

        private void UpdateTotalIncomeMinusExpenses()
        {
            if (decimal.TryParse(totalPerMonthResultLabel.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal totalPerMonth) &&
                decimal.TryParse(totalMonthlyExpensesResultLabel.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal totalMonthlyExpenses))
            {
                decimal netIncome = _service.CalculateTotalIncomeExpenses(totalPerMonth, totalMonthlyExpenses);

                // Use minus sign formatting, and no parentheses
                totalIncomeExpensesResultLabel.Text = netIncome.ToString("$#,0.00;-$#,0.00");

                // Change label color based on value
                if (netIncome < 0)
                {
                    totalIncomeExpensesResultLabel.ForeColor = Color.Red;
                }
                else
                {
                    totalIncomeExpensesResultLabel.ForeColor = SystemColors.ControlText; // Default label color
                }
            }
            else
            {
                totalIncomeExpensesResultLabel.Text = "$0.00";
                totalIncomeExpensesResultLabel.ForeColor = SystemColors.ControlText;
            }
        }


        private void UpdateSavings()
        {
            if (decimal.TryParse(totalIncomeExpensesResultLabel.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal totalIncomeExpenses) &&
                decimal.TryParse(monthlyAllowanceTextBox.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal monthlyAllowance))
            {
                decimal savings = _service.CalculateSavings(totalIncomeExpenses, monthlyAllowance);
                savingsResultLabel.Text = savings.ToString("$#,0.00;-$#,0.00");
            }
            else
            {
                savingsResultLabel.Text = 0.ToString("$#,0.00;-$#,0.00");
            }
        }

        private void UpdateBudgetPerCheck()
        {
            // SpendingPerCheck
            decimal.TryParse(monthlyAllowanceTextBox.Text, NumberStyles.Currency, CultureInfo.CurrentCulture,  out decimal monthlyAllowanceCheck);
            decimal SpendingPerCheck = _service.CalculateBudgetPerCheck(monthlyAllowanceCheck);
            firstCheckSpendingLabel.Text = SpendingPerCheck.ToString("$#,0.00;-$#,0.00");
            secondCheckSpendingLabel.Text = SpendingPerCheck.ToString("$#,0.00;-$#,0.00");
            spendingTotalResultLabel.Text = monthlyAllowanceCheck.ToString("$#,0.00;-$#,0.00");


            // Bill PayPerCheck
            decimal.TryParse(totalMonthlyExpensesResultLabel.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal totalMonthlyExpensesCheck);
            decimal BillPayPerCheck = _service.CalculateBudgetPerCheck(totalMonthlyExpensesCheck);
            firstCheckBillPayLabel.Text = BillPayPerCheck.ToString("$#,0.00;-$#,0.00");
            secondCheckBillPayLabel.Text = BillPayPerCheck.ToString("$#,0.00;-$#,0.00");
            billPayTotalResultLabel.Text = totalMonthlyExpensesCheck.ToString("$#,0.00;-$#,0.00");



            // SavingsPerCheck
            decimal.TryParse(savingsResultLabel.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal savingsCheck);
            decimal SavingsPerCheck = _service.CalculateBudgetPerCheck(savingsCheck);
            firstCheckSavingsLabel.Text = SavingsPerCheck.ToString("$#,0.00;-$#,0.00");
            secondCheckSavingsLabel.Text = SavingsPerCheck.ToString("$#,0.00;-$#,0.00");
            savingsTotalResultLabel.Text = savingsCheck.ToString("$#,0.00;-$#,0.00");


        }


    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
