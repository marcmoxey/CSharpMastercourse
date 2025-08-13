using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressModel address = new AddressModel();
            address.StreetAddress = "923 Custer St";
            address.City = "Valley Stream";
            address.State = "NY";
            address.ZipCode = "11580";

            Console.WriteLine(address.FullAddress);
            Console.ReadLine();
        }
    }
}
