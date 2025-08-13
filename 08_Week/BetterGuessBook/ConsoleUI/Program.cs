using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;


// capture the information about each guest(assumption is at least one guest and unknown maximum)
// info to capture: First name, last name, message to the host 
// Once done, loop through each guest and print their info 



namespace ConsoleUI
{
    class Program
    {
        // hold info about guest
        private static List<GuestModel> guests = new List<GuestModel>();

        static void Main(string[] args)
        {
        
          
            GetGuestInformation();
            PrintGuestInformation();

       
            Console.ReadLine();
        }
        private static void GetGuestInformation()
        {
            string noMoreGuestsComing = string.Empty;

            do
            {
                GuestModel guest = new GuestModel();
   
                guest.FirstName = GetInfoFromConsole("What is your first name: ");

               
                guest.LastName = GetInfoFromConsole("What is your last name: ");

                
                guest.MessageToHost = GetInfoFromConsole("What message would like to tell your host: ");

                
                noMoreGuestsComing = GetInfoFromConsole("Are more guest coming(yes/no): ");

                guests.Add(guest); // add to list 

                Console.Clear();

            }
            while (noMoreGuestsComing.ToLower() == "yes");
        }

        private static void PrintGuestInformation()
        {
            // display all guest 
            foreach (GuestModel guest in guests)
            {

                Console.WriteLine(guest.GuestInfo); // print full info for each guest

            }
        }

        private static string GetInfoFromConsole(string message) 
        {
            string output = "";

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }
    }
}
