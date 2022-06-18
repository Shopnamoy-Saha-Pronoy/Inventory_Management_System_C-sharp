using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryMSystem.Entity;
using InventoryMSystem.Framework;
using InventoryMSystem.Repository;

namespace InventoryMSystem.App
{
    public partial class Product : UserControl
    {
        private ProductDataRepository productDataRepo { get; set; }
        DelegateCollection.RefreshGridView refreshGrid { get; set; }

        public Product()
        {
            InitializeComponent();
            this.productDataRepo = new ProductDataRepository();
        }       

        private void ProductPopulateGridView(string search = null)
        {
            this.dgvProductData.AutoGenerateColumns = false;
            this.dgvProductData.DataSource = this.productDataRepo.GetAll(search).ToList();
            this.dgvProductData.ClearSelection();
            this.dgvProductData.Refresh();            
        }

        private void Product_Load(object sender, EventArgs e)
        {
            ProductPopulateGridView();
        }

        
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            refreshGrid = this.ProductPopulateGridView;
            new AddAll(refreshGrid).Show();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductData.CurrentRow.Selected)
                {
                    var dt = this.dgvProductData.CurrentRow.Cells;
                    var u = new ProductEntity
                    {
                        //Id = Convert.ToInt32(dt["Id"].Value.ToString()),
                        ProductName = dt["ProductName"].Value.ToString(),
                        CategoryName = dt["CategoryName"].Value.ToString(),
                        ProductQuantity = Convert.ToInt32(dt["ProductQuantity"].Value.ToString()),
                        ProductPrice = Convert.ToDouble(dt["ProductPrice"].Value.ToString()),
                        ProductUnitPrice = Convert.ToDouble(dt["ProductUnitPrice"].Value.ToString()),
                        SupplierName = dt["SupplierName"].Value.ToString()
                    };

                    refreshGrid = this.ProductPopulateGridView;
                    new AddAll(u, refreshGrid).Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Select Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
               
        }


        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool complete = this.productDataRepo.Delete(this.dgvProductData.CurrentRow.Cells["ProductName"].Value.ToString());
                if (complete)
                {
                    MessageBox.Show("Product Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ProductPopulateGridView();
                }
                else
                {
                    MessageBox.Show("Something Went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could Not Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.ProductPopulateGridView(this.txtSearch.Text);
        }
    }
}