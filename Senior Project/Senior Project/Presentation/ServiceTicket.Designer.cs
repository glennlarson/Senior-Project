namespace Senior_Project
{
    partial class BikeService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BikeService));
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustAreaCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustZip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustState = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustAddress2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCustFirstName = new System.Windows.Forms.TextBox();
            this.txtCustAddress1 = new System.Windows.Forms.TextBox();
            this.txtCustLastName = new System.Windows.Forms.TextBox();
            this.gbBike = new System.Windows.Forms.GroupBox();
            this.btnSelectBike = new System.Windows.Forms.Button();
            this.txtCBikeSerialNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCBikeModel = new System.Windows.Forms.TextBox();
            this.txtCBikeBrand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblTicket = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgService = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtServiceDescrip = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEnteredBy = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblServiceCost = new System.Windows.Forms.Label();
            this.gbCustomer.SuspendLayout();
            this.gbBike.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgService)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.lblCustID);
            this.gbCustomer.Controls.Add(this.txtCustPhone);
            this.gbCustomer.Controls.Add(this.label1);
            this.gbCustomer.Controls.Add(this.txtCustAreaCode);
            this.gbCustomer.Controls.Add(this.label2);
            this.gbCustomer.Controls.Add(this.txtCustZip);
            this.gbCustomer.Controls.Add(this.label3);
            this.gbCustomer.Controls.Add(this.txtCustState);
            this.gbCustomer.Controls.Add(this.label4);
            this.gbCustomer.Controls.Add(this.txtCustCity);
            this.gbCustomer.Controls.Add(this.label5);
            this.gbCustomer.Controls.Add(this.txtCustAddress2);
            this.gbCustomer.Controls.Add(this.label6);
            this.gbCustomer.Controls.Add(this.label14);
            this.gbCustomer.Controls.Add(this.txtCustFirstName);
            this.gbCustomer.Controls.Add(this.txtCustAddress1);
            this.gbCustomer.Controls.Add(this.txtCustLastName);
            this.gbCustomer.Location = new System.Drawing.Point(9, 30);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(334, 242);
            this.gbCustomer.TabIndex = 57;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(6, 16);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(57, 13);
            this.lblCustID.TabIndex = 39;
            this.lblCustID.Text = "First Name";
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(119, 197);
            this.txtCustPhone.MaxLength = 7;
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.ReadOnly = true;
            this.txtCustPhone.Size = new System.Drawing.Size(79, 20);
            this.txtCustPhone.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Last Name";
            // 
            // txtCustAreaCode
            // 
            this.txtCustAreaCode.Location = new System.Drawing.Point(79, 197);
            this.txtCustAreaCode.MaxLength = 3;
            this.txtCustAreaCode.Name = "txtCustAreaCode";
            this.txtCustAreaCode.ReadOnly = true;
            this.txtCustAreaCode.Size = new System.Drawing.Size(34, 20);
            this.txtCustAreaCode.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Address 1";
            // 
            // txtCustZip
            // 
            this.txtCustZip.Location = new System.Drawing.Point(79, 171);
            this.txtCustZip.MaxLength = 5;
            this.txtCustZip.Name = "txtCustZip";
            this.txtCustZip.ReadOnly = true;
            this.txtCustZip.Size = new System.Drawing.Size(100, 20);
            this.txtCustZip.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "City";
            // 
            // txtCustState
            // 
            this.txtCustState.Location = new System.Drawing.Point(79, 145);
            this.txtCustState.MaxLength = 2;
            this.txtCustState.Name = "txtCustState";
            this.txtCustState.ReadOnly = true;
            this.txtCustState.Size = new System.Drawing.Size(34, 20);
            this.txtCustState.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "State";
            // 
            // txtCustCity
            // 
            this.txtCustCity.Location = new System.Drawing.Point(79, 119);
            this.txtCustCity.Name = "txtCustCity";
            this.txtCustCity.ReadOnly = true;
            this.txtCustCity.Size = new System.Drawing.Size(250, 20);
            this.txtCustCity.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Zip";
            // 
            // txtCustAddress2
            // 
            this.txtCustAddress2.Location = new System.Drawing.Point(79, 92);
            this.txtCustAddress2.Name = "txtCustAddress2";
            this.txtCustAddress2.ReadOnly = true;
            this.txtCustAddress2.Size = new System.Drawing.Size(250, 20);
            this.txtCustAddress2.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Phone";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "Address 2";
            // 
            // txtCustFirstName
            // 
            this.txtCustFirstName.Location = new System.Drawing.Point(79, 13);
            this.txtCustFirstName.Name = "txtCustFirstName";
            this.txtCustFirstName.ReadOnly = true;
            this.txtCustFirstName.Size = new System.Drawing.Size(143, 20);
            this.txtCustFirstName.TabIndex = 46;
            // 
            // txtCustAddress1
            // 
            this.txtCustAddress1.Location = new System.Drawing.Point(79, 65);
            this.txtCustAddress1.Name = "txtCustAddress1";
            this.txtCustAddress1.ReadOnly = true;
            this.txtCustAddress1.Size = new System.Drawing.Size(250, 20);
            this.txtCustAddress1.TabIndex = 48;
            // 
            // txtCustLastName
            // 
            this.txtCustLastName.Location = new System.Drawing.Point(79, 39);
            this.txtCustLastName.Name = "txtCustLastName";
            this.txtCustLastName.ReadOnly = true;
            this.txtCustLastName.Size = new System.Drawing.Size(143, 20);
            this.txtCustLastName.TabIndex = 47;
            // 
            // gbBike
            // 
            this.gbBike.Controls.Add(this.btnSelectBike);
            this.gbBike.Controls.Add(this.txtCBikeSerialNumber);
            this.gbBike.Controls.Add(this.label9);
            this.gbBike.Controls.Add(this.txtCBikeModel);
            this.gbBike.Controls.Add(this.txtCBikeBrand);
            this.gbBike.Controls.Add(this.label7);
            this.gbBike.Controls.Add(this.lbl);
            this.gbBike.Location = new System.Drawing.Point(349, 30);
            this.gbBike.Name = "gbBike";
            this.gbBike.Size = new System.Drawing.Size(278, 122);
            this.gbBike.TabIndex = 58;
            this.gbBike.TabStop = false;
            this.gbBike.Text = "Bike";
            // 
            // btnSelectBike
            // 
            this.btnSelectBike.Location = new System.Drawing.Point(6, 14);
            this.btnSelectBike.Name = "btnSelectBike";
            this.btnSelectBike.Size = new System.Drawing.Size(99, 23);
            this.btnSelectBike.TabIndex = 8;
            this.btnSelectBike.Text = "Select Bike";
            this.btnSelectBike.UseVisualStyleBackColor = true;
            this.btnSelectBike.Click += new System.EventHandler(this.btnSelectBike_Click);
            // 
            // txtCBikeSerialNumber
            // 
            this.txtCBikeSerialNumber.Location = new System.Drawing.Point(85, 43);
            this.txtCBikeSerialNumber.Name = "txtCBikeSerialNumber";
            this.txtCBikeSerialNumber.ReadOnly = true;
            this.txtCBikeSerialNumber.Size = new System.Drawing.Size(187, 20);
            this.txtCBikeSerialNumber.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Serial Number";
            // 
            // txtCBikeModel
            // 
            this.txtCBikeModel.Location = new System.Drawing.Point(85, 95);
            this.txtCBikeModel.Name = "txtCBikeModel";
            this.txtCBikeModel.ReadOnly = true;
            this.txtCBikeModel.Size = new System.Drawing.Size(187, 20);
            this.txtCBikeModel.TabIndex = 5;
            // 
            // txtCBikeBrand
            // 
            this.txtCBikeBrand.Location = new System.Drawing.Point(85, 69);
            this.txtCBikeBrand.Name = "txtCBikeBrand";
            this.txtCBikeBrand.ReadOnly = true;
            this.txtCBikeBrand.Size = new System.Drawing.Size(187, 20);
            this.txtCBikeBrand.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Model";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(6, 72);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(35, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Brand";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(134, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 66;
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Location = new System.Drawing.Point(12, 9);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(116, 13);
            this.lblTicket.TabIndex = 65;
            this.lblTicket.Text = "Service Ticket Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dgService);
            this.groupBox1.Location = new System.Drawing.Point(349, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 138);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(173, 106);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Service";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Service";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgService
            // 
            this.dgService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgService.Location = new System.Drawing.Point(9, 17);
            this.dgService.Name = "dgService";
            this.dgService.ReadOnly = true;
            this.dgService.Size = new System.Drawing.Size(263, 82);
            this.dgService.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(358, 338);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 68;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtServiceDescrip);
            this.groupBox2.Location = new System.Drawing.Point(9, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 89);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Description";
            // 
            // txtServiceDescrip
            // 
            this.txtServiceDescrip.Location = new System.Drawing.Point(6, 19);
            this.txtServiceDescrip.MaxLength = 255;
            this.txtServiceDescrip.Multiline = true;
            this.txtServiceDescrip.Name = "txtServiceDescrip";
            this.txtServiceDescrip.Size = new System.Drawing.Size(319, 64);
            this.txtServiceDescrip.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(546, 338);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 70;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Entered By";
            // 
            // txtEnteredBy
            // 
            this.txtEnteredBy.Location = new System.Drawing.Point(305, 6);
            this.txtEnteredBy.Name = "txtEnteredBy";
            this.txtEnteredBy.ReadOnly = true;
            this.txtEnteredBy.Size = new System.Drawing.Size(203, 20);
            this.txtEnteredBy.TabIndex = 72;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(482, 302);
            this.txtCost.Name = "txtCost";
            this.txtCost.ReadOnly = true;
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 73;
            // 
            // lblServiceCost
            // 
            this.lblServiceCost.AutoSize = true;
            this.lblServiceCost.Location = new System.Drawing.Point(427, 305);
            this.lblServiceCost.Name = "lblServiceCost";
            this.lblServiceCost.Size = new System.Drawing.Size(31, 13);
            this.lblServiceCost.TabIndex = 74;
            this.lblServiceCost.Text = "Total";
            // 
            // BikeService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 371);
            this.Controls.Add(this.lblServiceCost);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtEnteredBy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.gbBike);
            this.Controls.Add(this.gbCustomer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BikeService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter Service Ticket";
            this.Load += new System.EventHandler(this.BikeService_Load);
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbBike.ResumeLayout(false);
            this.gbBike.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgService)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustAreaCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustZip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustAddress2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCustFirstName;
        private System.Windows.Forms.TextBox txtCustAddress1;
        private System.Windows.Forms.TextBox txtCustLastName;
        private System.Windows.Forms.GroupBox gbBike;
        private System.Windows.Forms.TextBox txtCBikeSerialNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCBikeModel;
        private System.Windows.Forms.TextBox txtCBikeBrand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnSelectBike;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgService;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtServiceDescrip;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEnteredBy;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblServiceCost;
    }
}