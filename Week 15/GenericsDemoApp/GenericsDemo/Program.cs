<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<string> stringList = new List<string>();
            //List<int> intList = new List<int>();

            //intList.Add(1);

            //string result = FizzBuzz("tests");
            //Console.WriteLine($"Test: {result}");

            //result = FizzBuzz("123");
            //Console.WriteLine($"123: {result}");

            //result = FizzBuzz(true);
            //Console.WriteLine($"true: {result}");

            //result = FizzBuzz(new PersonModel { FirstName = "Marc", LastName = "Moxey"});
            //Console.WriteLine($"PersonModel: {result}");

            // have to give it a type
            GenericHelper<PersonModel> peoplerHelper = new GenericHelper<PersonModel>();
            peoplerHelper.CheckItemAndAdd(new PersonModel { FirstName = "Marc", HasError = true });

            foreach (var item in peoplerHelper.RejectedItems) 
            {
                Console.WriteLine($" { item.FirstName } { item.LastName } was rejected");
            }
            Console.ReadLine(); 
        }

        // T - type, just one type(dont know the type)
        private static string FizzBuzz<T>(T item) 
        {
            var itemLength = item.ToString().Length;
            string output = string.Empty;

            if(itemLength % 3 == 0)
            {
                output += "Fizz";

            }
            else if (itemLength % 5 == 0)
            {
                output += "Buzz";
            }

             return output; 
        }
    }

    public class PersonModel : IErrorCheck
    {
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public bool HasError {  get; set; }
    }

    // where t: things 'T' can be
    public class GenericHelper<T> where T: IErrorCheck
    {
        public List<T> Items { get; set; } = new List<T>();
        public List<T> RejectedItems { get; set; } = new List<T>();

        public void CheckItemAndAdd(T item)
        {

            if(item.HasError == false)
            {
                Items.Add(item);
            }
            else
            {
                RejectedItems.Add(item);
            }
        }
    }
    public class CarModel : IErrorCheck
    {
        public string Manufacturer { get; set; }
        public int YearManufactured { get; set; }

        public bool HasError { get; set; }
    }
    public interface IErrorCheck
    {
        bool HasError { get; set; }  

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<string> stringList = new List<string>();
            //List<int> intList = new List<int>();

            //intList.Add(1);

            //string result = FizzBuzz("tests");
            //Console.WriteLine($"Test: {result}");

            //result = FizzBuzz("123");
            //Console.WriteLine($"123: {result}");

            //result = FizzBuzz(true);
            //Console.WriteLine($"true: {result}");

            //result = FizzBuzz(new PersonModel { FirstName = "Marc", LastName = "Moxey"});
            //Console.WriteLine($"PersonModel: {result}");

            // have to give it a type
            GenericHelper<PersonModel> peoplerHelper = new GenericHelper<PersonModel>();
            peoplerHelper.CheckItemAndAdd(new PersonModel { FirstName = "Marc", HasError = true });

            foreach (var item in peoplerHelper.RejectedItems) 
            {
                Console.WriteLine($" { item.FirstName } { item.LastName } was rejected");
            }
            Console.ReadLine(); 
        }

        // T - type, just one type(dont know the type)
        private static string FizzBuzz<T>(T item) 
        {
            var itemLength = item.ToString().Length;
            string output = string.Empty;

            if(itemLength % 3 == 0)
            {
                output += "Fizz";

            }
            else if (itemLength % 5 == 0)
            {
                output += "Buzz";
            }

             return output; 
        }
    }

    public class PersonModel : IErrorCheck
    {
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public bool HasError {  get; set; }
    }

    // where t: things 'T' can be
    public class GenericHelper<T> where T: IErrorCheck
    {
        public List<T> Items { get; set; } = new List<T>();
        public List<T> RejectedItems { get; set; } = new List<T>();

        public void CheckItemAndAdd(T item)
        {

            if(item.HasError == false)
            {
                Items.Add(item);
            }
            else
            {
                RejectedItems.Add(item);
            }
        }
    }
    public class CarModel : IErrorCheck
    {
        public string Manufacturer { get; set; }
        public int YearManufactured { get; set; }

        public bool HasError { get; set; }
    }
    public interface IErrorCheck
    {
        bool HasError { get; set; }  

    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
