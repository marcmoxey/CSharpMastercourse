using DemoLibrary;

namespace AccessModifiersDemo
{
    public class CEO : Manager
    {
        public void GetConnectionInfo()
        {
            DataAccess data = new DataAccess(); 
            
            formerLastName = "test";
        }
    }
}
