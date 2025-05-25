using ProductLibrary.Enums;
using ProductLibrary.Logic;
using ProductLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace ProductLibrary.Test
{
    public  class ProductServiceTest
    {
     
        private readonly ProductService _service;

        
        public ProductServiceTest()
        {
            _service = new ProductService();
        }

        [Fact]
        public void ValidateProduct_WithValidData_ReturnsTrue()
        {
            // Arrange 
            var product = new ProductModel
            {
                ProductName = "AMD Ryzen 5 5700G",
                Categories = Categories.Electronics,
                Price = 135.98m,
                Suppliers = new List<SupplierModel>
                {
                     new SupplierModel { SupplierName = "Supplier A", ContactNumber = "1234567890" },
                    new SupplierModel { SupplierName = "Supplier B", ContactNumber = "0987654321" }
                }
            };

           

            bool expected = true;

            // Act 
            var actual = _service.ValidateProduct(product);

            // Assert
            Assert.Equal(actual, expected);


        }

        [Fact]
        public void ValidateProduct_WithEmptyProductName_ReturnsFalse()
        {
            // Arrange 
            var product = new ProductModel
            {
                ProductName = "",
                Categories = Categories.Electronics,
                Price = 452.58m,
                Suppliers = new List<SupplierModel>
                {
                    new SupplierModel { SupplierName = "Supplier A", ContactNumber = "1234567890" },
                    new SupplierModel { SupplierName = "Supplier B", ContactNumber = "0987654321" }
                }
            };

            bool expected = false;

            // Act 
            var actual = _service.ValidateProduct(product);

            // Assert
            Assert.Equal(actual, expected);
        }


        [Fact]
        public void ValidateProduct_WithEmptyCategory_ReturnsFalse()
        {
            // Arrange 
            var product = new ProductModel
            {
                ProductName = "AMD Rx 9070 XT",
                Categories = null,
                Price = 952.59m,
                Suppliers = new List<SupplierModel>
                {
                    new SupplierModel { SupplierName = "Supplier A", ContactNumber = "1234567890" },
                    new SupplierModel { SupplierName = "Supplier B", ContactNumber = "0987654321" }
                }
            };

            bool expected = false;

            // Act 
            var actual = _service.ValidateProduct(product);

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void ValidateProduct_WithNegativePrice_ReturnsFalse()
        {
            var product = new ProductModel
            {
                ProductName = "AMD Rx 9070",
                Categories = Categories.Electronics,
                Price = -782.59m,
                Suppliers = new List<SupplierModel>
                {
                    new SupplierModel { SupplierName = "Supplier A", ContactNumber = "1234567890" },
                    new SupplierModel { SupplierName = "Supplier B", ContactNumber = "0987654321" }
                }
            };
        }


        [Fact]
        public void ValidateProduct_WithZeroPrice_ReturnsFalse()
        {
            // Arrange 
            var product = new ProductModel
            {
                ProductName = "Pulser x3 wireless mouse",
                Categories = Categories.Electronics,
                Price = 0,

                Suppliers = new List<SupplierModel>
                {
                    new SupplierModel { SupplierName = "Supplier A", ContactNumber = "1234567890" },
                    new SupplierModel { SupplierName = "Supplier B", ContactNumber = "0987654321" }
                }
            };
        }

        [Fact]
        public void ValidateProduct_WithNoSuppliers_ReturnsFalse()
        {
            // Arrange
            var product = new ProductModel
            {
                ProductName = "Pulser x3 wireless mouse",
                Categories = Categories.Electronics,
                Price = 0,
                Suppliers = new List<SupplierModel>()
            };

            bool expected = false;


            // Act
            var actual = _service.ValidateProduct(product);
            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void ValidateSupplier_WithValidData_ReturnsTrue()
        {
            // Arrange 
            var supplier = new SupplierModel
            {
                SupplierName = "Supplier A",
                ContactNumber = "1234567890"
            };
            bool expected = true;
            // Act 
            var actual = _service.ValidateSupplier(supplier);
            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void ValidateSupplier_WithEmptyName_ReturnFalse()
        {
            // Arrange 
            var suppler = new SupplierModel
            {
                SupplierName = "",
                ContactNumber = "1234567890"
            };

            bool expected = false;

            // Act
            var actual = _service.ValidateSupplier(suppler);

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void ValidateSupplier_WithEmptyContactNumber_ReturnsFalse()
        {
            // Arrange 
            var supplier = new SupplierModel
            {
                SupplierName = "Supplier A",
                ContactNumber = ""
            };
            bool expected = false;
            // Act 
            var actual = _service.ValidateSupplier(supplier);
            // Assert
            Assert.Equal(actual, expected);
        }


    }
}
