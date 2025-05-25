using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeLibrary.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public Dictionary<Subjects, double> Grades { get; set; } = new Dictionary<Subjects, double>();

        public StudentModel(int Id, string name)
        {
            StudentId = Id;
            StudentName = name;
          
        }
    }
}
