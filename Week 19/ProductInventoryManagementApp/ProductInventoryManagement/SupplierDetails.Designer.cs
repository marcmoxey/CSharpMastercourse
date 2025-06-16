namespace ProductInventoryManagement
{
    partial class SupplierDetails
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
            categoriesLabel = new Label();
            supplierNameTextBox = new TextBox();
            supplierNameLabel = new Label();
            saveBtn = new Button();
            contactNumberTextBox = new TextBox();
            SuspendLayout();
            // 
            // categoriesLabel
            // 
            categoriesLabel.AutoSize = true;
            categoriesLabel.Location = new Point(22, 145);
            categoriesLabel.Name = "categoriesLabel";
            categoriesLabel.Size = new Size(191, 32);
            categoriesLabel.TabIndex = 6;
            categoriesLabel.Text = "Contact Number";
            // 
            // supplierNameTextBox
            // 
            supplierNameTextBox.Location = new Point(219, 70);
            supplierNameTextBox.Name = "supplierNameTextBox";
            supplierNameTextBox.Size = new Size(265, 39);
            supplierNameTextBox.TabIndex = 5;
            // 
            // supplierNameLabel
            // 
            supplierNameLabel.AutoSize = true;
            supplierNameLabel.Location = new Point(40, 70);
            supplierNameLabel.Name = "supplierNameLabel";
            supplierNameLabel.Size = new Size(173, 32);
            supplierNameLabel.TabIndex = 4;
            supplierNameLabel.Text = "Supplier Name";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(166, 235);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(131, 52);
            saveBtn.TabIndex = 10;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // contactNumberTextBox
            // 
            contactNumberTextBox.Location = new Point(219, 142);
            contactNumberTextBox.Name = "contactNumberTextBox";
            contactNumberTextBox.Size = new Size(265, 39);
            contactNumberTextBox.TabIndex = 5;
            // 
            // SupplierDetails
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 376);
            Controls.Add(saveBtn);
            Controls.Add(categoriesLabel);
            Controls.Add(contactNumberTextBox);
            Controls.Add(supplierNameTextBox);
            Controls.Add(supplierNameLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "SupplierDetails";
            Text = "SupplierDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label categoriesLabel;
        private TextBox supplierNameTextBox;
        private Label supplierNameLabel;
        private Button saveBtn;
        private TextBox contactNumberTextBox;
    }
}