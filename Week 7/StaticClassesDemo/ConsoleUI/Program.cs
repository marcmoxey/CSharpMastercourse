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
           

            string firstName = UserMessages.GetAString("What is your first name: ");

            UserMessages.ApplicationStart(firstName);

            double x = RequestData.GetADouble("Please Enter your first  number: ");
            double y = RequestData.GetADouble("Please Enter your second number: ");

            double result = CalculateData.Add(x, y);

            UserMessages.PrintResultMessage($"The result of adding {x} and {y} is {result}");

            Console.ReadLine();
        }

       
    }
}
