using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            try
            {
                DifferentMethod();

                //Console.Write("What is your name: ");
                //name = Console.ReadLine();
                //ComplexMethod(name);
                //SimpleMethod();
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("You should not be calling this method");
                Console.WriteLine(ex.Message);
            } catch(NotImplementedException)
            {
                Console.WriteLine("You forgot to finish your code!!!");
            }
            catch (Exception ex) when (name.ToLower() == "marc")
            {
                Console.WriteLine("You used Marc's name, didn't you?");
               // Console.WriteLine(ex.Message);
            }
            catch (Exception ex)// general type exception
            {

                Console.WriteLine(ex);
              
            }
            finally
            {
                // clean up code
                // run this code anyway
                Console.WriteLine("I always run");
            }
            Console.ReadLine();
        }

        private static void ComplexMethod(string name)
        {
            if(name.ToLower() == "marc")
            {
                throw new InsufficientMemoryException("Marc too tall for this method");
            } else
            {
                throw new ArgumentException("This person isn't marc");
            }
        }

        private static void SimpleMethod() 
        {
            throw new InvalidOperationException("You should not be calling the SimpleMethod"); // specify type of exception
        }

        private static void DifferentMethod()
        {
            Console.WriteLine("This is the different method working properly");
     
        }
    }
}
