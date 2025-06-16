<<<<<<< HEAD
using UserLibrary.Models;
using UserLibrary.BusinessLogic;
using Xunit;
using System;

namespace UserLibrary.Tests
{
    public class PersonExtensionsTests
    {
        [Theory]
        [InlineData("Tim", "Corey", "Tim Corey")]
        [InlineData("Jane", "Smith", "Jane Smith")]
        [InlineData("Sue", "Storm", "Sue Storm")]
        public void GetFullNameShouldReturnValidNames(string firstName,
                                                      string lastName,
                                                      string expected)
        {
            // Arrange
            PersonModel p = new() { FirstName = firstName, LastName = lastName };

            // Act
            string actual = p.GetFullName();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Tim", "")]
        [InlineData("", "Smith")]
        [InlineData("", "")]
        [InlineData("Tim", "   ")]
        [InlineData("   ", "Smith")]
        [InlineData("   ", "   ")]
        [InlineData("Tim", null)]
        [InlineData(null, "Smith")]
        [InlineData(null, null)]
        public void GetFullNameShouldThrowExceptions(string firstName,
                                                      string lastName)
        {
            // Arrange
            PersonModel p = new() { FirstName = firstName, LastName = lastName };

            // Act
            Assert.Throws<ArgumentException>(() => p.GetFullName());
        }

        [Theory]
        [InlineData("Tim", "Corey", "TCorey")]
        [InlineData("Jane", "Smith", "JSmith")]
        [InlineData("Sue", "Storm", "SStorm")]
        public void GetLoginNameShouldReturnValidNames(string firstName,
                                                      string lastName,
                                                      string expected)
        {
            // Arrange
            PersonModel p = new() { FirstName = firstName, LastName = lastName };

            // Act
            string actual = p.GetLoginName();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Tim", "")]
        [InlineData("", "Smith")]
        [InlineData("", "")]
        [InlineData("Tim", "   ")]
        [InlineData("   ", "Smith")]
        [InlineData("   ", "   ")]
        [InlineData("Tim", null)]
        [InlineData(null, "Smith")]
        [InlineData(null, null)]
        public void GetLoginNameShouldThrowExceptions(string firstName,
                                                      string lastName)
        {
            // Arrange
            PersonModel p = new() { FirstName = firstName, LastName = lastName };

            // Act
            Assert.Throws<ArgumentException>(() => p.GetLoginName());
        }

        [Theory]
        [InlineData("Tim", "Corey", "TC")]
        [InlineData("Jane", "Smith", "JS")]
        [InlineData("Sue", "Storm", "SS")]
        public void GetInitialsShouldReturnValidNames(string firstName,
                                                      string lastName,
                                                      string expected)
        {
            // Arrange
            PersonModel p = new() { FirstName = firstName, LastName = lastName };

            // Act
            string actual = p.GetInitials();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Tim", "")]
        [InlineData("", "Smith")]
        [InlineData("", "")]
        [InlineData("Tim", "   ")]
        [InlineData("   ", "Smith")]
        [InlineData("   ", "   ")]
        [InlineData("Tim", null)]
        [InlineData(null, "Smith")]
        [InlineData(null, null)]
        public void GetInitialsShouldThrowExceptions(string firstName,
                                                      string lastName)
        {
            // Arrange
            PersonModel p = new() { FirstName = firstName, LastName = lastName };

            // Act
            Assert.Throws<ArgumentException>(() => p.GetInitials());
        }
    }
=======
using UserLibrary.Models;
using UserLibrary.BusinessLogic;
using Xunit;
using System;

namespace UserLibrary.Tests
{
    public class PersonExtensionsTests
    {
        [Theory]
        [InlineData("Tim", "Corey", "Tim Corey")]
        [InlineData("Jane", "Smith", "Jane Smith")]
        [InlineData("Sue", "Storm", "Sue Storm")]
        public void GetFullNameShouldReturnValidNames(string firstName,
                                                      string lastName,
                                                      string expected)
        {
            // Arrange
            PersonModel p = new() { FirstName = firstName, LastName = lastName };

            // Act
            string actual = p.GetFullName();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Tim", "")]
        [InlineData("", "Smith")]
        [InlineData("", "")]
        [InlineData("Tim", "   ")]
        [InlineData("   ", "Smith")]
        [InlineData("   ", "   ")]
        [InlineData("Tim", null)]
        [InlineData(null, "Smith")]
        [InlineData(null, null)]
        public void GetFullNameShouldThrowExceptions(string firstName,
                                                      string lastName)
        {
            // Arrange
            PersonModel p = new() { FirstName = firstName, LastName = lastName };

            // Act
            Assert.Throws<ArgumentException>(() => p.GetFullName());
        }

        [Theory]
        [InlineData("Tim", "Corey", "TCorey")]
        [InlineData("Jane", "Smith", "JSmith")]
        [InlineData("Sue", "Storm", "SStorm")]
        public void GetLoginNameShouldReturnValidNames(string firstName,
                                                      string lastName,
                                                      string expected)
        {
            // Arrange
            PersonModel p = new() { FirstName = firstName, LastName = lastName };

            // Act
            string actual = p.GetLoginName();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Tim", "")]
        [InlineData("", "Smith")]
        [InlineData("", "")]
        [InlineData("Tim", "   ")]
        [InlineData("   ", "Smith")]
        [InlineData("   ", "   ")]
        [InlineData("Tim", null)]
        [InlineData(null, "Smith")]
        [InlineData(null, null)]
        public void GetLoginNameShouldThrowExceptions(string firstName,
                                                      string lastName)
        {
            // Arrange
            PersonModel p = new() { FirstName = firstName, LastName = lastName };

            // Act
            Assert.Throws<ArgumentException>(() => p.GetLoginName());
        }

        [Theory]
        [InlineData("Tim", "Corey", "TC")]
        [InlineData("Jane", "Smith", "JS")]
        [InlineData("Sue", "Storm", "SS")]
        public void GetInitialsShouldReturnValidNames(string firstName,
                                                      string lastName,
                                                      string expected)
        {
            // Arrange
            PersonModel p = new() { FirstName = firstName, LastName = lastName };

            // Act
            string actual = p.GetInitials();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Tim", "")]
        [InlineData("", "Smith")]
        [InlineData("", "")]
        [InlineData("Tim", "   ")]
        [InlineData("   ", "Smith")]
        [InlineData("   ", "   ")]
        [InlineData("Tim", null)]
        [InlineData(null, "Smith")]
        [InlineData(null, null)]
        public void GetInitialsShouldThrowExceptions(string firstName,
                                                      string lastName)
        {
            // Arrange
            PersonModel p = new() { FirstName = firstName, LastName = lastName };

            // Act
            Assert.Throws<ArgumentException>(() => p.GetInitials());
        }
    }
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
}