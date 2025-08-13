using System;
using System.CodeDom;
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
            for (int i = 0; i <= 100; i++)
            {
                try
                {
                    if (i == 73)
                    {
                        throw new Exception("i is 73");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"An error has occurred: {ex.Message}");
                }
                Console.WriteLine($"The value of i is {i}");

            }

            Console.ReadLine();
        }
    }
}
