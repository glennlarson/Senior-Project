namespace Senior_Project
{
    partial class NewCustomerBike
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCustomerBike));
            this.txtCBikeSerial = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCBikeModel = new System.Windows.Forms.TextBox();
            this.txtCBikeBrand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCBikeSerial
            // 
            this.txtCBikeSerial.Location = new System.Drawing.Point(91, 6);
            this.txtCBikeSerial.Name = "txtCBikeSerial";
            this.txtCBikeSerial.Size = new System.Drawing.Size(187, 20);
            this.txtCBikeSerial.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Serial Number";
            // 
            // txtCBikeModel
            // 
            this.txtCBikeModel.Location = new System.Drawing.Point(91, 58);
            this.txtCBikeModel.Name = "txtCBikeModel";
            this.txtCBikeModel.Size = new System.Drawing.Size(187, 20);
            this.txtCBikeModel.TabIndex = 3;
            // 
            // txtCBikeBrand
            // 
            this.txtCBikeBrand.Location = new System.Drawing.Point(91, 32);
            this.txtCBikeBrand.Name = "txtCBikeBrand";
            this.txtCBikeBrand.Size = new System.Drawing.Size(187, 20);
            this.txtCBikeBrand.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Model";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(11, 28);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 16;
            this.lbl.Text = "Brand";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(203, 93);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(10, 93);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // NewCustomerBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 124);
            this.Controls.Add(this.txtCBikeSerial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCBikeModel);
            this.Controls.Add(this.txtCBikeBrand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewCustomerBike";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Customer Bike";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCBikeSerial;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCBikeModel;
        private System.Windows.Forms.TextBox txtCBikeBrand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
    }
}