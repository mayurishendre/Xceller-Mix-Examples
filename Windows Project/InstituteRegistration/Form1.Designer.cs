
namespace InstituteRegistration
{
    partial class frmInstituteRegistration
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
            this.groupBoxIR = new System.Windows.Forms.GroupBox();
            this.dgvInstitution = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCtNo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtIName = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIR = new System.Windows.Forms.Label();
            this.groupBoxIR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstitution)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxIR
            // 
            this.groupBoxIR.AutoSize = true;
            this.groupBoxIR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBoxIR.Controls.Add(this.dgvInstitution);
            this.groupBoxIR.Controls.Add(this.txtSearch);
            this.groupBoxIR.Controls.Add(this.label7);
            this.groupBoxIR.Controls.Add(this.txtCtNo);
            this.groupBoxIR.Controls.Add(this.txtAddress);
            this.groupBoxIR.Controls.Add(this.txtIName);
            this.groupBoxIR.Controls.Add(this.txtContactNo);
            this.groupBoxIR.Controls.Add(this.txtOwnerName);
            this.groupBoxIR.Controls.Add(this.label6);
            this.groupBoxIR.Controls.Add(this.label1);
            this.groupBoxIR.Controls.Add(this.btnDelete);
            this.groupBoxIR.Controls.Add(this.btnUpdate);
            this.groupBoxIR.Controls.Add(this.btnSave);
            this.groupBoxIR.Controls.Add(this.txtCity);
            this.groupBoxIR.Controls.Add(this.label5);
            this.groupBoxIR.Controls.Add(this.label4);
            this.groupBoxIR.Controls.Add(this.label3);
            this.groupBoxIR.Controls.Add(this.label2);
            this.groupBoxIR.Controls.Add(this.lblIR);
            this.groupBoxIR.Location = new System.Drawing.Point(6, 9);
            this.groupBoxIR.Name = "groupBoxIR";
            this.groupBoxIR.Size = new System.Drawing.Size(1260, 509);
            this.groupBoxIR.TabIndex = 0;
            this.groupBoxIR.TabStop = false;
            this.groupBoxIR.Text = "groupBox1";
            this.groupBoxIR.Enter += new System.EventHandler(this.groupBoxIR_Enter);
            // 
            // dgvInstitution
            // 
            this.dgvInstitution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstitution.Location = new System.Drawing.Point(498, 176);
            this.dgvInstitution.Name = "dgvInstitution";
            this.dgvInstitution.RowHeadersWidth = 51;
            this.dgvInstitution.RowTemplate.Height = 24;
            this.dgvInstitution.Size = new System.Drawing.Size(733, 216);
            this.dgvInstitution.TabIndex = 30;
            this.dgvInstitution.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(660, 139);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(289, 31);
            this.txtSearch.TabIndex = 29;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(494, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Search By Names";
            // 
            // txtCtNo
            // 
            this.txtCtNo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCtNo.Location = new System.Drawing.Point(189, 270);
            this.txtCtNo.Name = "txtCtNo";
            this.txtCtNo.Size = new System.Drawing.Size(289, 31);
            this.txtCtNo.TabIndex = 27;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(189, 185);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(289, 31);
            this.txtAddress.TabIndex = 26;
            // 
            // txtIName
            // 
            this.txtIName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIName.Location = new System.Drawing.Point(189, 141);
            this.txtIName.Multiline = true;
            this.txtIName.Name = "txtIName";
            this.txtIName.Size = new System.Drawing.Size(289, 31);
            this.txtIName.TabIndex = 25;
            this.txtIName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxIName_KeyPress);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(189, 361);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(289, 31);
            this.txtContactNo.TabIndex = 24;
            this.txtContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxContactNo_KeyPress);
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOwnerName.Location = new System.Drawing.Point(189, 316);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(289, 31);
            this.txtOwnerName.TabIndex = 23;
            this.txtOwnerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxOwnerName_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Contact No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Owner Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(763, 422);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 45);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(477, 422);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(182, 45);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(193, 422);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(182, 45);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(189, 226);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(289, 31);
            this.txtCity.TabIndex = 16;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxCity_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Center No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Institute Names";
            // 
            // lblIR
            // 
            this.lblIR.BackColor = System.Drawing.Color.Gainsboro;
            this.lblIR.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIR.Location = new System.Drawing.Point(29, 18);
            this.lblIR.Name = "lblIR";
            this.lblIR.Size = new System.Drawing.Size(1202, 72);
            this.lblIR.TabIndex = 9;
            this.lblIR.Text = "Institute Registration";
            this.lblIR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmInstituteRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1272, 525);
            this.Controls.Add(this.groupBoxIR);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximizeBox = false;
            this.Name = "frmInstituteRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Institute";
            this.Load += new System.EventHandler(this.frmInstituteRegistration_Load);
            this.groupBoxIR.ResumeLayout(false);
            this.groupBoxIR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstitution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIR;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIR;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCtNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtIName;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvInstitution;
    }
}

