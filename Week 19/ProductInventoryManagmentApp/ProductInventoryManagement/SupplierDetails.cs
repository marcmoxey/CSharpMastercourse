using ProductLibrary.Interfaces;
using ProductLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductInventoryManagement
{
    public partial class SupplierDetails : Form
    {
        ISaveSupplier _parent;
        public SupplierDetails(ISaveSupplier parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(supplierNameTextBox.Text) && string.IsNullOrEmpty(contactNumberTextBox.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Blank Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(supplierNameTextBox.Text))
            {
                MessageBox.Show("Please enter a supplier name.", "Blank Supplier Name Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(contactNumberTextBox.Text))
            {
                MessageBox.Show("Please enter a contact number.", "Blank Contact Number Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SupplierModel supplier = new SupplierModel
                {
                    SupplierName = supplierNameTextBox.Text,
                    ContactNumber = contactNumberTextBox.Text
                };

                _parent.SaveSupplier(supplier);
                this.Close();
            }
        }
    }
}
