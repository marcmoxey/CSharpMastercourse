using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel();
            Console.WriteLine(person.SetDefaultAge().PrintInfo());
           
            Console.ReadLine();
        }
    }
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }    
    }
    public static class Extensions
    {
        public static PersonModel SetDefaultAge(this PersonModel person)
        {   
            person.Age = 18;
            return person;
        }

        public static string PrintInfo(this PersonModel person)
        {
            person.FirstName = "John";
            person.LastName = "Doe";
            return $" {person.FirstName} {person.LastName} is {person.Age} years old";
        }
    }
        

}
