using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GuestBookLibrary.Models;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GuestModel> guests = new List<GuestModel>();

            WelcomeMessage();
            GetGuestInformation(guests);
            PrintGuestInformation(guests);
        
            Console.ReadLine();
        }

       private static void WelcomeMessage()
        {
            // Welcome The user
            Console.WriteLine("Welcome to The Guest Book");
            Console.WriteLine("**************************");
            Console.WriteLine();
        }

        private static void GetGuestInformation(List<GuestModel> guests)
        {
            int guestTotal = 0;
            string areMoreGuestComing = string.Empty;

            do
            {
                GuestModel guest = new GuestModel();

                // ask for name
                // store the name
                guest.Name = GetInfoFromConsole("What is your name: ");

                // ask user for number in party
                
                // convert string to number
                string peopleInPartyText = GetInfoFromConsole("How many people are in the party: ");
                bool isValidInt = int.TryParse(peopleInPartyText, out guestTotal);
                while (isValidInt == false)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number");
                    Console.Write("How many people are in the party: ");
                    peopleInPartyText = GetInfoFromConsole("How many people are in the party: ");
                    isValidInt = int.TryParse(peopleInPartyText, out guestTotal);

                }
                // Add the number to the total
                guest.NumberInParty = guestTotal;
                guests.Add(guest);

                // Check to see if more guest are coming
                // loop back to the top until no more guest
                areMoreGuestComing = GetInfoFromConsole("Are more guest coming(yes/no): ");


                Console.Clear();
            }
            while (areMoreGuestComing.ToLower() == "yes");
        }

        private static void PrintGuestInformation(List<GuestModel> guests)
        {
            // print the total guest count
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }

        }

        private static string GetInfoFromConsole(string message)
        {
            string output = string.Empty;
            Console.Write(message);
            output = Console.ReadLine();

            return output;

        }
    }
}
