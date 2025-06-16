using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PersonModel
    {
        public string FirstName { private get; set; } // private get - anyone can set it, but can't read it in UI; only can be read in this class

        public string LastName { get; private set; } // private set - anyone can read it, only in this class can you set it
        private string _password;

        public string Password
        {
           
            set { _password = value; }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }





        private int _age; // private field - should not manipulated it directly 

        public int Age
        { 
            get 
            {
                // When ask for age , return the age
                return _age; 
            }
            set 
            { 
                // age will only set if have a valid age range 
                if(value >= 0 && value <= 126)
                {
                    _age = value;
                } 
                else
                {
                    throw new ArgumentOutOfRangeException("value","Age needs to be between 0 and 126");
                }
           
             
            }
        }

        private string _ssn;

        public string SSN
        {
            get
            {
                // 123-45-6789 - 11 - 5 = 6
                string output = "***-**-" + _ssn.Substring(_ssn.Length - 4);
                return output;
            }
            set { _ssn = value; }
        }

        public PersonModel()
        {
            // overloading

        }
        public PersonModel(string lastName)
        {
            LastName = lastName;
        }

    }
}
