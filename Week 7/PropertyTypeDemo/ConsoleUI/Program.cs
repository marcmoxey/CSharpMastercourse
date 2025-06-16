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
            PersonModel person = new PersonModel("Moxey");

            person.FirstName = "Marc";
           // person.LastName = "Moxey";
            person.Age = 23;
            person.SSN = "123-45-6789";

            Console.WriteLine(person.FullName);

            Console.WriteLine(person.SSN);
            Console.ReadLine(); 
        }
    }
}
