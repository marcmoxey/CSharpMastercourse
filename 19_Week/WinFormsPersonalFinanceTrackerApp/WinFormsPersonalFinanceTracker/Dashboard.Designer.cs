<<<<<<< HEAD
﻿namespace WinFormsPersonalFinanceTracker
{
    partial class Dashboard
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
            expenseLabel = new Label();
            expenseTotalLabel = new Label();
            transactionListBox = new ListBox();
            addIncomeBtn = new Button();
            addExpenseBtn = new Button();
            remainingLabel = new Label();
            remainingTotalLabel = new Label();
            budgetTextBox = new TextBox();
            budgetLabel = new Label();
            SuspendLayout();
            // 
            // expenseLabel
            // 
            expenseLabel.AutoSize = true;
            expenseLabel.Location = new Point(72, 77);
            expenseLabel.Name = "expenseLabel";
            expenseLabel.Size = new Size(101, 32);
            expenseLabel.TabIndex = 2;
            expenseLabel.Text = "Expense";
            // 
            // expenseTotalLabel
            // 
            expenseTotalLabel.AutoSize = true;
            expenseTotalLabel.Location = new Point(204, 77);
            expenseTotalLabel.Name = "expenseTotalLabel";
            expenseTotalLabel.Size = new Size(71, 32);
            expenseTotalLabel.TabIndex = 3;
            expenseTotalLabel.Text = "$0.00";
            // 
            // transactionListBox
            // 
            transactionListBox.FormattingEnabled = true;
            transactionListBox.ItemHeight = 32;
            transactionListBox.Location = new Point(71, 141);
            transactionListBox.Name = "transactionListBox";
            transactionListBox.Size = new Size(401, 324);
            transactionListBox.TabIndex = 4;
            // 
            // addIncomeBtn
            // 
            addIncomeBtn.Location = new Point(73, 550);
            addIncomeBtn.Name = "addIncomeBtn";
            addIncomeBtn.Size = new Size(117, 45);
            addIncomeBtn.TabIndex = 5;
            addIncomeBtn.Text = "Income";
            addIncomeBtn.UseVisualStyleBackColor = true;
            addIncomeBtn.Click += addIncomeBtn_Click;
            // 
            // addExpenseBtn
            // 
            addExpenseBtn.Location = new Point(328, 550);
            addExpenseBtn.Name = "addExpenseBtn";
            addExpenseBtn.Size = new Size(121, 44);
            addExpenseBtn.TabIndex = 6;
            addExpenseBtn.Text = "Expense";
            addExpenseBtn.UseVisualStyleBackColor = true;
            addExpenseBtn.Click += addExpenseBtn_Click;
            // 
            // remainingLabel
            // 
            remainingLabel.AutoSize = true;
            remainingLabel.Location = new Point(73, 490);
            remainingLabel.Name = "remainingLabel";
            remainingLabel.Size = new Size(127, 32);
            remainingLabel.TabIndex = 7;
            remainingLabel.Text = "Remaining";
            // 
            // remainingTotalLabel
            // 
            remainingTotalLabel.AutoSize = true;
            remainingTotalLabel.Location = new Point(328, 490);
            remainingTotalLabel.Name = "remainingTotalLabel";
            remainingTotalLabel.Size = new Size(71, 32);
            remainingTotalLabel.TabIndex = 3;
            remainingTotalLabel.Text = "$0.00";
            // 
            // budgetTextBox
            // 
            budgetTextBox.Location = new Point(204, 23);
            budgetTextBox.Name = "budgetTextBox";
            budgetTextBox.Size = new Size(184, 39);
            budgetTextBox.TabIndex = 11;
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Location = new Point(77, 26);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new Size(91, 32);
            budgetLabel.TabIndex = 10;
            budgetLabel.Text = "Budget";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 618);
            Controls.Add(budgetTextBox);
            Controls.Add(budgetLabel);
            Controls.Add(remainingLabel);
            Controls.Add(addExpenseBtn);
            Controls.Add(addIncomeBtn);
            Controls.Add(transactionListBox);
            Controls.Add(remainingTotalLabel);
            Controls.Add(expenseTotalLabel);
            Controls.Add(expenseLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label expenseLabel;
        private Label expenseTotalLabel;
        private ListBox transactionListBox;
        private Button addIncomeBtn;
        private Button addExpenseBtn;
        private Label remainingLabel;
        private Label remainingTotalLabel;
        private TextBox budgetTextBox;
        private Label budgetLabel;
    }
}
=======
﻿namespace WinFormsPersonalFinanceTracker
{
    partial class Dashboard
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
            expenseLabel = new Label();
            expenseTotalLabel = new Label();
            transactionListBox = new ListBox();
            addIncomeBtn = new Button();
            addExpenseBtn = new Button();
            remainingLabel = new Label();
            remainingTotalLabel = new Label();
            budgetTextBox = new TextBox();
            budgetLabel = new Label();
            SuspendLayout();
            // 
            // expenseLabel
            // 
            expenseLabel.AutoSize = true;
            expenseLabel.Location = new Point(72, 77);
            expenseLabel.Name = "expenseLabel";
            expenseLabel.Size = new Size(101, 32);
            expenseLabel.TabIndex = 2;
            expenseLabel.Text = "Expense";
            // 
            // expenseTotalLabel
            // 
            expenseTotalLabel.AutoSize = true;
            expenseTotalLabel.Location = new Point(204, 77);
            expenseTotalLabel.Name = "expenseTotalLabel";
            expenseTotalLabel.Size = new Size(71, 32);
            expenseTotalLabel.TabIndex = 3;
            expenseTotalLabel.Text = "$0.00";
            // 
            // transactionListBox
            // 
            transactionListBox.FormattingEnabled = true;
            transactionListBox.ItemHeight = 32;
            transactionListBox.Location = new Point(71, 141);
            transactionListBox.Name = "transactionListBox";
            transactionListBox.Size = new Size(401, 324);
            transactionListBox.TabIndex = 4;
            // 
            // addIncomeBtn
            // 
            addIncomeBtn.Location = new Point(73, 550);
            addIncomeBtn.Name = "addIncomeBtn";
            addIncomeBtn.Size = new Size(117, 45);
            addIncomeBtn.TabIndex = 5;
            addIncomeBtn.Text = "Income";
            addIncomeBtn.UseVisualStyleBackColor = true;
            addIncomeBtn.Click += addIncomeBtn_Click;
            // 
            // addExpenseBtn
            // 
            addExpenseBtn.Location = new Point(328, 550);
            addExpenseBtn.Name = "addExpenseBtn";
            addExpenseBtn.Size = new Size(121, 44);
            addExpenseBtn.TabIndex = 6;
            addExpenseBtn.Text = "Expense";
            addExpenseBtn.UseVisualStyleBackColor = true;
            addExpenseBtn.Click += addExpenseBtn_Click;
            // 
            // remainingLabel
            // 
            remainingLabel.AutoSize = true;
            remainingLabel.Location = new Point(73, 490);
            remainingLabel.Name = "remainingLabel";
            remainingLabel.Size = new Size(127, 32);
            remainingLabel.TabIndex = 7;
            remainingLabel.Text = "Remaining";
            // 
            // remainingTotalLabel
            // 
            remainingTotalLabel.AutoSize = true;
            remainingTotalLabel.Location = new Point(328, 490);
            remainingTotalLabel.Name = "remainingTotalLabel";
            remainingTotalLabel.Size = new Size(71, 32);
            remainingTotalLabel.TabIndex = 3;
            remainingTotalLabel.Text = "$0.00";
            // 
            // budgetTextBox
            // 
            budgetTextBox.Location = new Point(204, 23);
            budgetTextBox.Name = "budgetTextBox";
            budgetTextBox.Size = new Size(184, 39);
            budgetTextBox.TabIndex = 11;
            // 
            // budgetLabel
            // 
            budgetLabel.AutoSize = true;
            budgetLabel.Location = new Point(77, 26);
            budgetLabel.Name = "budgetLabel";
            budgetLabel.Size = new Size(91, 32);
            budgetLabel.TabIndex = 10;
            budgetLabel.Text = "Budget";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 618);
            Controls.Add(budgetTextBox);
            Controls.Add(budgetLabel);
            Controls.Add(remainingLabel);
            Controls.Add(addExpenseBtn);
            Controls.Add(addIncomeBtn);
            Controls.Add(transactionListBox);
            Controls.Add(remainingTotalLabel);
            Controls.Add(expenseTotalLabel);
            Controls.Add(expenseLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label expenseLabel;
        private Label expenseTotalLabel;
        private ListBox transactionListBox;
        private Button addIncomeBtn;
        private Button addExpenseBtn;
        private Label remainingLabel;
        private Label remainingTotalLabel;
        private TextBox budgetTextBox;
        private Label budgetLabel;
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
