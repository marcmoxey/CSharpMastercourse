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
    public partial class PersonEntry : Form, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();

        public PersonEntry()
        {
            InitializeComponent();

            addressesList.DataSource = addresses; // This is the BindingList that we will use to store the addresses
            addressesList.DisplayMember = nameof(AddressModel.AddressDisplayValue); // DisplayMember is the property of AddressModel that we want to show in the ListBox
        }

        private void AddNewAddress_Click(object sender, EventArgs e)
        {
            AddressEntry entry = new AddressEntry(this);

            entry.Show();
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address); // This is where we add the new address to the BindingList
        }

        private void SaveRecord_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel // This is the model that we will use to store the person's information
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                IsActive = isActive.Checked,
                Addresses = addresses.ToList()
            };


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
    public partial class PersonEntry : Form, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();

        public PersonEntry()
        {
            InitializeComponent();

            addressesList.DataSource = addresses; // This is the BindingList that we will use to store the addresses
            addressesList.DisplayMember = nameof(AddressModel.AddressDisplayValue); // DisplayMember is the property of AddressModel that we want to show in the ListBox
        }

        private void AddNewAddress_Click(object sender, EventArgs e)
        {
            AddressEntry entry = new AddressEntry(this);

            entry.Show();
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address); // This is where we add the new address to the BindingList
        }

        private void SaveRecord_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel // This is the model that we will use to store the person's information
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                IsActive = isActive.Checked,
                Addresses = addresses.ToList()
            };


        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
