using ProductLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary.Models
{
    public  class ProductModel
    {
        public string ProductName { get; set; }
        public Categories? Categories { get; set; }
        public decimal Price { get; set; }  
        public List<SupplierModel> Suppliers { get; set; } = new List<SupplierModel>();
    }
}
