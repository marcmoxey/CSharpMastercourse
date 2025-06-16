<<<<<<< HEAD
﻿using GradeLibrary.Models;
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
=======
﻿using GradeLibrary.Models;
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
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
