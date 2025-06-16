<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = SomeMethod("Hello World");
            Console.WriteLine(result);

            result = SomeMethod(1 + 2);
            Console.WriteLine(result);
            int[] numArr= { 1, 2, 3};
            foreach (int i in numArr) 
            {

                Console.WriteLine(SomeMethod(i)); 
            
            }



            result = SomeMethod(numArr.Length);
            Console.WriteLine(result);






            Console.ReadLine();
        }

        private static string SomeMethod<T>(T item)
        {
            return item.ToString();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = SomeMethod("Hello World");
            Console.WriteLine(result);

            result = SomeMethod(1 + 2);
            Console.WriteLine(result);
            int[] numArr= { 1, 2, 3};
            foreach (int i in numArr) 
            {

                Console.WriteLine(SomeMethod(i)); 
            
            }



            result = SomeMethod(numArr.Length);
            Console.WriteLine(result);






            Console.ReadLine();
        }

        private static string SomeMethod<T>(T item)
        {
            return item.ToString();
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
