<<<<<<< HEAD
﻿using System;

namespace ExtensionMethods
{
    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {

            string output = string.Empty;

            while (string.IsNullOrEmpty(output))
            {
                
                Console.Write(message);
                output = Console.ReadLine();
            }

            return output;  
        }

        public static int RequestInt(this string message, int minValue, int maxValue)
        {
            return message.RequestInt(true, minValue, maxValue);
        }

        public static int RequestInt(this string message)
        {
           return message.RequestInt(false);
        }

        private static int RequestInt(this string message, bool useMinMax, int minValue = 0, int maxValue = 0)
        {
            int output = 0;
            bool isValid = false;
            bool isInValidRange = true;

            while (isValid == false || isInValidRange == false)
            {
                Console.Write(message);
                isValid = int.TryParse(Console.ReadLine(), out output);

                if (useMinMax == true)
                {
                    if (output >= minValue && output <= maxValue)
                    {
                        isInValidRange = true;
                    }
                    else
                    {
                        isInValidRange = false;

                    }
                }
            }
            return output;
        }
    }
}
=======
﻿using System;

namespace ExtensionMethods
{
    public static class ConsoleHelper
    {
        public static string RequestString(this string message)
        {

            string output = string.Empty;

            while (string.IsNullOrEmpty(output))
            {
                
                Console.Write(message);
                output = Console.ReadLine();
            }

            return output;  
        }

        public static int RequestInt(this string message, int minValue, int maxValue)
        {
            return message.RequestInt(true, minValue, maxValue);
        }

        public static int RequestInt(this string message)
        {
           return message.RequestInt(false);
        }

        private static int RequestInt(this string message, bool useMinMax, int minValue = 0, int maxValue = 0)
        {
            int output = 0;
            bool isValid = false;
            bool isInValidRange = true;

            while (isValid == false || isInValidRange == false)
            {
                Console.Write(message);
                isValid = int.TryParse(Console.ReadLine(), out output);

                if (useMinMax == true)
                {
                    if (output >= minValue && output <= maxValue)
                    {
                        isInValidRange = true;
                    }
                    else
                    {
                        isInValidRange = false;

                    }
                }
            }
            return output;
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
