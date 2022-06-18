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
    public partial class Dashboard : MetroForm
    {
        public Dashboard()
        {
            InitializeComponent();
            if(LoginRole.Role=="user")
            {
                lblUser.Text = "User";
                btnUser.Visible = false;
                plnUser.Visible = false;
            }
            else
                lblUser.Text = "Admin";
        }

        private void LoadPnl(UserControl ob)
        {
            if(this.pnlFullBody.Controls.Count>0)
            {
                this.pnlFullBody.Controls.RemoveAt(0);
            }               
            
            UserControl f = ob as UserControl;
            f.Dock = DockStyle.Fill;
            this.pnlFullBody.Controls.Add(f);
            this.pnlFullBody.Tag = f;
            f.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
                
        private void btnCategory_Click(object sender, EventArgs e)
        {
            LoadPnl(new Categories());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            LoadPnl(new Product());
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            LoadPnl(new Supplier());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            LoadPnl(new User());
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            LoadPnl(new Cart());
        }
    }
}
