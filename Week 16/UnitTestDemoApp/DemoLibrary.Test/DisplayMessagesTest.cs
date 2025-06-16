<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

// Arrange, Act, Assert - 3 steps for unit testing
// expected and the actual value
namespace DemoLibrary.Test
{
    public class DisplayMessagesTest
    {
        // Method name - what it should return
        [Fact]
        public void GreetingShouldReturnGoodMorningMessage()
        {
            // Arrange - declare instance of the class
            DisplayMessages messages = new DisplayMessages();
            // what we expect the value to be
            string expected = "Go to bed Marc";

            // Act - call the method
            string actual = messages.Greeting("Marc", 2);

            // Assert - check if the actual value is equal to the expected value
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreetingShouldReturnGoodAfternoonMessage()
        {
            // Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good afternoon Marc";

            // Act
            string actual = messages.Greeting("Marc", 14);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Marc", 0 ,"Go to bed Marc")]
        [InlineData("Marc", 1, "Go to bed Marc")]
        [InlineData("Marc", 2, "Go to bed Marc")]
        [InlineData("Marc", 3, "Go to bed Marc")]
        [InlineData("Marc", 4, "Go to bed Marc")]
        [InlineData("Marc", 5, "Good morning Marc")]
        [InlineData("Marc", 6, "Good morning Marc")]
        [InlineData("Marc", 7, "Good morning Marc")]
        [InlineData("Marc", 8, "Good morning Marc")]
        [InlineData("Marc", 9, "Good morning Marc")]
        [InlineData("Marc", 10, "Good morning Marc")]
        [InlineData("Marc", 11, "Good morning Marc")]
        [InlineData("Marc", 12, "Good afternoon Marc")]
        [InlineData("Marc", 13, "Good afternoon Marc")]
        [InlineData("Marc", 14, "Good afternoon Marc")]
        [InlineData("Marc", 15, "Good afternoon Marc")]
        [InlineData("Marc", 16, "Good afternoon Marc")]
        [InlineData("Marc", 17, "Good afternoon Marc")]
        [InlineData("Marc", 18, "Good evening Marc")]
        [InlineData("Marc", 19, "Good evening Marc")]
        [InlineData("Marc", 20, "Good evening Marc")]
        [InlineData("Marc", 21, "Good evening Marc")]
        [InlineData("Marc", 22, "Good evening Marc")]
        [InlineData("Marc", 23, "Good evening Marc")]
        public void GreetingShouldReturnExpectedValue(string firstName, int hourOfTheDay, string expected)
        {
            // Arrange
            DisplayMessages messages = new DisplayMessages();
            
            // Act
            string actual = messages.Greeting(firstName, hourOfTheDay);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

// Arrange, Act, Assert - 3 steps for unit testing
// expected and the actual value
namespace DemoLibrary.Test
{
    public class DisplayMessagesTest
    {
        // Method name - what it should return
        [Fact]
        public void GreetingShouldReturnGoodMorningMessage()
        {
            // Arrange - declare instance of the class
            DisplayMessages messages = new DisplayMessages();
            // what we expect the value to be
            string expected = "Go to bed Marc";

            // Act - call the method
            string actual = messages.Greeting("Marc", 2);

            // Assert - check if the actual value is equal to the expected value
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreetingShouldReturnGoodAfternoonMessage()
        {
            // Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good afternoon Marc";

            // Act
            string actual = messages.Greeting("Marc", 14);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Marc", 0 ,"Go to bed Marc")]
        [InlineData("Marc", 1, "Go to bed Marc")]
        [InlineData("Marc", 2, "Go to bed Marc")]
        [InlineData("Marc", 3, "Go to bed Marc")]
        [InlineData("Marc", 4, "Go to bed Marc")]
        [InlineData("Marc", 5, "Good morning Marc")]
        [InlineData("Marc", 6, "Good morning Marc")]
        [InlineData("Marc", 7, "Good morning Marc")]
        [InlineData("Marc", 8, "Good morning Marc")]
        [InlineData("Marc", 9, "Good morning Marc")]
        [InlineData("Marc", 10, "Good morning Marc")]
        [InlineData("Marc", 11, "Good morning Marc")]
        [InlineData("Marc", 12, "Good afternoon Marc")]
        [InlineData("Marc", 13, "Good afternoon Marc")]
        [InlineData("Marc", 14, "Good afternoon Marc")]
        [InlineData("Marc", 15, "Good afternoon Marc")]
        [InlineData("Marc", 16, "Good afternoon Marc")]
        [InlineData("Marc", 17, "Good afternoon Marc")]
        [InlineData("Marc", 18, "Good evening Marc")]
        [InlineData("Marc", 19, "Good evening Marc")]
        [InlineData("Marc", 20, "Good evening Marc")]
        [InlineData("Marc", 21, "Good evening Marc")]
        [InlineData("Marc", 22, "Good evening Marc")]
        [InlineData("Marc", 23, "Good evening Marc")]
        public void GreetingShouldReturnExpectedValue(string firstName, int hourOfTheDay, string expected)
        {
            // Arrange
            DisplayMessages messages = new DisplayMessages();
            
            // Act
            string actual = messages.Greeting(firstName, hourOfTheDay);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
