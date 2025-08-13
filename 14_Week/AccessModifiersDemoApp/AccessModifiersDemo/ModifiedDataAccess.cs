<<<<<<< HEAD
﻿using DemoLibrary;

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
=======
﻿using DemoLibrary;

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
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
