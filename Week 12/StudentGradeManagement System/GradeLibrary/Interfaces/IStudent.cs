using GradeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeLibrary.Interfaces
{
    public  interface IStudent
    {
        void AddStudent(string name);
        void AddGrade(int studentId, Subjects subject, double grade);
        void ViewStudentGrades(int studentId);
        void GenerateReport();
    }
}
