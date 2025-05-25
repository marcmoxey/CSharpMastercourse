using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersDemo
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();   

            
            //DataAccess data = new DataAccess();

            person.SavePerson();
            Console.ReadLine();
        }
    }
}
