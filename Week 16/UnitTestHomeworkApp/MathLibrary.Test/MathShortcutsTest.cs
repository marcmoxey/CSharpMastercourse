<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary.Test
{
    public class MathShortcutsTest
    {
        [Fact]
        public void AddShouldReturnCorrectSum()
        {
            // Arrange
            MathShortcuts math = new MathShortcuts();
            double expected = 9;

            // Act
            double actual = math.Add(4, 5);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void SubtractShouldReturnCorrectDifference()
        {
            // Arrange
            MathShortcuts math = new MathShortcuts();
            double expected = 1;
            // Act
            double actual = math.Subtract(5, 4);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MultiplyShouldReturnCorrectProduct()
        {
            // Arrange
            MathShortcuts math = new MathShortcuts();
            double expected = 20;
            // Act
            double actual = math.Multiply(4, 5);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivideShouldReturnCorrectQuotient()
        {
            // Arrange
            MathShortcuts math = new MathShortcuts();
            double expected = 2;

            // Act
            double actual = math.Divide(10, 5);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivideByZeroShouldThrowException()
        {
            // Arrange
            MathShortcuts math = new MathShortcuts();
            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => math.Divide(10, 0));
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary.Test
{
    public class MathShortcutsTest
    {
        [Fact]
        public void AddShouldReturnCorrectSum()
        {
            // Arrange
            MathShortcuts math = new MathShortcuts();
            double expected = 9;

            // Act
            double actual = math.Add(4, 5);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void SubtractShouldReturnCorrectDifference()
        {
            // Arrange
            MathShortcuts math = new MathShortcuts();
            double expected = 1;
            // Act
            double actual = math.Subtract(5, 4);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MultiplyShouldReturnCorrectProduct()
        {
            // Arrange
            MathShortcuts math = new MathShortcuts();
            double expected = 20;
            // Act
            double actual = math.Multiply(4, 5);
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivideShouldReturnCorrectQuotient()
        {
            // Arrange
            MathShortcuts math = new MathShortcuts();
            double expected = 2;

            // Act
            double actual = math.Divide(10, 5);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DivideByZeroShouldThrowException()
        {
            // Arrange
            MathShortcuts math = new MathShortcuts();
            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => math.Divide(10, 0));
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
