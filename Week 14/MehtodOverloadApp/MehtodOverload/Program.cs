<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MehtodOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel("Marc","Moxey");
            person.GenerateEmail();
            Console.WriteLine(person.Email);
            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public PersonModel()
        {
            
        }

        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public PersonModel(string firstName, string lastName, string email)
        {

            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public void GenerateEmail()
        {

            GenerateEmail(false, "aol.com");
        }

        public void GenerateEmail(string domain)
        {
            GenerateEmail(false,domain);
        }

        public void GenerateEmail(bool FirstInitialMethod)
        {
            GenerateEmail(FirstInitialMethod, "aol.com");
        }

        public void GenerateEmail( bool FirstInitialMethod, string domain)
        {
            if( FirstInitialMethod== true)
            {
                Email = $"{LastName}{FirstName.Substring(0,1)}@{domain}";
            }
            else
            {
               Email = $"{LastName}.{FirstName}@{domain}";
            }
             
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MehtodOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel("Marc","Moxey");
            person.GenerateEmail();
            Console.WriteLine(person.Email);
            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }

        public PersonModel()
        {
            
        }

        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public PersonModel(string firstName, string lastName, string email)
        {

            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public void GenerateEmail()
        {

            GenerateEmail(false, "aol.com");
        }

        public void GenerateEmail(string domain)
        {
            GenerateEmail(false,domain);
        }

        public void GenerateEmail(bool FirstInitialMethod)
        {
            GenerateEmail(FirstInitialMethod, "aol.com");
        }

        public void GenerateEmail( bool FirstInitialMethod, string domain)
        {
            if( FirstInitialMethod== true)
            {
                Email = $"{LastName}{FirstName.Substring(0,1)}@{domain}";
            }
            else
            {
               Email = $"{LastName}.{FirstName}@{domain}";
            }
             
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
