namespace Smart_Attendance_System
{
    partial class FpVerificationForm
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
            this.cboReaders = new System.Windows.Forms.ComboBox();
            this.lblSelectReader = new System.Windows.Forms.Label();
            this.lblPlaceFinger = new System.Windows.Forms.Label();
            this.pbFingerprint = new System.Windows.Forms.PictureBox();
            this.tbNameVerify = new System.Windows.Forms.TextBox();
            this.cbSubVerify = new System.Windows.Forms.ComboBox();
            this.cbDepVerify = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFingerprint)).BeginInit();
            this.SuspendLayout();
            // 
            // cboReaders
            // 
            this.cboReaders.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cboReaders.Location = new System.Drawing.Point(36, 341);
            this.cboReaders.Name = "cboReaders";
            this.cboReaders.Size = new System.Drawing.Size(159, 21);
            this.cboReaders.TabIndex = 29;
            // 
            // lblSelectReader
            // 
            this.lblSelectReader.Location = new System.Drawing.Point(33, 325);
            this.lblSelectReader.Name = "lblSelectReader";
            this.lblSelectReader.Size = new System.Drawing.Size(121, 13);
            this.lblSelectReader.TabIndex = 28;
            this.lblSelectReader.Text = "Select Reader:";
            // 
            // lblPlaceFinger
            // 
            this.lblPlaceFinger.Location = new System.Drawing.Point(34, 294);
            this.lblPlaceFinger.Name = "lblPlaceFinger";
            this.lblPlaceFinger.Size = new System.Drawing.Size(146, 19);
            this.lblPlaceFinger.TabIndex = 26;
            this.lblPlaceFinger.Text = "Place a finger on the reader";
            // 
            // pbFingerprint
            // 
            this.pbFingerprint.Location = new System.Drawing.Point(36, 122);
            this.pbFingerprint.Name = "pbFingerprint";
            this.pbFingerprint.Size = new System.Drawing.Size(159, 169);
            this.pbFingerprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFingerprint.TabIndex = 27;
            this.pbFingerprint.TabStop = false;
            // 
            // tbNameVerify
            // 
            this.tbNameVerify.Enabled = false;
            this.tbNameVerify.Location = new System.Drawing.Point(37, 12);
            this.tbNameVerify.Name = "tbNameVerify";
            this.tbNameVerify.Size = new System.Drawing.Size(158, 20);
            this.tbNameVerify.TabIndex = 30;
            // 
            // cbSubVerify
            // 
            this.cbSubVerify.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubVerify.FormattingEnabled = true;
            this.cbSubVerify.Location = new System.Drawing.Point(36, 65);
            this.cbSubVerify.Name = "cbSubVerify";
            this.cbSubVerify.Size = new System.Drawing.Size(158, 21);
            this.cbSubVerify.TabIndex = 31;
            // 
            // cbDepVerify
            // 
            this.cbDepVerify.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepVerify.FormattingEnabled = true;
            this.cbDepVerify.Location = new System.Drawing.Point(37, 38);
            this.cbDepVerify.Name = "cbDepVerify";
            this.cbDepVerify.Size = new System.Drawing.Size(158, 21);
            this.cbDepVerify.TabIndex = 31;
            // 
            // FpVerificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 378);
            this.Controls.Add(this.cbSubVerify);
            this.Controls.Add(this.cbDepVerify);
            this.Controls.Add(this.tbNameVerify);
            this.Controls.Add(this.cboReaders);
            this.Controls.Add(this.lblSelectReader);
            this.Controls.Add(this.lblPlaceFinger);
            this.Controls.Add(this.pbFingerprint);
            this.Name = "FpVerificationForm";
            this.Text = "FpVerificationForm";
            this.Load += new System.EventHandler(this.FpVerificationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFingerprint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cboReaders;
        internal System.Windows.Forms.Label lblSelectReader;
        internal System.Windows.Forms.Label lblPlaceFinger;
        internal System.Windows.Forms.PictureBox pbFingerprint;
        private System.Windows.Forms.TextBox tbNameVerify;
        private System.Windows.Forms.ComboBox cbSubVerify;
        private System.Windows.Forms.ComboBox cbDepVerify;
    }
}