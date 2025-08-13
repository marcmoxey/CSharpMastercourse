using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal someAnimal = new Animal();
            someAnimal.MakeSound(); 


            Dog dog = new Dog();
            dog.MakeSound();

            Cat cat = new Cat();
            cat.MakeSound();

            Lion lion = new Lion();
            lion.MakeSound();   


            Console.ReadLine(); 
        }
    }
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void MakeSound()
        {
            Console.WriteLine("Make a sound");
        }
    }

    public class Dog : Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof");
        }
    }

    public class Cat : Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    public class Lion : Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("Roar");
        }
    
    }

      
}
