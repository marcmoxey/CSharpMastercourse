<<<<<<< HEAD
﻿namespace Budget
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
            totalPerPaycheckLabel = new Label();
            monthlyBudgetLabel = new Label();
            totalPerPaycheckTextBox = new TextBox();
            totalPerMonthLabel = new Label();
            totalPerMonthResultLabel = new Label();
            monthlyExpensesLabel = new Label();
            monthlyExpensesListBox = new ListBox();
            totalIncomeExpensesLabel = new Label();
            totalIncomeExpensesResultLabel = new Label();
            savingsLabel = new Label();
            savingsResultLabel = new Label();
            label1 = new Label();
            totalMonthlyExpensesResultLabel = new Label();
            spendingLabel = new Label();
            billPayLabel = new Label();
            savingsDebtRepaymentLabel = new Label();
            firstCheckLabel = new Label();
            secondCheckLabel = new Label();
            totalLabel = new Label();
            firstCheckBillPayLabel = new Label();
            firstCheckSpendingLabel = new Label();
            secondCheckSpendingLabel = new Label();
            firstCheckSavingsLabel = new Label();
            addMonthlyExpenseBtn = new Button();
            secondCheckBillPayLabel = new Label();
            secondCheckSavingsLabel = new Label();
            spendingTotalResultLabel = new Label();
            billPayTotalResultLabel = new Label();
            savingsTotalResultLabel = new Label();
            monthlyAllowanceLabel = new Label();
            label6 = new Label();
            monthlyAllowanceTextBox = new TextBox();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // totalPerPaycheckLabel
            // 
            totalPerPaycheckLabel.AutoSize = true;
            totalPerPaycheckLabel.Location = new Point(12, 80);
            totalPerPaycheckLabel.Name = "totalPerPaycheckLabel";
            totalPerPaycheckLabel.Size = new Size(209, 32);
            totalPerPaycheckLabel.TabIndex = 0;
            totalPerPaycheckLabel.Text = "Total Per Paycheck";
            // 
            // monthlyBudgetLabel
            // 
            monthlyBudgetLabel.AutoSize = true;
            monthlyBudgetLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monthlyBudgetLabel.Location = new Point(299, 9);
            monthlyBudgetLabel.Name = "monthlyBudgetLabel";
            monthlyBudgetLabel.Size = new Size(290, 47);
            monthlyBudgetLabel.TabIndex = 1;
            monthlyBudgetLabel.Text = "Monthly Budget";
            // 
            // totalPerPaycheckTextBox
            // 
            totalPerPaycheckTextBox.Location = new Point(12, 115);
            totalPerPaycheckTextBox.Name = "totalPerPaycheckTextBox";
            totalPerPaycheckTextBox.Size = new Size(209, 39);
            totalPerPaycheckTextBox.TabIndex = 1;
            totalPerPaycheckTextBox.TextChanged += totalPerPaycheckTextBox_TextChanged;
            // 
            // totalPerMonthLabel
            // 
            totalPerMonthLabel.AutoSize = true;
            totalPerMonthLabel.Location = new Point(613, 53);
            totalPerMonthLabel.Name = "totalPerMonthLabel";
            totalPerMonthLabel.Size = new Size(184, 32);
            totalPerMonthLabel.TabIndex = 0;
            totalPerMonthLabel.Text = "Total Per Month";
            // 
            // totalPerMonthResultLabel
            // 
            totalPerMonthResultLabel.AutoSize = true;
            totalPerMonthResultLabel.Location = new Point(613, 95);
            totalPerMonthResultLabel.Name = "totalPerMonthResultLabel";
            totalPerMonthResultLabel.Size = new Size(71, 32);
            totalPerMonthResultLabel.TabIndex = 3;
            totalPerMonthResultLabel.Text = "$0.00";
            // 
            // monthlyExpensesLabel
            // 
            monthlyExpensesLabel.AutoSize = true;
            monthlyExpensesLabel.Location = new Point(12, 252);
            monthlyExpensesLabel.Name = "monthlyExpensesLabel";
            monthlyExpensesLabel.Size = new Size(208, 32);
            monthlyExpensesLabel.TabIndex = 4;
            monthlyExpensesLabel.Text = "Monthly Expenses";
            // 
            // monthlyExpensesListBox
            // 
            monthlyExpensesListBox.FormattingEnabled = true;
            monthlyExpensesListBox.ItemHeight = 32;
            monthlyExpensesListBox.Location = new Point(12, 287);
            monthlyExpensesListBox.Name = "monthlyExpensesListBox";
            monthlyExpensesListBox.Size = new Size(481, 260);
            monthlyExpensesListBox.TabIndex = 5;
            monthlyExpensesListBox.TabStop = false;
            // 
            // totalIncomeExpensesLabel
            // 
            totalIncomeExpensesLabel.AutoSize = true;
            totalIncomeExpensesLabel.Location = new Point(613, 147);
            totalIncomeExpensesLabel.Name = "totalIncomeExpensesLabel";
            totalIncomeExpensesLabel.Size = new Size(272, 32);
            totalIncomeExpensesLabel.TabIndex = 6;
            totalIncomeExpensesLabel.Text = "Total Income - Expenses";
            // 
            // totalIncomeExpensesResultLabel
            // 
            totalIncomeExpensesResultLabel.AutoSize = true;
            totalIncomeExpensesResultLabel.Location = new Point(613, 179);
            totalIncomeExpensesResultLabel.Name = "totalIncomeExpensesResultLabel";
            totalIncomeExpensesResultLabel.Size = new Size(71, 32);
            totalIncomeExpensesResultLabel.TabIndex = 7;
            totalIncomeExpensesResultLabel.Text = "$0.00";
            // 
            // savingsLabel
            // 
            savingsLabel.AutoSize = true;
            savingsLabel.Location = new Point(613, 220);
            savingsLabel.Name = "savingsLabel";
            savingsLabel.Size = new Size(95, 32);
            savingsLabel.TabIndex = 6;
            savingsLabel.Text = "Savings";
            // 
            // savingsResultLabel
            // 
            savingsResultLabel.AutoSize = true;
            savingsResultLabel.Location = new Point(613, 252);
            savingsResultLabel.Name = "savingsResultLabel";
            savingsResultLabel.Size = new Size(71, 32);
            savingsResultLabel.TabIndex = 7;
            savingsResultLabel.Text = "$0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 574);
            label1.Name = "label1";
            label1.Size = new Size(266, 32);
            label1.TabIndex = 6;
            label1.Text = "Total Monthly Expenses";
            // 
            // totalMonthlyExpensesResultLabel
            // 
            totalMonthlyExpensesResultLabel.AutoSize = true;
            totalMonthlyExpensesResultLabel.Location = new Point(299, 574);
            totalMonthlyExpensesResultLabel.Name = "totalMonthlyExpensesResultLabel";
            totalMonthlyExpensesResultLabel.Size = new Size(71, 32);
            totalMonthlyExpensesResultLabel.TabIndex = 7;
            totalMonthlyExpensesResultLabel.Text = "$0.00";
            // 
            // spendingLabel
            // 
            spendingLabel.AutoSize = true;
            spendingLabel.Location = new Point(613, 438);
            spendingLabel.Name = "spendingLabel";
            spendingLabel.Size = new Size(116, 32);
            spendingLabel.TabIndex = 8;
            spendingLabel.Text = "Spending";
            // 
            // billPayLabel
            // 
            billPayLabel.AutoSize = true;
            billPayLabel.Location = new Point(613, 492);
            billPayLabel.Name = "billPayLabel";
            billPayLabel.Size = new Size(89, 32);
            billPayLabel.TabIndex = 8;
            billPayLabel.Text = "Bill Pay";
            // 
            // savingsDebtRepaymentLabel
            // 
            savingsDebtRepaymentLabel.AutoSize = true;
            savingsDebtRepaymentLabel.Location = new Point(613, 535);
            savingsDebtRepaymentLabel.Name = "savingsDebtRepaymentLabel";
            savingsDebtRepaymentLabel.Size = new Size(290, 32);
            savingsDebtRepaymentLabel.TabIndex = 8;
            savingsDebtRepaymentLabel.Text = "Savings/ Debt Repayment";
            // 
            // firstCheckLabel
            // 
            firstCheckLabel.AutoSize = true;
            firstCheckLabel.Location = new Point(925, 384);
            firstCheckLabel.Name = "firstCheckLabel";
            firstCheckLabel.Size = new Size(117, 32);
            firstCheckLabel.TabIndex = 9;
            firstCheckLabel.Text = "1st Check";
            // 
            // secondCheckLabel
            // 
            secondCheckLabel.AutoSize = true;
            secondCheckLabel.Location = new Point(1062, 384);
            secondCheckLabel.Name = "secondCheckLabel";
            secondCheckLabel.Size = new Size(127, 32);
            secondCheckLabel.TabIndex = 9;
            secondCheckLabel.Text = "2nd Check";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(1207, 384);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(65, 32);
            totalLabel.TabIndex = 9;
            totalLabel.Text = "Total";
            // 
            // firstCheckBillPayLabel
            // 
            firstCheckBillPayLabel.AutoSize = true;
            firstCheckBillPayLabel.Location = new Point(925, 492);
            firstCheckBillPayLabel.Name = "firstCheckBillPayLabel";
            firstCheckBillPayLabel.Size = new Size(71, 32);
            firstCheckBillPayLabel.TabIndex = 7;
            firstCheckBillPayLabel.Text = "$0.00";
            // 
            // firstCheckSpendingLabel
            // 
            firstCheckSpendingLabel.AutoSize = true;
            firstCheckSpendingLabel.Location = new Point(925, 438);
            firstCheckSpendingLabel.Name = "firstCheckSpendingLabel";
            firstCheckSpendingLabel.Size = new Size(71, 32);
            firstCheckSpendingLabel.TabIndex = 7;
            firstCheckSpendingLabel.Text = "$0.00";
            // 
            // secondCheckSpendingLabel
            // 
            secondCheckSpendingLabel.AutoSize = true;
            secondCheckSpendingLabel.Location = new Point(1062, 438);
            secondCheckSpendingLabel.Name = "secondCheckSpendingLabel";
            secondCheckSpendingLabel.Size = new Size(71, 32);
            secondCheckSpendingLabel.TabIndex = 7;
            secondCheckSpendingLabel.Text = "$0.00";
            // 
            // firstCheckSavingsLabel
            // 
            firstCheckSavingsLabel.AutoSize = true;
            firstCheckSavingsLabel.Location = new Point(925, 535);
            firstCheckSavingsLabel.Name = "firstCheckSavingsLabel";
            firstCheckSavingsLabel.Size = new Size(71, 32);
            firstCheckSavingsLabel.TabIndex = 7;
            firstCheckSavingsLabel.Text = "$0.00";
            // 
            // addMonthlyExpenseBtn
            // 
            addMonthlyExpenseBtn.Location = new Point(400, 240);
            addMonthlyExpenseBtn.Name = "addMonthlyExpenseBtn";
            addMonthlyExpenseBtn.Size = new Size(93, 44);
            addMonthlyExpenseBtn.TabIndex = 2;
            addMonthlyExpenseBtn.Text = "Add";
            addMonthlyExpenseBtn.UseVisualStyleBackColor = true;
            addMonthlyExpenseBtn.Click += addMonthlyExpenseBtn_Click;
            // 
            // secondCheckBillPayLabel
            // 
            secondCheckBillPayLabel.AutoSize = true;
            secondCheckBillPayLabel.Location = new Point(1062, 492);
            secondCheckBillPayLabel.Name = "secondCheckBillPayLabel";
            secondCheckBillPayLabel.Size = new Size(71, 32);
            secondCheckBillPayLabel.TabIndex = 7;
            secondCheckBillPayLabel.Text = "$0.00";
            // 
            // secondCheckSavingsLabel
            // 
            secondCheckSavingsLabel.AutoSize = true;
            secondCheckSavingsLabel.Location = new Point(1062, 535);
            secondCheckSavingsLabel.Name = "secondCheckSavingsLabel";
            secondCheckSavingsLabel.Size = new Size(71, 32);
            secondCheckSavingsLabel.TabIndex = 7;
            secondCheckSavingsLabel.Text = "$0.00";
            // 
            // spendingTotalResultLabel
            // 
            spendingTotalResultLabel.AutoSize = true;
            spendingTotalResultLabel.Location = new Point(1207, 438);
            spendingTotalResultLabel.Name = "spendingTotalResultLabel";
            spendingTotalResultLabel.Size = new Size(71, 32);
            spendingTotalResultLabel.TabIndex = 7;
            spendingTotalResultLabel.Text = "$0.00";
            // 
            // billPayTotalResultLabel
            // 
            billPayTotalResultLabel.AutoSize = true;
            billPayTotalResultLabel.Location = new Point(1207, 492);
            billPayTotalResultLabel.Name = "billPayTotalResultLabel";
            billPayTotalResultLabel.Size = new Size(71, 32);
            billPayTotalResultLabel.TabIndex = 7;
            billPayTotalResultLabel.Text = "$0.00";
            // 
            // savingsTotalResultLabel
            // 
            savingsTotalResultLabel.AutoSize = true;
            savingsTotalResultLabel.Location = new Point(1207, 535);
            savingsTotalResultLabel.Name = "savingsTotalResultLabel";
            savingsTotalResultLabel.Size = new Size(71, 32);
            savingsTotalResultLabel.TabIndex = 7;
            savingsTotalResultLabel.Text = "$0.00";
            // 
            // monthlyAllowanceLabel
            // 
            monthlyAllowanceLabel.AutoSize = true;
            monthlyAllowanceLabel.Location = new Point(613, 287);
            monthlyAllowanceLabel.Name = "monthlyAllowanceLabel";
            monthlyAllowanceLabel.Size = new Size(219, 32);
            monthlyAllowanceLabel.TabIndex = 6;
            monthlyAllowanceLabel.Text = "Monthly Allowance";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(613, 319);
            label6.Name = "label6";
            label6.Size = new Size(0, 32);
            label6.TabIndex = 7;
            // 
            // monthlyAllowanceTextBox
            // 
            monthlyAllowanceTextBox.Location = new Point(613, 322);
            monthlyAllowanceTextBox.Name = "monthlyAllowanceTextBox";
            monthlyAllowanceTextBox.Size = new Size(209, 39);
            monthlyAllowanceTextBox.TabIndex = 3;
            monthlyAllowanceTextBox.TextChanged += monthlyAllowanceTextBox_TextChanged;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(1165, 693);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(107, 41);
            saveBtn.TabIndex = 10;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 795);
            Controls.Add(saveBtn);
            Controls.Add(addMonthlyExpenseBtn);
            Controls.Add(totalLabel);
            Controls.Add(secondCheckLabel);
            Controls.Add(firstCheckLabel);
            Controls.Add(savingsDebtRepaymentLabel);
            Controls.Add(billPayLabel);
            Controls.Add(spendingLabel);
            Controls.Add(totalMonthlyExpensesResultLabel);
            Controls.Add(secondCheckSavingsLabel);
            Controls.Add(secondCheckBillPayLabel);
            Controls.Add(savingsTotalResultLabel);
            Controls.Add(billPayTotalResultLabel);
            Controls.Add(spendingTotalResultLabel);
            Controls.Add(secondCheckSpendingLabel);
            Controls.Add(firstCheckSpendingLabel);
            Controls.Add(firstCheckSavingsLabel);
            Controls.Add(firstCheckBillPayLabel);
            Controls.Add(label6);
            Controls.Add(savingsResultLabel);
            Controls.Add(totalIncomeExpensesResultLabel);
            Controls.Add(label1);
            Controls.Add(monthlyAllowanceLabel);
            Controls.Add(savingsLabel);
            Controls.Add(totalIncomeExpensesLabel);
            Controls.Add(monthlyExpensesListBox);
            Controls.Add(monthlyExpensesLabel);
            Controls.Add(totalPerMonthResultLabel);
            Controls.Add(monthlyAllowanceTextBox);
            Controls.Add(totalPerPaycheckTextBox);
            Controls.Add(totalPerMonthLabel);
            Controls.Add(monthlyBudgetLabel);
            Controls.Add(totalPerPaycheckLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Dashbaord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label totalPerPaycheckLabel;
        private Label monthlyBudgetLabel;
        private TextBox totalPerPaycheckTextBox;
        private Label totalPerMonthLabel;
        private Label totalPerMonthResultLabel;
        private Label monthlyExpensesLabel;
        private ListBox monthlyExpensesListBox;
        private Label totalIncomeExpensesLabel;
        private Label totalIncomeExpensesResultLabel;
        private Label savingsLabel;
        private Label savingsResultLabel;
        private Label label1;
        private Label totalMonthlyExpensesResultLabel;
        private Label spendingLabel;
        private Label billPayLabel;
        private Label savingsDebtRepaymentLabel;
        private Label firstCheckLabel;
        private Label secondCheckLabel;
        private Label totalLabel;
        private Label firstCheckBillPayLabel;
        private Label firstCheckSpendingLabel;
        private Label secondCheckSpendingLabel;
        private Label firstCheckSavingsLabel;
        private Button addMonthlyExpenseBtn;
        private Label secondCheckBillPayLabel;
        private Label secondCheckSavingsLabel;
        private Label spendingTotalResultLabel;
        private Label billPayTotalResultLabel;
        private Label savingsTotalResultLabel;
        private Label monthlyAllowanceLabel;
        private Label label6;
        private TextBox monthlyAllowanceTextBox;
        private Button saveBtn;
    }
}
=======
﻿namespace Budget
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
            totalPerPaycheckLabel = new Label();
            monthlyBudgetLabel = new Label();
            totalPerPaycheckTextBox = new TextBox();
            totalPerMonthLabel = new Label();
            totalPerMonthResultLabel = new Label();
            monthlyExpensesLabel = new Label();
            monthlyExpensesListBox = new ListBox();
            totalIncomeExpensesLabel = new Label();
            totalIncomeExpensesResultLabel = new Label();
            savingsLabel = new Label();
            savingsResultLabel = new Label();
            label1 = new Label();
            totalMonthlyExpensesResultLabel = new Label();
            spendingLabel = new Label();
            billPayLabel = new Label();
            savingsDebtRepaymentLabel = new Label();
            firstCheckLabel = new Label();
            secondCheckLabel = new Label();
            totalLabel = new Label();
            firstCheckBillPayLabel = new Label();
            firstCheckSpendingLabel = new Label();
            secondCheckSpendingLabel = new Label();
            firstCheckSavingsLabel = new Label();
            addMonthlyExpenseBtn = new Button();
            secondCheckBillPayLabel = new Label();
            secondCheckSavingsLabel = new Label();
            spendingTotalResultLabel = new Label();
            billPayTotalResultLabel = new Label();
            savingsTotalResultLabel = new Label();
            monthlyAllowanceLabel = new Label();
            label6 = new Label();
            monthlyAllowanceTextBox = new TextBox();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // totalPerPaycheckLabel
            // 
            totalPerPaycheckLabel.AutoSize = true;
            totalPerPaycheckLabel.Location = new Point(12, 80);
            totalPerPaycheckLabel.Name = "totalPerPaycheckLabel";
            totalPerPaycheckLabel.Size = new Size(209, 32);
            totalPerPaycheckLabel.TabIndex = 0;
            totalPerPaycheckLabel.Text = "Total Per Paycheck";
            // 
            // monthlyBudgetLabel
            // 
            monthlyBudgetLabel.AutoSize = true;
            monthlyBudgetLabel.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monthlyBudgetLabel.Location = new Point(299, 9);
            monthlyBudgetLabel.Name = "monthlyBudgetLabel";
            monthlyBudgetLabel.Size = new Size(290, 47);
            monthlyBudgetLabel.TabIndex = 1;
            monthlyBudgetLabel.Text = "Monthly Budget";
            // 
            // totalPerPaycheckTextBox
            // 
            totalPerPaycheckTextBox.Location = new Point(12, 115);
            totalPerPaycheckTextBox.Name = "totalPerPaycheckTextBox";
            totalPerPaycheckTextBox.Size = new Size(209, 39);
            totalPerPaycheckTextBox.TabIndex = 1;
            totalPerPaycheckTextBox.TextChanged += totalPerPaycheckTextBox_TextChanged;
            // 
            // totalPerMonthLabel
            // 
            totalPerMonthLabel.AutoSize = true;
            totalPerMonthLabel.Location = new Point(613, 53);
            totalPerMonthLabel.Name = "totalPerMonthLabel";
            totalPerMonthLabel.Size = new Size(184, 32);
            totalPerMonthLabel.TabIndex = 0;
            totalPerMonthLabel.Text = "Total Per Month";
            // 
            // totalPerMonthResultLabel
            // 
            totalPerMonthResultLabel.AutoSize = true;
            totalPerMonthResultLabel.Location = new Point(613, 95);
            totalPerMonthResultLabel.Name = "totalPerMonthResultLabel";
            totalPerMonthResultLabel.Size = new Size(71, 32);
            totalPerMonthResultLabel.TabIndex = 3;
            totalPerMonthResultLabel.Text = "$0.00";
            // 
            // monthlyExpensesLabel
            // 
            monthlyExpensesLabel.AutoSize = true;
            monthlyExpensesLabel.Location = new Point(12, 252);
            monthlyExpensesLabel.Name = "monthlyExpensesLabel";
            monthlyExpensesLabel.Size = new Size(208, 32);
            monthlyExpensesLabel.TabIndex = 4;
            monthlyExpensesLabel.Text = "Monthly Expenses";
            // 
            // monthlyExpensesListBox
            // 
            monthlyExpensesListBox.FormattingEnabled = true;
            monthlyExpensesListBox.ItemHeight = 32;
            monthlyExpensesListBox.Location = new Point(12, 287);
            monthlyExpensesListBox.Name = "monthlyExpensesListBox";
            monthlyExpensesListBox.Size = new Size(481, 260);
            monthlyExpensesListBox.TabIndex = 5;
            monthlyExpensesListBox.TabStop = false;
            // 
            // totalIncomeExpensesLabel
            // 
            totalIncomeExpensesLabel.AutoSize = true;
            totalIncomeExpensesLabel.Location = new Point(613, 147);
            totalIncomeExpensesLabel.Name = "totalIncomeExpensesLabel";
            totalIncomeExpensesLabel.Size = new Size(272, 32);
            totalIncomeExpensesLabel.TabIndex = 6;
            totalIncomeExpensesLabel.Text = "Total Income - Expenses";
            // 
            // totalIncomeExpensesResultLabel
            // 
            totalIncomeExpensesResultLabel.AutoSize = true;
            totalIncomeExpensesResultLabel.Location = new Point(613, 179);
            totalIncomeExpensesResultLabel.Name = "totalIncomeExpensesResultLabel";
            totalIncomeExpensesResultLabel.Size = new Size(71, 32);
            totalIncomeExpensesResultLabel.TabIndex = 7;
            totalIncomeExpensesResultLabel.Text = "$0.00";
            // 
            // savingsLabel
            // 
            savingsLabel.AutoSize = true;
            savingsLabel.Location = new Point(613, 220);
            savingsLabel.Name = "savingsLabel";
            savingsLabel.Size = new Size(95, 32);
            savingsLabel.TabIndex = 6;
            savingsLabel.Text = "Savings";
            // 
            // savingsResultLabel
            // 
            savingsResultLabel.AutoSize = true;
            savingsResultLabel.Location = new Point(613, 252);
            savingsResultLabel.Name = "savingsResultLabel";
            savingsResultLabel.Size = new Size(71, 32);
            savingsResultLabel.TabIndex = 7;
            savingsResultLabel.Text = "$0.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 574);
            label1.Name = "label1";
            label1.Size = new Size(266, 32);
            label1.TabIndex = 6;
            label1.Text = "Total Monthly Expenses";
            // 
            // totalMonthlyExpensesResultLabel
            // 
            totalMonthlyExpensesResultLabel.AutoSize = true;
            totalMonthlyExpensesResultLabel.Location = new Point(299, 574);
            totalMonthlyExpensesResultLabel.Name = "totalMonthlyExpensesResultLabel";
            totalMonthlyExpensesResultLabel.Size = new Size(71, 32);
            totalMonthlyExpensesResultLabel.TabIndex = 7;
            totalMonthlyExpensesResultLabel.Text = "$0.00";
            // 
            // spendingLabel
            // 
            spendingLabel.AutoSize = true;
            spendingLabel.Location = new Point(613, 438);
            spendingLabel.Name = "spendingLabel";
            spendingLabel.Size = new Size(116, 32);
            spendingLabel.TabIndex = 8;
            spendingLabel.Text = "Spending";
            // 
            // billPayLabel
            // 
            billPayLabel.AutoSize = true;
            billPayLabel.Location = new Point(613, 492);
            billPayLabel.Name = "billPayLabel";
            billPayLabel.Size = new Size(89, 32);
            billPayLabel.TabIndex = 8;
            billPayLabel.Text = "Bill Pay";
            // 
            // savingsDebtRepaymentLabel
            // 
            savingsDebtRepaymentLabel.AutoSize = true;
            savingsDebtRepaymentLabel.Location = new Point(613, 535);
            savingsDebtRepaymentLabel.Name = "savingsDebtRepaymentLabel";
            savingsDebtRepaymentLabel.Size = new Size(290, 32);
            savingsDebtRepaymentLabel.TabIndex = 8;
            savingsDebtRepaymentLabel.Text = "Savings/ Debt Repayment";
            // 
            // firstCheckLabel
            // 
            firstCheckLabel.AutoSize = true;
            firstCheckLabel.Location = new Point(925, 384);
            firstCheckLabel.Name = "firstCheckLabel";
            firstCheckLabel.Size = new Size(117, 32);
            firstCheckLabel.TabIndex = 9;
            firstCheckLabel.Text = "1st Check";
            // 
            // secondCheckLabel
            // 
            secondCheckLabel.AutoSize = true;
            secondCheckLabel.Location = new Point(1062, 384);
            secondCheckLabel.Name = "secondCheckLabel";
            secondCheckLabel.Size = new Size(127, 32);
            secondCheckLabel.TabIndex = 9;
            secondCheckLabel.Text = "2nd Check";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(1207, 384);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(65, 32);
            totalLabel.TabIndex = 9;
            totalLabel.Text = "Total";
            // 
            // firstCheckBillPayLabel
            // 
            firstCheckBillPayLabel.AutoSize = true;
            firstCheckBillPayLabel.Location = new Point(925, 492);
            firstCheckBillPayLabel.Name = "firstCheckBillPayLabel";
            firstCheckBillPayLabel.Size = new Size(71, 32);
            firstCheckBillPayLabel.TabIndex = 7;
            firstCheckBillPayLabel.Text = "$0.00";
            // 
            // firstCheckSpendingLabel
            // 
            firstCheckSpendingLabel.AutoSize = true;
            firstCheckSpendingLabel.Location = new Point(925, 438);
            firstCheckSpendingLabel.Name = "firstCheckSpendingLabel";
            firstCheckSpendingLabel.Size = new Size(71, 32);
            firstCheckSpendingLabel.TabIndex = 7;
            firstCheckSpendingLabel.Text = "$0.00";
            // 
            // secondCheckSpendingLabel
            // 
            secondCheckSpendingLabel.AutoSize = true;
            secondCheckSpendingLabel.Location = new Point(1062, 438);
            secondCheckSpendingLabel.Name = "secondCheckSpendingLabel";
            secondCheckSpendingLabel.Size = new Size(71, 32);
            secondCheckSpendingLabel.TabIndex = 7;
            secondCheckSpendingLabel.Text = "$0.00";
            // 
            // firstCheckSavingsLabel
            // 
            firstCheckSavingsLabel.AutoSize = true;
            firstCheckSavingsLabel.Location = new Point(925, 535);
            firstCheckSavingsLabel.Name = "firstCheckSavingsLabel";
            firstCheckSavingsLabel.Size = new Size(71, 32);
            firstCheckSavingsLabel.TabIndex = 7;
            firstCheckSavingsLabel.Text = "$0.00";
            // 
            // addMonthlyExpenseBtn
            // 
            addMonthlyExpenseBtn.Location = new Point(400, 240);
            addMonthlyExpenseBtn.Name = "addMonthlyExpenseBtn";
            addMonthlyExpenseBtn.Size = new Size(93, 44);
            addMonthlyExpenseBtn.TabIndex = 2;
            addMonthlyExpenseBtn.Text = "Add";
            addMonthlyExpenseBtn.UseVisualStyleBackColor = true;
            addMonthlyExpenseBtn.Click += addMonthlyExpenseBtn_Click;
            // 
            // secondCheckBillPayLabel
            // 
            secondCheckBillPayLabel.AutoSize = true;
            secondCheckBillPayLabel.Location = new Point(1062, 492);
            secondCheckBillPayLabel.Name = "secondCheckBillPayLabel";
            secondCheckBillPayLabel.Size = new Size(71, 32);
            secondCheckBillPayLabel.TabIndex = 7;
            secondCheckBillPayLabel.Text = "$0.00";
            // 
            // secondCheckSavingsLabel
            // 
            secondCheckSavingsLabel.AutoSize = true;
            secondCheckSavingsLabel.Location = new Point(1062, 535);
            secondCheckSavingsLabel.Name = "secondCheckSavingsLabel";
            secondCheckSavingsLabel.Size = new Size(71, 32);
            secondCheckSavingsLabel.TabIndex = 7;
            secondCheckSavingsLabel.Text = "$0.00";
            // 
            // spendingTotalResultLabel
            // 
            spendingTotalResultLabel.AutoSize = true;
            spendingTotalResultLabel.Location = new Point(1207, 438);
            spendingTotalResultLabel.Name = "spendingTotalResultLabel";
            spendingTotalResultLabel.Size = new Size(71, 32);
            spendingTotalResultLabel.TabIndex = 7;
            spendingTotalResultLabel.Text = "$0.00";
            // 
            // billPayTotalResultLabel
            // 
            billPayTotalResultLabel.AutoSize = true;
            billPayTotalResultLabel.Location = new Point(1207, 492);
            billPayTotalResultLabel.Name = "billPayTotalResultLabel";
            billPayTotalResultLabel.Size = new Size(71, 32);
            billPayTotalResultLabel.TabIndex = 7;
            billPayTotalResultLabel.Text = "$0.00";
            // 
            // savingsTotalResultLabel
            // 
            savingsTotalResultLabel.AutoSize = true;
            savingsTotalResultLabel.Location = new Point(1207, 535);
            savingsTotalResultLabel.Name = "savingsTotalResultLabel";
            savingsTotalResultLabel.Size = new Size(71, 32);
            savingsTotalResultLabel.TabIndex = 7;
            savingsTotalResultLabel.Text = "$0.00";
            // 
            // monthlyAllowanceLabel
            // 
            monthlyAllowanceLabel.AutoSize = true;
            monthlyAllowanceLabel.Location = new Point(613, 287);
            monthlyAllowanceLabel.Name = "monthlyAllowanceLabel";
            monthlyAllowanceLabel.Size = new Size(219, 32);
            monthlyAllowanceLabel.TabIndex = 6;
            monthlyAllowanceLabel.Text = "Monthly Allowance";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(613, 319);
            label6.Name = "label6";
            label6.Size = new Size(0, 32);
            label6.TabIndex = 7;
            // 
            // monthlyAllowanceTextBox
            // 
            monthlyAllowanceTextBox.Location = new Point(613, 322);
            monthlyAllowanceTextBox.Name = "monthlyAllowanceTextBox";
            monthlyAllowanceTextBox.Size = new Size(209, 39);
            monthlyAllowanceTextBox.TabIndex = 3;
            monthlyAllowanceTextBox.TextChanged += monthlyAllowanceTextBox_TextChanged;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(1165, 693);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(107, 41);
            saveBtn.TabIndex = 10;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 795);
            Controls.Add(saveBtn);
            Controls.Add(addMonthlyExpenseBtn);
            Controls.Add(totalLabel);
            Controls.Add(secondCheckLabel);
            Controls.Add(firstCheckLabel);
            Controls.Add(savingsDebtRepaymentLabel);
            Controls.Add(billPayLabel);
            Controls.Add(spendingLabel);
            Controls.Add(totalMonthlyExpensesResultLabel);
            Controls.Add(secondCheckSavingsLabel);
            Controls.Add(secondCheckBillPayLabel);
            Controls.Add(savingsTotalResultLabel);
            Controls.Add(billPayTotalResultLabel);
            Controls.Add(spendingTotalResultLabel);
            Controls.Add(secondCheckSpendingLabel);
            Controls.Add(firstCheckSpendingLabel);
            Controls.Add(firstCheckSavingsLabel);
            Controls.Add(firstCheckBillPayLabel);
            Controls.Add(label6);
            Controls.Add(savingsResultLabel);
            Controls.Add(totalIncomeExpensesResultLabel);
            Controls.Add(label1);
            Controls.Add(monthlyAllowanceLabel);
            Controls.Add(savingsLabel);
            Controls.Add(totalIncomeExpensesLabel);
            Controls.Add(monthlyExpensesListBox);
            Controls.Add(monthlyExpensesLabel);
            Controls.Add(totalPerMonthResultLabel);
            Controls.Add(monthlyAllowanceTextBox);
            Controls.Add(totalPerPaycheckTextBox);
            Controls.Add(totalPerMonthLabel);
            Controls.Add(monthlyBudgetLabel);
            Controls.Add(totalPerPaycheckLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboard";
            Text = "Dashbaord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label totalPerPaycheckLabel;
        private Label monthlyBudgetLabel;
        private TextBox totalPerPaycheckTextBox;
        private Label totalPerMonthLabel;
        private Label totalPerMonthResultLabel;
        private Label monthlyExpensesLabel;
        private ListBox monthlyExpensesListBox;
        private Label totalIncomeExpensesLabel;
        private Label totalIncomeExpensesResultLabel;
        private Label savingsLabel;
        private Label savingsResultLabel;
        private Label label1;
        private Label totalMonthlyExpensesResultLabel;
        private Label spendingLabel;
        private Label billPayLabel;
        private Label savingsDebtRepaymentLabel;
        private Label firstCheckLabel;
        private Label secondCheckLabel;
        private Label totalLabel;
        private Label firstCheckBillPayLabel;
        private Label firstCheckSpendingLabel;
        private Label secondCheckSpendingLabel;
        private Label firstCheckSavingsLabel;
        private Button addMonthlyExpenseBtn;
        private Label secondCheckBillPayLabel;
        private Label secondCheckSavingsLabel;
        private Label spendingTotalResultLabel;
        private Label billPayTotalResultLabel;
        private Label savingsTotalResultLabel;
        private Label monthlyAllowanceLabel;
        private Label label6;
        private TextBox monthlyAllowanceTextBox;
        private Button saveBtn;
    }
}
>>>>>>> 9e6ca562ba4b79c549dfe0a1520ee498281f8ad9
