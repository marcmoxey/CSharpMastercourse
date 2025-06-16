using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Models
{
    public class CourseModel
    {
        public string CourseName { get; set; }
        public int Credits { get; set; }    

        public string GetCourseInfo => $"{CourseName} - {Credits} credits";
    }
}
