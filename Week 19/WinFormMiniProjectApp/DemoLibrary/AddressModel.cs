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
