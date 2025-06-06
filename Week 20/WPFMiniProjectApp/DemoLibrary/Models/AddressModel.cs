﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Models
{
    public class AddressModel
    {
        public string StreetAddress { get; set; }   
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public string AddressDisplayValue => $"{StreetAddress} {City}, {State} {ZipCode}";
    }
}
