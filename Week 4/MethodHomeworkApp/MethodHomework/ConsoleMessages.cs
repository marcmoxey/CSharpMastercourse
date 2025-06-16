using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHomework
{
    public static class ConsoleMessages
    {
        public static void Welcome()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Welcome to the application");
            Console.WriteLine("Created by Marc Moxey");
        }
        public static string GetUserName()
        {
           
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            return name;

        }

        public static void GreetUser(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
