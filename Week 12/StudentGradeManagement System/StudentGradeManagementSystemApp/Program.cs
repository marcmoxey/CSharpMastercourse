<<<<<<< HEAD
﻿using GradeLibrary;
using GradeLibrary.Interfaces;
using GradeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentGradeManagementSystemApp
{


    class Program
    {
        static IStudent studentManager = new StudentManager();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nStudent Grade Management System");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Grade");
                Console.WriteLine("3. View Student Grades");
                Console.WriteLine("4. Generate Report");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudentUI();
                        break;
                    case "2":
                        AddGradeUI();
                        break;
                    case "3":
                        ViewStudentGradesUI();
                        break;
                    case "4":
                        studentManager.GenerateReport();
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }

        static void AddStudentUI()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            studentManager.AddStudent(name);
        }

        static void AddGradeUI()
        {
            Console.Write("Enter Student ID: ");
            int studentId;
            while (!int.TryParse(Console.ReadLine(), out studentId))
            {
                Console.Write("Invalid ID! Enter a valid student ID: ");
            }

            Console.WriteLine("Available Subjects:");
            foreach (var subj in Enum.GetValues(typeof(Subjects)))
            {
                Console.WriteLine($"{(int)subj}: {subj}");
            }

            Console.Write("Enter Subject Number: ");
            int subjectInput;
            while (!int.TryParse(Console.ReadLine(), out subjectInput) || !Enum.IsDefined(typeof(Subjects), subjectInput))
            {
                Console.Write("Invalid subject! Enter a valid subject number: ");
            }

            Subjects subject = (Subjects)subjectInput;

            Console.Write("Enter Grade (0-100): ");
            double grade;
            while (!double.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 100)
            {
                Console.Write("Invalid grade! Enter a value between 0 and 100: ");
            }

            studentManager.AddGrade(studentId, subject, grade);
        }

        static void ViewStudentGradesUI()
        {
            Console.Write("Enter Student ID: ");
            int studentId;
            while (!int.TryParse(Console.ReadLine(), out studentId))
            {
                Console.Write("Invalid ID! Enter a valid student ID: ");
            }

            studentManager.ViewStudentGrades(studentId);
        }
    }
}
=======
﻿using GradeLibrary;
using GradeLibrary.Interfaces;
using GradeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentGradeManagementSystemApp
{


    class Program
    {
        static IStudent studentManager = new StudentManager();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nStudent Grade Management System");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Grade");
                Console.WriteLine("3. View Student Grades");
                Console.WriteLine("4. Generate Report");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudentUI();
                        break;
                    case "2":
                        AddGradeUI();
                        break;
                    case "3":
                        ViewStudentGradesUI();
                        break;
                    case "4":
                        studentManager.GenerateReport();
                        break;
                    case "5":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }

        static void AddStudentUI()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            studentManager.AddStudent(name);
        }

        static void AddGradeUI()
        {
            Console.Write("Enter Student ID: ");
            int studentId;
            while (!int.TryParse(Console.ReadLine(), out studentId))
            {
                Console.Write("Invalid ID! Enter a valid student ID: ");
            }

            Console.WriteLine("Available Subjects:");
            foreach (var subj in Enum.GetValues(typeof(Subjects)))
            {
                Console.WriteLine($"{(int)subj}: {subj}");
            }

            Console.Write("Enter Subject Number: ");
            int subjectInput;
            while (!int.TryParse(Console.ReadLine(), out subjectInput) || !Enum.IsDefined(typeof(Subjects), subjectInput))
            {
                Console.Write("Invalid subject! Enter a valid subject number: ");
            }

            Subjects subject = (Subjects)subjectInput;

            Console.Write("Enter Grade (0-100): ");
            double grade;
            while (!double.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 100)
            {
                Console.Write("Invalid grade! Enter a value between 0 and 100: ");
            }

            studentManager.AddGrade(studentId, subject, grade);
        }

        static void ViewStudentGradesUI()
        {
            Console.Write("Enter Student ID: ");
            int studentId;
            while (!int.TryParse(Console.ReadLine(), out studentId))
            {
                Console.Write("Invalid ID! Enter a valid student ID: ");
            }

            studentManager.ViewStudentGrades(studentId);
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
