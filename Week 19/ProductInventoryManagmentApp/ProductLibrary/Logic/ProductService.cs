using ProductLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductLibrary.Enums;

namespace ProductLibrary.Logic
{
    public class ProductService
    {
        public bool ValidateProduct(ProductModel product)
        {
            return !string.IsNullOrWhiteSpace(product.ProductName) && !string.IsNullOrWhiteSpace(product.Categories.ToString()) && product.Price > 0 && product.Suppliers.Count > 0;
        }

        public bool ValidateSupplier(SupplierModel supplier)
        {
            return !string.IsNullOrWhiteSpace(supplier.SupplierName) && !string.IsNullOrWhiteSpace(supplier.ContactNumber);
        }
    }
}
