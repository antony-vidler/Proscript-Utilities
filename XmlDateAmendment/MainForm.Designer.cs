namespace XmlDateAmendment
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSourceFolder = new System.Windows.Forms.Label();
            this.txtSourceFolder = new System.Windows.Forms.TextBox();
            this.btnSourceBrowse = new System.Windows.Forms.Button();
            this.lblDestinationFolder = new System.Windows.Forms.Label();
            this.txtDestinationFolder = new System.Windows.Forms.TextBox();
            this.btnDestinationBrowse = new System.Windows.Forms.Button();
            this.lblAmendmentDate = new System.Windows.Forms.Label();
            this.txtAmendmentDate = new System.Windows.Forms.TextBox();
            this.lblDateHint = new System.Windows.Forms.Label();
            this.chkAutoGenerateTransactionId = new System.Windows.Forms.CheckBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnEsc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSourceFolder
            // 
            this.lblSourceFolder.AutoSize = true;
            this.lblSourceFolder.Location = new System.Drawing.Point(12, 15);
            this.lblSourceFolder.Name = "lblSourceFolder";
            this.lblSourceFolder.Size = new System.Drawing.Size(82, 15);
            this.lblSourceFolder.TabIndex = 0;
            this.lblSourceFolder.Text = "Source Folder:";
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceFolder.Location = new System.Drawing.Point(12, 33);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.ReadOnly = true;
            this.txtSourceFolder.Size = new System.Drawing.Size(408, 23);
            this.txtSourceFolder.TabIndex = 1;
            this.txtSourceFolder.TextChanged += new System.EventHandler(this.txtSourceFolder_TextChanged);
            // 
            // btnSourceBrowse
            // 
            this.btnSourceBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSourceBrowse.Location = new System.Drawing.Point(426, 32);
            this.btnSourceBrowse.Name = "btnSourceBrowse";
            this.btnSourceBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnSourceBrowse.TabIndex = 2;
            this.btnSourceBrowse.Text = "Browse...";
            this.btnSourceBrowse.UseVisualStyleBackColor = true;
            this.btnSourceBrowse.Click += new System.EventHandler(this.btnSourceBrowse_Click);
            // 
            // lblDestinationFolder
            // 
            this.lblDestinationFolder.AutoSize = true;
            this.lblDestinationFolder.Location = new System.Drawing.Point(12, 69);
            this.lblDestinationFolder.Name = "lblDestinationFolder";
            this.lblDestinationFolder.Size = new System.Drawing.Size(111, 15);
            this.lblDestinationFolder.TabIndex = 3;
            this.lblDestinationFolder.Text = "Destination Folder:";
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinationFolder.Location = new System.Drawing.Point(12, 87);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.ReadOnly = true;
            this.txtDestinationFolder.Size = new System.Drawing.Size(408, 23);
            this.txtDestinationFolder.TabIndex = 4;
            // 
            // btnDestinationBrowse
            // 
            this.btnDestinationBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDestinationBrowse.Location = new System.Drawing.Point(426, 86);
            this.btnDestinationBrowse.Name = "btnDestinationBrowse";
            this.btnDestinationBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnDestinationBrowse.TabIndex = 5;
            this.btnDestinationBrowse.Text = "Browse...";
            this.btnDestinationBrowse.UseVisualStyleBackColor = true;
            this.btnDestinationBrowse.Click += new System.EventHandler(this.btnDestinationBrowse_Click);
            // 
            // lblAmendmentDate
            // 
            this.lblAmendmentDate.AutoSize = true;
            this.lblAmendmentDate.Location = new System.Drawing.Point(12, 123);
            this.lblAmendmentDate.Name = "lblAmendmentDate";
            this.lblAmendmentDate.Size = new System.Drawing.Size(103, 15);
            this.lblAmendmentDate.TabIndex = 6;
            this.lblAmendmentDate.Text = "Amendment Date:";
            // 
            // txtAmendmentDate
            // 
            this.txtAmendmentDate.Location = new System.Drawing.Point(12, 141);
            this.txtAmendmentDate.Name = "txtAmendmentDate";
            this.txtAmendmentDate.Size = new System.Drawing.Size(140, 23);
            this.txtAmendmentDate.TabIndex = 7;
            // 
            // lblDateHint
            // 
            this.lblDateHint.AutoSize = true;
            this.lblDateHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDateHint.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDateHint.Location = new System.Drawing.Point(158, 144);
            this.lblDateHint.Name = "lblDateHint";
            this.lblDateHint.Size = new System.Drawing.Size(75, 13);
            this.lblDateHint.TabIndex = 8;
            this.lblDateHint.Text = "(dd/MM/yyyy)";
            // 
            // chkAutoGenerateTransactionId
            // 
            this.chkAutoGenerateTransactionId.AutoSize = true;
            this.chkAutoGenerateTransactionId.Checked = true;
            this.chkAutoGenerateTransactionId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoGenerateTransactionId.Location = new System.Drawing.Point(12, 178);
            this.chkAutoGenerateTransactionId.Name = "chkAutoGenerateTransactionId";
            this.chkAutoGenerateTransactionId.Size = new System.Drawing.Size(205, 19);
            this.chkAutoGenerateTransactionId.TabIndex = 9;
            this.chkAutoGenerateTransactionId.Text = "Auto Generate Transaction ID";
            this.chkAutoGenerateTransactionId.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(12, 215);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(100, 30);
            this.btnChange.TabIndex = 10;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnEsc
            // 
            this.btnEsc.Location = new System.Drawing.Point(118, 215);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(75, 30);
            this.btnEsc.TabIndex = 11;
            this.btnEsc.Text = "Esc";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 261);
            this.Controls.Add(this.lblSourceFolder);
            this.Controls.Add(this.txtSourceFolder);
            this.Controls.Add(this.btnSourceBrowse);
            this.Controls.Add(this.lblDestinationFolder);
            this.Controls.Add(this.txtDestinationFolder);
            this.Controls.Add(this.btnDestinationBrowse);
            this.Controls.Add(this.lblAmendmentDate);
            this.Controls.Add(this.txtAmendmentDate);
            this.Controls.Add(this.lblDateHint);
            this.Controls.Add(this.chkAutoGenerateTransactionId);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnEsc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML Date Amendment Tool";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblSourceFolder;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.Button btnSourceBrowse;
        private System.Windows.Forms.Label lblDestinationFolder;
        private System.Windows.Forms.TextBox txtDestinationFolder;
        private System.Windows.Forms.Button btnDestinationBrowse;
        private System.Windows.Forms.Label lblAmendmentDate;
        private System.Windows.Forms.TextBox txtAmendmentDate;
        private System.Windows.Forms.Label lblDateHint;
        private System.Windows.Forms.CheckBox chkAutoGenerateTransactionId;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnEsc;
    }
}
