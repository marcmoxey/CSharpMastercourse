﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class CalculateData
    {
        public static int myAge; // Don't store data in a class, lives for entire life of the application
        public static double Add(double x, double y)
        {
           double output = x + y;
            return output;
        }
    }
}
