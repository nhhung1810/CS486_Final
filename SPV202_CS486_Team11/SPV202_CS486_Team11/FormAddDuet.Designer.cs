
namespace SPV202_CS486_Team11
{
    partial class FormAddDuet
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
            this.textID = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.textSongID = new System.Windows.Forms.TextBox();
            this.labelSongId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Reverse ID";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(145, 21);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(217, 22);
            this.textID.TabIndex = 8;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(272, 171);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 7;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // textSongID
            // 
            this.textSongID.Location = new System.Drawing.Point(145, 63);
            this.textSongID.Name = "textSongID";
            this.textSongID.Size = new System.Drawing.Size(217, 22);
            this.textSongID.TabIndex = 8;
            // 
            // labelSongId
            // 
            this.labelSongId.AutoSize = true;
            this.labelSongId.Location = new System.Drawing.Point(23, 63);
            this.labelSongId.Name = "labelSongId";
            this.labelSongId.Size = new System.Drawing.Size(58, 17);
            this.labelSongId.TabIndex = 9;
            this.labelSongId.Text = "Song ID";
            // 
            // FormAddDuet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 224);
            this.Controls.Add(this.labelSongId);
            this.Controls.Add(this.textSongID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.buttonConfirm);
            this.Name = "FormAddDuet";
            this.Text = "Choose a person to duet with";
            this.Load += new System.EventHandler(this.FormAddDuet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox textSongID;
        private System.Windows.Forms.Label labelSongId;
    }
}