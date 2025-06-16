namespace StudentCourseEnrollment
{
    partial class CourseEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveBtn = new System.Windows.Forms.Button();
            this.creditsText = new System.Windows.Forms.TextBox();
            this.courseNameText = new System.Windows.Forms.TextBox();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.courseEntryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(201, 226);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(144, 59);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // creditsText
            // 
            this.creditsText.Location = new System.Drawing.Point(298, 149);
            this.creditsText.Name = "creditsText";
            this.creditsText.Size = new System.Drawing.Size(239, 35);
            this.creditsText.TabIndex = 2;
            // 
            // courseNameText
            // 
            this.courseNameText.Location = new System.Drawing.Point(298, 93);
            this.courseNameText.Name = "courseNameText";
            this.courseNameText.Size = new System.Drawing.Size(239, 35);
            this.courseNameText.TabIndex = 1;
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Location = new System.Drawing.Point(196, 152);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(90, 29);
            this.creditsLabel.TabIndex = 11;
            this.creditsLabel.Text = "Credits";
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Location = new System.Drawing.Point(130, 96);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(162, 29);
            this.courseNameLabel.TabIndex = 10;
            this.courseNameLabel.Text = "Coruse Name";
            // 
            // courseEntryLabel
            // 
            this.courseEntryLabel.AutoSize = true;
            this.courseEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseEntryLabel.Location = new System.Drawing.Point(26, 18);
            this.courseEntryLabel.Name = "courseEntryLabel";
            this.courseEntryLabel.Size = new System.Drawing.Size(232, 39);
            this.courseEntryLabel.TabIndex = 9;
            this.courseEntryLabel.Text = "Course Entry";
            // 
            // CourseEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 354);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.creditsText);
            this.Controls.Add(this.courseNameText);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.courseEntryLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "CourseEntry";
            this.Text = "CourseEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox creditsText;
        private System.Windows.Forms.TextBox courseNameText;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label courseEntryLabel;
    }
}