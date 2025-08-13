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
            double x = RequestData.GetADouble("Enter a the first number: ");
            double y = RequestData.GetADouble("Enter the second number: ");

            double sum = CalculateData.Add(x, y);
            UserMessages.PrintResultMessage($"The sum of {x} and {y} is {sum}");

            double difference = CalculateData.Subtract(x, y);
            UserMessages.PrintResultMessage($"The difference of {x} and {y} is {difference}");


            double product = CalculateData.Multiply(x, y);
            UserMessages.PrintResultMessage($"The product of {x} and {y} is {product}");

            double quotient = CalculateData.Divide(x, y);
            UserMessages.PrintResultMessage($"The quotient of {x} and {y} is {quotient}");

        }
    }

}
