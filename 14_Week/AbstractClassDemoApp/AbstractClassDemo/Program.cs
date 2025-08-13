<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.VIN = "1234567890";
          
            Console.ReadLine(); 
        }
    }

    // base class - not fully complete
    // can inherit but can't instantiate
    public abstract class InventoryItem
    {
        public string ProductName { get; set; }
        public int QuantityOnHand { get; set; }
    }


    public abstract class Vehicle
    {
        public string VIN { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }
    }


    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; } = 4;
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.VIN = "1234567890";
            Console.ReadLine(); 
        }
    }

    // base class - not fully complete
    // can inherit but can't instantiate
    public abstract class InventoryItem
    {
        public string ProductName { get; set; }
        public int QuantityOnHand { get; set; }
    }


    public abstract class Vehicle
    {
        public string VIN { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }
    }


    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; } = 4;
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
