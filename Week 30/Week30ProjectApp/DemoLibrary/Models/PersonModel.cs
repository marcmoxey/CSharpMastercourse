using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; }

        public void EndOfShift(List<(PersonModel, VehicleModel)> lst)
        {
            if (lst.GetType() == typeof(PersonModel))
            {
                foreach (var item in lst)
                {
                    Console.WriteLine($"{item.Item1.FirstName}  {item.Item1.LastName}");
                }
            }
            else if (lst.GetType() == typeof(VehicleModel))
            {
                foreach (var item in lst)
                {
                    Console.WriteLine($"{item.Item2.Make} {item.Item2.Model} {item.Item2.Year}");
                }
            }
        }   
    }
}
