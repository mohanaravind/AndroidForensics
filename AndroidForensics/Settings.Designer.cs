namespace AndroidForensics
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDK = new System.Windows.Forms.TextBox();
            this.grpExtractionConfig = new System.Windows.Forms.GroupBox();
            this.chkCalendar = new System.Windows.Forms.CheckBox();
            this.chkContacts = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.chkSettings = new System.Windows.Forms.CheckBox();
            this.chkDownloads = new System.Windows.Forms.CheckBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.chkBrowser = new System.Windows.Forms.CheckBox();
            this.chkTelephony = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.grpExtractionConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSDK);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Folder Paths";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output";
            // 
            // txtOutput
            // 
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOutput.Location = new System.Drawing.Point(61, 61);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(298, 22);
            this.txtOutput.TabIndex = 3;
            this.txtOutput.Text = "C:\\Users\\Aravind\\Desktop\\AF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SDK";
            // 
            // txtSDK
            // 
            this.txtSDK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDK.Location = new System.Drawing.Point(61, 21);
            this.txtSDK.Name = "txtSDK";
            this.txtSDK.Size = new System.Drawing.Size(298, 22);
            this.txtSDK.TabIndex = 0;
            this.txtSDK.Text = "C:\\Program Files (x86)\\Android\\android-sdk";
            // 
            // grpExtractionConfig
            // 
            this.grpExtractionConfig.Controls.Add(this.chkCalendar);
            this.grpExtractionConfig.Controls.Add(this.chkContacts);
            this.grpExtractionConfig.Controls.Add(this.checkBox3);
            this.grpExtractionConfig.Controls.Add(this.chkSettings);
            this.grpExtractionConfig.Controls.Add(this.chkDownloads);
            this.grpExtractionConfig.Controls.Add(this.chkEmail);
            this.grpExtractionConfig.Controls.Add(this.chkBrowser);
            this.grpExtractionConfig.Controls.Add(this.chkTelephony);
            this.grpExtractionConfig.Location = new System.Drawing.Point(12, 129);
            this.grpExtractionConfig.Name = "grpExtractionConfig";
            this.grpExtractionConfig.Size = new System.Drawing.Size(374, 113);
            this.grpExtractionConfig.TabIndex = 2;
            this.grpExtractionConfig.TabStop = false;
            this.grpExtractionConfig.Text = "Extraction Configuration";
            // 
            // chkCalendar
            // 
            this.chkCalendar.AutoSize = true;
            this.chkCalendar.Location = new System.Drawing.Point(273, 34);
            this.chkCalendar.Name = "chkCalendar";
            this.chkCalendar.Size = new System.Drawing.Size(72, 17);
            this.chkCalendar.TabIndex = 9;
            this.chkCalendar.Tag = "com.android.providers.calendar/databases;calendar.db";
            this.chkCalendar.Text = "Calendar";
            this.chkCalendar.UseVisualStyleBackColor = true;
            // 
            // chkContacts
            // 
            this.chkContacts.AutoSize = true;
            this.chkContacts.Location = new System.Drawing.Point(274, 74);
            this.chkContacts.Name = "chkContacts";
            this.chkContacts.Size = new System.Drawing.Size(71, 17);
            this.chkContacts.TabIndex = 8;
            this.chkContacts.Tag = "com.android.providers.contacts/databases;contacts2.db,profile.db";
            this.chkContacts.Text = "Contacts";
            this.chkContacts.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(200, 74);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(46, 17);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Tag = "com.whatsapp/databases;msgstore.db";
            this.checkBox3.Text = "Talk";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // chkSettings
            // 
            this.chkSettings.AutoSize = true;
            this.chkSettings.Location = new System.Drawing.Point(126, 74);
            this.chkSettings.Name = "chkSettings";
            this.chkSettings.Size = new System.Drawing.Size(68, 17);
            this.chkSettings.TabIndex = 5;
            this.chkSettings.Tag = "com.android.providers.settings/databases;settings.db";
            this.chkSettings.Text = "Settings";
            this.chkSettings.UseVisualStyleBackColor = true;
            // 
            // chkDownloads
            // 
            this.chkDownloads.AutoSize = true;
            this.chkDownloads.Location = new System.Drawing.Point(29, 74);
            this.chkDownloads.Name = "chkDownloads";
            this.chkDownloads.Size = new System.Drawing.Size(85, 17);
            this.chkDownloads.TabIndex = 4;
            this.chkDownloads.Tag = "com.android.providers.downloads/databases;downloads.db";
            this.chkDownloads.Text = "Downloads";
            this.chkDownloads.UseVisualStyleBackColor = true;
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Checked = true;
            this.chkEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEmail.Location = new System.Drawing.Point(200, 34);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(53, 17);
            this.chkEmail.TabIndex = 3;
            this.chkEmail.Tag = "com.google.android.email/databases;EmailProvider.db";
            this.chkEmail.Text = "Email";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // chkBrowser
            // 
            this.chkBrowser.AutoSize = true;
            this.chkBrowser.Checked = true;
            this.chkBrowser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBrowser.Location = new System.Drawing.Point(126, 34);
            this.chkBrowser.Name = "chkBrowser";
            this.chkBrowser.Size = new System.Drawing.Size(68, 17);
            this.chkBrowser.TabIndex = 2;
            this.chkBrowser.Tag = "com.google.android.browser/databases;autofill.db,browser2.db,webview.db";
            this.chkBrowser.Text = "Browser";
            this.chkBrowser.UseVisualStyleBackColor = true;
            // 
            // chkTelephony
            // 
            this.chkTelephony.AutoSize = true;
            this.chkTelephony.Checked = true;
            this.chkTelephony.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTelephony.Location = new System.Drawing.Point(29, 34);
            this.chkTelephony.Name = "chkTelephony";
            this.chkTelephony.Size = new System.Drawing.Size(79, 17);
            this.chkTelephony.TabIndex = 1;
            this.chkTelephony.Tag = "com.android.providers.telephony/databases;telephony.db,mmssms.db";
            this.chkTelephony.Text = "Telephony";
            this.chkTelephony.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 256);
            this.Controls.Add(this.grpExtractionConfig);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpExtractionConfig.ResumeLayout(false);
            this.grpExtractionConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSDK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox grpExtractionConfig;
        private System.Windows.Forms.CheckBox chkCalendar;
        private System.Windows.Forms.CheckBox chkContacts;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox chkSettings;
        private System.Windows.Forms.CheckBox chkDownloads;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.CheckBox chkBrowser;
        private System.Windows.Forms.CheckBox chkTelephony;
    }
}