using StudentLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Interfaces
{
    public interface ISaveCourse
    {
        void SaveCourse(CourseModel course);    
    }
}
