using UserLibrary.Models;
using UserLibrary.BusinessLogic;
namespace WinFormsUser
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
            };

            fullNameResultsLabel.Text = person.GetFullName();
            loginNameResultsLabel.Text = person.GetLoginName();
            initalsResultsLabel.Text = person.GetInitials();
        }
    }
}
