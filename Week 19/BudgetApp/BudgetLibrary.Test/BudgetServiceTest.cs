<<<<<<< HEAD
﻿using BudgetLibrary.Logic;
using BudgetLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetLibrary.Test
{
    public class BudgetServiceTest
    {
        private BudgetService _service;

        public BudgetServiceTest()
        {
            _service = new BudgetService();
        }

        [Theory]
        [InlineData(1674.37, 3348.74)]
        [InlineData(11000, 22000)]
        [InlineData(1000, 2000)]
        public void CalculateTotalPerMonth_ValidInput_ReturnsCorrectValue(decimal totalPerPayCheck, decimal expected)
        {
            // Arrange 

            // Act 
            var actual = _service.CalculateTotalPerMonth(totalPerPayCheck);

            // Assert 
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void CalculateTotalMonthlyExpenses_ValidInput_ReturnsCorrectValue()
        {
            // Arrange 
            var expenses = new List<MonthlyExpenseModel>
            {
                new MonthlyExpenseModel { ExpenseName = "Rent", ExpenseCost = 1200 },
                new MonthlyExpenseModel { ExpenseName = "Utilities", ExpenseCost = 300 },
                new MonthlyExpenseModel { ExpenseName = "Groceries", ExpenseCost = 400 }
            };

            decimal expected = 1900;

            // Act 
            var actual = _service.CalculateTotalMonthlyExpenses(expenses);

            // Assert 
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3348.74, 1057.92, 2290.82)]
        public void CalculateTotalIncomeExpenses_ValidInput_ReturnsCorrectValue(decimal totalPerMonth, decimal totalMonthlyExpenses, decimal expected)
        {
            // Arrange


            // Act 
            var actual = _service.CalculateTotalIncomeExpenses(totalPerMonth, totalMonthlyExpenses);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2290.82, 140, 2150.82)]
        public void CalculateSavings_ValidInput_ReturnsCorrectValue(decimal totalIncomeExpenses, decimal monthlyAllowance, decimal expected)
        {
            // Arrange

            // Act 
            var actual = _service.CalculateSavings(totalIncomeExpenses, monthlyAllowance);

            // Assert 
            Assert.Equal(expected, actual);


        }

        [Theory]
        [InlineData(1057.92, 528.96)]
        [InlineData(140, 70)]
        [InlineData(2150.82, 1075.41)]
        public void CalculateBudgetPerCheck_ValidInput_ReturnsCorrectValue(decimal total, decimal expected)
        {
            // Arrange

            // Act 
            var actual = _service.CalculateBudgetPerCheck(total);
            // Assert 
            Assert.Equal(expected, actual);
        }

 
        [Fact]
        public void ValidateMonthlyExpense_ValidInput_ReturnsTrue()
        {

            // Arrange 
            var expense = new MonthlyExpenseModel { ExpenseName = "Rent", ExpenseCost = 1200 };

            var expected = true;
            // Act
            var actual = _service.ValidateMonthlyExpense(expense);
            // Assert
            Assert.Equal(expected, actual);
        }



    }
}

=======
﻿using BudgetLibrary.Logic;
using BudgetLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetLibrary.Test
{
    public class BudgetServiceTest
    {
        private BudgetService _service;

        public BudgetServiceTest()
        {
            _service = new BudgetService();
        }

        [Theory]
        [InlineData(1674.37, 3348.74)]
        [InlineData(11000, 22000)]
        [InlineData(1000, 2000)]
        public void CalculateTotalPerMonth_ValidInput_ReturnsCorrectValue(decimal totalPerPayCheck, decimal expected)
        {
            // Arrange 

            // Act 
            var actual = _service.CalculateTotalPerMonth(totalPerPayCheck);

            // Assert 
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void CalculateTotalMonthlyExpenses_ValidInput_ReturnsCorrectValue()
        {
            // Arrange 
            var expenses = new List<MonthlyExpenseModel>
            {
                new MonthlyExpenseModel { ExpenseName = "Rent", ExpenseCost = 1200 },
                new MonthlyExpenseModel { ExpenseName = "Utilities", ExpenseCost = 300 },
                new MonthlyExpenseModel { ExpenseName = "Groceries", ExpenseCost = 400 }
            };

            decimal expected = 1900;

            // Act 
            var actual = _service.CalculateTotalMonthlyExpenses(expenses);

            // Assert 
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3348.74, 1057.92, 2290.82)]
        public void CalculateTotalIncomeExpenses_ValidInput_ReturnsCorrectValue(decimal totalPerMonth, decimal totalMonthlyExpenses, decimal expected)
        {
            // Arrange


            // Act 
            var actual = _service.CalculateTotalIncomeExpenses(totalPerMonth, totalMonthlyExpenses);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2290.82, 140, 2150.82)]
        public void CalculateSavings_ValidInput_ReturnsCorrectValue(decimal totalIncomeExpenses, decimal monthlyAllowance, decimal expected)
        {
            // Arrange

            // Act 
            var actual = _service.CalculateSavings(totalIncomeExpenses, monthlyAllowance);

            // Assert 
            Assert.Equal(expected, actual);


        }

        [Theory]
        [InlineData(1057.92, 528.96)]
        [InlineData(140, 70)]
        [InlineData(2150.82, 1075.41)]
        public void CalculateBudgetPerCheck_ValidInput_ReturnsCorrectValue(decimal total, decimal expected)
        {
            // Arrange

            // Act 
            var actual = _service.CalculateBudgetPerCheck(total);
            // Assert 
            Assert.Equal(expected, actual);
        }

 
        [Fact]
        public void ValidateMonthlyExpense_ValidInput_ReturnsTrue()
        {

            // Arrange 
            var expense = new MonthlyExpenseModel { ExpenseName = "Rent", ExpenseCost = 1200 };

            var expected = true;
            // Act
            var actual = _service.ValidateMonthlyExpense(expense);
            // Assert
            Assert.Equal(expected, actual);
        }



    }
}

>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
