<<<<<<< HEAD
﻿namespace WinFormsPersonalFinanceTracker
{
    partial class IncomeEntry
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
            incomeDateLabel = new Label();
            incomeMonthCalendar = new MonthCalendar();
            addIncomeBtn = new Button();
            categoryLabel = new Label();
            incomeCategoiresComboBox = new ComboBox();
            incomeAmountTextBox = new TextBox();
            incomeAmountLabel = new Label();
            incomeEntryLabel = new Label();
            SuspendLayout();
            // 
            // incomeDateLabel
            // 
            incomeDateLabel.AutoSize = true;
            incomeDateLabel.Location = new Point(55, 102);
            incomeDateLabel.Name = "incomeDateLabel";
            incomeDateLabel.Size = new Size(64, 32);
            incomeDateLabel.TabIndex = 15;
            incomeDateLabel.Text = "Date";
            // 
            // incomeMonthCalendar
            // 
            incomeMonthCalendar.Location = new Point(193, 91);
            incomeMonthCalendar.Name = "incomeMonthCalendar";
            incomeMonthCalendar.TabIndex = 14;
            // 
            // addIncomeBtn
            // 
            addIncomeBtn.Location = new Point(66, 445);
            addIncomeBtn.Name = "addIncomeBtn";
            addIncomeBtn.Size = new Size(110, 46);
            addIncomeBtn.TabIndex = 13;
            addIncomeBtn.Text = "Add";
            addIncomeBtn.UseVisualStyleBackColor = true;
            addIncomeBtn.Click += addIncomeBtn_Click;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(66, 375);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(110, 32);
            categoryLabel.TabIndex = 12;
            categoryLabel.Text = "Category";
            // 
            // incomeCategoiresComboBox
            // 
            incomeCategoiresComboBox.FormattingEnabled = true;
            incomeCategoiresComboBox.Location = new Point(197, 372);
            incomeCategoiresComboBox.Name = "incomeCategoiresComboBox";
            incomeCategoiresComboBox.Size = new Size(223, 40);
            incomeCategoiresComboBox.TabIndex = 11;
            // 
            // incomeAmountTextBox
            // 
            incomeAmountTextBox.Location = new Point(193, 295);
            incomeAmountTextBox.Name = "incomeAmountTextBox";
            incomeAmountTextBox.Size = new Size(227, 39);
            incomeAmountTextBox.TabIndex = 10;
            // 
            // incomeAmountLabel
            // 
            incomeAmountLabel.AutoSize = true;
            incomeAmountLabel.Location = new Point(66, 298);
            incomeAmountLabel.Name = "incomeAmountLabel";
            incomeAmountLabel.Size = new Size(100, 32);
            incomeAmountLabel.TabIndex = 9;
            incomeAmountLabel.Text = "Amount";
            // 
            // incomeEntryLabel
            // 
            incomeEntryLabel.AutoSize = true;
            incomeEntryLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            incomeEntryLabel.Location = new Point(35, 19);
            incomeEntryLabel.Name = "incomeEntryLabel";
            incomeEntryLabel.Size = new Size(239, 47);
            incomeEntryLabel.TabIndex = 8;
            incomeEntryLabel.Text = "Income Entry";
            // 
            // IncomeEntry
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 523);
            Controls.Add(incomeDateLabel);
            Controls.Add(incomeMonthCalendar);
            Controls.Add(addIncomeBtn);
            Controls.Add(categoryLabel);
            Controls.Add(incomeCategoiresComboBox);
            Controls.Add(incomeAmountTextBox);
            Controls.Add(incomeAmountLabel);
            Controls.Add(incomeEntryLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "IncomeEntry";
            Text = "IncomeEntry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label incomeDateLabel;
        private MonthCalendar incomeMonthCalendar;
        private Button addIncomeBtn;
        private Label categoryLabel;
        private ComboBox incomeCategoiresComboBox;
        private TextBox incomeAmountTextBox;
        private Label incomeAmountLabel;
        private Label incomeEntryLabel;
    }
=======
﻿namespace WinFormsPersonalFinanceTracker
{
    partial class IncomeEntry
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
            incomeDateLabel = new Label();
            incomeMonthCalendar = new MonthCalendar();
            addIncomeBtn = new Button();
            categoryLabel = new Label();
            incomeCategoiresComboBox = new ComboBox();
            incomeAmountTextBox = new TextBox();
            incomeAmountLabel = new Label();
            incomeEntryLabel = new Label();
            SuspendLayout();
            // 
            // incomeDateLabel
            // 
            incomeDateLabel.AutoSize = true;
            incomeDateLabel.Location = new Point(55, 102);
            incomeDateLabel.Name = "incomeDateLabel";
            incomeDateLabel.Size = new Size(64, 32);
            incomeDateLabel.TabIndex = 15;
            incomeDateLabel.Text = "Date";
            // 
            // incomeMonthCalendar
            // 
            incomeMonthCalendar.Location = new Point(193, 91);
            incomeMonthCalendar.Name = "incomeMonthCalendar";
            incomeMonthCalendar.TabIndex = 14;
            // 
            // addIncomeBtn
            // 
            addIncomeBtn.Location = new Point(66, 445);
            addIncomeBtn.Name = "addIncomeBtn";
            addIncomeBtn.Size = new Size(110, 46);
            addIncomeBtn.TabIndex = 13;
            addIncomeBtn.Text = "Add";
            addIncomeBtn.UseVisualStyleBackColor = true;
            addIncomeBtn.Click += addIncomeBtn_Click;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(66, 375);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(110, 32);
            categoryLabel.TabIndex = 12;
            categoryLabel.Text = "Category";
            // 
            // incomeCategoiresComboBox
            // 
            incomeCategoiresComboBox.FormattingEnabled = true;
            incomeCategoiresComboBox.Location = new Point(197, 372);
            incomeCategoiresComboBox.Name = "incomeCategoiresComboBox";
            incomeCategoiresComboBox.Size = new Size(223, 40);
            incomeCategoiresComboBox.TabIndex = 11;
            // 
            // incomeAmountTextBox
            // 
            incomeAmountTextBox.Location = new Point(193, 295);
            incomeAmountTextBox.Name = "incomeAmountTextBox";
            incomeAmountTextBox.Size = new Size(227, 39);
            incomeAmountTextBox.TabIndex = 10;
            // 
            // incomeAmountLabel
            // 
            incomeAmountLabel.AutoSize = true;
            incomeAmountLabel.Location = new Point(66, 298);
            incomeAmountLabel.Name = "incomeAmountLabel";
            incomeAmountLabel.Size = new Size(100, 32);
            incomeAmountLabel.TabIndex = 9;
            incomeAmountLabel.Text = "Amount";
            // 
            // incomeEntryLabel
            // 
            incomeEntryLabel.AutoSize = true;
            incomeEntryLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            incomeEntryLabel.Location = new Point(35, 19);
            incomeEntryLabel.Name = "incomeEntryLabel";
            incomeEntryLabel.Size = new Size(239, 47);
            incomeEntryLabel.TabIndex = 8;
            incomeEntryLabel.Text = "Income Entry";
            // 
            // IncomeEntry
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 523);
            Controls.Add(incomeDateLabel);
            Controls.Add(incomeMonthCalendar);
            Controls.Add(addIncomeBtn);
            Controls.Add(categoryLabel);
            Controls.Add(incomeCategoiresComboBox);
            Controls.Add(incomeAmountTextBox);
            Controls.Add(incomeAmountLabel);
            Controls.Add(incomeEntryLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "IncomeEntry";
            Text = "IncomeEntry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label incomeDateLabel;
        private MonthCalendar incomeMonthCalendar;
        private Button addIncomeBtn;
        private Label categoryLabel;
        private ComboBox incomeCategoiresComboBox;
        private TextBox incomeAmountTextBox;
        private Label incomeAmountLabel;
        private Label incomeEntryLabel;
    }
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
}