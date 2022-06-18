
namespace InventoryMSystem.App
{
    partial class Supplier
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel18 = new System.Windows.Forms.Panel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSupplierPaidAmount = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSupplierBill = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSupplierAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSDelete = new MetroFramework.Controls.MetroButton();
            this.btnSEdit = new MetroFramework.Controls.MetroButton();
            this.btnSAdd = new MetroFramework.Controls.MetroButton();
            this.txtSupplierName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel15 = new System.Windows.Forms.Panel();
            this.dgvSupplierData = new MetroFramework.Controls.MetroGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierPaidAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Azure;
            this.panel18.Controls.Add(this.materialLabel3);
            this.panel18.Controls.Add(this.materialLabel2);
            this.panel18.Controls.Add(this.materialLabel1);
            this.panel18.Controls.Add(this.materialLabel8);
            this.panel18.Controls.Add(this.txtSupplierPaidAmount);
            this.panel18.Controls.Add(this.txtSupplierBill);
            this.panel18.Controls.Add(this.txtSupplierAddress);
            this.panel18.Controls.Add(this.btnSDelete);
            this.panel18.Controls.Add(this.btnSEdit);
            this.panel18.Controls.Add(this.btnSAdd);
            this.panel18.Controls.Add(this.txtSupplierName);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel18.Location = new System.Drawing.Point(653, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(356, 676);
            this.panel18.TabIndex = 5;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(25, 197);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(90, 23);
            this.materialLabel3.TabIndex = 64;
            this.materialLabel3.Text = "Address";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(48, 250);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(67, 23);
            this.materialLabel2.TabIndex = 63;
            this.materialLabel2.Text = "Bill";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(48, 312);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 23);
            this.materialLabel1.TabIndex = 62;
            this.materialLabel1.Text = "Paid";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Depth = 0;
            this.materialLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(59, 148);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(67, 23);
            this.materialLabel8.TabIndex = 61;
            this.materialLabel8.Text = "Name";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSupplierPaidAmount
            // 
            this.txtSupplierPaidAmount.Depth = 0;
            this.txtSupplierPaidAmount.Hint = "";
            this.txtSupplierPaidAmount.Location = new System.Drawing.Point(153, 307);
            this.txtSupplierPaidAmount.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSupplierPaidAmount.Name = "txtSupplierPaidAmount";
            this.txtSupplierPaidAmount.PasswordChar = '\0';
            this.txtSupplierPaidAmount.SelectedText = "";
            this.txtSupplierPaidAmount.SelectionLength = 0;
            this.txtSupplierPaidAmount.SelectionStart = 0;
            this.txtSupplierPaidAmount.Size = new System.Drawing.Size(171, 28);
            this.txtSupplierPaidAmount.TabIndex = 26;
            this.txtSupplierPaidAmount.UseSystemPasswordChar = false;
            // 
            // txtSupplierBill
            // 
            this.txtSupplierBill.Depth = 0;
            this.txtSupplierBill.Hint = "";
            this.txtSupplierBill.Location = new System.Drawing.Point(153, 250);
            this.txtSupplierBill.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSupplierBill.Name = "txtSupplierBill";
            this.txtSupplierBill.PasswordChar = '\0';
            this.txtSupplierBill.SelectedText = "";
            this.txtSupplierBill.SelectionLength = 0;
            this.txtSupplierBill.SelectionStart = 0;
            this.txtSupplierBill.Size = new System.Drawing.Size(171, 28);
            this.txtSupplierBill.TabIndex = 24;
            this.txtSupplierBill.UseSystemPasswordChar = false;
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Depth = 0;
            this.txtSupplierAddress.Hint = "";
            this.txtSupplierAddress.Location = new System.Drawing.Point(153, 197);
            this.txtSupplierAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.PasswordChar = '\0';
            this.txtSupplierAddress.SelectedText = "";
            this.txtSupplierAddress.SelectionLength = 0;
            this.txtSupplierAddress.SelectionStart = 0;
            this.txtSupplierAddress.Size = new System.Drawing.Size(171, 28);
            this.txtSupplierAddress.TabIndex = 22;
            this.txtSupplierAddress.UseSystemPasswordChar = false;
            // 
            // btnSDelete
            // 
            this.btnSDelete.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSDelete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSDelete.Location = new System.Drawing.Point(236, 371);
            this.btnSDelete.Name = "btnSDelete";
            this.btnSDelete.Size = new System.Drawing.Size(80, 50);
            this.btnSDelete.TabIndex = 20;
            this.btnSDelete.Text = "Delete";
            this.btnSDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSDelete.UseSelectable = true;
            this.btnSDelete.Click += new System.EventHandler(this.btnSDelete_Click);
            // 
            // btnSEdit
            // 
            this.btnSEdit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSEdit.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSEdit.Location = new System.Drawing.Point(133, 371);
            this.btnSEdit.Name = "btnSEdit";
            this.btnSEdit.Size = new System.Drawing.Size(80, 50);
            this.btnSEdit.TabIndex = 19;
            this.btnSEdit.Text = "Edit";
            this.btnSEdit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSEdit.UseSelectable = true;
            this.btnSEdit.Click += new System.EventHandler(this.btnSEdit_Click);
            // 
            // btnSAdd
            // 
            this.btnSAdd.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSAdd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSAdd.Location = new System.Drawing.Point(35, 371);
            this.btnSAdd.Name = "btnSAdd";
            this.btnSAdd.Size = new System.Drawing.Size(80, 50);
            this.btnSAdd.TabIndex = 18;
            this.btnSAdd.Text = "Add";
            this.btnSAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSAdd.UseSelectable = true;
            this.btnSAdd.Click += new System.EventHandler(this.btnSAdd_Click);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Depth = 0;
            this.txtSupplierName.Hint = "";
            this.txtSupplierName.Location = new System.Drawing.Point(153, 143);
            this.txtSupplierName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.PasswordChar = '\0';
            this.txtSupplierName.SelectedText = "";
            this.txtSupplierName.SelectionLength = 0;
            this.txtSupplierName.SelectionStart = 0;
            this.txtSupplierName.Size = new System.Drawing.Size(171, 28);
            this.txtSupplierName.TabIndex = 3;
            this.txtSupplierName.UseSystemPasswordChar = false;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.GhostWhite;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(653, 77);
            this.panel15.TabIndex = 10;
            // 
            // dgvSupplierData
            // 
            this.dgvSupplierData.AllowUserToAddRows = false;
            this.dgvSupplierData.AllowUserToDeleteRows = false;
            this.dgvSupplierData.AllowUserToResizeRows = false;
            this.dgvSupplierData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSupplierData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSupplierData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvSupplierData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplierData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSupplierData.ColumnHeadersHeight = 25;
            this.dgvSupplierData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SupplierName,
            this.SupplierAddress,
            this.SupplierBill,
            this.SupplierPaidAmount});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplierData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSupplierData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupplierData.EnableHeadersVisualStyles = false;
            this.dgvSupplierData.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSupplierData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSupplierData.Location = new System.Drawing.Point(0, 77);
            this.dgvSupplierData.Name = "dgvSupplierData";
            this.dgvSupplierData.ReadOnly = true;
            this.dgvSupplierData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplierData.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSupplierData.RowHeadersVisible = false;
            this.dgvSupplierData.RowHeadersWidth = 51;
            this.dgvSupplierData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSupplierData.RowTemplate.Height = 24;
            this.dgvSupplierData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplierData.Size = new System.Drawing.Size(653, 599);
            this.dgvSupplierData.TabIndex = 11;
            this.dgvSupplierData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplierData_CellContentClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // SupplierName
            // 
            this.SupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.HeaderText = "Name";
            this.SupplierName.MinimumWidth = 6;
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // SupplierAddress
            // 
            this.SupplierAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierAddress.DataPropertyName = "SupplierAddress";
            this.SupplierAddress.HeaderText = "Address";
            this.SupplierAddress.MinimumWidth = 6;
            this.SupplierAddress.Name = "SupplierAddress";
            this.SupplierAddress.ReadOnly = true;
            // 
            // SupplierBill
            // 
            this.SupplierBill.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierBill.DataPropertyName = "SupplierBill";
            this.SupplierBill.HeaderText = "Bill";
            this.SupplierBill.MinimumWidth = 6;
            this.SupplierBill.Name = "SupplierBill";
            this.SupplierBill.ReadOnly = true;
            // 
            // SupplierPaidAmount
            // 
            this.SupplierPaidAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SupplierPaidAmount.DataPropertyName = "SupplierPaidAmount";
            this.SupplierPaidAmount.HeaderText = "Paid Amount";
            this.SupplierPaidAmount.MinimumWidth = 6;
            this.SupplierPaidAmount.Name = "SupplierPaidAmount";
            this.SupplierPaidAmount.ReadOnly = true;
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSupplierData);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel18);
            this.Name = "Supplier";
            this.Size = new System.Drawing.Size(1009, 676);
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplierData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel18;
        private MetroFramework.Controls.MetroButton btnSDelete;
        private MetroFramework.Controls.MetroButton btnSEdit;
        private MetroFramework.Controls.MetroButton btnSAdd;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSupplierName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSupplierBill;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSupplierAddress;
        private System.Windows.Forms.Panel panel15;
        private MetroFramework.Controls.MetroGrid dgvSupplierData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierPaidAmount;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSupplierPaidAmount;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}
