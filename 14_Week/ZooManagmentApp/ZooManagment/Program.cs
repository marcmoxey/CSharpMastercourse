<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            List<Animal> zooAnimals = new List<Animal>
            {
                 new Lion("Alex"),
                new Monkey("George")
            };


            foreach(var animal in zooAnimals)
            {
                animal.MakeSound();
                animal.Feed();
            }
            Console.ReadLine();
        }
    }

    public abstract class Animal
    {
        protected string Name { get; set; }
        protected int HungerLevel { get; set; }

        public Animal(string name)
        {
            Name = Name;
            HungerLevel = 5;
        }
        public virtual void Feed()
        {
            HungerLevel--;
            Console.WriteLine($"{Name} has been fed. Hunger Level: {HungerLevel}");
        }

       public abstract void MakeSound();
 
    }

    public class Lion : Animal
    {
     
        public Lion(string name) : base(name)
        {
            Name = name;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} roars!");
        }

        public override void Feed()
        {
            HungerLevel -= 2;
            Console.WriteLine($"{Name} devoured the meat. Hunger Level: {HungerLevel}");
        }
    }

    public class Monkey : Animal
    {
        public Monkey(string name) : base(name)
        {
            Name = name;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} screeches!");
        }

   
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagment
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            List<Animal> zooAnimals = new List<Animal>
            {
                 new Lion("Alex"),
                new Monkey("George")
            };


            foreach(var animal in zooAnimals)
            {
                animal.MakeSound();
                animal.Feed();
            }
            Console.ReadLine();
        }
    }

    public abstract class Animal
    {
        protected string Name { get; set; }
        protected int HungerLevel { get; set; }

        public Animal(string name)
        {
            Name = Name;
            HungerLevel = 5;
        }
        public virtual void Feed()
        {
            HungerLevel--;
            Console.WriteLine($"{Name} has been fed. Hunger Level: {HungerLevel}");
        }

       public abstract void MakeSound();
 
    }

    public class Lion : Animal
    {
     
        public Lion(string name) : base(name)
        {
            Name = name;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} roars!");
        }

        public override void Feed()
        {
            HungerLevel -= 2;
            Console.WriteLine($"{Name} devoured the meat. Hunger Level: {HungerLevel}");
        }
    }

    public class Monkey : Animal
    {
        public Monkey(string name) : base(name)
        {
            Name = name;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} screeches!");
        }

   
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
