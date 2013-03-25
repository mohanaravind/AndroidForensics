namespace AndroidForensics
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnExtract = new System.Windows.Forms.Button();
            this.lnkSettings = new System.Windows.Forms.LinkLabel();
            this.grpDeviceInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDeviceStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picDeviceStatus = new System.Windows.Forms.PictureBox();
            this.grpExtractionInfo = new System.Windows.Forms.GroupBox();
            this.txtExtractionInfo = new System.Windows.Forms.TextBox();
            this.grpDeviceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeviceStatus)).BeginInit();
            this.grpExtractionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExtract
            // 
            this.btnExtract.Enabled = false;
            this.btnExtract.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtract.Location = new System.Drawing.Point(470, 319);
            this.btnExtract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 24);
            this.btnExtract.TabIndex = 0;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // lnkSettings
            // 
            this.lnkSettings.AutoSize = true;
            this.lnkSettings.Location = new System.Drawing.Point(496, 7);
            this.lnkSettings.Name = "lnkSettings";
            this.lnkSettings.Size = new System.Drawing.Size(49, 13);
            this.lnkSettings.TabIndex = 1;
            this.lnkSettings.TabStop = true;
            this.lnkSettings.Text = "Settings";
            this.lnkSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSettings_LinkClicked);
            // 
            // grpDeviceInfo
            // 
            this.grpDeviceInfo.Controls.Add(this.pictureBox1);
            this.grpDeviceInfo.Controls.Add(this.lblDeviceStatus);
            this.grpDeviceInfo.Controls.Add(this.label3);
            this.grpDeviceInfo.Controls.Add(this.lblSerialNumber);
            this.grpDeviceInfo.Controls.Add(this.label1);
            this.grpDeviceInfo.Controls.Add(this.picDeviceStatus);
            this.grpDeviceInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDeviceInfo.Location = new System.Drawing.Point(12, 23);
            this.grpDeviceInfo.Name = "grpDeviceInfo";
            this.grpDeviceInfo.Size = new System.Drawing.Size(533, 124);
            this.grpDeviceInfo.TabIndex = 3;
            this.grpDeviceInfo.TabStop = false;
            this.grpDeviceInfo.Text = "Device Informatoin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AndroidForensics.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(470, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblDeviceStatus
            // 
            this.lblDeviceStatus.AutoSize = true;
            this.lblDeviceStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceStatus.Location = new System.Drawing.Point(247, 43);
            this.lblDeviceStatus.Name = "lblDeviceStatus";
            this.lblDeviceStatus.Size = new System.Drawing.Size(77, 13);
            this.lblDeviceStatus.TabIndex = 8;
            this.lblDeviceStatus.Text = "Disconnected";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Device Status:";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNumber.Location = new System.Drawing.Point(247, 79);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(84, 13);
            this.lblSerialNumber.TabIndex = 6;
            this.lblSerialNumber.Text = "###########";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Serial Number:";
            // 
            // picDeviceStatus
            // 
            this.picDeviceStatus.Image = global::AndroidForensics.Properties.Resources.Disconnected;
            this.picDeviceStatus.Location = new System.Drawing.Point(27, 34);
            this.picDeviceStatus.Name = "picDeviceStatus";
            this.picDeviceStatus.Size = new System.Drawing.Size(64, 64);
            this.picDeviceStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDeviceStatus.TabIndex = 3;
            this.picDeviceStatus.TabStop = false;
            // 
            // grpExtractionInfo
            // 
            this.grpExtractionInfo.Controls.Add(this.txtExtractionInfo);
            this.grpExtractionInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExtractionInfo.Location = new System.Drawing.Point(12, 153);
            this.grpExtractionInfo.Name = "grpExtractionInfo";
            this.grpExtractionInfo.Size = new System.Drawing.Size(533, 147);
            this.grpExtractionInfo.TabIndex = 4;
            this.grpExtractionInfo.TabStop = false;
            this.grpExtractionInfo.Text = "Extraction Informatoin";
            // 
            // txtExtractionInfo
            // 
            this.txtExtractionInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtractionInfo.Location = new System.Drawing.Point(6, 21);
            this.txtExtractionInfo.Multiline = true;
            this.txtExtractionInfo.Name = "txtExtractionInfo";
            this.txtExtractionInfo.ReadOnly = true;
            this.txtExtractionInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExtractionInfo.Size = new System.Drawing.Size(521, 113);
            this.txtExtractionInfo.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 357);
            this.Controls.Add(this.grpExtractionInfo);
            this.Controls.Add(this.grpDeviceInfo);
            this.Controls.Add(this.lnkSettings);
            this.Controls.Add(this.btnExtract);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Android Forensics";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpDeviceInfo.ResumeLayout(false);
            this.grpDeviceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeviceStatus)).EndInit();
            this.grpExtractionInfo.ResumeLayout(false);
            this.grpExtractionInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.LinkLabel lnkSettings;
        private System.Windows.Forms.GroupBox grpDeviceInfo;
        private System.Windows.Forms.PictureBox picDeviceStatus;
        private System.Windows.Forms.Label lblDeviceStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpExtractionInfo;
        private System.Windows.Forms.TextBox txtExtractionInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

