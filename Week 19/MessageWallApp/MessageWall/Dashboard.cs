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

namespace MessageWall
{
    public partial class Dashboard : Form
    {
        private BindingList<string> messages = new BindingList<string>(); 


        public Dashboard()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            messageListBox.DataSource = messages; // Bind the list box to the messages list
            messageListBox.DisplayMember = nameof(Dashboard.Text); // Set the display member to the text property of the list box(use when have an object)
        }
        private void addMessage_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(messageText.Text))
            {
                MessageBox.Show("Please enter a message before trying to add it to the list.", "Blank Message Field", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show a message if the text box is empty
               
            } 
            else
            {
                messages.Add(messageText.Text); // Add the message to the list
                messageText.Text = ""; // Clear the text box
                messageText.Focus(); // Set focus back to the text box
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

namespace MessageWall
{
    public partial class Dashboard : Form
    {
        private BindingList<string> messages = new BindingList<string>(); 


        public Dashboard()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            messageListBox.DataSource = messages; // Bind the list box to the messages list
            messageListBox.DisplayMember = nameof(Dashboard.Text); // Set the display member to the text property of the list box(use when have an object)
        }
        private void addMessage_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(messageText.Text))
            {
                MessageBox.Show("Please enter a message before trying to add it to the list.", "Blank Message Field", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show a message if the text box is empty
               
            } 
            else
            {
                messages.Add(messageText.Text); // Add the message to the list
                messageText.Text = ""; // Clear the text box
                messageText.Focus(); // Set focus back to the text box
            }
           
        }
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
