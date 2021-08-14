
namespace SPV202_CS486_Team11
{
    partial class FormAddPerformTrio
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
            this.labelSongId = new System.Windows.Forms.Label();
            this.textSongID = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSongId
            // 
            this.labelSongId.AutoSize = true;
            this.labelSongId.Location = new System.Drawing.Point(21, 26);
            this.labelSongId.Name = "labelSongId";
            this.labelSongId.Size = new System.Drawing.Size(58, 17);
            this.labelSongId.TabIndex = 13;
            this.labelSongId.Text = "Song ID";
            // 
            // textSongID
            // 
            this.textSongID.Location = new System.Drawing.Point(143, 26);
            this.textSongID.Name = "textSongID";
            this.textSongID.Size = new System.Drawing.Size(217, 22);
            this.textSongID.TabIndex = 11;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(285, 77);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 10;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // FormAddPerformTrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 141);
            this.Controls.Add(this.labelSongId);
            this.Controls.Add(this.textSongID);
            this.Controls.Add(this.buttonConfirm);
            this.Name = "FormAddPerformTrio";
            this.Text = "FormAddPerformTrio";
            this.Load += new System.EventHandler(this.FormAddPerformTrio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSongId;
        private System.Windows.Forms.TextBox textSongID;
        private System.Windows.Forms.Button buttonConfirm;
    }
}