<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokenLibrary
{
    public class CompanyCreator
    {
        public List<CompanyModel> CreateCompanyList()
        {
            List<CompanyModel> output = new();

            output.Add(new() 
            {
                CompanyName = "Acme",
                NumberOfEmployees = 4, 
                NumberOfDaysOffTotal = 12 
            });

            output.Add(new()
            {
                CompanyName = "Blimpy",
                NumberOfEmployees = 6,
                NumberOfDaysOffTotal = 30
            });

            output.Add(new()
            {
                CompanyName = "Carta",
                NumberOfEmployees = 2,
                NumberOfDaysOffTotal = 7
            });

            output.Add(new()
            {
                CompanyName = "Drummon",
                NumberOfEmployees = 37,
                NumberOfDaysOffTotal = 111
            });

            output.Add(new()
            {
                CompanyName = "Elissia",
                NumberOfEmployees = 5,
                NumberOfDaysOffTotal = 20
            });

            output.Add(new()
            {
                CompanyName = "Fortiguard",
                NumberOfEmployees = 19,
                NumberOfDaysOffTotal = 95
            });

            return output;
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokenLibrary
{
    public class CompanyCreator
    {
        public List<CompanyModel> CreateCompanyList()
        {
            List<CompanyModel> output = new();

            output.Add(new() 
            {
                CompanyName = "Acme",
                NumberOfEmployees = 4, 
                NumberOfDaysOffTotal = 12 
            });

            output.Add(new()
            {
                CompanyName = "Blimpy",
                NumberOfEmployees = 6,
                NumberOfDaysOffTotal = 30
            });

            output.Add(new()
            {
                CompanyName = "Carta",
                NumberOfEmployees = 2,
                NumberOfDaysOffTotal = 7
            });

            output.Add(new()
            {
                CompanyName = "Drummon",
                NumberOfEmployees = 37,
                NumberOfDaysOffTotal = 111
            });

            output.Add(new()
            {
                CompanyName = "Elissia",
                NumberOfEmployees = 5,
                NumberOfDaysOffTotal = 20
            });

            output.Add(new()
            {
                CompanyName = "Fortiguard",
                NumberOfEmployees = 19,
                NumberOfDaysOffTotal = 95
            });

            return output;
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
