namespace BrokenLibrary
{
    public class CompanyModel
    {
        public string CompanyName { get; set; }
        public int NumberOfEmployees { get; set; }
        public double NumberOfDaysOffTotal { get; set; }
        
        public double AverageDaysOff ()
        {
            return NumberOfDaysOffTotal / NumberOfEmployees;
        }
    }
}