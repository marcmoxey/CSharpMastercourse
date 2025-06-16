namespace WinFormsUser
{
    partial class Form1
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
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            saveBtn = new Button();
            fullNameLabel = new Label();
            loginNameLabel = new Label();
            initialsLabel = new Label();
            fullNameResultsLabel = new Label();
            loginNameResultsLabel = new Label();
            initalsResultsLabel = new Label();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(42, 30);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(129, 32);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(42, 80);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(126, 32);
            lastNameLabel.TabIndex = 0;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(177, 27);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(250, 39);
            firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(177, 77);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(250, 39);
            lastNameTextBox.TabIndex = 1;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(177, 140);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(117, 46);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new Point(42, 240);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(123, 32);
            fullNameLabel.TabIndex = 3;
            fullNameLabel.Text = "Full Name";
            // 
            // loginNameLabel
            // 
            loginNameLabel.AutoSize = true;
            loginNameLabel.Location = new Point(42, 286);
            loginNameLabel.Name = "loginNameLabel";
            loginNameLabel.Size = new Size(144, 32);
            loginNameLabel.TabIndex = 3;
            loginNameLabel.Text = "Login Name";
            // 
            // initialsLabel
            // 
            initialsLabel.AutoSize = true;
            initialsLabel.Location = new Point(42, 340);
            initialsLabel.Name = "initialsLabel";
            initialsLabel.Size = new Size(82, 32);
            initialsLabel.TabIndex = 3;
            initialsLabel.Text = "Initials";
            // 
            // fullNameResultsLabel
            // 
            fullNameResultsLabel.AutoSize = true;
            fullNameResultsLabel.Location = new Point(192, 240);
            fullNameResultsLabel.Name = "fullNameResultsLabel";
            fullNameResultsLabel.Size = new Size(29, 32);
            fullNameResultsLabel.TabIndex = 3;
            fullNameResultsLabel.Text = "...";
            // 
            // loginNameResultsLabel
            // 
            loginNameResultsLabel.AutoSize = true;
            loginNameResultsLabel.Location = new Point(192, 286);
            loginNameResultsLabel.Name = "loginNameResultsLabel";
            loginNameResultsLabel.Size = new Size(29, 32);
            loginNameResultsLabel.TabIndex = 3;
            loginNameResultsLabel.Text = "...";
            // 
            // initalsResultsLabel
            // 
            initalsResultsLabel.AutoSize = true;
            initalsResultsLabel.Location = new Point(192, 340);
            initalsResultsLabel.Name = "initalsResultsLabel";
            initalsResultsLabel.Size = new Size(29, 32);
            initalsResultsLabel.TabIndex = 3;
            initalsResultsLabel.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 409);
            Controls.Add(initialsLabel);
            Controls.Add(loginNameLabel);
            Controls.Add(initalsResultsLabel);
            Controls.Add(loginNameResultsLabel);
            Controls.Add(fullNameResultsLabel);
            Controls.Add(fullNameLabel);
            Controls.Add(saveBtn);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private Button saveBtn;
        private Label fullNameLabel;
        private Label loginNameLabel;
        private Label initialsLabel;
        private Label fullNameResultsLabel;
        private Label loginNameResultsLabel;
        private Label initalsResultsLabel;
    }
}
