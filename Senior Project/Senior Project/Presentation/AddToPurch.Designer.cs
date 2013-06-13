namespace Senior_Project
{
    partial class AddToPurch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToPurch));
            this.dgList = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbProdBike = new System.Windows.Forms.ComboBox();
            this.numbUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // dgList
            // 
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Location = new System.Drawing.Point(12, 36);
            this.dgList.MultiSelect = false;
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.Size = new System.Drawing.Size(914, 273);
            this.dgList.TabIndex = 0;
            this.dgList.SelectionChanged += new System.EventHandler(this.dgList_SelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(82, 322);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(851, 325);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbProdBike
            // 
            this.cbProdBike.FormattingEnabled = true;
            this.cbProdBike.Items.AddRange(new object[] {
            "Bikes",
            "Products"});
            this.cbProdBike.Location = new System.Drawing.Point(12, 9);
            this.cbProdBike.Name = "cbProdBike";
            this.cbProdBike.Size = new System.Drawing.Size(121, 21);
            this.cbProdBike.TabIndex = 3;
            this.cbProdBike.SelectedIndexChanged += new System.EventHandler(this.cbProdBike_SelectedIndexChanged);
            // 
            // numbUpDown
            // 
            this.numbUpDown.Location = new System.Drawing.Point(12, 325);
            this.numbUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numbUpDown.Name = "numbUpDown";
            this.numbUpDown.Size = new System.Drawing.Size(64, 20);
            this.numbUpDown.TabIndex = 5;
            this.numbUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddToPurch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 360);
            this.Controls.Add(this.numbUpDown);
            this.Controls.Add(this.cbProdBike);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddToPurch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Item";
            this.Load += new System.EventHandler(this.AddToPurch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbProdBike;
        private System.Windows.Forms.NumericUpDown numbUpDown;
    }
}