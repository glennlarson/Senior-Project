namespace Senior_Project
{
    partial class EmployeeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeAdmin));
            this.lblEmpNum = new System.Windows.Forms.Label();
            this.lblEmpFirst = new System.Windows.Forms.Label();
            this.lblEmpLast = new System.Windows.Forms.Label();
            this.lblEmpAddress1 = new System.Windows.Forms.Label();
            this.lblEmpAddress2 = new System.Windows.Forms.Label();
            this.lblEmpCity = new System.Windows.Forms.Label();
            this.lblEmpState = new System.Windows.Forms.Label();
            this.lblEmpZip = new System.Windows.Forms.Label();
            this.dgEmployeeList = new System.Windows.Forms.DataGridView();
            this.txtEmpNum = new System.Windows.Forms.TextBox();
            this.txtEmpFirst = new System.Windows.Forms.TextBox();
            this.txtEmpLast = new System.Windows.Forms.TextBox();
            this.txtEmpAddress1 = new System.Windows.Forms.TextBox();
            this.txtEmpAddress2 = new System.Windows.Forms.TextBox();
            this.txtEmpCity = new System.Windows.Forms.TextBox();
            this.lblEmpPhone = new System.Windows.Forms.Label();
            this.lblDash = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpEmpPass = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtEmpPay = new System.Windows.Forms.MaskedTextBox();
            this.txtEmpZip = new System.Windows.Forms.MaskedTextBox();
            this.txtEmpAreaCode = new System.Windows.Forms.MaskedTextBox();
            this.txtEmpPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmpState = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpNum
            // 
            this.lblEmpNum.AutoSize = true;
            this.lblEmpNum.Location = new System.Drawing.Point(13, 9);
            this.lblEmpNum.Name = "lblEmpNum";
            this.lblEmpNum.Size = new System.Drawing.Size(93, 13);
            this.lblEmpNum.TabIndex = 0;
            this.lblEmpNum.Text = "Employee Number";
            // 
            // lblEmpFirst
            // 
            this.lblEmpFirst.AutoSize = true;
            this.lblEmpFirst.Location = new System.Drawing.Point(13, 35);
            this.lblEmpFirst.Name = "lblEmpFirst";
            this.lblEmpFirst.Size = new System.Drawing.Size(106, 13);
            this.lblEmpFirst.TabIndex = 1;
            this.lblEmpFirst.Text = "Employee First Name";
            // 
            // lblEmpLast
            // 
            this.lblEmpLast.AutoSize = true;
            this.lblEmpLast.Location = new System.Drawing.Point(13, 61);
            this.lblEmpLast.Name = "lblEmpLast";
            this.lblEmpLast.Size = new System.Drawing.Size(107, 13);
            this.lblEmpLast.TabIndex = 2;
            this.lblEmpLast.Text = "Employee Last Name";
            // 
            // lblEmpAddress1
            // 
            this.lblEmpAddress1.AutoSize = true;
            this.lblEmpAddress1.Location = new System.Drawing.Point(13, 87);
            this.lblEmpAddress1.Name = "lblEmpAddress1";
            this.lblEmpAddress1.Size = new System.Drawing.Size(54, 13);
            this.lblEmpAddress1.TabIndex = 3;
            this.lblEmpAddress1.Text = "Address 1";
            // 
            // lblEmpAddress2
            // 
            this.lblEmpAddress2.AutoSize = true;
            this.lblEmpAddress2.Location = new System.Drawing.Point(13, 113);
            this.lblEmpAddress2.Name = "lblEmpAddress2";
            this.lblEmpAddress2.Size = new System.Drawing.Size(54, 13);
            this.lblEmpAddress2.TabIndex = 4;
            this.lblEmpAddress2.Text = "Address 2";
            // 
            // lblEmpCity
            // 
            this.lblEmpCity.AutoSize = true;
            this.lblEmpCity.Location = new System.Drawing.Point(13, 140);
            this.lblEmpCity.Name = "lblEmpCity";
            this.lblEmpCity.Size = new System.Drawing.Size(24, 13);
            this.lblEmpCity.TabIndex = 5;
            this.lblEmpCity.Text = "City";
            // 
            // lblEmpState
            // 
            this.lblEmpState.AutoSize = true;
            this.lblEmpState.Location = new System.Drawing.Point(13, 166);
            this.lblEmpState.Name = "lblEmpState";
            this.lblEmpState.Size = new System.Drawing.Size(32, 13);
            this.lblEmpState.TabIndex = 6;
            this.lblEmpState.Text = "State";
            // 
            // lblEmpZip
            // 
            this.lblEmpZip.AutoSize = true;
            this.lblEmpZip.Location = new System.Drawing.Point(13, 193);
            this.lblEmpZip.Name = "lblEmpZip";
            this.lblEmpZip.Size = new System.Drawing.Size(22, 13);
            this.lblEmpZip.TabIndex = 7;
            this.lblEmpZip.Text = "Zip";
            // 
            // dgEmployeeList
            // 
            this.dgEmployeeList.AllowUserToAddRows = false;
            this.dgEmployeeList.AllowUserToResizeColumns = false;
            this.dgEmployeeList.AllowUserToResizeRows = false;
            this.dgEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployeeList.Location = new System.Drawing.Point(423, 8);
            this.dgEmployeeList.MultiSelect = false;
            this.dgEmployeeList.Name = "dgEmployeeList";
            this.dgEmployeeList.ReadOnly = true;
            this.dgEmployeeList.Size = new System.Drawing.Size(612, 355);
            this.dgEmployeeList.TabIndex = 20;
            this.dgEmployeeList.Click += new System.EventHandler(this.dgEmployeeList_SelectionChanged);
            // 
            // txtEmpNum
            // 
            this.txtEmpNum.Enabled = false;
            this.txtEmpNum.Location = new System.Drawing.Point(126, 6);
            this.txtEmpNum.Name = "txtEmpNum";
            this.txtEmpNum.Size = new System.Drawing.Size(78, 20);
            this.txtEmpNum.TabIndex = 1;
            // 
            // txtEmpFirst
            // 
            this.txtEmpFirst.Location = new System.Drawing.Point(125, 32);
            this.txtEmpFirst.Name = "txtEmpFirst";
            this.txtEmpFirst.Size = new System.Drawing.Size(239, 20);
            this.txtEmpFirst.TabIndex = 2;
            // 
            // txtEmpLast
            // 
            this.txtEmpLast.Location = new System.Drawing.Point(126, 58);
            this.txtEmpLast.Name = "txtEmpLast";
            this.txtEmpLast.Size = new System.Drawing.Size(238, 20);
            this.txtEmpLast.TabIndex = 3;
            // 
            // txtEmpAddress1
            // 
            this.txtEmpAddress1.Location = new System.Drawing.Point(126, 84);
            this.txtEmpAddress1.Name = "txtEmpAddress1";
            this.txtEmpAddress1.Size = new System.Drawing.Size(238, 20);
            this.txtEmpAddress1.TabIndex = 4;
            // 
            // txtEmpAddress2
            // 
            this.txtEmpAddress2.Location = new System.Drawing.Point(125, 110);
            this.txtEmpAddress2.Name = "txtEmpAddress2";
            this.txtEmpAddress2.Size = new System.Drawing.Size(239, 20);
            this.txtEmpAddress2.TabIndex = 5;
            // 
            // txtEmpCity
            // 
            this.txtEmpCity.Location = new System.Drawing.Point(125, 137);
            this.txtEmpCity.Name = "txtEmpCity";
            this.txtEmpCity.Size = new System.Drawing.Size(128, 20);
            this.txtEmpCity.TabIndex = 6;
            // 
            // lblEmpPhone
            // 
            this.lblEmpPhone.AutoSize = true;
            this.lblEmpPhone.Location = new System.Drawing.Point(13, 219);
            this.lblEmpPhone.Name = "lblEmpPhone";
            this.lblEmpPhone.Size = new System.Drawing.Size(78, 13);
            this.lblEmpPhone.TabIndex = 17;
            this.lblEmpPhone.Text = "Phone Number";
            // 
            // lblDash
            // 
            this.lblDash.AutoSize = true;
            this.lblDash.Location = new System.Drawing.Point(163, 219);
            this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(10, 13);
            this.lblDash.TabIndex = 19;
            this.lblDash.Text = "-";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(336, 340);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Location = new System.Drawing.Point(13, 245);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(51, 13);
            this.lblPayRate.TabIndex = 23;
            this.lblPayRate.Text = "Pay Rate";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 340);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = " Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(115, 340);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpEmpPass
            // 
            this.btnUpEmpPass.Location = new System.Drawing.Point(98, 311);
            this.btnUpEmpPass.Name = "btnUpEmpPass";
            this.btnUpEmpPass.Size = new System.Drawing.Size(167, 23);
            this.btnUpEmpPass.TabIndex = 27;
            this.btnUpEmpPass.Text = "Update Employee Password";
            this.btnUpEmpPass.UseVisualStyleBackColor = true;
            this.btnUpEmpPass.Click += new System.EventHandler(this.btnUpEmpPass_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(229, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtEmpPay
            // 
            this.txtEmpPay.Location = new System.Drawing.Point(125, 242);
            this.txtEmpPay.Mask = "##.##";
            this.txtEmpPay.Name = "txtEmpPay";
            this.txtEmpPay.Size = new System.Drawing.Size(100, 20);
            this.txtEmpPay.TabIndex = 11;
            // 
            // txtEmpZip
            // 
            this.txtEmpZip.Location = new System.Drawing.Point(126, 189);
            this.txtEmpZip.Mask = "00000";
            this.txtEmpZip.Name = "txtEmpZip";
            this.txtEmpZip.Size = new System.Drawing.Size(42, 20);
            this.txtEmpZip.TabIndex = 8;
            // 
            // txtEmpAreaCode
            // 
            this.txtEmpAreaCode.Location = new System.Drawing.Point(126, 215);
            this.txtEmpAreaCode.Mask = "000";
            this.txtEmpAreaCode.Name = "txtEmpAreaCode";
            this.txtEmpAreaCode.Size = new System.Drawing.Size(32, 20);
            this.txtEmpAreaCode.TabIndex = 9;
            // 
            // txtEmpPhone
            // 
            this.txtEmpPhone.Location = new System.Drawing.Point(179, 216);
            this.txtEmpPhone.Mask = "0000000";
            this.txtEmpPhone.Name = "txtEmpPhone";
            this.txtEmpPhone.Size = new System.Drawing.Size(100, 20);
            this.txtEmpPhone.TabIndex = 10;
            // 
            // txtEmpState
            // 
            this.txtEmpState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpState.Location = new System.Drawing.Point(126, 163);
            this.txtEmpState.MaxLength = 2;
            this.txtEmpState.Name = "txtEmpState";
            this.txtEmpState.Size = new System.Drawing.Size(31, 20);
            this.txtEmpState.TabIndex = 7;
            // 
            // EmployeeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 375);
            this.Controls.Add(this.txtEmpPhone);
            this.Controls.Add(this.txtEmpAreaCode);
            this.Controls.Add(this.txtEmpZip);
            this.Controls.Add(this.txtEmpPay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpEmpPass);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblPayRate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDash);
            this.Controls.Add(this.lblEmpPhone);
            this.Controls.Add(this.txtEmpState);
            this.Controls.Add(this.txtEmpCity);
            this.Controls.Add(this.txtEmpAddress2);
            this.Controls.Add(this.txtEmpAddress1);
            this.Controls.Add(this.txtEmpLast);
            this.Controls.Add(this.txtEmpFirst);
            this.Controls.Add(this.txtEmpNum);
            this.Controls.Add(this.dgEmployeeList);
            this.Controls.Add(this.lblEmpZip);
            this.Controls.Add(this.lblEmpState);
            this.Controls.Add(this.lblEmpCity);
            this.Controls.Add(this.lblEmpAddress2);
            this.Controls.Add(this.lblEmpAddress1);
            this.Controls.Add(this.lblEmpLast);
            this.Controls.Add(this.lblEmpFirst);
            this.Controls.Add(this.lblEmpNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee Administration";
            this.Load += new System.EventHandler(this.EmployeeAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpNum;
        private System.Windows.Forms.Label lblEmpFirst;
        private System.Windows.Forms.Label lblEmpLast;
        private System.Windows.Forms.Label lblEmpAddress1;
        private System.Windows.Forms.Label lblEmpAddress2;
        private System.Windows.Forms.Label lblEmpCity;
        private System.Windows.Forms.Label lblEmpState;
        private System.Windows.Forms.Label lblEmpZip;
        private System.Windows.Forms.DataGridView dgEmployeeList;
        private System.Windows.Forms.TextBox txtEmpNum;
        private System.Windows.Forms.TextBox txtEmpFirst;
        private System.Windows.Forms.TextBox txtEmpLast;
        private System.Windows.Forms.TextBox txtEmpAddress1;
        private System.Windows.Forms.TextBox txtEmpAddress2;
        private System.Windows.Forms.TextBox txtEmpCity;
        private System.Windows.Forms.Label lblEmpPhone;
        private System.Windows.Forms.Label lblDash;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpEmpPass;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MaskedTextBox txtEmpPay;
        private System.Windows.Forms.MaskedTextBox txtEmpZip;
        private System.Windows.Forms.MaskedTextBox txtEmpAreaCode;
        private System.Windows.Forms.MaskedTextBox txtEmpPhone;
        private System.Windows.Forms.TextBox txtEmpState;
    }
}