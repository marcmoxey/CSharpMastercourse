<<<<<<< HEAD
using PersonalFianceLibrary;
using PersonalFianceLibrary.Interfaces;
using PersonalFianceLibrary.Logic;
using PersonalFianceLibrary.Models;
using System.ComponentModel;

namespace WinFormsPersonalFinanceTracker
{
    public partial class Dashboard : Form, IPersonalFinance
    {
        private readonly PersonalFinanceService _service;
        BindingList<ExpenseModel> expenses = new BindingList<ExpenseModel>();
        private List<IncomeModel> incomes = new List<IncomeModel>();

        public Dashboard()
        {
            InitializeComponent();
            _service = new PersonalFinanceService();
            transactionListBox.DataSource = expenses;
            transactionListBox.DisplayMember = nameof(ExpenseModel.ExpenseDisplayValue);
        }

        public void addIncomeBtn_Click(object sender, EventArgs e)
        {
            IncomeEntry entry = new IncomeEntry(this);
            entry.Show();
        }

        public void addExpenseBtn_Click(object sender, EventArgs e)
        {

            ExpenseEntry entry = new ExpenseEntry(this);
            entry.Show();

        }

        public void AddIncome(IncomeModel income)
        {
            incomes.Add(income);
            UpdateBudget(income);
            UpdateExpense();
            UpdateRemainingBudget();

        }

        public void AddExpense(ExpenseModel expense)
        {
            expenses.Add(expense);
            UpdateExpense();
            UpdateRemainingBudget();
        }

        private void UpdateBudget(IncomeModel income)
        {
            
            decimal.TryParse(budgetTextBox.Text, out decimal newBudget);
            var newIncome = _service.CalculateNewBudget(income, newBudget);
            budgetTextBox.Text = newIncome.ToString();
        }

        private void UpdateRemainingBudget()
        {
            decimal.TryParse(budgetTextBox.Text, out decimal budget);
            var allExpense = transactionListBox.Items.OfType<ExpenseModel>().ToList();
            decimal total = _service.CalculateRemaining(allExpense, budget);
            remainingTotalLabel.Text = total.ToString("$#,0.00;-$#,0.00");
        }

   
        private void UpdateExpense()
        {
            var allExpense = transactionListBox.Items.OfType<ExpenseModel>().ToList();
            decimal allTransactions = _service.CalculateAllTransactions(allExpense);
            expenseTotalLabel.Text = allTransactions.ToString("$#,0.00;-$#,0.00");

        }


        
    }
}
=======
using PersonalFianceLibrary;
using PersonalFianceLibrary.Interfaces;
using PersonalFianceLibrary.Logic;
using PersonalFianceLibrary.Models;
using System.ComponentModel;

namespace WinFormsPersonalFinanceTracker
{
    public partial class Dashboard : Form, IPersonalFinance
    {
        private readonly PersonalFinanceService _service;
        BindingList<ExpenseModel> expenses = new BindingList<ExpenseModel>();
        private List<IncomeModel> incomes = new List<IncomeModel>();

        public Dashboard()
        {
            InitializeComponent();
            _service = new PersonalFinanceService();
            transactionListBox.DataSource = expenses;
            transactionListBox.DisplayMember = nameof(ExpenseModel.ExpenseDisplayValue);
        }

        public void addIncomeBtn_Click(object sender, EventArgs e)
        {
            IncomeEntry entry = new IncomeEntry(this);
            entry.Show();
        }

        public void addExpenseBtn_Click(object sender, EventArgs e)
        {

            ExpenseEntry entry = new ExpenseEntry(this);
            entry.Show();

        }

        public void AddIncome(IncomeModel income)
        {
            incomes.Add(income);
            UpdateBudget(income);
            UpdateExpense();
            UpdateRemainingBudget();

        }

        public void AddExpense(ExpenseModel expense)
        {
            expenses.Add(expense);
            UpdateExpense();
            UpdateRemainingBudget();
        }

        private void UpdateBudget(IncomeModel income)
        {
            
            decimal.TryParse(budgetTextBox.Text, out decimal newBudget);
            var newIncome = _service.CalculateNewBudget(income, newBudget);
            budgetTextBox.Text = newIncome.ToString();
        }

        private void UpdateRemainingBudget()
        {
            decimal.TryParse(budgetTextBox.Text, out decimal budget);
            var allExpense = transactionListBox.Items.OfType<ExpenseModel>().ToList();
            decimal total = _service.CalculateRemaining(allExpense, budget);
            remainingTotalLabel.Text = total.ToString("$#,0.00;-$#,0.00");
        }

   
        private void UpdateExpense()
        {
            var allExpense = transactionListBox.Items.OfType<ExpenseModel>().ToList();
            decimal allTransactions = _service.CalculateAllTransactions(allExpense);
            expenseTotalLabel.Text = allTransactions.ToString("$#,0.00;-$#,0.00");

        }


        
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
