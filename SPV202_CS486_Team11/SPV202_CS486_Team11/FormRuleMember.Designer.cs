
namespace SPV202_CS486_Team11
{
    partial class FormRuleMember
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
            this.dgvOfficial = new System.Windows.Forms.DataGridView();
            this.dgvNonOfficial = new System.Windows.Forms.DataGridView();
            this.flpRule = new System.Windows.Forms.FlowLayoutPanel();
            this.lblOfficial = new System.Windows.Forms.Label();
            this.lblNonOfficial = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonOfficial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOfficial
            // 
            this.dgvOfficial.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOfficial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvOfficial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvOfficial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfficial.Location = new System.Drawing.Point(0, 290);
            this.dgvOfficial.Name = "dgvOfficial";
            this.dgvOfficial.RowHeadersWidth = 62;
            this.dgvOfficial.RowTemplate.Height = 28;
            this.dgvOfficial.Size = new System.Drawing.Size(500, 383);
            this.dgvOfficial.TabIndex = 1;
            // 
            // dgvNonOfficial
            // 
            this.dgvNonOfficial.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNonOfficial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNonOfficial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNonOfficial.Location = new System.Drawing.Point(510, 290);
            this.dgvNonOfficial.Name = "dgvNonOfficial";
            this.dgvNonOfficial.RowHeadersWidth = 62;
            this.dgvNonOfficial.RowTemplate.Height = 28;
            this.dgvNonOfficial.Size = new System.Drawing.Size(531, 383);
            this.dgvNonOfficial.TabIndex = 2;
            // 
            // flpRule
            // 
            this.flpRule.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpRule.Location = new System.Drawing.Point(0, 0);
            this.flpRule.Name = "flpRule";
            this.flpRule.Size = new System.Drawing.Size(1041, 242);
            this.flpRule.TabIndex = 0;
            // 
            // lblOfficial
            // 
            this.lblOfficial.AutoSize = true;
            this.lblOfficial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOfficial.Location = new System.Drawing.Point(-5, 245);
            this.lblOfficial.Name = "lblOfficial";
            this.lblOfficial.Size = new System.Drawing.Size(113, 27);
            this.lblOfficial.TabIndex = 3;
            this.lblOfficial.Text = "Principals ";
            // 
            // lblNonOfficial
            // 
            this.lblNonOfficial.AutoSize = true;
            this.lblNonOfficial.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNonOfficial.Location = new System.Drawing.Point(505, 245);
            this.lblNonOfficial.Name = "lblNonOfficial";
            this.lblNonOfficial.Size = new System.Drawing.Size(123, 27);
            this.lblNonOfficial.TabIndex = 4;
            this.lblNonOfficial.Text = "Understudy";
            // 
            // FormRuleMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 673);
            this.Controls.Add(this.lblOfficial);
            this.Controls.Add(this.lblNonOfficial);
            this.Controls.Add(this.dgvNonOfficial);
            this.Controls.Add(this.dgvOfficial);
            this.Controls.Add(this.flpRule);
            this.Name = "FormRuleMember";
            this.Text = "FormRuleMember";
            this.Load += new System.EventHandler(this.FormRuleMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonOfficial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOfficial;
        private System.Windows.Forms.DataGridView dgvNonOfficial;
        private System.Windows.Forms.FlowLayoutPanel flpRule;
        private System.Windows.Forms.Label lblOfficial;
        private System.Windows.Forms.Label lblNonOfficial;
    }
}