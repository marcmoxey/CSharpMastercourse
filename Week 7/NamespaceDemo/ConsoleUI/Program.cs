using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoundationInfo;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>();
            ConsoleUI.PersonModel person = new PersonModel(); 

            person.FirstName = "Marc";

            Calculation.Add(5, 10);
            Console.ReadLine();
        }
    }
}
