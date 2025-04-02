using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookLibrary.Models
{
    public class GuestModel
    {
        public string Name { get; set; }
        public int NumberInParty { get; set; }

    

        public string GuestInfo
        {
            get 
            {
                return $"{Name} has {NumberInParty} in their party coming";
            }
        
        }

    }
}
