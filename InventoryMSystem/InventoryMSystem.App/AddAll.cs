using InventoryMSystem.Entity;
using InventoryMSystem.Framework;
using InventoryMSystem.Repository;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMSystem.App
{
    public partial class AddAll : MetroForm
    {
        private ProductDataRepository productDataRepo { get; set; }
        private DelegateCollection.RefreshGridView RefreshGridView { get; set; }
        private ProductEntity Product { get; set; }

        public AddAll()
        {
            InitializeComponent();
            this.productDataRepo = new ProductDataRepository();
        }

        public AddAll(DelegateCollection.RefreshGridView obj) :this()
        {           
            this.productDataRepo = new ProductDataRepository();
            this.RefreshGridView = obj;
            this.btnEditProduct.Visible = false;
        }

        public AddAll(ProductEntity p, DelegateCollection.RefreshGridView obj) : this()
        {
            try
            {
                this.Product = new ProductEntity();
                this.RefreshGridView = obj;
                this.btnAddProduct.Visible = false;
                this.btnEditProduct.Visible = true;
                if (p == null)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    this.Product = p;
                    this.FillEdit();
                }                
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void FillEdit()
        {
            //this.txtId.Text = this.Product.Id.ToString();
            this.txtProductName.Text = this.Product.ProductName;
            this.cmbCategoryName.Text = Product.CategoryName;
            this.txtProductQuantity.Text = this.Product.ProductQuantity.ToString();
            this.txtProductPrice.Text = this.Product.ProductPrice.ToString();
            this.txtProductUnitPrice.Text = this.Product.ProductUnitPrice.ToString();
            this.cmbSupplierName.Text = this.Product.SupplierName;
        }

        private void FillCategory()
        {
            //List<string> category = new List<string>();
            this.cmbCategoryName.Items.Clear();
            //var category = this.productDataRepo.GetCategory();
            for (int ax = 0; ax < this.productDataRepo.GetCategory().Count; ax++)
            {
                //this.cmbCategoryName.Items.Add(category[ax]);
                this.cmbCategoryName.Items.Add(this.productDataRepo.GetCategory()[ax]);
            }
        }

        private void FillSupplier()
        {
            //List<string> supplier = new List<string>();
            this.cmbSupplierName.Items.Clear();
            var supplier = productDataRepo.GetSupplier();

            for (int ax = 0; ax < supplier.Count; ax++)
            {
                this.cmbSupplierName.Items.Add(supplier[ax]);
            }
        }


        private bool IsValidTo()
        {
            if (Validation.IsStringValid(this.txtProductName.Text) ||
               Validation.IsStringValid(this.cmbCategoryName.Text) ||
               Validation.IsIntValid(this.txtProductQuantity.Text) ||
               Validation.IsDoubleValid(this.txtProductPrice.Text) ||
               Validation.IsDoubleValid(this.txtProductUnitPrice.Text) ||
               Validation.IsStringValid(this.cmbSupplierName.Text))
                return true;

            return false;
        }

        private ProductEntity FillForm()
        {
            if (!this.IsValidTo())
                return null;

            var u = new ProductEntity();
            //u.Id = Convert.ToInt32(this.txtId.Text);
            u.ProductName = this.txtProductName.Text;
            u.CategoryName = this.cmbCategoryName.Text;
            u.ProductQuantity = Convert.ToInt32(this.txtProductQuantity.Text);
            u.ProductPrice = Convert.ToDouble(this.txtProductPrice.Text);
            u.ProductUnitPrice = Convert.ToDouble(this.txtProductUnitPrice.Text);
            u.SupplierName = this.cmbSupplierName.Text;
            return u;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var productObject = this.FillForm();
                if (productObject == null)
                {
                    MessageBox.Show("Please fill all data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                var complete = this.productDataRepo.Add(productObject);
                if (complete)
                {
                    MessageBox.Show("Product Insert Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.RefreshGridView(null);
                }
                else
                {
                    MessageBox.Show("Something went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill all data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var productObject = this.FillForm();
                if (productObject == null)
                {
                    MessageBox.Show("Please fill all data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                var complete = this.productDataRepo.Edit(productObject);
                if (complete)
                {
                    MessageBox.Show("User Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.RefreshGridView(null);
                }
                else
                {
                    MessageBox.Show("Could Not update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill all data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void AddAll_Load(object sender, EventArgs e)
        {
            FillCategory();
            FillSupplier();
        }
    }
}
