using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();
            
            
            person.FirstName = "What is your first name: ".RequestString();
            
            person.LastName = "What is your last name: ".RequestString();

            person.Age = "How old are you: ".RequestInt(0,120);

            Console.ReadLine();
        }
    }
}
