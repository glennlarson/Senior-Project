namespace Senior_Project
{
    partial class Services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services));
            this.lblServiceID = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.txtServiceType = new System.Windows.Forms.TextBox();
            this.txtServiceDescrip = new System.Windows.Forms.TextBox();
            this.dgServiceList = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtServiceCost = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgServiceList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Location = new System.Drawing.Point(5, 15);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(57, 13);
            this.lblServiceID.TabIndex = 0;
            this.lblServiceID.Text = "Service ID";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Location = new System.Drawing.Point(5, 41);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(74, 13);
            this.lblServiceName.TabIndex = 1;
            this.lblServiceName.Text = "Service Name";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Location = new System.Drawing.Point(5, 67);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(70, 13);
            this.lblServiceType.TabIndex = 2;
            this.lblServiceType.Text = "Service Type";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(5, 93);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(99, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Service Description";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(5, 205);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 5;
            this.lblCost.Text = "Cost";
            // 
            // txtServiceID
            // 
            this.txtServiceID.Enabled = false;
            this.txtServiceID.Location = new System.Drawing.Point(112, 12);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(119, 20);
            this.txtServiceID.TabIndex = 1;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(112, 38);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(234, 20);
            this.txtServiceName.TabIndex = 2;
            // 
            // txtServiceType
            // 
            this.txtServiceType.Location = new System.Drawing.Point(112, 64);
            this.txtServiceType.Name = "txtServiceType";
            this.txtServiceType.Size = new System.Drawing.Size(234, 20);
            this.txtServiceType.TabIndex = 3;
            // 
            // txtServiceDescrip
            // 
            this.txtServiceDescrip.Location = new System.Drawing.Point(112, 90);
            this.txtServiceDescrip.MaxLength = 255;
            this.txtServiceDescrip.Multiline = true;
            this.txtServiceDescrip.Name = "txtServiceDescrip";
            this.txtServiceDescrip.Size = new System.Drawing.Size(234, 106);
            this.txtServiceDescrip.TabIndex = 4;
            // 
            // dgServiceList
            // 
            this.dgServiceList.AllowUserToAddRows = false;
            this.dgServiceList.AllowUserToDeleteRows = false;
            this.dgServiceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgServiceList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgServiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgServiceList.Location = new System.Drawing.Point(352, 12);
            this.dgServiceList.Name = "dgServiceList";
            this.dgServiceList.ReadOnly = true;
            this.dgServiceList.Size = new System.Drawing.Size(781, 244);
            this.dgServiceList.TabIndex = 12;
            this.dgServiceList.Click += new System.EventHandler(this.dgServiceList_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 233);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(96, 233);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(258, 233);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(177, 233);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtServiceCost
            // 
            this.txtServiceCost.Location = new System.Drawing.Point(112, 202);
            this.txtServiceCost.Name = "txtServiceCost";
            this.txtServiceCost.Size = new System.Drawing.Size(100, 20);
            this.txtServiceCost.TabIndex = 5;
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 270);
            this.Controls.Add(this.txtServiceCost);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgServiceList);
            this.Controls.Add(this.txtServiceDescrip);
            this.Controls.Add(this.txtServiceType);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.txtServiceID);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.lblServiceName);
            this.Controls.Add(this.lblServiceID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Services";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Services";
            this.Load += new System.EventHandler(this.Services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgServiceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.TextBox txtServiceType;
        private System.Windows.Forms.TextBox txtServiceDescrip;
        private System.Windows.Forms.DataGridView dgServiceList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MaskedTextBox txtServiceCost;
    }
}