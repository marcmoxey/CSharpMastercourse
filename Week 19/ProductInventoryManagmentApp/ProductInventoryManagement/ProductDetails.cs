using ProductLibrary.Interfaces;
using ProductLibrary.Models;
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
            if (string.IsNullOrWhiteSpace(productNameTextBox.Text) && string.IsNullOrEmpty(categoriesComboBox.Text) && string.IsNullOrWhiteSpace(priceTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(productNameTextBox.Text))
            {
                MessageBox.Show("Please enter a product name.", "Blank Product Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(categoriesComboBox.Text))
            {
                MessageBox.Show("Please select a category.", "Blank Category Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(priceTextBox.Text))
            {
                MessageBox.Show("Please enter a price.", "Blank Price Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                ProductModel product = new ProductModel
                {
                    ProductName = productNameTextBox.Text,
                    Categories = (ProductLibrary.Enums.Categories)categoriesComboBox.SelectedItem,
                    Price = decimal.Parse(priceTextBox.Text),
                    Suppliers = suppliers.ToList()
                };
            }
        }

        public void SaveSupplier(SupplierModel supplier)
        {
            suppliers.Add(supplier);
        }

       
    }
}
