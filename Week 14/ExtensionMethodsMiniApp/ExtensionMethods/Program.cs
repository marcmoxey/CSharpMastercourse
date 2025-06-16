<<<<<<< HEAD
﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();
            
            
            person.FirstName = "What is your first name: ".RequestString();
            
            person.LastName = "What is your last name: ".RequestString();

            person.Age = "How old are you: ".RequestInt(0,120);

            Console.ReadLine();
        }
    }
}
=======
﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();
            
            
            person.FirstName = "What is your first name: ".RequestString();
            
            person.LastName = "What is your last name: ".RequestString();

            person.Age = "How old are you: ".RequestInt(0,120);

            Console.ReadLine();
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
