using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangle rectangleArea = new Rectangle();
            Console.WriteLine(rectangleArea.CalculateAera(5, 5)); 

            Circle circle = new Circle();
            Console.WriteLine(circle.CalculateAera(3));

            Triangle triangle = new Triangle();
            Console.WriteLine(triangle.CalculateAera(4,3));
        }
    }

    public class Shape
    {
       public double CalculateAera(double l, double w)
        {
            return l* w;
        }


    }

    public class Rectangle : Shape
    {
     
    }

    public class Circle : Shape
    {
        public double CalculateAera(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }

    public class Triangle : Shape
    {
        public double CalculateAera(double b, double h)
        {
            return  0.5 * b * h;
        }
    }
}
