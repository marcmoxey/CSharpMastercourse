<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person1 = new PersonModel("Marc", "Moxey", 23);
            PersonModel person2 = new PersonModel("Malani", "Newton", 9);


            person1.IsLegal += Person1_IsLegal;
            person1.CheckAge(23).PrintToConsole();

            person2.CheckAge(9).PrintToConsole();   
            Console.ReadLine();
        }

        private static void Person1_IsLegal(object sender, EventArgs e)
        {
           PersonModel model = (PersonModel)sender;

            Console.WriteLine($"{model.FirstName}: is Legal");
        }
    }

    public static class ConsoleHelper
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }
    }

    public class PersonModel
    {
        public event EventHandler<EventArgs> IsLegal;

        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public int Age { get; set; }

        public PersonModel(string firstName, string lastName, int age)
        {
           FirstName = firstName;
            LastName = lastName;
            Age = age;
      
        }

        public string CheckAge(int age)
        {
            string output = string.Empty;
            if(Age >= 18)
            {
                output = $"{FirstName} {LastName} is {Age} years old and is at legal age";
            }
            else
            {
                 output = $"{FirstName} {LastName} is {Age} years old and not at legal age ";
            }

            return output;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person1 = new PersonModel("Marc", "Moxey", 23);
            PersonModel person2 = new PersonModel("Malani", "Newton", 9);


            person1.IsLegal += Person1_IsLegal;
            person1.CheckAge(23).PrintToConsole();

            person2.CheckAge(9).PrintToConsole();   
            Console.ReadLine();
        }

        private static void Person1_IsLegal(object sender, EventArgs e)
        {
           PersonModel model = (PersonModel)sender;

            Console.WriteLine($"{model.FirstName}: is Legal");
        }
    }

    public static class ConsoleHelper
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }
    }

    public class PersonModel
    {
        public event EventHandler<EventArgs> IsLegal;

        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public int Age { get; set; }

        public PersonModel(string firstName, string lastName, int age)
        {
           FirstName = firstName;
            LastName = lastName;
            Age = age;
      
        }

        public string CheckAge(int age)
        {
            string output = string.Empty;
            if(Age >= 18)
            {
                output = $"{FirstName} {LastName} is {Age} years old and is at legal age";
            }
            else
            {
                 output = $"{FirstName} {LastName} is {Age} years old and not at legal age ";
            }

            return output;
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
