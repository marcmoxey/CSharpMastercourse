using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLibrary.Models
{
    public class VehicleModel : IShiftWorker
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public string EndOfShift()
        {
            return $"{Year} {Make} {Model} is entering diagnostic mode.";
        }
    }
}
