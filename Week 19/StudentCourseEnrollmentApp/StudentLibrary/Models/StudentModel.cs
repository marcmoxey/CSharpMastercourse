﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Models
{
    public class StudentModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }    

        public List<CourseModel> courses = new List<CourseModel>();    
    }
}
