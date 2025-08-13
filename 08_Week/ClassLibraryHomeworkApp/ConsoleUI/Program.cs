using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLibrary.Models;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           
            PersonModel person = new PersonModel();
            string firstName = person.FirstName = "Marc";
            string lastName = person.LastName = "Moxey";
            Console.WriteLine($"{firstName} {lastName}");
            Console.ReadLine(); 
        }
    }
}
