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
    public partial class Supplier : UserControl
    {
        private SupplierDataRepository SupplierDataRepo { get; set; }

        public Supplier()
        {
            InitializeComponent();
            this.SupplierDataRepo = new SupplierDataRepository();
        }

        private void SupplierPopulateGridView(string search = null)
        {
            this.dgvSupplierData.AutoGenerateColumns = false;
            this.dgvSupplierData.DataSource = this.SupplierDataRepo.GetAll(search).ToList();
            this.dgvSupplierData.ClearSelection();
            this.dgvSupplierData.Refresh();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            SupplierPopulateGridView();
        }

        private void dgvSupplierData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.txtId.Text = dgvSupplierData.SelectedRows[0].Cells[0].Value.ToString();
            this.txtSupplierName.Text = dgvSupplierData.SelectedRows[0].Cells[1].Value.ToString();
            this.txtSupplierAddress.Text = dgvSupplierData.SelectedRows[0].Cells[2].Value.ToString();
            this.txtSupplierBill.Text = dgvSupplierData.SelectedRows[0].Cells[3].Value.ToString();
            this.txtSupplierPaidAmount.Text = dgvSupplierData.SelectedRows[0].Cells[4].Value.ToString();
        }

        private bool IsValidTo()
        {
            if (Validation.IsStringValid(this.txtSupplierName.Text) ||
               Validation.IsStringValid(this.txtSupplierAddress.Text) ||
               Validation.IsDoubleValid(this.txtSupplierBill.Text) ||
               Validation.IsDoubleValid(this.txtSupplierPaidAmount.Text))
                return true;

            return false;
        }

        private SupplierEntity FillEntity()
        {
            if (!this.IsValidTo())
                return null;

            var u = new SupplierEntity();
            //u.Id = Convert.ToInt32(this.txtId.Text);
            u.SupplierName = this.txtSupplierName.Text;
            u.SupplierAddress = this.txtSupplierAddress.Text;
            u.SupplierBill = Convert.ToDouble(this.txtSupplierBill.Text);
            u.SupplierPaidAmount = Convert.ToDouble(this.txtSupplierPaidAmount.Text);

            return u;
        }

        private void btnSAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var supplierObject = this.FillEntity();
                if (supplierObject == null)
                {
                    MessageBox.Show("Please fill all data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                var complete = this.SupplierDataRepo.Save(supplierObject);
                if (complete)
                {
                    MessageBox.Show("Supplier Insert Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SupplierPopulateGridView();
                }
                else
                {
                    MessageBox.Show("Something went Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Please fill all data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnSEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var supplierObject = this.FillEntity();
                if (supplierObject == null)
                {
                    MessageBox.Show("Please fill all data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                var complete = this.SupplierDataRepo.Edit(supplierObject);
                if (complete)
                {
                    MessageBox.Show("Supplier Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SupplierPopulateGridView();
                }
                else
                {
                    MessageBox.Show("Could Not update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Please fill all data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnSDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool complete = this.SupplierDataRepo.Delete(this.dgvSupplierData.CurrentRow.Cells["SupplierName"].Value.ToString());
                if (complete)
                {
                    MessageBox.Show("Supplier Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SupplierPopulateGridView();
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
    }
}
