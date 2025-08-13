using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; } 

        public void Work()
        {

        }

        public void CalculateBonus()
        {
           
        }
    }

    public class Manager : Employee
    {
        public void Fire()
        {

        }

        public void Hire()
        {

        }

        public void Work()
        {
            Console.WriteLine("I oversee everyone");
        }

        public void CalculateBonus()
        {
            decimal bonus = Salary * 0.15M;
        }
    }

    public class Developer : Employee
    {
        public void Work()
        {
            Console.WriteLine("I build things");
        }

        public void CalculateBonus()
        {
            decimal bonus = Salary * 0.10M;
        }
    }

    public class Intern : Developer
    {

        public void Work()
        {
            Console.WriteLine("I get delegate anyoing task");
        }

        public void CalculateBonus()
        {
            decimal bonus = Salary * 0.03M;
        }
    }
}
