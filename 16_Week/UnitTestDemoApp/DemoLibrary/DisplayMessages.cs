<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Red, Green, Refactor
    // Red - write a failing test
    // Green - write code that test pass
    // Refactor - make the code better
namespace DemoLibrary
{
    public class DisplayMessages
    {

        public string Greeting(string firstName, int hourOfTheDay)
        {
            string output = string.Empty;
            if(hourOfTheDay < 5)
            {
                output = $"Go to bed {firstName}";
            }
            else if (hourOfTheDay < 12)
            {
                output = $"Good morning {firstName}";
            }
            else if (hourOfTheDay < 18)
            {
                output = $"Good afternoon {firstName}";
            }
            else
            {
                output = $"Good evening {firstName}";
            }

            //switch(hourOfTheDay)
            //{
            //    case < 12:
            //        output = $"Good morning {firstName}";
            //        break;
            //    case < 18:
            //        output = $"Good afternoon {firstName}";
            //        break;
            //    default:
            //        output = $"Good evening {firstName}";
            //        break;
            //}

            return output;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Red, Green, Refactor
    // Red - write a failing test
    // Green - write code that test pass
    // Refactor - make the code better
namespace DemoLibrary
{
    public class DisplayMessages
    {

        public string Greeting(string firstName, int hourOfTheDay)
        {
            string output = string.Empty;
            if(hourOfTheDay < 5)
            {
                output = $"Go to bed {firstName}";
            }
            else if (hourOfTheDay < 12)
            {
                output = $"Good morning {firstName}";
            }
            else if (hourOfTheDay < 18)
            {
                output = $"Good afternoon {firstName}";
            }
            else
            {
                output = $"Good evening {firstName}";
            }

            //switch(hourOfTheDay)
            //{
            //    case < 12:
            //        output = $"Good morning {firstName}";
            //        break;
            //    case < 18:
            //        output = $"Good afternoon {firstName}";
            //        break;
            //    default:
            //        output = $"Good evening {firstName}";
            //        break;
            //}

            return output;
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
