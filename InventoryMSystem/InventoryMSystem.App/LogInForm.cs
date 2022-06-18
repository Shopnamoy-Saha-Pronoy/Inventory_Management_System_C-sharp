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
    public partial class LogInForm : MetroForm
    {
        private UserDataRepository UserDataRepo { get; set; }
        private UserEntity u { get; set; }

        public LogInForm()
        {
            InitializeComponent();
            this.u = new UserEntity();
            this.UserDataRepo = new UserDataRepository();
        }

 
        private void sbShowHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if(this.sbShowHidePassword.Checked)
            {
                this.txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtPassword.UseSystemPasswordChar = true;
            }
        }


        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            u.UserName = this.txtUserId.Text;
            u.UserPassword = this.txtPassword.Text;


            //var objectCart = this.FillEntity();
            try
            {
                if (u == null)
                {
                    MessageBox.Show("Please fill all data", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return;
                }
                this.u = this.UserDataRepo.SearchUser(u);                
                if (this.u != null)
                {
                    LoginRole.Role = this.u.Role;
                    this.Hide();
                    Dashboard d = new Dashboard();
                    d.Show();
                }
                else
                {
                    MessageBox.Show("Invalied username or password", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Something went wrong ","Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
                    
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtUserId.Clear();
            this.txtPassword.Clear();
        }

    }
}
