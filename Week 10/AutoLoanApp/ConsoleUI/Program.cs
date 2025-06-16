using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLoanLibrary;
using CarLoanLibrary.Models;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoLoanModel carLoan = new AutoLoanModel();

            GetUserInformation(carLoan);


        }
        private static double GetValidInput(string prompt, string errorMessage)
        {
            Console.Write(prompt);
            while (true)
            {
                string input = Console.ReadLine();
                if (double.TryParse(input, out double result) && result > 0)
                {
                    return result;
                }
                Console.WriteLine(errorMessage);
                Console.Write(prompt);
            }
        }

        private static void GetUserInformation(AutoLoanModel carLoan)
        {

            // Get loan amount
            carLoan.LoanAmount = GetValidInput("How much is the loan: ", "Invalid input. Please enter a valid loan amount.");

            // Get duration of the loan
            carLoan.LoanTerm = GetValidInput("What is the duration of the loan (in years): ", "Invalid input. Please enter a valid loan term.");

            // Get interest on loan
            carLoan.InterestRate = GetValidInput("What is the annual interest rate of the loan (e.g., 6 for 6%): ", "Invalid input. Please enter a valid interest rate.");


            // Calculate periodic interest rate
            double periodicInterestRate = AutoLoanLogic.CalculatePeriodicInterestRate(carLoan.InterestRate);

            // Calculate total number of monthly payments
            double totalMonthlyPayments = AutoLoanLogic.CalculateTotalMonthlyPayments(carLoan.LoanTerm);

            // Calculate monthly auto loan payment
            double monthlyAutoLoanPayments = AutoLoanLogic.CalculateAutoLoanPayments(carLoan.LoanAmount, periodicInterestRate, totalMonthlyPayments);

            // Display monthly payment
            Console.WriteLine($"Your monthly auto payment is {monthlyAutoLoanPayments:C}");


            // Initialize remaining balance
            double remainingBalance = carLoan.LoanAmount;

            Console.WriteLine("Month\tInterest\tPrincipal\tEnding Balance");
            for (int month = 1; month <= totalMonthlyPayments; month++)
            {

                // Calculate interest for the current month
                double interest = AutoLoanLogic.CalculateCurrentMonthInterest(remainingBalance, periodicInterestRate);

                // calculate principle for the current month
                double principal = AutoLoanLogic.CalculateCurrentMonthPrinciple(monthlyAutoLoanPayments, interest);

                // update the remaining Balance
                remainingBalance -= principal;

                // Print the details for the current month
                Console.WriteLine($"{month}\t{interest:C}\t\t{principal:C}\t\t{remainingBalance:C}");

                // Print "End of year X" after every 12 months
                if (month % 12 == 0)
                {
                    Console.WriteLine($"End of year {month / 12}");
                }
            }
        }
    }
}
