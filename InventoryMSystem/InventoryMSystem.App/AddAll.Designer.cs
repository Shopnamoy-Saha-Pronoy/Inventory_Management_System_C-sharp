
namespace InventoryMSystem.App
{
    partial class AddAll
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbSupplierName = new MetroFramework.Controls.MetroComboBox();
            this.cmbCategoryName = new MetroFramework.Controls.MetroComboBox();
            this.txtProductUnitPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtProductPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtProductQuantity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtProductName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialLabel8);
            this.panel1.Controls.Add(this.btnEditProduct);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.cmbSupplierName);
            this.panel1.Controls.Add(this.cmbCategoryName);
            this.panel1.Controls.Add(this.txtProductUnitPrice);
            this.panel1.Controls.Add(this.txtProductPrice);
            this.panel1.Controls.Add(this.txtProductQuantity);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 489);
            this.panel1.TabIndex = 0;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Depth = 0;
            this.materialLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(39, 51);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(0);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(67, 23);
            this.materialLabel8.TabIndex = 75;
            this.materialLabel8.Text = "Name";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnEditProduct.FlatAppearance.BorderSize = 0;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEditProduct.Location = new System.Drawing.Point(203, 371);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(94, 41);
            this.btnEditProduct.TabIndex = 63;
            this.btnEditProduct.Text = "Edit";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.Depth = 0;
            this.materialLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(12, 104);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(100, 23);
            this.materialLabel7.TabIndex = 74;
            this.materialLabel7.Text = "Category";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddProduct.Location = new System.Drawing.Point(104, 371);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(93, 41);
            this.btnAddProduct.TabIndex = 61;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.Depth = 0;
            this.materialLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(39, 161);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(67, 23);
            this.materialLabel6.TabIndex = 73;
            this.materialLabel6.Text = "Stock";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Depth = 0;
            this.materialLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(39, 211);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(67, 23);
            this.materialLabel5.TabIndex = 72;
            this.materialLabel5.Text = "Price";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Depth = 0;
            this.materialLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(23, 260);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(99, 23);
            this.materialLabel4.TabIndex = 71;
            this.materialLabel4.Text = "Unit Price";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(36, 323);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(86, 23);
            this.materialLabel1.TabIndex = 70;
            this.materialLabel1.Text = "Supplier";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSupplierName
            // 
            this.cmbSupplierName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSupplierName.FormattingEnabled = true;
            this.cmbSupplierName.ItemHeight = 24;
            this.cmbSupplierName.Location = new System.Drawing.Point(152, 316);
            this.cmbSupplierName.Name = "cmbSupplierName";
            this.cmbSupplierName.Size = new System.Drawing.Size(171, 30);
            this.cmbSupplierName.TabIndex = 68;
            this.cmbSupplierName.UseSelectable = true;
            // 
            // cmbCategoryName
            // 
            this.cmbCategoryName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoryName.FormattingEnabled = true;
            this.cmbCategoryName.ItemHeight = 24;
            this.cmbCategoryName.Location = new System.Drawing.Point(152, 104);
            this.cmbCategoryName.Name = "cmbCategoryName";
            this.cmbCategoryName.Size = new System.Drawing.Size(171, 30);
            this.cmbCategoryName.TabIndex = 66;
            this.cmbCategoryName.UseSelectable = true;
            // 
            // txtProductUnitPrice
            // 
            this.txtProductUnitPrice.Depth = 0;
            this.txtProductUnitPrice.Hint = "";
            this.txtProductUnitPrice.Location = new System.Drawing.Point(152, 260);
            this.txtProductUnitPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProductUnitPrice.Name = "txtProductUnitPrice";
            this.txtProductUnitPrice.PasswordChar = '\0';
            this.txtProductUnitPrice.SelectedText = "";
            this.txtProductUnitPrice.SelectionLength = 0;
            this.txtProductUnitPrice.SelectionStart = 0;
            this.txtProductUnitPrice.Size = new System.Drawing.Size(171, 28);
            this.txtProductUnitPrice.TabIndex = 67;
            this.txtProductUnitPrice.UseSystemPasswordChar = false;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Depth = 0;
            this.txtProductPrice.Hint = "";
            this.txtProductPrice.Location = new System.Drawing.Point(152, 211);
            this.txtProductPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.PasswordChar = '\0';
            this.txtProductPrice.SelectedText = "";
            this.txtProductPrice.SelectionLength = 0;
            this.txtProductPrice.SelectionStart = 0;
            this.txtProductPrice.Size = new System.Drawing.Size(171, 28);
            this.txtProductPrice.TabIndex = 65;
            this.txtProductPrice.UseSystemPasswordChar = false;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Depth = 0;
            this.txtProductQuantity.Hint = "";
            this.txtProductQuantity.Location = new System.Drawing.Point(152, 156);
            this.txtProductQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.PasswordChar = '\0';
            this.txtProductQuantity.SelectedText = "";
            this.txtProductQuantity.SelectionLength = 0;
            this.txtProductQuantity.SelectionStart = 0;
            this.txtProductQuantity.Size = new System.Drawing.Size(171, 28);
            this.txtProductQuantity.TabIndex = 64;
            this.txtProductQuantity.UseSystemPasswordChar = false;
            // 
            // txtProductName
            // 
            this.txtProductName.Depth = 0;
            this.txtProductName.Hint = "";
            this.txtProductName.Location = new System.Drawing.Point(152, 46);
            this.txtProductName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.SelectedText = "";
            this.txtProductName.SelectionLength = 0;
            this.txtProductName.SelectionStart = 0;
            this.txtProductName.Size = new System.Drawing.Size(171, 28);
            this.txtProductName.TabIndex = 62;
            this.txtProductName.UseSystemPasswordChar = false;
            // 
            // AddAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 569);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "AddAll";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.TransparencyKey = System.Drawing.Color.LavenderBlush;
            this.Load += new System.EventHandler(this.AddAll_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.Button btnEditProduct;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.Button btnAddProduct;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MetroFramework.Controls.MetroComboBox cmbSupplierName;
        private MetroFramework.Controls.MetroComboBox cmbCategoryName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProductUnitPrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProductPrice;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProductQuantity;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProductName;
    }
}