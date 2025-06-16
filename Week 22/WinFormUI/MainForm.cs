<<<<<<< HEAD
using UserLibrary.BusinessLogic;
using UserLibrary.Models;

namespace WinFormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void processForm_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;

            if (string.IsNullOrWhiteSpace(firstNameText.Text))
            {
                errorLabel.Text = "You need to provide a valid first name.";
                errorLabel.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(lastNameText.Text))
            {
                errorLabel.Text = "You need to provide a valid last name.";
                errorLabel.Visible = true;
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
=======
using UserLibrary.BusinessLogic;
using UserLibrary.Models;

namespace WinFormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void processForm_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;

            if (string.IsNullOrWhiteSpace(firstNameText.Text))
            {
                errorLabel.Text = "You need to provide a valid first name.";
                errorLabel.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(lastNameText.Text))
            {
                errorLabel.Text = "You need to provide a valid last name.";
                errorLabel.Visible = true;
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
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
}