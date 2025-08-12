<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class AddressModel
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public string AddressDisplayValue => $"{ StreetAddress }, { City }, { State }  { ZipCode }";
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary
{
    public class AddressModel
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public string AddressDisplayValue => $"{ StreetAddress }, { City }, { State }  { ZipCode }";
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
