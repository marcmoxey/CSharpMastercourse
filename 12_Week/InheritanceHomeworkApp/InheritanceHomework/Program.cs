using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHomework
{
    /*
     * 
     *  Create a vehicle class, a car class, boat class, 
     *  and a motorcycle class. Identify what
     *  inheritance should happen if any and wire it up
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Vehicle
    {
        public void Start()
        {

        }

        public void Stop()
        {

        }

        public string EngineType { get; set; }

        public int NumberOfSeats { get; set; }

    }

    public class Car : Vehicle
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }

    }

    public class Boat : Vehicle
    {
            
    }

    public class Motorcycle
    {
        public int NumberOfWheels { get; set; }
    }
}
