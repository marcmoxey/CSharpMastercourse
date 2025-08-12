<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(firstNameTextBox.Text) && string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                MessageBox.Show("Please enter your first and last name.", "Blank Name Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNameTextBox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            { 
                MessageBox.Show("Please enter your first name.", "Blank First Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNameTextBox.Focus();
            }
            else if(string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                MessageBox.Show("Please enter your last name.", "Blank Last Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastNameTextBox.Focus();
            } else
            {
                MessageBox.Show($"Hello {firstNameTextBox.Text} {lastNameTextBox.Text}");
                firstNameTextBox.Clear();
                lastNameTextBox.Clear();
                firstNameTextBox.Focus();
            }
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(firstNameTextBox.Text) && string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                MessageBox.Show("Please enter your first and last name.", "Blank Name Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNameTextBox.Focus();
            }
            else if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            { 
                MessageBox.Show("Please enter your first name.", "Blank First Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstNameTextBox.Focus();
            }
            else if(string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                MessageBox.Show("Please enter your last name.", "Blank Last Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastNameTextBox.Focus();
            } else
            {
                MessageBox.Show($"Hello {firstNameTextBox.Text} {lastNameTextBox.Text}");
                firstNameTextBox.Clear();
                lastNameTextBox.Clear();
                firstNameTextBox.Focus();
            }
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
