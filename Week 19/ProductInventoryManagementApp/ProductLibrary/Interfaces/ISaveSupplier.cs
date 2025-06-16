using ProductLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary.Interfaces
{
    public interface ISaveSupplier
    {
        void SaveSupplier(SupplierModel supplier);
    }
}
