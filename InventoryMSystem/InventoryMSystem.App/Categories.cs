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
    public partial class Categories : UserControl
    {
        private CategoryDataRepository catagoryDataRepo { get; set; }

        public Categories()
        {
            InitializeComponent();
            catagoryDataRepo = new CategoryDataRepository();
        }

        private void CategoryPopulateGridView(string search = null)
        {
            this.dgvCategoryData.AutoGenerateColumns = false;
            this.dgvCategoryData.DataSource = this.catagoryDataRepo.GetAll(search).ToList();
            this.dgvCategoryData.ClearSelection();
            this.dgvCategoryData.Refresh();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            this.CategoryPopulateGridView();
        }

        private void dgvCategoryData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.txtId.Text = dgvCategoryData.SelectedRows[0].Cells[0].Value.ToString();
            this.txtCategoryName.Text = dgvCategoryData.SelectedRows[0].Cells[1].Value.ToString();
        }
                
        private bool IsValidTo()
        {
            if (Validation.IsStringValid(this.txtCategoryName.Text))
                return true;

            return false;
        }

        private CategoryEntity FillEntity()
        {
            if (!this.IsValidTo())
                return null;

            var u = new CategoryEntity();
            //u.Id = Convert.ToInt32(this.txtId.Text);
            u.CategoryName = this.txtCategoryName.Text;

            return u;
        }

        private void btnCAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var categotyObject = this.FillEntity();
                if (categotyObject == null)
                {
                    MessageBox.Show("Please fill all data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                var complete = this.catagoryDataRepo.Save(categotyObject);
                if (complete)
                {
                    MessageBox.Show("Category Insert Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CategoryPopulateGridView();
                }
                else
                {
                    MessageBox.Show("Something went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Please fill all data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        //private void btnCEdit_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        var categotyObject = this.FillEntity();
        //        if (categotyObject == null)
        //        {
        //            MessageBox.Show("Please fill all data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        //            return;
        //        }
        //        var complete = this.catagoryDataRepo.Edit(categotyObject);
        //        if (complete)
        //        {
        //            MessageBox.Show("Catagory Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            CategoryPopulateGridView();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Could Not update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (Exception exc)
        //    {
        //        MessageBox.Show("Please fill all data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        //    }
        //}

        private void btnCDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool complete = this.catagoryDataRepo.Delete(this.dgvCategoryData.CurrentRow.Cells["CategoryName"].Value.ToString());
                if (complete)
                {
                    MessageBox.Show("Category Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CategoryPopulateGridView();
                }
                else
                {
                    MessageBox.Show("Could Not Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could Not Delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
    }
}
