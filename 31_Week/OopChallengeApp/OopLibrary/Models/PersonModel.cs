using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLibrary.Models
{
    public class PersonModel : IShiftWorker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string EndOfShift()
        {
            return $"{FirstName} {LastName} is going home.";
        }
    }
}
