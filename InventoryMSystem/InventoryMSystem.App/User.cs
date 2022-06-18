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
    public partial class User : UserControl
    {
        private UserDataRepository UserDataRepo { get; set; }
        private DelegateCollection.RefreshGridView refreshGrid { get; set; }

        public User()
        {
            InitializeComponent();
            this.UserDataRepo = new UserDataRepository();
            DelegateCollection.RefreshGridView re= this.UserPopulateGridView;
            this.refreshGrid = re;
        }
        
        private void UserPopulateGridView(string search = null)
        {
            this.dgvUserData.AutoGenerateColumns = false;
            this.dgvUserData.DataSource = this.UserDataRepo.GetAll(search).ToList();
            this.dgvUserData.ClearSelection();
            this.dgvUserData.Refresh();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            this.UserPopulateGridView();
        }
            
        private bool IsValidTo()
        {
            if(Validation.IsStringValid(this.txtFullName.Text) ||
               Validation.IsStringValid(this.txtUserName.Text) || 
               Validation.IsStringValid(this.txtUserPassword.Text) || 
               Validation.IsStringValid(this.txtRole.Text) || 
               Validation.IsStringValid(this.txtUserPhone.Text))            
               return true;
            
            return false;
        }

        private UserEntity FillEntity()
        {
            if (!this.IsValidTo())
                return null;

            var u = new UserEntity();
           // u.Id = Convert.ToInt32(this.txtId.Text);
            u.FullName = this.txtFullName.Text;
            u.UserName = this.txtUserName.Text;
            u.UserPassword = this.txtUserPassword.Text;
            u.UserPhone = this.txtUserPhone.Text;
            u.Role = this.txtRole.Text;

            return u;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var userObject = this.FillEntity();
                if (userObject == null)
                {
                    MessageBox.Show("Please fill all data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                var complete = this.UserDataRepo.Save(userObject);
                if (complete)
                {
                    MessageBox.Show("User Insert Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserPopulateGridView();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool complete = this.UserDataRepo.Delete(this.dgvUserData.CurrentRow.Cells["UserName"].Value.ToString());
                if (complete)
                {
                    MessageBox.Show("User Delete Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserPopulateGridView();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var userObject = this.FillEntity();
                if (userObject == null)
                {
                    MessageBox.Show("Please fill all data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                var complete = this.UserDataRepo.Edit(userObject);
                if (complete)
                {
                    MessageBox.Show("User Update Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UserPopulateGridView();
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

        private void dgvUserData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.txtId.Text = dgvUserData.SelectedRows[0].Cells[0].Value.ToString();
            this.txtFullName.Text = dgvUserData.SelectedRows[0].Cells[1].Value.ToString();
            this.txtUserName.Text = dgvUserData.SelectedRows[0].Cells[2].Value.ToString();
            this.txtUserPassword.Text = dgvUserData.SelectedRows[0].Cells[3].Value.ToString();
            this.txtUserPhone.Text = dgvUserData.SelectedRows[0].Cells[4].Value.ToString();
            this.txtRole.Text = dgvUserData.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.UserPopulateGridView(this.txtSearch.Text);
        }
    }
}
