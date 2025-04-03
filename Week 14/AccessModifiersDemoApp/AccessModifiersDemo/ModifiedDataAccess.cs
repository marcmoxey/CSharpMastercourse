using DemoLibrary;

namespace AccessModifiersDemo
{
    public class ModifiedDataAccess : DataAccess // protected internal allow access something in any class that derives from base class
    {
        public void GetUnsecureConnectionInfo()
        {
            GetConnectionString();
        }
    }
}
