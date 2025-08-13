<<<<<<< HEAD
﻿

using StandardLibrary;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Generators  generators = new Generators();
            PersonModel person = new PersonModel
            {
                Prefix = "Mr",
                FirstName = "Marc",
                LastName = "Moxey",
            };


            string message = generators.WelcomeMessage(person.Prefix, person.LastName);
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
=======
﻿

using StandardLibrary;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Generators  generators = new Generators();
            PersonModel person = new PersonModel
            {
                Prefix = "Mr",
                FirstName = "Marc",
                LastName = "Moxey",
            };


            string message = generators.WelcomeMessage(person.Prefix, person.LastName);
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
