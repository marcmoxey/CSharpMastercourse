<<<<<<< HEAD
﻿namespace BrokenLibrary
{
    public class CompanyModel
    {
        public string CompanyName { get; set; }
        public int NumberOfEmployees { get; set; }
        public int NumberOfDaysOffTotal { get; set; }
        
        public int AverageDaysOff ()
        {
            return NumberOfDaysOffTotal / NumberOfEmployees;
        }
    }
=======
﻿namespace BrokenLibrary
{
    public class CompanyModel
    {
        public string CompanyName { get; set; }
        public int NumberOfEmployees { get; set; }
        public int NumberOfDaysOffTotal { get; set; }
        
        public int AverageDaysOff ()
        {
            return NumberOfDaysOffTotal / NumberOfEmployees;
        }
    }
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
}