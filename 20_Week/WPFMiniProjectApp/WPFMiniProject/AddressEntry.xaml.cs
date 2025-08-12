<<<<<<< HEAD
﻿using DemoLibrary.Logic;
using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFMiniProject
{
    /// <summary>
    /// Interaction logic for AddressEntry.xaml
    /// </summary>
    public partial class AddressEntry : Window
    {
        ISaveAddress _addresses;

        // If editing, this holds the existing address to be modified
        private readonly AddressModel _existingAddress;

        //  Initializes the form for either creating a new address or editing an existing one.
        public AddressEntry(ISaveAddress address, AddressModel existingAddress = null)
        {
            InitializeComponent();
            _addresses = address;
            _existingAddress = existingAddress;

            // If an existing address is provided, fill the form with its data for editing
            if (existingAddress != null )
            {
                streetAddressTextBox.Text = _existingAddress.StreetAddress;
                cityTextBox.Text = _existingAddress.City;   
                stateTextBox.Text = _existingAddress.State; 
                zipCodeTextBox.Text = _existingAddress.ZipCode;
            }
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            if(_existingAddress != null)
            {
                _existingAddress.StreetAddress = streetAddressTextBox.Text;
                _existingAddress.City = cityTextBox.Text; 
                _existingAddress.State = stateTextBox.Text; 
                _existingAddress.ZipCode = zipCodeTextBox.Text; 
            } else
            {
                AddressModel address = new AddressModel
                {
                    StreetAddress = streetAddressTextBox.Text,
                    City = cityTextBox.Text,
                    State = stateTextBox.Text,
                    ZipCode = zipCodeTextBox.Text,

                };

                _addresses.SaveAddress(address);
            }
        
            this.Close();
        }
    }
}
=======
﻿using DemoLibrary.Logic;
using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFMiniProject
{
    /// <summary>
    /// Interaction logic for AddressEntry.xaml
    /// </summary>
    public partial class AddressEntry : Window
    {
        ISaveAddress _addresses;
        public AddressEntry(ISaveAddress address)
        {
            InitializeComponent();
            _addresses = address;
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            AddressModel address = new AddressModel
            {
                StreetAddress = streetAddressTextBox.Text,
                City = cityTextBox.Text,
                State = stateTextBox.Text,
                ZipCode = zipCodeTextBox.Text,

            };

            _addresses.SaveAddress(address);
            this.Close();
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
