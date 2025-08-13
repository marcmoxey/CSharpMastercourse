<<<<<<< HEAD
﻿namespace Budget
{
    partial class MonthlyExpenseEntry
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
            monthlyExpenseEntryLabel = new Label();
            expenseNameLabel = new Label();
            expenseCostLabel = new Label();
            expenseNameTextBox = new TextBox();
            expenseCostTextBox = new TextBox();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // monthlyExpenseEntryLabel
            // 
            monthlyExpenseEntryLabel.AutoSize = true;
            monthlyExpenseEntryLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monthlyExpenseEntryLabel.Location = new Point(144, 9);
            monthlyExpenseEntryLabel.Name = "monthlyExpenseEntryLabel";
            monthlyExpenseEntryLabel.Size = new Size(319, 47);
            monthlyExpenseEntryLabel.TabIndex = 1;
            monthlyExpenseEntryLabel.Text = "Monthly Expenses";
            // 
            // expenseNameLabel
            // 
            expenseNameLabel.AutoSize = true;
            expenseNameLabel.Location = new Point(23, 99);
            expenseNameLabel.Name = "expenseNameLabel";
            expenseNameLabel.Size = new Size(172, 32);
            expenseNameLabel.TabIndex = 2;
            expenseNameLabel.Text = "Expense Name";
            // 
            // expenseCostLabel
            // 
            expenseCostLabel.AutoSize = true;
            expenseCostLabel.Location = new Point(23, 154);
            expenseCostLabel.Name = "expenseCostLabel";
            expenseCostLabel.Size = new Size(155, 32);
            expenseCostLabel.TabIndex = 2;
            expenseCostLabel.Text = "Expense Cost";
            // 
            // expenseNameTextBox
            // 
            expenseNameTextBox.Location = new Point(211, 99);
            expenseNameTextBox.Name = "expenseNameTextBox";
            expenseNameTextBox.Size = new Size(274, 39);
            expenseNameTextBox.TabIndex = 3;
            // 
            // expenseCostTextBox
            // 
            expenseCostTextBox.Location = new Point(211, 147);
            expenseCostTextBox.Name = "expenseCostTextBox";
            expenseCostTextBox.Size = new Size(274, 39);
            expenseCostTextBox.TabIndex = 3;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(144, 231);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(103, 46);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // MonthlyExpenseEntry
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 307);
            Controls.Add(saveBtn);
            Controls.Add(expenseCostTextBox);
            Controls.Add(expenseNameTextBox);
            Controls.Add(expenseCostLabel);
            Controls.Add(expenseNameLabel);
            Controls.Add(monthlyExpenseEntryLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "MonthlyExpenseEntry";
            Text = "MonthlyExpenseEntry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label monthlyExpenseEntryLabel;
        private Label expenseNameLabel;
        private Label expenseCostLabel;
        private TextBox expenseNameTextBox;
        private TextBox expenseCostTextBox;
        private Button saveBtn;
    }
=======
﻿namespace Budget
{
    partial class MonthlyExpenseEntry
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
            monthlyExpenseEntryLabel = new Label();
            expenseNameLabel = new Label();
            expenseCostLabel = new Label();
            expenseNameTextBox = new TextBox();
            expenseCostTextBox = new TextBox();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // monthlyExpenseEntryLabel
            // 
            monthlyExpenseEntryLabel.AutoSize = true;
            monthlyExpenseEntryLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monthlyExpenseEntryLabel.Location = new Point(144, 9);
            monthlyExpenseEntryLabel.Name = "monthlyExpenseEntryLabel";
            monthlyExpenseEntryLabel.Size = new Size(319, 47);
            monthlyExpenseEntryLabel.TabIndex = 1;
            monthlyExpenseEntryLabel.Text = "Monthly Expenses";
            // 
            // expenseNameLabel
            // 
            expenseNameLabel.AutoSize = true;
            expenseNameLabel.Location = new Point(23, 99);
            expenseNameLabel.Name = "expenseNameLabel";
            expenseNameLabel.Size = new Size(172, 32);
            expenseNameLabel.TabIndex = 2;
            expenseNameLabel.Text = "Expense Name";
            // 
            // expenseCostLabel
            // 
            expenseCostLabel.AutoSize = true;
            expenseCostLabel.Location = new Point(23, 154);
            expenseCostLabel.Name = "expenseCostLabel";
            expenseCostLabel.Size = new Size(155, 32);
            expenseCostLabel.TabIndex = 2;
            expenseCostLabel.Text = "Expense Cost";
            // 
            // expenseNameTextBox
            // 
            expenseNameTextBox.Location = new Point(211, 99);
            expenseNameTextBox.Name = "expenseNameTextBox";
            expenseNameTextBox.Size = new Size(274, 39);
            expenseNameTextBox.TabIndex = 3;
            // 
            // expenseCostTextBox
            // 
            expenseCostTextBox.Location = new Point(211, 147);
            expenseCostTextBox.Name = "expenseCostTextBox";
            expenseCostTextBox.Size = new Size(274, 39);
            expenseCostTextBox.TabIndex = 3;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(144, 231);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(103, 46);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // MonthlyExpenseEntry
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 307);
            Controls.Add(saveBtn);
            Controls.Add(expenseCostTextBox);
            Controls.Add(expenseNameTextBox);
            Controls.Add(expenseCostLabel);
            Controls.Add(expenseNameLabel);
            Controls.Add(monthlyExpenseEntryLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "MonthlyExpenseEntry";
            Text = "MonthlyExpenseEntry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label monthlyExpenseEntryLabel;
        private Label expenseNameLabel;
        private Label expenseCostLabel;
        private TextBox expenseNameTextBox;
        private TextBox expenseCostTextBox;
        private Button saveBtn;
    }
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
}