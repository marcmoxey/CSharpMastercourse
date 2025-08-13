<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{

   public class DataAccess
    {
        // internal - anything in the assembly 
        // protect internal - combined the two
        protected internal string GetConnectionString()
        {
            return "Sensitive Data";
        }
    }
    public class Person
    {
        private protected string formerLastName = String.Empty;
        public string FirstName { get; set; }
        public string LastName { get; private set; }

        private string _ssn;

        public string SSN
        {
            get
            {
                return $"***-**-{_ssn.Substring(_ssn.Length - 4)}"; 
            }
            set
            {
                _ssn = value ;
            }
        }

        public void ChangeLastName(string newLastName)
        {
            formerLastName = LastName;
            LastName = newLastName;
        }
        public void SayHello()
        {
            Console.WriteLine($"Hello { FirstName}");
        }

        public void SavePerson()
        {
            DataAccess data = new DataAccess(); 
            string conn = data.GetConnectionString();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{

   public class DataAccess
    {
        // internal - anything in the assembly 
        // protect internal - combind the two
        protected internal string GetConnectionString()
        {
            return "Sensitive Data";
        }
    }
    public class Person
    {
        private protected string formerLastName = String.Empty;
        public string FirstName { get; set; }
        public string LastName { get; private set; }

        private string _ssn;

        public string SSN
        {
            get
            {
                return $"***-**-{_ssn.Substring(_ssn.Length - 4)}"; 
            }
            set
            {
                _ssn = value ;
            }
        }

        public void ChangeLastName(string newLastName)
        {
            formerLastName = LastName;
            LastName = newLastName;
        }
        public void SayHello()
        {
            Console.WriteLine($"Hello { FirstName}");
        }

        public void SavePerson()
        {
            DataAccess data = new DataAccess(); 
            string conn = data.GetConnectionString();
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
