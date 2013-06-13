namespace Senior_Project
{
    partial class Manage_Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Products));
            this.dgProducts = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblProdSku = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblProductCost = new System.Windows.Forms.Label();
            this.lblQtyOH = new System.Windows.Forms.Label();
            this.lblReOrder = new System.Windows.Forms.Label();
            this.txtProdSku = new System.Windows.Forms.TextBox();
            this.txtProdType = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtProdCost = new System.Windows.Forms.TextBox();
            this.txtQOH = new System.Windows.Forms.NumericUpDown();
            this.txtReOrder = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQOH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProducts
            // 
            this.dgProducts.AllowUserToAddRows = false;
            this.dgProducts.AllowUserToDeleteRows = false;
            this.dgProducts.AllowUserToOrderColumns = true;
            this.dgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProducts.Location = new System.Drawing.Point(411, 12);
            this.dgProducts.MultiSelect = false;
            this.dgProducts.Name = "dgProducts";
            this.dgProducts.ReadOnly = true;
            this.dgProducts.Size = new System.Drawing.Size(791, 240);
            this.dgProducts.TabIndex = 0;
            this.dgProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProducts_CellClick);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 207);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(107, 207);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 8;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(321, 207);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblProdSku
            // 
            this.lblProdSku.AutoSize = true;
            this.lblProdSku.Location = new System.Drawing.Point(9, 40);
            this.lblProdSku.Name = "lblProdSku";
            this.lblProdSku.Size = new System.Drawing.Size(66, 13);
            this.lblProdSku.TabIndex = 5;
            this.lblProdSku.Text = "Product Sku";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Product Name";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(9, 92);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(71, 13);
            this.lblProductType.TabIndex = 7;
            this.lblProductType.Text = "Product Type";
            // 
            // lblProductCost
            // 
            this.lblProductCost.AutoSize = true;
            this.lblProductCost.Location = new System.Drawing.Point(9, 118);
            this.lblProductCost.Name = "lblProductCost";
            this.lblProductCost.Size = new System.Drawing.Size(68, 13);
            this.lblProductCost.TabIndex = 8;
            this.lblProductCost.Text = "Product Cost";
            // 
            // lblQtyOH
            // 
            this.lblQtyOH.AutoSize = true;
            this.lblQtyOH.Location = new System.Drawing.Point(9, 144);
            this.lblQtyOH.Name = "lblQtyOH";
            this.lblQtyOH.Size = new System.Drawing.Size(92, 13);
            this.lblQtyOH.TabIndex = 9;
            this.lblQtyOH.Text = "Quantity On Hand";
            // 
            // lblReOrder
            // 
            this.lblReOrder.AutoSize = true;
            this.lblReOrder.Location = new System.Drawing.Point(9, 170);
            this.lblReOrder.Name = "lblReOrder";
            this.lblReOrder.Size = new System.Drawing.Size(72, 13);
            this.lblReOrder.TabIndex = 10;
            this.lblReOrder.Text = "Reorder Point";
            // 
            // txtProdSku
            // 
            this.txtProdSku.Location = new System.Drawing.Point(107, 37);
            this.txtProdSku.Name = "txtProdSku";
            this.txtProdSku.Size = new System.Drawing.Size(298, 20);
            this.txtProdSku.TabIndex = 1;
            // 
            // txtProdType
            // 
            this.txtProdType.Location = new System.Drawing.Point(107, 89);
            this.txtProdType.Name = "txtProdType";
            this.txtProdType.Size = new System.Drawing.Size(298, 20);
            this.txtProdType.TabIndex = 3;
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(107, 63);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(298, 20);
            this.txtProdName.TabIndex = 2;
            // 
            // txtProdCost
            // 
            this.txtProdCost.Location = new System.Drawing.Point(107, 115);
            this.txtProdCost.Name = "txtProdCost";
            this.txtProdCost.Size = new System.Drawing.Size(85, 20);
            this.txtProdCost.TabIndex = 4;
            // 
            // txtQOH
            // 
            this.txtQOH.Location = new System.Drawing.Point(107, 142);
            this.txtQOH.Name = "txtQOH";
            this.txtQOH.Size = new System.Drawing.Size(57, 20);
            this.txtQOH.TabIndex = 5;
            // 
            // txtReOrder
            // 
            this.txtReOrder.Location = new System.Drawing.Point(107, 170);
            this.txtReOrder.Name = "txtReOrder";
            this.txtReOrder.Size = new System.Drawing.Size(57, 20);
            this.txtReOrder.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(216, 207);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Manage_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 265);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtReOrder);
            this.Controls.Add(this.txtQOH);
            this.Controls.Add(this.txtProdCost);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.txtProdType);
            this.Controls.Add(this.txtProdSku);
            this.Controls.Add(this.lblReOrder);
            this.Controls.Add(this.lblQtyOH);
            this.Controls.Add(this.lblProductCost);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblProdSku);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manage_Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Products";
            this.Load += new System.EventHandler(this.Manage_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQOH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProducts;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblProdSku;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblProductCost;
        private System.Windows.Forms.Label lblQtyOH;
        private System.Windows.Forms.Label lblReOrder;
        private System.Windows.Forms.TextBox txtProdSku;
        private System.Windows.Forms.TextBox txtProdType;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtProdCost;
        private System.Windows.Forms.NumericUpDown txtQOH;
        private System.Windows.Forms.NumericUpDown txtReOrder;
        private System.Windows.Forms.Button btnClear;
    }
}