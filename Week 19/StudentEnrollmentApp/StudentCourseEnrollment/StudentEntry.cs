using StudentLibrary.Interfaces;
using StudentLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCourseEnrollment
{
    public partial class StudentEntry : Form, ISaveCourse
    {
        // used to automatically update the list box when a new course is added
        BindingList<CourseModel> courses = new BindingList<CourseModel>();
        public StudentEntry()
        {
            InitializeComponent();
            courseListBox.DataSource = courses; // Bind the course list to the list box so user can see added courses 
            courseListBox.DisplayMember = nameof(CourseModel.GetCourseInfo); // Display the course name and credits in the list box
        }
        private void addCourseBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(firstNameText.Text) && string.IsNullOrEmpty(lastNameText.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message if fields are empty
            }
            else if (string.IsNullOrEmpty(firstNameText.Text))
            {
                MessageBox.Show("Please enter a first name.", "Blank First Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message if first name is empty
            }
            else if (string.IsNullOrEmpty(lastNameText.Text))
            {
                MessageBox.Show("Please enter a last name.", "Blank Last Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message if last name is empty
            } else
            {
                // Create a new course entry form and pass in the current form as the parent
                CourseEntry entry = new CourseEntry(this);

                entry.Show(); // show the course entry form
            }
          
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameText.Text) && string.IsNullOrEmpty(lastNameText.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message if fields are empty
            }
            else if (string.IsNullOrEmpty(firstNameText.Text))
            {
                MessageBox.Show("Please enter a first name.", "Blank First Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message if first name is empty
            }
            else if (string.IsNullOrEmpty(lastNameText.Text))
            {
                MessageBox.Show("Please enter a last name.", "Blank Last Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message if last name is empty
            } else
            {
                // Create a new student model and populate it with the data from the text boxes
                StudentModel student = new StudentModel
                {
                    FirstName = firstNameText.Text, // get the first name from the text box
                    LastName = lastNameText.Text, // get the last name from the text box
                    courses = courses.ToList() // convert the binding list to a list and assign it to the student model

                };
            }
             
        }
        public void SaveCourse(CourseModel course)
        {
            courses.Add(course); // add the course to the binding list, allowing the list box to update automatically

        }


    }
}
