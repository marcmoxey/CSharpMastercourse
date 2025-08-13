<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class MathShortcuts
    {

        public double Add(double x, double y)
        {
            double output = 0;
            output = x + y;
            return output;
        }
        
        public double Subtract(double x, double y)
        {
            double output = 0;
            output = x - y;
            return output;
        }

        public double Multiply(double x, double y)
        {
            double output = 0;
            output = x * y;
            return output;
        }

        public double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            double output = 0;
            output = x / y;
            return output;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class MathShortcuts
    {

        public double Add(double x, double y)
        {
            double output = 0;
            output = x + y;
            return output;
        }
        
        public double Subtract(double x, double y)
        {
            double output = 0;
            output = x - y;
            return output;
        }

        public double Multiply(double x, double y)
        {
            double output = 0;
            output = x * y;
            return output;
        }

        public double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            double output = 0;
            output = x / y;
            return output;
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
