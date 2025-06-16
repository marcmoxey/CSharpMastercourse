<<<<<<< HEAD
﻿using System.Windows;
using UserLibrary.BusinessLogic;
using UserLibrary.Models;

namespace WPFUI
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

        private void processForm_Click(object sender, RoutedEventArgs e)
        {
            errorLabel.Visibility = Visibility.Hidden;

            if (string.IsNullOrWhiteSpace(firstNameText.Text))
            {
                errorLabel.Text = "You need to provide a valid first name.";
                errorLabel.Visibility = Visibility.Visible;
                return;
            }

            if (string.IsNullOrWhiteSpace(lastNameText.Text))
            {
                errorLabel.Text = "You need to provide a valid last name.";
                errorLabel.Visibility = Visibility.Visible;
                return;
            }

            PersonModel person = new();
            person.FirstName = firstNameText.Text;
            person.LastName = lastNameText.Text;

            fullNameLabel.Text = "Full Name: " + person.GetFullName();
            loginNameLabel.Text = "Login Name: " + person.GetLoginName();
            initialsLabel.Text = "Initials: " + person.GetInitials();
        }
    }
}
=======
﻿using System.Windows;
using UserLibrary.BusinessLogic;
using UserLibrary.Models;

namespace WPFUI
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

        private void processForm_Click(object sender, RoutedEventArgs e)
        {
            errorLabel.Visibility = Visibility.Hidden;

            if (string.IsNullOrWhiteSpace(firstNameText.Text))
            {
                errorLabel.Text = "You need to provide a valid first name.";
                errorLabel.Visibility = Visibility.Visible;
                return;
            }

            if (string.IsNullOrWhiteSpace(lastNameText.Text))
            {
                errorLabel.Text = "You need to provide a valid last name.";
                errorLabel.Visibility = Visibility.Visible;
                return;
            }

            PersonModel person = new();
            person.FirstName = firstNameText.Text;
            person.LastName = lastNameText.Text;

            fullNameLabel.Text = "Full Name: " + person.GetFullName();
            loginNameLabel.Text = "Login Name: " + person.GetLoginName();
            initialsLabel.Text = "Initials: " + person.GetInitials();
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
