using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Models
{
   public class VehicleModel
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

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
