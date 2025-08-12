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

           int sum = ConsoleMath.MathShortcut.Add(1, 2);
           ConsoleMessages.UserMessages.PrintResults($"The sum of 1 + 2 is {sum}");
        }
    }
}
