<<<<<<< HEAD
﻿using DemoLibrary;
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

namespace WPFHomework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindingList<PersonModel> people = new BindingList<PersonModel>();
        public MainWindow()
        {
            InitializeComponent();
            namesList.ItemsSource = people; 
        }

        private void sayHi_Click(object sender, RoutedEventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text
            };

            people.Add(person);
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
        }
    }
=======
﻿using DemoLibrary;
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

namespace WPFHomework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindingList<PersonModel> people = new BindingList<PersonModel>();
        public MainWindow()
        {
            InitializeComponent();
            namesList.ItemsSource = people; 
        }

        private void sayHi_Click(object sender, RoutedEventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text
            };

            people.Add(person);
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
        }
    }
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
}