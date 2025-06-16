namespace ProductInventoryManagement
{
    partial class ProductDetails
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
            productNameLabel = new Label();
            productNameTextBox = new TextBox();
            categoriesLabel = new Label();
            categoriesComboBox = new ComboBox();
            priceLabel = new Label();
            priceTextBox = new TextBox();
            suppliersListBox = new ListBox();
            suppliersLabel = new Label();
            addProductBtn = new Button();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new Point(26, 46);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(167, 32);
            productNameLabel.TabIndex = 0;
            productNameLabel.Text = "Product Name";
            // 
            // productNameTextBox
            // 
            productNameTextBox.Location = new Point(189, 43);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(265, 39);
            productNameTextBox.TabIndex = 1;
            // 
            // categoriesLabel
            // 
            categoriesLabel.AutoSize = true;
            categoriesLabel.Location = new Point(56, 118);
            categoriesLabel.Name = "categoriesLabel";
            categoriesLabel.Size = new Size(127, 32);
            categoriesLabel.TabIndex = 2;
            categoriesLabel.Text = "Categories";
            // 
            // categoriesComboBox
            // 
            categoriesComboBox.FormattingEnabled = true;
            categoriesComboBox.Location = new Point(189, 118);
            categoriesComboBox.Name = "categoriesComboBox";
            categoriesComboBox.Size = new Size(265, 40);
            categoriesComboBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(118, 200);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(65, 32);
            priceLabel.TabIndex = 4;
            priceLabel.Text = "Price";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(189, 200);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(265, 39);
            priceTextBox.TabIndex = 5;
            // 
            // suppliersListBox
            // 
            suppliersListBox.FormattingEnabled = true;
            suppliersListBox.ItemHeight = 32;
            suppliersListBox.Location = new Point(26, 322);
            suppliersListBox.Name = "suppliersListBox";
            suppliersListBox.Size = new Size(428, 260);
            suppliersListBox.TabIndex = 6;
            // 
            // suppliersLabel
            // 
            suppliersLabel.AutoSize = true;
            suppliersLabel.Location = new Point(26, 287);
            suppliersLabel.Name = "suppliersLabel";
            suppliersLabel.Size = new Size(112, 32);
            suppliersLabel.TabIndex = 7;
            suppliersLabel.Text = "Suppliers";
            // 
            // addProductBtn
            // 
            addProductBtn.Location = new Point(388, 279);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Size = new Size(75, 37);
            addProductBtn.TabIndex = 8;
            addProductBtn.Text = "Add";
            addProductBtn.UseVisualStyleBackColor = true;
            addProductBtn.Click += addProductBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(118, 627);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(131, 52);
            saveBtn.TabIndex = 9;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // ProductDetails
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 728);
            Controls.Add(saveBtn);
            Controls.Add(addProductBtn);
            Controls.Add(suppliersLabel);
            Controls.Add(suppliersListBox);
            Controls.Add(priceTextBox);
            Controls.Add(priceLabel);
            Controls.Add(categoriesComboBox);
            Controls.Add(categoriesLabel);
            Controls.Add(productNameTextBox);
            Controls.Add(productNameLabel);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "ProductDetails";
            Text = "  ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productNameLabel;
        private TextBox productNameTextBox;
        private Label categoriesLabel;
        private ComboBox categoriesComboBox;
        private Label priceLabel;
        private TextBox priceTextBox;
        private ListBox suppliersListBox;
        private Label suppliersLabel;
        private Button addProductBtn;
        private Button saveBtn;
    }
}
