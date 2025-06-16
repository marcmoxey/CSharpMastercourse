<<<<<<< HEAD
﻿using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractClassHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {


            IDrive car = new Car();

            car.Start();
            car.Accelerate(60);
            car.Brake(30);  
            car.Turn("left");


            Console.ReadLine();
        }
    }

    public abstract class Vehicle : IDrive
    {
        public string VIN { get; set; } 
        public string Manufactured { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }

        public abstract void Accelerate(int speed);

        public abstract void Brake(int speed);

        public abstract void Start();

        public abstract void Stop();
     

        public abstract void Turn(string direction);
  
    }

    public class Car : Vehicle
    {
        public override void Accelerate(int speed)
        {
            Console.WriteLine($"Going {speed} mph");
        }

        public override void Brake(int speed)
        {
            Console.WriteLine($"Breaking from {speed}");
        }

        public override void Start()
        {
            Console.WriteLine("starting car");
        }

        public override void Stop()
        {
            Console.WriteLine($"Shut off car");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"I'm turning {direction}");
        }
    }
}
=======
﻿using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractClassHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {


            IDrive car = new Car();

            car.Start();
            car.Accelerate(60);
            car.Brake(30);  
            car.Turn("left");


            Console.ReadLine();
        }
    }

    public abstract class Vehicle : IDrive
    {
        public string VIN { get; set; } 
        public string Manufactured { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }

        public abstract void Accelerate(int speed);

        public abstract void Brake(int speed);

        public abstract void Start();

        public abstract void Stop();
     

        public abstract void Turn(string direction);
  
    }

    public class Car : Vehicle
    {
        public override void Accelerate(int speed)
        {
            Console.WriteLine($"Going {speed} mph");
        }

        public override void Brake(int speed)
        {
            Console.WriteLine($"Breaking from {speed}");
        }

        public override void Start()
        {
            Console.WriteLine("starting car");
        }

        public override void Stop()
        {
            Console.WriteLine($"Shut off car");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"I'm turning {direction}");
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
