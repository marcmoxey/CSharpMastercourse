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
            //// creating an instance of the PersonModel class - building a house from the blueprints
            //List<PersonModel> people = new List<PersonModel>();

            //// Variable hold the street address
            //PersonModel person = new PersonModel();

            //// setting the properties of the person object
            //person.firstName = "Marc";
            //people.Add(person);

            //person = new PersonModel(); // variable new street address
            //person.firstName = "John";
            //people.Add(person);


            //foreach (PersonModel p in people) 
            //{
            //    Console.WriteLine(p.firstName); 
            //}

            List<PersonModel> people = new List<PersonModel>(); 
            string firstName = "";
            string lastName = "";

            do
            {
                Console.Write("What is your first name (or type exit to stop): ");
                firstName = Console.ReadLine();

                Console.Write("What is your last name: ");
                lastName = Console.ReadLine();

                if (firstName.ToLower() != "exit")
                {
                    PersonModel person = new PersonModel();
                    person.FirstName = firstName;
                    person.LastName = lastName;
                    people.Add(person);
                }
            }
            while (firstName.ToLower() != "exit");

            foreach(PersonModel p in people)
            {
                    ProcessPerson.GreetPerson(p);
            }
            Console.ReadLine();
        }
    }
}
