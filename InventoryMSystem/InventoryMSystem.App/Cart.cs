using InventoryMSystem.Entity;
using InventoryMSystem.Framework;
using InventoryMSystem.Repository;
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
    public partial class Cart : UserControl
    {
        private CartDataRepository cartDataRepo { get; set; }
        private DelegateCollection.RefreshGridView re { get; set; }
        DataTable table = new DataTable();

        private int stock;
        private int id,quantity;
        private double price,bill;
        private double grandTotalBill = 0;
        private string name,catagory;
        public Cart()
        {
            InitializeComponent();
            this.cartDataRepo = new CartDataRepository();
        }

        private void sum()
        {
            int A = 0, B = 0;
            for (A = 0; A < dgvProductData.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dgvProductData.Rows[A].Cells[1].Value);
            }

            this.txtTotalPrice.Text = B.ToString();
        }


        private void FillCategory()
        {
            //List<string> category = new List<string>();
            this.cmbCategoryName.Items.Clear();
            var category = this.cartDataRepo.GetCategory();

            for (int ax = 0; ax < category.Count; ax++)
            {
                this.cmbCategoryName.Items.Add(category[ax]);
            }
        }
        private void CartPopulateGridView(string category = null, string search = null)
        {
            this.dgvProductData.AutoGenerateColumns = false;
            this.dgvProductData.DataSource = this.cartDataRepo.GetAll(category,search).ToList();
            this.dgvProductData.ClearSelection();
            this.dgvProductData.Refresh();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            //dgvProductData.Da
            this.CartPopulateGridView();
            FillCategory();
        }

        private void dgvProductData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtProductName.Text = dgvProductData.SelectedRows[0].Cells[0].Value.ToString();
            this.txtProductPrice.Text = dgvProductData.SelectedRows[0].Cells[1].Value.ToString();

            this.stock = Convert.ToInt32(dgvProductData.SelectedRows[0].Cells[2].Value.ToString());
            this.catagory = dgvProductData.SelectedRows[0].Cells[3].Value.ToString();
            //this.price = Convert.ToDouble(dgvProductData.SelectedRows[0].Cells[4].Value.ToString());

            btnAddCart.Visible = true;
        }

        private void dgvBillGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            this.txtProductName.Text= dgvBillGrid.SelectedRows[0].Cells[1].Value.ToString();
            this.txtQuantity.Text= dgvBillGrid.SelectedRows[0].Cells[2].Value.ToString();
            this.cmbCategoryName.Text = dgvBillGrid.SelectedRows[0].Cells[3].Value.ToString();
            this.txtProductPrice.Text= dgvBillGrid.SelectedRows[0].Cells[5].Value.ToString();


            //this.id = Convert.ToInt32(dgvBillGrid.SelectedRows[0].Cells[0].Value.ToString());
            //this.name =dgvBillGrid.SelectedRows[0].Cells[1].Value.ToString();
            //this.quantity = Convert.ToInt32(dgvBillGrid.SelectedRows[0].Cells[2].Value.ToString());
            //this.catagory = dgvBillGrid.SelectedRows[0].Cells[3].Value.ToString();
            //this.bill = Convert.ToDouble(dgvBillGrid.SelectedRows[0].Cells[4].Value.ToString());

            btnDelete.Visible = true;
            btnSell.Visible = true;
        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CartPopulateGridView(this.cmbCategoryName.Text,null);
        }

        private void txtProductName_TextChanged_1(object sender, EventArgs e)
        {
            this.CartPopulateGridView(this.cmbCategoryName.Text, this.txtProductName.Text);
        }


        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dt = this.dgvBillGrid.CurrentRow.Cells;

            grandTotalBill = grandTotalBill - Convert.ToDouble(this.dgvBillGrid.CurrentRow.Cells["TotalBill"].Value.ToString());
            lblTotalBill.Text = grandTotalBill.ToString();
            Refresh();
            this.dgvBillGrid.Rows.Remove(this.dgvBillGrid.CurrentRow);
            this.dgvBillGrid.Refresh();
            this.dgvBillGrid.ClearSelection();
            //string x = this.dgvBillGrid.CurrentRow.Cells["PName"].Value.ToString();
            // int y= Convert.ToInt32(this.dgvProductData.CurrentRow.Cells["ProductQuantity"].Value.ToString()) - Convert.ToInt32(this.dgvBillGrid.CurrentRow.Cells["OrderQuantity"].Value.ToString());

            //this.cartDataRepo.UpdateQuantirty(x, y);


        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            this.name = this.txtProductName.Text;
            this.quantity = Convert.ToInt32(this.txtQuantity.Text);
            this.price = Convert.ToDouble(this.txtProductPrice.Text);


            if (this.txtQuantity.Text == null)
            {
                MessageBox.Show("Enter The Quantity of Products");
                txtQuantity.Focus();
            }            
            else if (Convert.ToInt32(txtQuantity.Text) > stock)
                MessageBox.Show("No Enough Stock Available");
            else
            {   id = id + 1;
                stock = Convert.ToInt32(txtQuantity.Text);
                dgvBillGrid.Rows.Add(id, name, quantity, catagory, bill, price);

                //int dt = (Convert.ToInt32(this.dgvProductData.CurrentRow.Cells["ProductQuantity"].Value.ToString())- quantity);

                int q= stock - quantity;
                cartDataRepo.UpdateQuantirty(name, (Convert.ToInt32(this.dgvProductData.CurrentRow.Cells["ProductQuantity"].Value.ToString()) - quantity));
                //table.Rows.Add(num, product, qty, uprice, totprice);
                //OrderGv.DataSource = table;
                //flag = 0;
            }
            grandTotalBill = grandTotalBill + bill;
            lblTotalBill.Text = grandTotalBill.ToString();
            Refresh();

        }

        private bool IsValidTo()
        {
            if (Validation.IsIntValid(this.txtQuantity.Text) ||
               Validation.IsStringValid(this.txtProductName.Text) ||
               Validation.IsStringValid(this.cmbCategoryName.Text) ||
               Validation.IsDoubleValid(this.txtProductPrice.Text) ||
               Validation.IsDoubleValid(this.txtTotalPrice.Text))
                return true;

            return false;
        }

        //private CartEntity FillForm(DataGridViewCellCollection dt)
        //{
        //    if (!this.IsValidTo())
        //        return null;

        //    var u = new CartEntity();

        //    u.Id = Convert.ToInt32(dt["SalesId"].Value);
        //    u.ProductName = u.CategoryName = dt["PName"].ToString();
        //    u.Quantity = Convert.ToInt32(dt["OrderQuantity"].Value);
        //    u.Price = Convert.ToDouble(dt["PPrice"].Value);
        //    u.CategoryName = dt["CategoryName"].ToString();
        //    u.TotalBill = Convert.ToDouble(dt["TotalBill"].Value);
        //    u.OrderDate = dt["OrderDate"].ToString();
        //    return u;
        //}

        private CartEntity FillForm()
        {
            //if (!this.IsValidTo())
            //    return null;

            var u = new CartEntity();


            u.ProductName = this.name;
            u.Quantity = this.quantity;
            u.Price = this.price;
            u.TotalBill = grandTotalBill;
            return u;
           
        }


        private void btnSell_Click(object sender, EventArgs e)
        {



            //var cartList = new List<CartEntity>();

            //for (int ax = 0; ax < this.dgvBillGrid.Rows.Count; ax++)
            //{
            //    var objectCart = this.FillForm(this.dgvBillGrid.Rows[ax].Cells);
            //    cartList.Add(objectCart);
            //}
            //var complete = this.cartDataRepo.Add(cartList);

            try
            {
                var userObject = this.FillForm();

                if (userObject == null)
                {
                    MessageBox.Show("Please fill all data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                bool complete = this.cartDataRepo.Add(userObject);
                if (complete)
                {
                    MessageBox.Show("Product Insert Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //this.RefreshGridView(null);
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

        
        private void Refresh()
        {
            this.cmbCategoryName.SelectedIndex = -1;
            this.txtProductName.Clear();
            this.txtProductPrice.Clear();
            this.txtQuantity.Clear();
            this.txtTotalPrice.Clear();
            this.dgvProductData.Refresh();
            this.dgvProductData.ClearSelection();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.cmbCategoryName.SelectedIndex = -1;
            this.txtProductName.Clear();
            this.txtProductPrice.Clear();
            this.txtQuantity.Clear();
            this.txtTotalPrice.Clear();
            this.dgvProductData.Refresh();
            this.dgvProductData.ClearSelection();
        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantity.Text == null)
                {
                    txtTotalPrice.Clear();
                }
                else if (txtProductName.Text == null)
                {
                    MessageBox.Show("Please , Enter Product Name ", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtProductName.Focus();
                }
                else
                {
                    bill = Convert.ToDouble(txtProductPrice.Text) * Convert.ToDouble(txtQuantity.Text);
                    txtTotalPrice.Text = bill.ToString();
                }
            }
            catch (Exception)
            {

            }
        }

    }
}
