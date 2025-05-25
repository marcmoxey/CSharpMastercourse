using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Logic
{
    public interface ISaveAddress
    {
        void SaveAddress(AddressModel address);
    }
}
