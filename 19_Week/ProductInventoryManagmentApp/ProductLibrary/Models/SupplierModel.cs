using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary.Models
{
    public class SupplierModel
    {
        public string SupplierName { get; set; }
        public string ContactNumber { get; set; }  
        
        public string SupplierFullDetails => $"{SupplierName} - Phone Number: {ContactNumber}";
    }
}
