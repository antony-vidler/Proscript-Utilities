namespace XmlDateAmendment
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblSourceFolder;
        private System.Windows.Forms.TextBox txtSourceFolder;
        private System.Windows.Forms.Button btnSourceBrowse;
        private System.Windows.Forms.Label lblDestinationFolder;
        private System.Windows.Forms.TextBox txtDestinationFolder;
        private System.Windows.Forms.Button btnDestinationBrowse;
        private System.Windows.Forms.Label lblAmendmentDate;
        private System.Windows.Forms.TextBox txtAmendmentDate;
        private System.Windows.Forms.CheckBox chkAutoGenerateTransactionId;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnEsc;

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
            this.lblSourceFolder.Size = new System.Drawing.Size(88, 13);
            this.lblSourceFolder.TabIndex = 0;
            this.lblSourceFolder.Text = "Source Folder:";
            // 
            // txtSourceFolder
            // 
            this.txtSourceFolder.Location = new System.Drawing.Point(106, 12);
            this.txtSourceFolder.Name = "txtSourceFolder";
            this.txtSourceFolder.Size = new System.Drawing.Size(250, 20);
            this.txtSourceFolder.TabIndex = 1;
            // 
            // btnSourceBrowse
            // 
            this.btnSourceBrowse.Location = new System.Drawing.Point(362, 10);
            this.btnSourceBrowse.Name = "btnSourceBrowse";
            this.btnSourceBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnSourceBrowse.TabIndex = 2;
            this.btnSourceBrowse.Text = "Browse";
            this.btnSourceBrowse.UseVisualStyleBackColor = true;
            // 
            // lblDestinationFolder
            // 
            this.lblDestinationFolder.AutoSize = true;
            this.lblDestinationFolder.Location = new System.Drawing.Point(12, 41);
            this.lblDestinationFolder.Name = "lblDestinationFolder";
            this.lblDestinationFolder.Size = new System.Drawing.Size(105, 13);
            this.lblDestinationFolder.TabIndex = 3;
            this.lblDestinationFolder.Text = "Destination Folder:";
            // 
            // txtDestinationFolder
            // 
            this.txtDestinationFolder.Location = new System.Drawing.Point(123, 38);
            this.txtDestinationFolder.Name = "txtDestinationFolder";
            this.txtDestinationFolder.Size = new System.Drawing.Size(250, 20);
            this.txtDestinationFolder.TabIndex = 4;
            // 
            // btnDestinationBrowse
            // 
            this.btnDestinationBrowse.Location = new System.Drawing.Point(379, 36);
            this.btnDestinationBrowse.Name = "btnDestinationBrowse";
            this.btnDestinationBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnDestinationBrowse.TabIndex = 5;
            this.btnDestinationBrowse.Text = "Browse";
            this.btnDestinationBrowse.UseVisualStyleBackColor = true;
            // 
            // lblAmendmentDate
            // 
            this.lblAmendmentDate.AutoSize = true;
            this.lblAmendmentDate.Location = new System.Drawing.Point(12, 67);
            this.lblAmendmentDate.Name = "lblAmendmentDate";
            this.lblAmendmentDate.Size = new System.Drawing.Size(98, 13);
            this.lblAmendmentDate.TabIndex = 6;
            this.lblAmendmentDate.Text = "Amendment Date:";
            // 
            // txtAmendmentDate
            // 
            this.txtAmendmentDate.Location = new System.Drawing.Point(116, 64);
            this.txtAmendmentDate.Name = "txtAmendmentDate";
            this.txtAmendmentDate.Size = new System.Drawing.Size(100, 20);
            this.txtAmendmentDate.TabIndex = 7;
            // 
            // chkAutoGenerateTransactionId
            // 
            this.chkAutoGenerateTransactionId.AutoSize = true;
            this.chkAutoGenerateTransactionId.Location = new System.Drawing.Point(12, 90);
            this.chkAutoGenerateTransactionId.Name = "chkAutoGenerateTransactionId";
            this.chkAutoGenerateTransactionId.Size = new System.Drawing.Size(196, 17);
            this.chkAutoGenerateTransactionId.TabIndex = 8;
            this.chkAutoGenerateTransactionId.Text = "Auto Generate Transaction ID";
            this.chkAutoGenerateTransactionId.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(12, 113);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnEsc
            // 
            this.btnEsc.Location = new System.Drawing.Point(93, 113);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(75, 23);
            this.btnEsc.TabIndex = 10;
            this.btnEsc.Text = "Esc";
            this.btnEsc.UseVisualStyleBackColor = true;

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 161);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.chkAutoGenerateTransactionId);
            this.Controls.Add(this.txtAmendmentDate);
            this.Controls.Add(this.lblAmendmentDate);
            this.Controls.Add(this.btnDestinationBrowse);
            this.Controls.Add(this.txtDestinationFolder);
            this.Controls.Add(this.lblDestinationFolder);
            this.Controls.Add(this.btnSourceBrowse);
            this.Controls.Add(this.txtSourceFolder);
            this.Controls.Add(this.lblSourceFolder);
            this.Name = "MainForm";
            this.Text = "XML Date Amendment";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}