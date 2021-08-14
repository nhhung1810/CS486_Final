namespace set2
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
            this.labelSongId = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelSongId
            // 
            this.labelSongId.AutoSize = true;
            this.labelSongId.Location = new System.Drawing.Point(16, 59);
            this.labelSongId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSongId.Name = "labelSongId";
            this.labelSongId.Size = new System.Drawing.Size(63, 13);
            this.labelSongId.TabIndex = 13;
            this.labelSongId.Text = "Song Name";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(108, 59);
            this.textName.Margin = new System.Windows.Forms.Padding(2);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(164, 20);
            this.textName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Song ID";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(108, 25);
            this.textID.Margin = new System.Windows.Forms.Padding(2);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(164, 20);
            this.textID.TabIndex = 12;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(216, 172);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(56, 19);
            this.buttonConfirm.TabIndex = 10;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Number";
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(108, 98);
            this.textNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(164, 20);
            this.textNumber.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 229);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.labelSongId);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.buttonConfirm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSongId;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNumber;
    }
}

