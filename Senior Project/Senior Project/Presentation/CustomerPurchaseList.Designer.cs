namespace Senior_Project
{
    partial class CustomerPurchaseList
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
            this.dgList = new System.Windows.Forms.DataGridView();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnCloes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgList
            // 
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Location = new System.Drawing.Point(12, 12);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.Size = new System.Drawing.Size(805, 469);
            this.dgList.TabIndex = 0;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(12, 489);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(106, 23);
            this.btnDetails.TabIndex = 1;
            this.btnDetails.Text = "Purchase Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnCloes
            // 
            this.btnCloes.Location = new System.Drawing.Point(742, 489);
            this.btnCloes.Name = "btnCloes";
            this.btnCloes.Size = new System.Drawing.Size(75, 23);
            this.btnCloes.TabIndex = 2;
            this.btnCloes.Text = "Close";
            this.btnCloes.UseVisualStyleBackColor = true;
            this.btnCloes.Click += new System.EventHandler(this.btnCloes_Click);
            // 
            // CustomerPurchaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 524);
            this.Controls.Add(this.btnCloes);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.dgList);
            this.Name = "CustomerPurchaseList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Purchase History";
            this.Load += new System.EventHandler(this.CustomerPurchaseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnCloes;
    }
}