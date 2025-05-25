using ProductLibrary.Interfaces;
using ProductLibrary.Logic;
using ProductLibrary.Models;
using System;
using System.ComponentModel;

namespace ProductInventoryManagement
{
    public partial class ProductDetails : Form, ISaveSupplier
    {
        BindingList<SupplierModel> suppliers = new BindingList<SupplierModel>();
        public ProductDetails()
        {
            InitializeComponent();
            suppliersListBox.DataSource = suppliers;
            suppliersListBox.DisplayMember = nameof(SupplierModel.SupplierFullDetails);

            categoriesComboBox.DataSource = Enum.GetValues(typeof(ProductLibrary.Enums.Categories));
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {


            // Go to Supplier Form
            SupplierDetails entry = new SupplierDetails(this);
            entry.Show();


        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
          
           ProductModel product = new ProductModel
           {
                    ProductName = productNameTextBox.Text,
                    Categories = (ProductLibrary.Enums.Categories)categoriesComboBox.SelectedItem,
                    Price = decimal.TryParse(priceTextBox.Text, out var price) ? price : -1,
                    Suppliers = suppliers.ToList()
           };

            var service = new ProductService();
            if (!service.ValidateProduct(product))
            {
                MessageBox.Show("Please fill in all fields correctly.", "Invalid Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        public void SaveSupplier(SupplierModel supplier)
        {
            suppliers.Add(supplier);
        }

       
    }
}
