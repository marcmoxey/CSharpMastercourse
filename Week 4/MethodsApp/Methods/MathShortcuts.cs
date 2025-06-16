using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public static class MathShortcuts
    {
        public static double Add(double x, double y)
        {
            //Console.WriteLine($"The value if {x} + {y} = {x + y}");
            double output = x + y;
            return output;
        }

        public static double AddAll(double[] values)
        {
            double results = 0;

            foreach(double value in values)
            {
                results += value;
            }

            return results;
        }
    }
}
