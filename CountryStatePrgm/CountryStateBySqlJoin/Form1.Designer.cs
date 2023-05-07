
namespace CountryStateBySqlJoin
{
    partial class Form1
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
            this.btnInnerJoin = new System.Windows.Forms.Button();
            this.dgvCountry = new System.Windows.Forms.DataGridView();
            this.dgvState = new System.Windows.Forms.DataGridView();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.btnLeftJoin = new System.Windows.Forms.Button();
            this.btnRightJoin = new System.Windows.Forms.Button();
            this.btnFullOuterJoin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInnerJoin
            // 
            this.btnInnerJoin.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInnerJoin.Location = new System.Drawing.Point(182, 293);
            this.btnInnerJoin.Name = "btnInnerJoin";
            this.btnInnerJoin.Size = new System.Drawing.Size(120, 43);
            this.btnInnerJoin.TabIndex = 10;
            this.btnInnerJoin.Text = "InnerJoin";
            this.btnInnerJoin.UseVisualStyleBackColor = true;
            this.btnInnerJoin.Click += new System.EventHandler(this.btnInnerJoin_Click);
            // 
            // dgvCountry
            // 
            this.dgvCountry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountry.Location = new System.Drawing.Point(32, 12);
            this.dgvCountry.Name = "dgvCountry";
            this.dgvCountry.RowHeadersWidth = 51;
            this.dgvCountry.RowTemplate.Height = 24;
            this.dgvCountry.Size = new System.Drawing.Size(450, 269);
            this.dgvCountry.TabIndex = 11;
            // 
            // dgvState
            // 
            this.dgvState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvState.Location = new System.Drawing.Point(542, 12);
            this.dgvState.Name = "dgvState";
            this.dgvState.RowHeadersWidth = 51;
            this.dgvState.RowTemplate.Height = 24;
            this.dgvState.Size = new System.Drawing.Size(473, 269);
            this.dgvState.TabIndex = 12;
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(32, 360);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersWidth = 51;
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.Size = new System.Drawing.Size(983, 269);
            this.dgvResult.TabIndex = 13;
            // 
            // btnLeftJoin
            // 
            this.btnLeftJoin.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftJoin.Location = new System.Drawing.Point(542, 293);
            this.btnLeftJoin.Name = "btnLeftJoin";
            this.btnLeftJoin.Size = new System.Drawing.Size(120, 43);
            this.btnLeftJoin.TabIndex = 15;
            this.btnLeftJoin.Text = "LeftJoin";
            this.btnLeftJoin.UseVisualStyleBackColor = true;
            this.btnLeftJoin.Click += new System.EventHandler(this.btnLeftJoin_Click);
            // 
            // btnRightJoin
            // 
            this.btnRightJoin.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightJoin.Location = new System.Drawing.Point(730, 293);
            this.btnRightJoin.Name = "btnRightJoin";
            this.btnRightJoin.Size = new System.Drawing.Size(120, 43);
            this.btnRightJoin.TabIndex = 16;
            this.btnRightJoin.Text = "RightJoin";
            this.btnRightJoin.UseVisualStyleBackColor = true;
            this.btnRightJoin.Click += new System.EventHandler(this.btnRightJoin_Click);
            // 
            // btnFullOuterJoin
            // 
            this.btnFullOuterJoin.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullOuterJoin.Location = new System.Drawing.Point(345, 296);
            this.btnFullOuterJoin.Name = "btnFullOuterJoin";
            this.btnFullOuterJoin.Size = new System.Drawing.Size(165, 42);
            this.btnFullOuterJoin.TabIndex = 17;
            this.btnFullOuterJoin.Text = "FullOuterJoin";
            this.btnFullOuterJoin.UseVisualStyleBackColor = true;
            this.btnFullOuterJoin.Click += new System.EventHandler(this.btnFullOuterJoin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1068, 709);
            this.Controls.Add(this.btnFullOuterJoin);
            this.Controls.Add(this.btnRightJoin);
            this.Controls.Add(this.btnLeftJoin);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.dgvState);
            this.Controls.Add(this.dgvCountry);
            this.Controls.Add(this.btnInnerJoin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInnerJoin;
        private System.Windows.Forms.DataGridView dgvCountry;
        private System.Windows.Forms.DataGridView dgvState;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button btnLeftJoin;
        private System.Windows.Forms.Button btnRightJoin;
        private System.Windows.Forms.Button btnFullOuterJoin;
    }
}

