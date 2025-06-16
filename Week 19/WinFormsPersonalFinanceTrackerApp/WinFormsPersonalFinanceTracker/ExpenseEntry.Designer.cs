<<<<<<< HEAD
﻿namespace WinFormsPersonalFinanceTracker
{
    partial class ExpenseEntry
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
            expenseEntryLabel = new Label();
            expenseAmountLabel = new Label();
            expenseAmountTextBox = new TextBox();
            expenseCategoiresComboBox = new ComboBox();
            expenseCategoryLabel = new Label();
            addExpenseBtn = new Button();
            expenseMonthCalendar = new MonthCalendar();
            expenseDateLabel = new Label();
            SuspendLayout();
            // 
            // expenseEntryLabel
            // 
            expenseEntryLabel.AutoSize = true;
            expenseEntryLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            expenseEntryLabel.Location = new Point(24, 9);
            expenseEntryLabel.Name = "expenseEntryLabel";
            expenseEntryLabel.Size = new Size(252, 47);
            expenseEntryLabel.TabIndex = 0;
            expenseEntryLabel.Text = "Expense Entry";
            // 
            // expenseAmountLabel
            // 
            expenseAmountLabel.AutoSize = true;
            expenseAmountLabel.Location = new Point(55, 288);
            expenseAmountLabel.Name = "expenseAmountLabel";
            expenseAmountLabel.Size = new Size(100, 32);
            expenseAmountLabel.TabIndex = 1;
            expenseAmountLabel.Text = "Amount";
            // 
            // expenseAmountTextBox
            // 
            expenseAmountTextBox.Location = new Point(182, 285);
            expenseAmountTextBox.Name = "expenseAmountTextBox";
            expenseAmountTextBox.Size = new Size(227, 39);
            expenseAmountTextBox.TabIndex = 2;
            // 
            // expenseCategoiresComboBox
            // 
            expenseCategoiresComboBox.FormattingEnabled = true;
            expenseCategoiresComboBox.Location = new Point(186, 362);
            expenseCategoiresComboBox.Name = "expenseCategoiresComboBox";
            expenseCategoiresComboBox.Size = new Size(223, 40);
            expenseCategoiresComboBox.TabIndex = 3;
            // 
            // expenseCategoryLabel
            // 
            expenseCategoryLabel.AutoSize = true;
            expenseCategoryLabel.Location = new Point(55, 365);
            expenseCategoryLabel.Name = "expenseCategoryLabel";
            expenseCategoryLabel.Size = new Size(110, 32);
            expenseCategoryLabel.TabIndex = 4;
            expenseCategoryLabel.Text = "Category";
            // 
            // addExpenseBtn
            // 
            addExpenseBtn.Location = new Point(55, 435);
            addExpenseBtn.Name = "addExpenseBtn";
            addExpenseBtn.Size = new Size(110, 46);
            addExpenseBtn.TabIndex = 5;
            addExpenseBtn.Text = "Add";
            addExpenseBtn.UseVisualStyleBackColor = true;
            addExpenseBtn.Click += addExpenseBtn_Click;
            // 
            // expenseMonthCalendar
            // 
            expenseMonthCalendar.Location = new Point(182, 81);
            expenseMonthCalendar.Name = "expenseMonthCalendar";
            expenseMonthCalendar.TabIndex = 6;
            // 
            // expenseDateLabel
            // 
            expenseDateLabel.AutoSize = true;
            expenseDateLabel.Location = new Point(44, 92);
            expenseDateLabel.Name = "expenseDateLabel";
            expenseDateLabel.Size = new Size(64, 32);
            expenseDateLabel.TabIndex = 7;
            expenseDateLabel.Text = "Date";
            // 
            // ExpenseEntry
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 513);
            Controls.Add(expenseDateLabel);
            Controls.Add(expenseMonthCalendar);
            Controls.Add(addExpenseBtn);
            Controls.Add(expenseCategoryLabel);
            Controls.Add(expenseCategoiresComboBox);
            Controls.Add(expenseAmountTextBox);
            Controls.Add(expenseAmountLabel);
            Controls.Add(expenseEntryLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "ExpenseEntry";
            Text = "ExpenseEntry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label expenseEntryLabel;
        private Label expenseAmountLabel;
        private TextBox expenseAmountTextBox;
        private ComboBox expenseCategoiresComboBox;
        private Label expenseCategoryLabel;
        private Button addExpenseBtn;
        private MonthCalendar expenseMonthCalendar;
        private Label expenseDateLabel;
    }
=======
﻿namespace WinFormsPersonalFinanceTracker
{
    partial class ExpenseEntry
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
            expenseEntryLabel = new Label();
            expenseAmountLabel = new Label();
            expenseAmountTextBox = new TextBox();
            expenseCategoiresComboBox = new ComboBox();
            expenseCategoryLabel = new Label();
            addExpenseBtn = new Button();
            expenseMonthCalendar = new MonthCalendar();
            expenseDateLabel = new Label();
            SuspendLayout();
            // 
            // expenseEntryLabel
            // 
            expenseEntryLabel.AutoSize = true;
            expenseEntryLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            expenseEntryLabel.Location = new Point(24, 9);
            expenseEntryLabel.Name = "expenseEntryLabel";
            expenseEntryLabel.Size = new Size(252, 47);
            expenseEntryLabel.TabIndex = 0;
            expenseEntryLabel.Text = "Expense Entry";
            // 
            // expenseAmountLabel
            // 
            expenseAmountLabel.AutoSize = true;
            expenseAmountLabel.Location = new Point(55, 288);
            expenseAmountLabel.Name = "expenseAmountLabel";
            expenseAmountLabel.Size = new Size(100, 32);
            expenseAmountLabel.TabIndex = 1;
            expenseAmountLabel.Text = "Amount";
            // 
            // expenseAmountTextBox
            // 
            expenseAmountTextBox.Location = new Point(182, 285);
            expenseAmountTextBox.Name = "expenseAmountTextBox";
            expenseAmountTextBox.Size = new Size(227, 39);
            expenseAmountTextBox.TabIndex = 2;
            // 
            // expenseCategoiresComboBox
            // 
            expenseCategoiresComboBox.FormattingEnabled = true;
            expenseCategoiresComboBox.Location = new Point(186, 362);
            expenseCategoiresComboBox.Name = "expenseCategoiresComboBox";
            expenseCategoiresComboBox.Size = new Size(223, 40);
            expenseCategoiresComboBox.TabIndex = 3;
            // 
            // expenseCategoryLabel
            // 
            expenseCategoryLabel.AutoSize = true;
            expenseCategoryLabel.Location = new Point(55, 365);
            expenseCategoryLabel.Name = "expenseCategoryLabel";
            expenseCategoryLabel.Size = new Size(110, 32);
            expenseCategoryLabel.TabIndex = 4;
            expenseCategoryLabel.Text = "Category";
            // 
            // addExpenseBtn
            // 
            addExpenseBtn.Location = new Point(55, 435);
            addExpenseBtn.Name = "addExpenseBtn";
            addExpenseBtn.Size = new Size(110, 46);
            addExpenseBtn.TabIndex = 5;
            addExpenseBtn.Text = "Add";
            addExpenseBtn.UseVisualStyleBackColor = true;
            addExpenseBtn.Click += addExpenseBtn_Click;
            // 
            // expenseMonthCalendar
            // 
            expenseMonthCalendar.Location = new Point(182, 81);
            expenseMonthCalendar.Name = "expenseMonthCalendar";
            expenseMonthCalendar.TabIndex = 6;
            // 
            // expenseDateLabel
            // 
            expenseDateLabel.AutoSize = true;
            expenseDateLabel.Location = new Point(44, 92);
            expenseDateLabel.Name = "expenseDateLabel";
            expenseDateLabel.Size = new Size(64, 32);
            expenseDateLabel.TabIndex = 7;
            expenseDateLabel.Text = "Date";
            // 
            // ExpenseEntry
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 513);
            Controls.Add(expenseDateLabel);
            Controls.Add(expenseMonthCalendar);
            Controls.Add(addExpenseBtn);
            Controls.Add(expenseCategoryLabel);
            Controls.Add(expenseCategoiresComboBox);
            Controls.Add(expenseAmountTextBox);
            Controls.Add(expenseAmountLabel);
            Controls.Add(expenseEntryLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "ExpenseEntry";
            Text = "ExpenseEntry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label expenseEntryLabel;
        private Label expenseAmountLabel;
        private TextBox expenseAmountTextBox;
        private ComboBox expenseCategoiresComboBox;
        private Label expenseCategoryLabel;
        private Button addExpenseBtn;
        private MonthCalendar expenseMonthCalendar;
        private Label expenseDateLabel;
    }
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
}