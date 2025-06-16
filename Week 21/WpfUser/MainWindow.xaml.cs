﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UserLibrary.Models;
using UserLibrary.BusinessLogic;

namespace WpfUser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstNameTextBox.Text,
                LastName = lasttNameTextBox.Text,
            };

            fullNameResultsTextBlock.Text = person.GetFullName();
            loginResultsTextBox.Text = person.GetLoginName();
            initalResultsTextBlock.Text = person.GetInitials(); 
        }
    }
}