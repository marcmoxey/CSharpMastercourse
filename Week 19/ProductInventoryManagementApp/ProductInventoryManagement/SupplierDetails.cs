using ProductLibrary.Interfaces;
using ProductLibrary.Logic;
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
            
           SupplierModel supplier = new SupplierModel
           {
               SupplierName = supplierNameTextBox.Text,
               ContactNumber = contactNumberTextBox.Text
           };

            var service = new ProductService();
            if (!service.ValidateSupplier(supplier))
            {
                MessageBox.Show("Please fill in all fields.", "Invalid Supplier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                _parent.SaveSupplier(supplier);
                this.Close();
            
        }
    }
}
