using FinanceLibrary;
using FinanceLibrary.Interfaces;
using FinanceLibrary.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp
{
    class Program
    {

        static IFinanceManager manager = new FinanceManager();
        static void Main(string[] args)
        {

            while (true)
            {

                Console.WriteLine("Welcome to Personal Finance Tracker!");
                Console.WriteLine("1. Add Transaction");
                Console.WriteLine("2. View Transactions");
                Console.WriteLine("3. View Summary");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTransactionUI();
                        break;
                    case "2":
                        ViewTransactionUI();
                        break;
                    case "3":
                        manager.GetSummary();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Try again");
                        break;
                }
            }

        }

        public static void AddTransactionUI()
        {
            Console.Write("Enter amount: ");
            decimal amount;
            while (!decimal.TryParse(Console.ReadLine(), NumberStyles.Currency, CultureInfo.InvariantCulture, out amount))
            {
                Console.Write("Invalid input! Enter a valid amount");
            }

            // Show available categories
            Console.WriteLine("Available categories:");
            foreach(var category in Enum.GetValues(typeof(Categories)))
            {
                Console.WriteLine($"{(int)category}: {category}");
            }

            Console.Write("Enter category number: ");
            int categoryInput;
            while (!int.TryParse(Console.ReadLine(), out categoryInput) || !Enum.IsDefined(typeof(Categories),categoryInput))
            {
                Console.Write("Invalid category! Enter a valid category number: ");
            }

            // Convert the user's input into the corresponding enum value
            Categories selectedCategory = (Categories)categoryInput;

            Console.Write("Is this an income or expense? (Type 'income' or 'expense'): ");
            string typeInput = Console.ReadLine().ToLower();

            // Repeat until a valid input ("income" or "expense") is provided
            while (typeInput != "income" && typeInput != "expense")
            {
                Console.Write("Invalid input! Please enter 'income' or 'expense': ");
                typeInput = Console.ReadLine().ToLower();
            }

            bool isIncome = typeInput == "income"; // Determine transaction type


            Console.Write("Enter date (yyyy-MM-dd): ");
            DateTime date; 
            while(!DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.Write("Invalid date format! Enter again (yyyy-MM-dd): ");
            }

            Console.Write("Enter description (optional): ");
            string description = Console.ReadLine();

            manager.AddTransaction(amount, selectedCategory, isIncome, date, description);
        }

        public static void ViewTransactionUI()
        {

            Console.WriteLine("1. View all transactions");
            Console.WriteLine("2. Filter by category");
            Console.WriteLine("3. Filter by date");
            Console.Write("Enter choice: ");
            string filterChoice = Console.ReadLine();

            List<TransactionModel> transactions = new List<TransactionModel>();

            if (filterChoice == "2")
            {

                // Show available categories
                Console.WriteLine("Available categories: "); 
                foreach(var category in Enum.GetValues(typeof(Categories)))
                {
                    Console.WriteLine($"{(int)category}: {category}");
                }

                Console.Write("Enter category number: ");
                int categoryInput;

                while (!int.TryParse(Console.ReadLine(), out categoryInput) || !Enum.IsDefined(typeof(Categories), categoryInput))
                {
                    Console.Write("Invalid category! Enter a valid category number: ");
                }

                Categories  selectedCategory = (Categories)categoryInput;
                transactions = manager.GetTransactions(selectedCategory);

            }
            else if (filterChoice == "3")
            {

                Console.Write("Enter date (yyyy-MM-dd): ");
                DateTime filterDate;

                while (!DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out filterDate))
                {
                    Console.Write("Invalid date format! Enter (yyyy-MM-dd): ");
                }

                transactions = manager.GetTransactions(date: filterDate);
            }
            else
            {
        
                transactions = manager.GetTransactions(); // View all transactions if no filter
            }
            if (transactions.Count == 0)
            {
                Console.WriteLine("No transactions found match your criteria." +
                    "n");
            }
            else
            {
                Console.WriteLine("\nTransactions:");
                foreach (TransactionModel transaction in transactions)
                {
                    Console.WriteLine($"{transaction.Date:yyyy-MM-dd}: {transaction.Category} - {(transaction.IsIncome ? "+" : "-")}${transaction.Amount} ({transaction.Description})");
                }
            }
        }
    }
}

              