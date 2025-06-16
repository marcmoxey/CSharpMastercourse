<<<<<<< HEAD
﻿namespace WinFormUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.processForm = new System.Windows.Forms.Button();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.loginNameLabel = new System.Windows.Forms.Label();
            this.initialsLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(58, 79);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(157, 37);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name: ";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(221, 76);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(375, 43);
            this.firstNameText.TabIndex = 1;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(221, 142);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(375, 43);
            this.lastNameText.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(58, 145);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(155, 37);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name: ";
            // 
            // processForm
            // 
            this.processForm.Location = new System.Drawing.Point(221, 207);
            this.processForm.Name = "processForm";
            this.processForm.Size = new System.Drawing.Size(232, 64);
            this.processForm.TabIndex = 4;
            this.processForm.Text = "Process";
            this.processForm.UseVisualStyleBackColor = true;
            this.processForm.Click += new System.EventHandler(this.processForm_Click);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(58, 311);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(150, 37);
            this.fullNameLabel.TabIndex = 5;
            this.fullNameLabel.Text = "Full Name: ";
            // 
            // loginNameLabel
            // 
            this.loginNameLabel.AutoSize = true;
            this.loginNameLabel.Location = new System.Drawing.Point(58, 366);
            this.loginNameLabel.Name = "loginNameLabel";
            this.loginNameLabel.Size = new System.Drawing.Size(175, 37);
            this.loginNameLabel.TabIndex = 6;
            this.loginNameLabel.Text = "Login Name: ";
            // 
            // initialsLabel
            // 
            this.initialsLabel.AutoSize = true;
            this.initialsLabel.Location = new System.Drawing.Point(58, 421);
            this.initialsLabel.Name = "initialsLabel";
            this.initialsLabel.Size = new System.Drawing.Size(107, 37);
            this.initialsLabel.TabIndex = 7;
            this.initialsLabel.Text = "Initials: ";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(221, 43);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(207, 30);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "This is our error label";
            this.errorLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 476);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.initialsLabel);
            this.Controls.Add(this.loginNameLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.processForm);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MainForm";
            this.Text = "WinForm Demo App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label firstNameLabel;
        private TextBox firstNameText;
        private TextBox lastNameText;
        private Label lastNameLabel;
        private Button processForm;
        private Label fullNameLabel;
        private Label loginNameLabel;
        private Label initialsLabel;
        private Label errorLabel;
    }
=======
﻿namespace WinFormUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.processForm = new System.Windows.Forms.Button();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.loginNameLabel = new System.Windows.Forms.Label();
            this.initialsLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(58, 79);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(157, 37);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name: ";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(221, 76);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(375, 43);
            this.firstNameText.TabIndex = 1;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(221, 142);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(375, 43);
            this.lastNameText.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(58, 145);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(155, 37);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name: ";
            // 
            // processForm
            // 
            this.processForm.Location = new System.Drawing.Point(221, 207);
            this.processForm.Name = "processForm";
            this.processForm.Size = new System.Drawing.Size(232, 64);
            this.processForm.TabIndex = 4;
            this.processForm.Text = "Process";
            this.processForm.UseVisualStyleBackColor = true;
            this.processForm.Click += new System.EventHandler(this.processForm_Click);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(58, 311);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(150, 37);
            this.fullNameLabel.TabIndex = 5;
            this.fullNameLabel.Text = "Full Name: ";
            // 
            // loginNameLabel
            // 
            this.loginNameLabel.AutoSize = true;
            this.loginNameLabel.Location = new System.Drawing.Point(58, 366);
            this.loginNameLabel.Name = "loginNameLabel";
            this.loginNameLabel.Size = new System.Drawing.Size(175, 37);
            this.loginNameLabel.TabIndex = 6;
            this.loginNameLabel.Text = "Login Name: ";
            // 
            // initialsLabel
            // 
            this.initialsLabel.AutoSize = true;
            this.initialsLabel.Location = new System.Drawing.Point(58, 421);
            this.initialsLabel.Name = "initialsLabel";
            this.initialsLabel.Size = new System.Drawing.Size(107, 37);
            this.initialsLabel.TabIndex = 7;
            this.initialsLabel.Text = "Initials: ";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(221, 43);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(207, 30);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "This is our error label";
            this.errorLabel.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 476);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.initialsLabel);
            this.Controls.Add(this.loginNameLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.processForm);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MainForm";
            this.Text = "WinForm Demo App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label firstNameLabel;
        private TextBox firstNameText;
        private TextBox lastNameText;
        private Label lastNameLabel;
        private Button processForm;
        private Label fullNameLabel;
        private Label loginNameLabel;
        private Label initialsLabel;
        private Label errorLabel;
    }
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
}