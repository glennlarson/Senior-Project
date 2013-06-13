namespace Senior_Project
{
    partial class PurchaseDetails
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
            this.gbPayment = new System.Windows.Forms.GroupBox();
            this.txtcardType = new System.Windows.Forms.TextBox();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblCardType = new System.Windows.Forms.Label();
            this.bgPayType = new System.Windows.Forms.GroupBox();
            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.gbPurchase = new System.Windows.Forms.GroupBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.dgPurchaseList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.txtCustAreaCode = new System.Windows.Forms.TextBox();
            this.txtCustZip = new System.Windows.Forms.TextBox();
            this.txtCustState = new System.Windows.Forms.TextBox();
            this.txtCustCity = new System.Windows.Forms.TextBox();
            this.txtCustAddress2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCustAddress1 = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gbPayment.SuspendLayout();
            this.bgPayType.SuspendLayout();
            this.gbPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPayment
            // 
            this.gbPayment.Controls.Add(this.txtcardType);
            this.gbPayment.Controls.Add(this.txtPayAmount);
            this.gbPayment.Controls.Add(this.txtTotal);
            this.gbPayment.Controls.Add(this.lblTotal);
            this.gbPayment.Controls.Add(this.txtTax);
            this.gbPayment.Controls.Add(this.lblTax);
            this.gbPayment.Controls.Add(this.lblAmount);
            this.gbPayment.Controls.Add(this.txtCardNum);
            this.gbPayment.Controls.Add(this.lblCardNumber);
            this.gbPayment.Controls.Add(this.lblCardType);
            this.gbPayment.Controls.Add(this.bgPayType);
            this.gbPayment.Location = new System.Drawing.Point(12, 282);
            this.gbPayment.Name = "gbPayment";
            this.gbPayment.Size = new System.Drawing.Size(353, 235);
            this.gbPayment.TabIndex = 13;
            this.gbPayment.TabStop = false;
            this.gbPayment.Text = "Payment";
            // 
            // txtcardType
            // 
            this.txtcardType.Location = new System.Drawing.Point(105, 133);
            this.txtcardType.Name = "txtcardType";
            this.txtcardType.ReadOnly = true;
            this.txtcardType.Size = new System.Drawing.Size(202, 20);
            this.txtcardType.TabIndex = 15;
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Location = new System.Drawing.Point(166, 197);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.ReadOnly = true;
            this.txtPayAmount.Size = new System.Drawing.Size(100, 20);
            this.txtPayAmount.TabIndex = 14;
            this.txtPayAmount.Text = "0";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(172, 82);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(135, 20);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(135, 85);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(172, 52);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(135, 20);
            this.txtTax.TabIndex = 11;
            this.txtTax.Text = "0";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(135, 55);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 10;
            this.lblTax.Text = "Tax";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(117, 200);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount";
            // 
            // txtCardNum
            // 
            this.txtCardNum.Enabled = false;
            this.txtCardNum.Location = new System.Drawing.Point(105, 169);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.ReadOnly = true;
            this.txtCardNum.Size = new System.Drawing.Size(202, 20);
            this.txtCardNum.TabIndex = 6;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(21, 172);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(69, 13);
            this.lblCardNumber.TabIndex = 5;
            this.lblCardNumber.Text = "Card Number";
            // 
            // lblCardType
            // 
            this.lblCardType.AutoSize = true;
            this.lblCardType.Location = new System.Drawing.Point(21, 136);
            this.lblCardType.Name = "lblCardType";
            this.lblCardType.Size = new System.Drawing.Size(56, 13);
            this.lblCardType.TabIndex = 4;
            this.lblCardType.Text = "Card Type";
            // 
            // bgPayType
            // 
            this.bgPayType.Controls.Add(this.rbCredit);
            this.bgPayType.Controls.Add(this.rbCash);
            this.bgPayType.Enabled = false;
            this.bgPayType.Location = new System.Drawing.Point(19, 22);
            this.bgPayType.Name = "bgPayType";
            this.bgPayType.Size = new System.Drawing.Size(112, 100);
            this.bgPayType.TabIndex = 2;
            this.bgPayType.TabStop = false;
            this.bgPayType.Text = "Type";
            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.Location = new System.Drawing.Point(9, 30);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(82, 17);
            this.rbCredit.TabIndex = 0;
            this.rbCredit.TabStop = true;
            this.rbCredit.Text = "Credit/Debit";
            this.rbCredit.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Location = new System.Drawing.Point(9, 64);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(49, 17);
            this.rbCash.TabIndex = 1;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // gbPurchase
            // 
            this.gbPurchase.Controls.Add(this.txtSubTotal);
            this.gbPurchase.Controls.Add(this.lblSubTotal);
            this.gbPurchase.Controls.Add(this.dgPurchaseList);
            this.gbPurchase.Location = new System.Drawing.Point(371, 32);
            this.gbPurchase.Name = "gbPurchase";
            this.gbPurchase.Size = new System.Drawing.Size(631, 485);
            this.gbPurchase.TabIndex = 12;
            this.gbPurchase.TabStop = false;
            this.gbPurchase.Text = "Purchase";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(391, 450);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(76, 20);
            this.txtSubTotal.TabIndex = 11;
            this.txtSubTotal.Text = "0";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(332, 453);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(53, 13);
            this.lblSubTotal.TabIndex = 10;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // dgPurchaseList
            // 
            this.dgPurchaseList.AllowUserToAddRows = false;
            this.dgPurchaseList.AllowUserToDeleteRows = false;
            this.dgPurchaseList.AllowUserToResizeColumns = false;
            this.dgPurchaseList.AllowUserToResizeRows = false;
            this.dgPurchaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPurchaseList.Location = new System.Drawing.Point(6, 19);
            this.dgPurchaseList.MultiSelect = false;
            this.dgPurchaseList.Name = "dgPurchaseList";
            this.dgPurchaseList.ReadOnly = true;
            this.dgPurchaseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPurchaseList.Size = new System.Drawing.Size(619, 420);
            this.dgPurchaseList.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustPhone);
            this.groupBox1.Controls.Add(this.txtCustAreaCode);
            this.groupBox1.Controls.Add(this.txtCustZip);
            this.groupBox1.Controls.Add(this.txtCustState);
            this.groupBox1.Controls.Add(this.txtCustCity);
            this.groupBox1.Controls.Add(this.txtCustAddress2);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtCustAddress1);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCustID);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 244);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer";
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(129, 206);
            this.txtCustPhone.MaxLength = 7;
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.ReadOnly = true;
            this.txtCustPhone.Size = new System.Drawing.Size(79, 20);
            this.txtCustPhone.TabIndex = 35;
            // 
            // txtCustAreaCode
            // 
            this.txtCustAreaCode.Location = new System.Drawing.Point(89, 206);
            this.txtCustAreaCode.MaxLength = 3;
            this.txtCustAreaCode.Name = "txtCustAreaCode";
            this.txtCustAreaCode.ReadOnly = true;
            this.txtCustAreaCode.Size = new System.Drawing.Size(34, 20);
            this.txtCustAreaCode.TabIndex = 34;
            // 
            // txtCustZip
            // 
            this.txtCustZip.Location = new System.Drawing.Point(89, 180);
            this.txtCustZip.MaxLength = 5;
            this.txtCustZip.Name = "txtCustZip";
            this.txtCustZip.ReadOnly = true;
            this.txtCustZip.Size = new System.Drawing.Size(100, 20);
            this.txtCustZip.TabIndex = 33;
            // 
            // txtCustState
            // 
            this.txtCustState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustState.Location = new System.Drawing.Point(89, 154);
            this.txtCustState.MaxLength = 2;
            this.txtCustState.Name = "txtCustState";
            this.txtCustState.ReadOnly = true;
            this.txtCustState.Size = new System.Drawing.Size(34, 20);
            this.txtCustState.TabIndex = 32;
            // 
            // txtCustCity
            // 
            this.txtCustCity.Location = new System.Drawing.Point(89, 128);
            this.txtCustCity.Name = "txtCustCity";
            this.txtCustCity.ReadOnly = true;
            this.txtCustCity.Size = new System.Drawing.Size(250, 20);
            this.txtCustCity.TabIndex = 31;
            // 
            // txtCustAddress2
            // 
            this.txtCustAddress2.Location = new System.Drawing.Point(89, 101);
            this.txtCustAddress2.Name = "txtCustAddress2";
            this.txtCustAddress2.ReadOnly = true;
            this.txtCustAddress2.Size = new System.Drawing.Size(250, 20);
            this.txtCustAddress2.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Address 2";
            // 
            // txtCustAddress1
            // 
            this.txtCustAddress1.Location = new System.Drawing.Point(89, 74);
            this.txtCustAddress1.Name = "txtCustAddress1";
            this.txtCustAddress1.ReadOnly = true;
            this.txtCustAddress1.Size = new System.Drawing.Size(250, 20);
            this.txtCustAddress1.TabIndex = 28;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(89, 48);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(143, 20);
            this.txtLastName.TabIndex = 27;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(89, 22);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(143, 20);
            this.txtFirstName.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Zip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Address 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Last Name";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(16, 25);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(57, 13);
            this.lblCustID.TabIndex = 19;
            this.lblCustID.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Entered By Employee";
            // 
            // txtEmp
            // 
            this.txtEmp.Location = new System.Drawing.Point(150, 6);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.ReadOnly = true;
            this.txtEmp.Size = new System.Drawing.Size(215, 20);
            this.txtEmp.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(927, 523);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(837, 523);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(84, 23);
            this.btnPrint.TabIndex = 17;
            this.btnPrint.Text = "Print Reciept";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // PurchaseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 555);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtEmp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbPayment);
            this.Controls.Add(this.gbPurchase);
            this.Controls.Add(this.groupBox1);
            this.Name = "PurchaseDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Purchase Details";
            this.Load += new System.EventHandler(this.PurchaseDetails_Load);
            this.gbPayment.ResumeLayout(false);
            this.gbPayment.PerformLayout();
            this.bgPayType.ResumeLayout(false);
            this.bgPayType.PerformLayout();
            this.gbPurchase.ResumeLayout(false);
            this.gbPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPurchaseList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPayment;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblCardType;
        private System.Windows.Forms.GroupBox bgPayType;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Windows.Forms.RadioButton rbCash;
        private System.Windows.Forms.GroupBox gbPurchase;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.DataGridView dgPurchaseList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.TextBox txtCustAreaCode;
        private System.Windows.Forms.TextBox txtCustZip;
        private System.Windows.Forms.TextBox txtCustState;
        private System.Windows.Forms.TextBox txtCustCity;
        private System.Windows.Forms.TextBox txtCustAddress2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCustAddress1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtcardType;
        private System.Windows.Forms.Button btnPrint;
    }
}