using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    // public - anybody can use it 
    // internal - anybody in this project can use it 
    // private - anybody in this scope can use it
    // static - call it directly 
    public static class ConsoleMessage
    {
        public static void SayHi(string name)
        {
            Console.WriteLine($"Hello {name}");
            Console.WriteLine("I hope you are having a good day.");
        }

        public static string GetUserName()
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();

            return name;
        }
        public static void SayGoodbye()
        {
            Console.WriteLine("Goodbye, my user.");
            Console.WriteLine("thank you for visiting.");
            Console.WriteLine("I cannot wait to see you again");
        }
    }
}
