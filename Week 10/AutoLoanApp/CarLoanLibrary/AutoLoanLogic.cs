using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLoanLibrary
{

public static class AutoLoanLogic
    {
        public static double CalculateAutoLoanPayments(double loanAmount, double periodicInterestRate, double numberOfPayments)
        {
            // Calculate the denominator: 1 - (1 + i)^(-n)
            double denominator = 1 - Math.Pow(1 + periodicInterestRate, -numberOfPayments);

            // Calculate the periodic payment
            double autoLoanPayment = (periodicInterestRate * loanAmount) / denominator;

            return autoLoanPayment;
        }

        public static double CalculatePeriodicInterestRate(double annualInterestRate)
        {
            // Convert annual interest rate to monthly interest rate
            return annualInterestRate / 100 / 12; // Divide by 100 to convert percentage to decimal
        }

        public static double CalculateTotalMonthlyPayments(double loanTerm)
        {
            // Calculate total number of monthly payments
            return loanTerm * 12;
        }

        public static double CalculateCurrentMonthInterest(double remainingBalance, double periodicInterestRate)
        {
            // Calculate interest for the current month
            return remainingBalance * periodicInterestRate;
        }

        public static double CalculateCurrentMonthPrinciple(double monthlyAutoLoanPayments, double interest)
        {
            // Calculate principal for the current month
            return monthlyAutoLoanPayments - interest;
        }
    }
}
