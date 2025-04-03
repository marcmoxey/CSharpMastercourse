namespace DemoLibrary
{
    public class Employee : Person
    {
        public string GetFormerLastName()
        {
            // protected allow access something in any class that derives from this class
            return formerLastName;
        }
    }
}
