<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollegeClassModel history = new CollegeClassModel("History 101", 3);
            CollegeClassModel math = new CollegeClassModel("Calculus 201", 2);

            history.EnrollmentFull += CollegeClass_EnrollmentFull;

            history.SignUpStudents("Tim Corey").PrintToConsole();
            history.SignUpStudents("Marc Moxey").PrintToConsole();
            history.SignUpStudents("Sue Storm").PrintToConsole();
            history.SignUpStudents("Joe Smith").PrintToConsole();
            history.SignUpStudents("Marry Jones").PrintToConsole();
            history.SignUpStudents("Sandy Patty").PrintToConsole();
            Console.WriteLine();


            math.EnrollmentFull += CollegeClass_EnrollmentFull;
            math.SignUpStudents("Sue Storm").PrintToConsole();
            math.SignUpStudents("Joe Smith").PrintToConsole();
            math.SignUpStudents("Marry Jones").PrintToConsole();


            Console.ReadLine();
        }



        // Event Listener
        private static void CollegeClass_EnrollmentFull(object sender, string e)
        {
            CollegeClassModel model = (CollegeClassModel)sender; // cast sender to the correct type


            Console.WriteLine();
            Console.WriteLine($"{model.CourseTitle}: Full");
            Console.WriteLine();
        }
    }


    public static class ConsoleHelpers
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }
    }

    public class CollegeClassModel
    {

        public event EventHandler<string> EnrollmentFull; // declaration


        private  List<string> enrolledStudents = new List<string>();
        private List<string> waitingList = new List<string>();

        public string CourseTitle { get; private set; }
        public int MaximumStudents { get; private set; }


        public CollegeClassModel(string title, int maximumStudents)
        {
            CourseTitle = title;
            MaximumStudents = maximumStudents;
        }

        public string SignUpStudents(string studentName)
        {
            string output = string.Empty;

            if (enrolledStudents.Count < MaximumStudents) 
            {
                enrolledStudents.Add(studentName);
                output = $"{studentName} was enrolled in {CourseTitle}";

                // check to if see if we are maxed out 
                if (enrolledStudents.Count == MaximumStudents) 
                {
                    EnrollmentFull?.Invoke(this, $"{CourseTitle} enrollment is now full"); // firing of  the event
                }
               

            }
            else
            {
                 
                waitingList.Add(studentName);
                output = $"{studentName} was added to the wait list for {CourseTitle}";
            }

            return output ;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollegeClassModel history = new CollegeClassModel("History 101", 3);
            CollegeClassModel math = new CollegeClassModel("Calculus 201", 2);

            history.EnrollmentFull += CollegeClass_EnrollmentFull;

            history.SignUpStudents("Tim Corey").PrintToConsole();
            history.SignUpStudents("Marc Moxey").PrintToConsole();
            history.SignUpStudents("Sue Storm").PrintToConsole();
            history.SignUpStudents("Joe Smith").PrintToConsole();
            history.SignUpStudents("Marry Jones").PrintToConsole();
            history.SignUpStudents("Sandy Patty").PrintToConsole();
            Console.WriteLine();


            math.EnrollmentFull += CollegeClass_EnrollmentFull;
            math.SignUpStudents("Sue Storm").PrintToConsole();
            math.SignUpStudents("Joe Smith").PrintToConsole();
            math.SignUpStudents("Marry Jones").PrintToConsole();


            Console.ReadLine();
        }



        // Event Listener
        private static void CollegeClass_EnrollmentFull(object sender, string e)
        {
            CollegeClassModel model = (CollegeClassModel)sender; // cast sender to the correct type


            Console.WriteLine();
            Console.WriteLine($"{model.CourseTitle}: Full");
            Console.WriteLine();
        }
    }


    public static class ConsoleHelpers
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }
    }

    public class CollegeClassModel
    {

        public event EventHandler<string> EnrollmentFull; // declaration


        private  List<string> enrolledStudents = new List<string>();
        private List<string> waitingList = new List<string>();

        public string CourseTitle { get; private set; }
        public int MaximumStudents { get; private set; }


        public CollegeClassModel(string title, int maximumStudents)
        {
            CourseTitle = title;
            MaximumStudents = maximumStudents;
        }

        public string SignUpStudents(string studentName)
        {
            string output = string.Empty;

            if (enrolledStudents.Count < MaximumStudents) 
            {
                enrolledStudents.Add(studentName);
                output = $"{studentName} was enrolled in {CourseTitle}";

                // check to if see if we are maxed out 
                if (enrolledStudents.Count == MaximumStudents) 
                {
                    EnrollmentFull?.Invoke(this, $"{CourseTitle} enrollment is now full"); // firing of  the event
                }
               

            }
            else
            {
                 
                waitingList.Add(studentName);
                output = $"{studentName} was added to the wait list for {CourseTitle}";
            }

            return output ;
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
