using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

   
          
            List<Phone> phones= new List<Phone>();
            phones.Add(new CellPhone());
            phones.Add(new SmartPhone());  

            foreach(var phone in phones)
            {
                if(phone is CellPhone cell)
                {
                    cell.Carrier = "";
                }

                if(phone is SmartPhone smartPhone)
                {
                    smartPhone.ConnectToInternet();
                }
            }



           // can't inherit from more than on parent

            Console.ReadLine();
        }
    }
}
