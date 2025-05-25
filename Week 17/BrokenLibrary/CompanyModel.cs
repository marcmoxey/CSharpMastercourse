namespace BrokenLibrary
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
}