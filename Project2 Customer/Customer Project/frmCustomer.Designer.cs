
namespace Customer_Project
{
    partial class frmCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCustomeType = new System.Windows.Forms.ComboBox();
            this.txtboxCustomeName = new System.Windows.Forms.TextBox();
            this.txtboxPhNo = new System.Windows.Forms.TextBox();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.txtboxBillDate = new System.Windows.Forms.TextBox();
            this.txtboxBillAmount = new System.Windows.Forms.TextBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnValidate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(556, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bill Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(559, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bill Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(562, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // cmbCustomeType
            // 
            this.cmbCustomeType.FormattingEnabled = true;
            this.cmbCustomeType.Items.AddRange(new object[] {
            "Customer",
            "Lead"});
            this.cmbCustomeType.Location = new System.Drawing.Point(219, 66);
            this.cmbCustomeType.Name = "cmbCustomeType";
            this.cmbCustomeType.Size = new System.Drawing.Size(252, 24);
            this.cmbCustomeType.TabIndex = 6;
            this.cmbCustomeType.SelectedIndexChanged += new System.EventHandler(this.cmbCustomeType_SelectedIndexChanged);
            // 
            // txtboxCustomeName
            // 
            this.txtboxCustomeName.Location = new System.Drawing.Point(219, 120);
            this.txtboxCustomeName.Name = "txtboxCustomeName";
            this.txtboxCustomeName.Size = new System.Drawing.Size(252, 22);
            this.txtboxCustomeName.TabIndex = 7;
            // 
            // txtboxPhNo
            // 
            this.txtboxPhNo.Location = new System.Drawing.Point(219, 179);
            this.txtboxPhNo.Name = "txtboxPhNo";
            this.txtboxPhNo.Size = new System.Drawing.Size(252, 22);
            this.txtboxPhNo.TabIndex = 8;
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Location = new System.Drawing.Point(714, 173);
            this.txtboxAddress.Multiline = true;
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(252, 102);
            this.txtboxAddress.TabIndex = 9;
            // 
            // txtboxBillDate
            // 
            this.txtboxBillDate.Location = new System.Drawing.Point(714, 117);
            this.txtboxBillDate.Name = "txtboxBillDate";
            this.txtboxBillDate.Size = new System.Drawing.Size(252, 22);
            this.txtboxBillDate.TabIndex = 10;
            // 
            // txtboxBillAmount
            // 
            this.txtboxBillAmount.Location = new System.Drawing.Point(714, 56);
            this.txtboxBillAmount.Multiline = true;
            this.txtboxBillAmount.Name = "txtboxBillAmount";
            this.txtboxBillAmount.Size = new System.Drawing.Size(252, 22);
            this.txtboxBillAmount.TabIndex = 11;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(12, 332);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(954, 247);
            this.dgvCustomer.TabIndex = 13;
            // 
            // btnValidate
            // 
            this.btnValidate.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.Location = new System.Drawing.Point(47, 251);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(113, 42);
            this.btnValidate.TabIndex = 14;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1095, 591);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.txtboxBillAmount);
            this.Controls.Add(this.txtboxBillDate);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.txtboxPhNo);
            this.Controls.Add(this.txtboxCustomeName);
            this.Controls.Add(this.cmbCustomeType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCustomeType;
        private System.Windows.Forms.TextBox txtboxCustomeName;
        private System.Windows.Forms.TextBox txtboxPhNo;
        private System.Windows.Forms.TextBox txtboxAddress;
        private System.Windows.Forms.TextBox txtboxBillDate;
        private System.Windows.Forms.TextBox txtboxBillAmount;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnValidate;
    }
}

