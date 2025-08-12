<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new EmployeeModel("Marc","Moxey","IT");
            employee.DisplayEmployeeInfo();
            Console.WriteLine(employee.Info);
            Console.ReadLine(); 
        }
    }

    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public string Info { get; set; }


        public EmployeeModel()
        {
            
        }

        public EmployeeModel(string firstName, string lastName, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }
        public EmployeeModel(string firstName, string lastName, string jobTitle, decimal salary, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            JobTitle = jobTitle;
            Salary = salary;
            Department = department;    
        }

        public void DisplayEmployeeInfo()
        {
            DisplayEmployeeInfo(FirstName, LastName, Department, JobTitle, Salary.ToString());
        }
        public void DisplayEmployeeInfo(string firstName, string lastName, string department, string jobTitle)
        {
            DisplayEmployeeInfo(firstName, lastName, department, jobTitle);
        }

        public void DisplayEmployeeInfo(string firstName, string lastName, string department)
        {
            DisplayEmployeeInfo(firstName, lastName, department);
        }


        public void DisplayEmployeeInfo(string firstName, string lastName, string department, string jobTitle, string salary)
        {
            if (jobTitle == null)
            {
                Info = $"{LastName}, {FirstName} work in {Department}";
            } 
            else if(salary == null)
            {
                Info = $"{LastName}, {FirstName} work in {Department} as {JobTitle}";
            }
            else
            {
                Info = $"{LastName}, {FirstName} work in {Department} as {JobTitle} and makes {Salary} a year";
            }
                
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee = new EmployeeModel("Marc","Moxey","IT");
            employee.DisplayEmployeeInfo();
            Console.WriteLine(employee.Info);
            Console.ReadLine(); 
        }
    }

    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
        public string Info { get; set; }


        public EmployeeModel()
        {
            
        }

        public EmployeeModel(string firstName, string lastName, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }
        public EmployeeModel(string firstName, string lastName, string jobTitle, decimal salary, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            JobTitle = jobTitle;
            Salary = salary;
            Department = department;    
        }

        public void DisplayEmployeeInfo()
        {
            DisplayEmployeeInfo(FirstName, LastName, Department, JobTitle, Salary.ToString());
        }
        public void DisplayEmployeeInfo(string firstName, string lastName, string department, string jobTitle)
        {
            DisplayEmployeeInfo(firstName, lastName, department, jobTitle);
        }

        public void DisplayEmployeeInfo(string firstName, string lastName, string department)
        {
            DisplayEmployeeInfo(firstName, lastName, department);
        }


        public void DisplayEmployeeInfo(string firstName, string lastName, string department, string jobTitle, string salary)
        {
            if (jobTitle == null)
            {
                Info = $"{LastName}, {FirstName} work in {Department}";
            } 
            else if(salary == null)
            {
                Info = $"{LastName}, {FirstName} work in {Department} as {JobTitle}";
            }
            else
            {
                Info = $"{LastName}, {FirstName} work in {Department} as {JobTitle} and makes {Salary} a year";
            }
                
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
