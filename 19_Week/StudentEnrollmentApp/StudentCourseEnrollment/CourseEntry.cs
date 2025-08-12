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
    public partial class CourseEntry : Form
    {
        ISaveCourse _parent;  // interface reference to communicate with the parent form
        public CourseEntry(ISaveCourse parent)
        {
            InitializeComponent();
            _parent = parent; // store the parent reference to call SaveCourse method
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(courseNameText.Text) &&  string.IsNullOrEmpty(creditsText.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message if fields are empty
               
            } else if(string.IsNullOrEmpty(courseNameText.Text))
            {
                MessageBox.Show("Please enter a course name.", "Blank Course Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message if course name is empty
            }
            else if (string.IsNullOrEmpty(creditsText.Text))
            {
                MessageBox.Show("Please enter credits.", "Blank Credit Field", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message if credits are empty
            }
            else if (!int.TryParse(creditsText.Text, out int credits) || credits <= 0)
            {
                MessageBox.Show("Please enter a valid number of credits greater than 0.", "Invalid Credits", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message if credits are not valid
            }
            else
            {
                CourseModel course = new CourseModel
                {
                    CourseName = courseNameText.Text, // Read course name
                    Credits = int.Parse(creditsText.Text) // Convert credits text to int
                };

                _parent.SaveCourse(course); // Call the SaveCourse method on the parent form to save the course

                this.Close(); // Close the course entry form after saving
            }

        }
    }
}
