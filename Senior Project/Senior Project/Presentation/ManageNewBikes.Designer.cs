namespace Senior_Project
{
    partial class ManageNewBikes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageNewBikes));
            this.dgBikeList = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblBikeType = new System.Windows.Forms.Label();
            this.lblBikeCost = new System.Windows.Forms.Label();
            this.lblQOH = new System.Windows.Forms.Label();
            this.lblReorder = new System.Windows.Forms.Label();
            this.txtBikeBrand = new System.Windows.Forms.TextBox();
            this.txtBikeModel = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtBikeCost = new System.Windows.Forms.TextBox();
            this.txtQOH = new System.Windows.Forms.NumericUpDown();
            this.txtReOrder = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbBikeDetails = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgBikeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQOH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReOrder)).BeginInit();
            this.gbBikeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgBikeList
            // 
            this.dgBikeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBikeList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgBikeList.Location = new System.Drawing.Point(387, 12);
            this.dgBikeList.MultiSelect = false;
            this.dgBikeList.Name = "dgBikeList";
            this.dgBikeList.ReadOnly = true;
            this.dgBikeList.Size = new System.Drawing.Size(745, 266);
            this.dgBikeList.TabIndex = 20;
            this.dgBikeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBikeList_CellClick);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 255);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(104, 255);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(296, 255);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(6, 40);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(59, 13);
            this.lblBrand.TabIndex = 5;
            this.lblBrand.Text = "Bike Brand";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(6, 67);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(60, 13);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Bike Model";
            // 
            // lblBikeType
            // 
            this.lblBikeType.AutoSize = true;
            this.lblBikeType.Location = new System.Drawing.Point(9, 94);
            this.lblBikeType.Name = "lblBikeType";
            this.lblBikeType.Size = new System.Drawing.Size(31, 13);
            this.lblBikeType.TabIndex = 7;
            this.lblBikeType.Text = "Type";
            // 
            // lblBikeCost
            // 
            this.lblBikeCost.AutoSize = true;
            this.lblBikeCost.Location = new System.Drawing.Point(9, 121);
            this.lblBikeCost.Name = "lblBikeCost";
            this.lblBikeCost.Size = new System.Drawing.Size(52, 13);
            this.lblBikeCost.TabIndex = 8;
            this.lblBikeCost.Text = "Bike Cost";
            // 
            // lblQOH
            // 
            this.lblQOH.AutoSize = true;
            this.lblQOH.Location = new System.Drawing.Point(9, 148);
            this.lblQOH.Name = "lblQOH";
            this.lblQOH.Size = new System.Drawing.Size(92, 13);
            this.lblQOH.TabIndex = 9;
            this.lblQOH.Text = "Quantity On Hand";
            // 
            // lblReorder
            // 
            this.lblReorder.AutoSize = true;
            this.lblReorder.Location = new System.Drawing.Point(9, 176);
            this.lblReorder.Name = "lblReorder";
            this.lblReorder.Size = new System.Drawing.Size(74, 13);
            this.lblReorder.TabIndex = 10;
            this.lblReorder.Text = "ReOrder Point";
            // 
            // txtBikeBrand
            // 
            this.txtBikeBrand.Location = new System.Drawing.Point(109, 37);
            this.txtBikeBrand.Name = "txtBikeBrand";
            this.txtBikeBrand.Size = new System.Drawing.Size(246, 20);
            this.txtBikeBrand.TabIndex = 1;
            // 
            // txtBikeModel
            // 
            this.txtBikeModel.Location = new System.Drawing.Point(109, 64);
            this.txtBikeModel.Name = "txtBikeModel";
            this.txtBikeModel.Size = new System.Drawing.Size(246, 20);
            this.txtBikeModel.TabIndex = 2;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(109, 91);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(246, 20);
            this.txtType.TabIndex = 3;
            // 
            // txtBikeCost
            // 
            this.txtBikeCost.Location = new System.Drawing.Point(109, 118);
            this.txtBikeCost.Name = "txtBikeCost";
            this.txtBikeCost.Size = new System.Drawing.Size(83, 20);
            this.txtBikeCost.TabIndex = 4;
            // 
            // txtQOH
            // 
            this.txtQOH.Location = new System.Drawing.Point(109, 146);
            this.txtQOH.Name = "txtQOH";
            this.txtQOH.Size = new System.Drawing.Size(64, 20);
            this.txtQOH.TabIndex = 5;
            // 
            // txtReOrder
            // 
            this.txtReOrder.Location = new System.Drawing.Point(109, 174);
            this.txtReOrder.Name = "txtReOrder";
            this.txtReOrder.Size = new System.Drawing.Size(64, 20);
            this.txtReOrder.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(202, 255);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbBikeDetails
            // 
            this.gbBikeDetails.Controls.Add(this.lblBrand);
            this.gbBikeDetails.Controls.Add(this.lblModel);
            this.gbBikeDetails.Controls.Add(this.txtReOrder);
            this.gbBikeDetails.Controls.Add(this.lblBikeType);
            this.gbBikeDetails.Controls.Add(this.txtQOH);
            this.gbBikeDetails.Controls.Add(this.lblBikeCost);
            this.gbBikeDetails.Controls.Add(this.txtBikeCost);
            this.gbBikeDetails.Controls.Add(this.lblQOH);
            this.gbBikeDetails.Controls.Add(this.txtType);
            this.gbBikeDetails.Controls.Add(this.lblReorder);
            this.gbBikeDetails.Controls.Add(this.txtBikeModel);
            this.gbBikeDetails.Controls.Add(this.txtBikeBrand);
            this.gbBikeDetails.Location = new System.Drawing.Point(12, 12);
            this.gbBikeDetails.Name = "gbBikeDetails";
            this.gbBikeDetails.Size = new System.Drawing.Size(369, 237);
            this.gbBikeDetails.TabIndex = 19;
            this.gbBikeDetails.TabStop = false;
            this.gbBikeDetails.Text = "Bike Details";
            // 
            // ManageNewBikes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 291);
            this.Controls.Add(this.gbBikeDetails);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgBikeList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManageNewBikes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage New Bikes";
            this.Load += new System.EventHandler(this.ManageNewBikes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBikeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQOH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReOrder)).EndInit();
            this.gbBikeDetails.ResumeLayout(false);
            this.gbBikeDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgBikeList;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblBikeType;
        private System.Windows.Forms.Label lblBikeCost;
        private System.Windows.Forms.Label lblQOH;
        private System.Windows.Forms.Label lblReorder;
        private System.Windows.Forms.TextBox txtBikeBrand;
        private System.Windows.Forms.TextBox txtBikeModel;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtBikeCost;
        private System.Windows.Forms.NumericUpDown txtQOH;
        private System.Windows.Forms.NumericUpDown txtReOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbBikeDetails;
    }
}