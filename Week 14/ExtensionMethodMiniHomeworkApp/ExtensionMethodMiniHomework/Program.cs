<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ExtensionMethodMiniHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MovieModel movie = new MovieModel();

            movie.MovieTitle = "What was the last movie you saw: ".RequestString();

            movie.Rating = "What would you rate that movie: ".RequestDouble(0, 5);

            Console.WriteLine("Done!");
            Console.ReadLine(); 
        }
    }

    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string output = string.Empty;
            
            while(string.IsNullOrEmpty(output))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }
          
            return output;
        }



        public static double RequestDouble(this string message, double minRating, double maxRating)
        {
            return message.RequestDouble(true, minRating, maxRating); 
        }


        public static double RequestDouble(this string message)
        {
            return message.RequestDouble(false);   
        }

        private static double RequestDouble(this string message, bool useMinMaxRating, double minRating = 0, double maxRating = 5)
        {
            double output = 0;
            bool isValidDouble = false;
            bool isInValidRange = true;

            while(isValidDouble == false || useMinMaxRating == false)
            {
                Console.Write(message);
                isValidDouble = double.TryParse(Console.ReadLine(), out output);
            }

            if(isInValidRange)
            {
                if (output >= minRating && output <= maxRating)
                {
                   isInValidRange = true;
                }
                else
                {
                    isInValidRange = false;
                }
            }

            return output;  
        }
           
          
    }

    public class MovieModel
    {
        public string MovieTitle { get; set; }
        public double Rating { get; set; }
    }
    
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ExtensionMethodMiniHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MovieModel movie = new MovieModel();

            movie.MovieTitle = "What was the last movie you saw: ".RequestString();

            movie.Rating = "What would you rate that movie: ".RequestDouble(0, 5);

            Console.WriteLine("Done!");
            Console.ReadLine(); 
        }
    }

    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {
            string output = string.Empty;
            
            while(string.IsNullOrEmpty(output))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }
          
            return output;
        }



        public static double RequestDouble(this string message, double minRating, double maxRating)
        {
            return message.RequestDouble(true, minRating, maxRating); 
        }


        public static double RequestDouble(this string message)
        {
            return message.RequestDouble(false);   
        }

        private static double RequestDouble(this string message, bool useMinMaxRating, double minRating = 0, double maxRating = 5)
        {
            double output = 0;
            bool isValidDouble = false;
            bool isInValidRange = true;

            while(isValidDouble == false || useMinMaxRating == false)
            {
                Console.Write(message);
                isValidDouble = double.TryParse(Console.ReadLine(), out output);
            }

            if(isInValidRange)
            {
                if (output >= minRating && output <= maxRating)
                {
                   isInValidRange = true;
                }
                else
                {
                    isInValidRange = false;
                }
            }

            return output;  
        }
           
          
    }

    public class MovieModel
    {
        public string MovieTitle { get; set; }
        public double Rating { get; set; }
    }
    
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
