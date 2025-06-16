<<<<<<< HEAD
﻿using GradeLibrary.Interfaces;
using GradeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeLibrary
{
    public class StudentManager : IStudent
    {
        private List<StudentModel> students = new List<StudentModel>(); 
        private static int nextStudentId = 1;   

        public void AddGrade(int studentId, Subjects subject, double grade)
        {
            var student = students.FirstOrDefault(s => s.StudentId == studentId);

            if (student == null) 
            {

                Console.WriteLine("Student not found!");
                return;
            }

            if(grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid grade! Enter a value between 0 and 100");
                return;
            }

            student.Grades[subject] = grade;
            Console.WriteLine("Grade recorded successfully!");
        }

        public void AddStudent(string name)
        {
            students.Add(new StudentModel(nextStudentId++, name));
            Console.WriteLine("Student added successfully!");
        }

        public void GenerateReport()
        {
            if(!students.Any())
            {
                Console.WriteLine("No students available");
                return ;
            }

            var highestGradeStudent = students.OrderByDescending(s => s.Grades.Values.Average()).FirstOrDefault();
            var averageGrade = students.SelectMany(s => s.Grades.Values).DefaultIfEmpty(0).Average();
            var passingStudents = students.Where(s => s.Grades.Values.All(g => g >= 50)).ToList();

            Console.WriteLine("\n--- Report ---");
            Console.WriteLine($"Average Grade: {averageGrade:F2}");
            Console.WriteLine($"Top Performer: {highestGradeStudent?.StudentName} with Avg Grade: {highestGradeStudent?.Grades.Values.Average():F2}");
            Console.WriteLine($"Students Passing All Subjects: {passingStudents.Count}");
        }

        public void ViewStudentGrades(int studentId)
        {
           var student = students.FirstOrDefault(s => s.StudentId == studentId);
            if (student == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            Console.WriteLine($"\nGrades for {student.StudentName}");
            foreach (var grade in student.Grades)
            {
                Console.WriteLine($"{grade.Key}: {grade.Value}");
            }
        }
    }
}
=======
﻿using GradeLibrary.Interfaces;
using GradeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeLibrary
{
    public class StudentManager : IStudent
    {
        private List<StudentModel> students = new List<StudentModel>(); 
        private static int nextStudentId = 1;   

        public void AddGrade(int studentId, Subjects subject, double grade)
        {
            var student = students.FirstOrDefault(s => s.StudentId == studentId);

            if (student == null) 
            {

                Console.WriteLine("Student not found!");
                return;
            }

            if(grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid grade! Enter a value between 0 and 100");
                return;
            }

            student.Grades[subject] = grade;
            Console.WriteLine("Grade recorded successfully!");
        }

        public void AddStudent(string name)
        {
            students.Add(new StudentModel(nextStudentId++, name));
            Console.WriteLine("Student added successfully!");
        }

        public void GenerateReport()
        {
            if(!students.Any())
            {
                Console.WriteLine("No students available");
                return ;
            }

            var highestGradeStudent = students.OrderByDescending(s => s.Grades.Values.Average()).FirstOrDefault();
            var averageGrade = students.SelectMany(s => s.Grades.Values).DefaultIfEmpty(0).Average();
            var passingStudents = students.Where(s => s.Grades.Values.All(g => g >= 50)).ToList();

            Console.WriteLine("\n--- Report ---");
            Console.WriteLine($"Average Grade: {averageGrade:F2}");
            Console.WriteLine($"Top Performer: {highestGradeStudent?.StudentName} with Avg Grade: {highestGradeStudent?.Grades.Values.Average():F2}");
            Console.WriteLine($"Students Passing All Subjects: {passingStudents.Count}");
        }

        public void ViewStudentGrades(int studentId)
        {
           var student = students.FirstOrDefault(s => s.StudentId == studentId);
            if (student == null)
            {
                Console.WriteLine("Student not found");
                return;
            }

            Console.WriteLine($"\nGrades for {student.StudentName}");
            foreach (var grade in student.Grades)
            {
                Console.WriteLine($"{grade.Key}: {grade.Value}");
            }
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
