using HomeworrkLibrary;

namespace ClassLibraryHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MathShortcuts math = new MathShortcuts();
            Console.WriteLine(math.Add(9,10));
            Console.WriteLine(math.Subtract(7,3));
            Console.WriteLine(math.Multiply(9,11));
            Console.WriteLine(math.Divide(100,25));

            Console.ReadLine(); 
        }
    }
}
