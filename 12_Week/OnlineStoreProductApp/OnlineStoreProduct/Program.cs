using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Electronics monitor = new Electronics();
            Console.WriteLine(monitor.DiscountPrice(1597)); 

            Clothing hoodies = new Clothing();
            Console.WriteLine(hoodies.DiscountPrice(75));
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public void DiscountPrice()
        {

        }
    }

    public class Electronics : Product
    {
        public decimal DiscountPrice(decimal Price)
        {
            decimal discount = Price * 0.65M;
            decimal output = Price - discount;
            return output;
        }
    }

    public class Clothing  : Product
    {
        public decimal DiscountPrice(decimal Price)
        {
            decimal discount = Price * 0.10M;
            decimal output = Price - discount;
            return output;
        }
    }

    public class Grocery : Product
    {
        public decimal DiscountPrice(decimal Price)
        {
            decimal discount = Price * 0.10M;
            decimal output = Price - discount;
            return output;
        }
    }
}
