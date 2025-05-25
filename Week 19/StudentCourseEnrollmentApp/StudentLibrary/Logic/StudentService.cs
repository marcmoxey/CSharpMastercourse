using StudentLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Logic
{
    public  class StudentService
    {
        public bool ValidateStudent(StudentModel student)
        {
            return !string.IsNullOrEmpty(student.FirstName) && !string.IsNullOrEmpty(student.LastName) && student.courses.Count > 0;
        }

        public bool ValidateCourse(CourseModel course)
        {
            return !string.IsNullOrEmpty(course.CourseName) && course.Credits > 0;
        }
    }
}
