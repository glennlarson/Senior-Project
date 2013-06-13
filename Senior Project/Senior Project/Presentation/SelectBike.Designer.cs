namespace Senior_Project
{
    partial class SelectBike
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectBike));
            this.dgCustBikes = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnNewBike = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustBikes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCustBikes
            // 
            this.dgCustBikes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustBikes.Location = new System.Drawing.Point(12, 12);
            this.dgCustBikes.Name = "dgCustBikes";
            this.dgCustBikes.ReadOnly = true;
            this.dgCustBikes.Size = new System.Drawing.Size(591, 233);
            this.dgCustBikes.TabIndex = 0;
            this.dgCustBikes.Click += new System.EventHandler(this.dgCustBikes_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 253);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnNewBike
            // 
            this.btnNewBike.Location = new System.Drawing.Point(253, 253);
            this.btnNewBike.Name = "btnNewBike";
            this.btnNewBike.Size = new System.Drawing.Size(108, 23);
            this.btnNewBike.TabIndex = 2;
            this.btnNewBike.Text = "New Bike";
            this.btnNewBike.UseVisualStyleBackColor = true;
            this.btnNewBike.Click += new System.EventHandler(this.btnNewBike_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(527, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SelectBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 288);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNewBike);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dgCustBikes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectBike";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Select Customer Bike";
            this.Load += new System.EventHandler(this.SelectBike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustBikes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCustBikes;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnNewBike;
        private System.Windows.Forms.Button btnCancel;
    }
}