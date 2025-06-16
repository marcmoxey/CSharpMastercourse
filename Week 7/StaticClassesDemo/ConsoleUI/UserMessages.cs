using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
     public class UserMessages
     {
        public static string GetAString(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();
            return output;
        }

        public static void ApplicationStart(string name)
        {
            Console.Clear(); // clears out the console window
            Console.WriteLine("Welcome to the Static Class Demo App");

            int hourOfDay = DateTime.Now.Hour;

            if(hourOfDay < 12)
            {
                Console.WriteLine($"Good Morning! {name}");
            }
            else if (hourOfDay < 19)
            {
                Console.WriteLine($"Good Afternoon! {name}");
            }
            else
            {
                Console.WriteLine($"Good Evening! {name}");
            }
        }

      
        public static void PrintResultMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine("Thank you for using our app to calculate for you.");  
        }
    }
}
