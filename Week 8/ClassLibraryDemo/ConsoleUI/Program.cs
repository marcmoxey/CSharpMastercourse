using DemoLibrary;
using DemoLibrary.Models;
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
            // Add reference - bring in code
            PersonModel person = new PersonModel();
            double results = Calculation.Add(4, 6);
            Console.WriteLine(results);
            Console.ReadLine();
        }
    }
}
