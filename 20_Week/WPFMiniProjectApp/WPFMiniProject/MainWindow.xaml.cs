<<<<<<< HEAD
﻿using DemoLibrary.Logic;
using DemoLibrary.Models;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFMiniProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();
        public MainWindow()
        {
            InitializeComponent();
            addressesListBox.ItemsSource = addresses;
           
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }

        private void addAddressBtn_Click(object sender, RoutedEventArgs e)
        {
            AddressEntry entry = new AddressEntry(this);
            entry.Show();
            
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstNameTextBox.Text,
                LastName = lasttNameTextBox.Text,
                Addresses = addresses.ToList()
            };
        }

        private void editAddressBtn_Click(object sender, RoutedEventArgs e)
        {
            if(addressesListBox.SelectedItem is AddressModel selectedAddress)
            {
                AddressEntry entry = new AddressEntry(this, selectedAddress);
                entry.ShowDialog();
                addressesListBox.Items.Refresh();

            } else
            {
                MessageBox.Show("Please select an Address to edit", "Invalid Address", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void deleteAddressBtn_Click(object sender, RoutedEventArgs e)
        {
            if(addressesListBox.SelectedItem is AddressModel selectedAddress)
            {
                if(MessageBox.Show($"Are you sure you want to delete {selectedAddress.AddressDisplayValue}?", "Confirm Delete", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    addresses.Remove(selectedAddress);

                }

            }
            else
            {
                MessageBox.Show("Please selected an address to delete", "Invalid Address", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
=======
﻿using DemoLibrary.Logic;
using DemoLibrary.Models;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFMiniProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();
        public MainWindow()
        {
            InitializeComponent();
            addressesListBox.ItemsSource = addresses;
           
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }

        private void addAddressBtn_Click(object sender, RoutedEventArgs e)
        {
            AddressEntry entry = new AddressEntry(this);
            entry.Show();
            
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstNameTextBox.Text,
                LastName = lasttNameTextBox.Text,
                Addresses = addresses.ToList()
            };
        }
    }
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
}