<<<<<<< HEAD
﻿using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormMiniProject
{
    public partial class AddressEntry : Form
    {
        ISaveAddress _parent; // This is the parent form that we will use to save the address information

        public AddressEntry(ISaveAddress parent)
        {
            InitializeComponent();

            _parent = parent; // This is the parent form that we will use to save the address information
        }

        private void SaveRecord_Click(object sender, EventArgs e)
        {
            AddressModel address = new AddressModel // This is the model that we will use to store the address information
            {
                StreetAddress = streetAddressText.Text,
                City = cityText.Text,
                State = stateText.Text,
                ZipCode = zipCodeText.Text
            };

            _parent.SaveAddress(address);// This is where we save the address information to the parent form

            this.Close();
        }
    }
}
=======
﻿using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormMiniProject
{
    public partial class AddressEntry : Form
    {
        ISaveAddress _parent; // This is the parent form that we will use to save the address information

        public AddressEntry(ISaveAddress parent)
        {
            InitializeComponent();

            _parent = parent; // This is the parent form that we will use to save the address information
        }

        private void SaveRecord_Click(object sender, EventArgs e)
        {
            AddressModel address = new AddressModel // This is the model that we will use to store the address information
            {
                StreetAddress = streetAddressText.Text,
                City = cityText.Text,
                State = stateText.Text,
                ZipCode = zipCodeText.Text
            };

            _parent.SaveAddress(address);// This is where we save the address information to the parent form

            this.Close();
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
