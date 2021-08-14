
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonOfficial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOfficial
            // 
            this.dgvOfficial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOfficial.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvOfficial.Location = new System.Drawing.Point(0, 259);
            this.dgvOfficial.Name = "dgvOfficial";
            this.dgvOfficial.RowHeadersWidth = 62;
            this.dgvOfficial.RowTemplate.Height = 28;
            this.dgvOfficial.Size = new System.Drawing.Size(500, 285);
            this.dgvOfficial.TabIndex = 1;
            // 
            // dgvNonOfficial
            // 
            this.dgvNonOfficial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNonOfficial.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvNonOfficial.Location = new System.Drawing.Point(506, 259);
            this.dgvNonOfficial.Name = "dgvNonOfficial";
            this.dgvNonOfficial.RowHeadersWidth = 62;
            this.dgvNonOfficial.RowTemplate.Height = 28;
            this.dgvNonOfficial.Size = new System.Drawing.Size(519, 285);
            this.dgvNonOfficial.TabIndex = 2;
            // 
            // flpRule
            // 
            this.flpRule.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpRule.Location = new System.Drawing.Point(0, 0);
            this.flpRule.Name = "flpRule";
            this.flpRule.Size = new System.Drawing.Size(1025, 259);
            this.flpRule.TabIndex = 0;
            // 
            // FormRuleMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 544);
            this.Controls.Add(this.dgvNonOfficial);
            this.Controls.Add(this.dgvOfficial);
            this.Controls.Add(this.flpRule);
            this.Name = "FormRuleMember";
            this.Text = "FormRuleMember";
            this.Load += new System.EventHandler(this.FormRuleMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNonOfficial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOfficial;
        private System.Windows.Forms.DataGridView dgvNonOfficial;
        private System.Windows.Forms.FlowLayoutPanel flpRule;
    }
}