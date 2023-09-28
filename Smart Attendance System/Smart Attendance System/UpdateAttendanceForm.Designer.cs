namespace Smart_Attendance_System
{
    partial class UpdateAttendanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAttendanceForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.DGVUpdateAttendance = new System.Windows.Forms.DataGridView();
            this.tbId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbRollNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbDate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbTime = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbStatus = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUpdateAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 32);
            this.panel1.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.ActiveBorderThickness = 1;
            this.btnExit.ActiveCornerRadius = 1;
            this.btnExit.ActiveFillColor = System.Drawing.Color.White;
            this.btnExit.ActiveForecolor = System.Drawing.Color.LimeGreen;
            this.btnExit.ActiveLineColor = System.Drawing.Color.LimeGreen;
            this.btnExit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.ButtonText = "X";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnExit.IdleBorderThickness = 1;
            this.btnExit.IdleCornerRadius = 1;
            this.btnExit.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.btnExit.IdleForecolor = System.Drawing.Color.White;
            this.btnExit.IdleLineColor = System.Drawing.Color.LimeGreen;
            this.btnExit.Location = new System.Drawing.Point(771, -10);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 51);
            this.btnExit.TabIndex = 4;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(247, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Update Attendance";
            // 
            // DGVUpdateAttendance
            // 
            this.DGVUpdateAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUpdateAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUpdateAttendance.Location = new System.Drawing.Point(297, 49);
            this.DGVUpdateAttendance.Name = "DGVUpdateAttendance";
            this.DGVUpdateAttendance.Size = new System.Drawing.Size(503, 333);
            this.DGVUpdateAttendance.TabIndex = 55;
            this.DGVUpdateAttendance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUpdateAttendance_CellClick);
            // 
            // tbId
            // 
            this.tbId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbId.Enabled = false;
            this.tbId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbId.ForeColor = System.Drawing.Color.White;
            this.tbId.HintForeColor = System.Drawing.Color.Empty;
            this.tbId.HintText = "";
            this.tbId.isPassword = false;
            this.tbId.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbId.LineIdleColor = System.Drawing.Color.Gray;
            this.tbId.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbId.LineThickness = 3;
            this.tbId.Location = new System.Drawing.Point(109, 49);
            this.tbId.Margin = new System.Windows.Forms.Padding(4);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(167, 23);
            this.tbId.TabIndex = 56;
            this.tbId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbName
            // 
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbName.ForeColor = System.Drawing.Color.White;
            this.tbName.HintForeColor = System.Drawing.Color.Empty;
            this.tbName.HintText = "";
            this.tbName.isPassword = false;
            this.tbName.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbName.LineIdleColor = System.Drawing.Color.Gray;
            this.tbName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbName.LineThickness = 3;
            this.tbName.Location = new System.Drawing.Point(109, 80);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(167, 36);
            this.tbName.TabIndex = 57;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbRollNo
            // 
            this.tbRollNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRollNo.Enabled = false;
            this.tbRollNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbRollNo.ForeColor = System.Drawing.Color.White;
            this.tbRollNo.HintForeColor = System.Drawing.Color.Empty;
            this.tbRollNo.HintText = "";
            this.tbRollNo.isPassword = false;
            this.tbRollNo.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbRollNo.LineIdleColor = System.Drawing.Color.Gray;
            this.tbRollNo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbRollNo.LineThickness = 3;
            this.tbRollNo.Location = new System.Drawing.Point(109, 124);
            this.tbRollNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbRollNo.Name = "tbRollNo";
            this.tbRollNo.Size = new System.Drawing.Size(167, 36);
            this.tbRollNo.TabIndex = 57;
            this.tbRollNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbDate
            // 
            this.tbDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDate.Enabled = false;
            this.tbDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbDate.ForeColor = System.Drawing.Color.White;
            this.tbDate.HintForeColor = System.Drawing.Color.Empty;
            this.tbDate.HintText = "";
            this.tbDate.isPassword = false;
            this.tbDate.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbDate.LineIdleColor = System.Drawing.Color.Gray;
            this.tbDate.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbDate.LineThickness = 3;
            this.tbDate.Location = new System.Drawing.Point(109, 168);
            this.tbDate.Margin = new System.Windows.Forms.Padding(4);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(167, 36);
            this.tbDate.TabIndex = 57;
            this.tbDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbTime
            // 
            this.tbTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTime.Enabled = false;
            this.tbTime.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbTime.ForeColor = System.Drawing.Color.White;
            this.tbTime.HintForeColor = System.Drawing.Color.Empty;
            this.tbTime.HintText = "";
            this.tbTime.isPassword = false;
            this.tbTime.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbTime.LineIdleColor = System.Drawing.Color.Gray;
            this.tbTime.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbTime.LineThickness = 3;
            this.tbTime.Location = new System.Drawing.Point(109, 212);
            this.tbTime.Margin = new System.Windows.Forms.Padding(4);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(167, 36);
            this.tbTime.TabIndex = 57;
            this.tbTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 58;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 59;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 60;
            this.label4.Text = "Roll No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 61;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 62;
            this.label6.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 63;
            this.label7.Text = "Status";
            // 
            // tbStatus
            // 
            this.tbStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbStatus.ForeColor = System.Drawing.Color.White;
            this.tbStatus.HintForeColor = System.Drawing.Color.Empty;
            this.tbStatus.HintText = "";
            this.tbStatus.isPassword = false;
            this.tbStatus.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbStatus.LineIdleColor = System.Drawing.Color.Gray;
            this.tbStatus.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbStatus.LineThickness = 3;
            this.tbStatus.Location = new System.Drawing.Point(109, 256);
            this.tbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(167, 36);
            this.tbStatus.TabIndex = 64;
            this.tbStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveBorderThickness = 1;
            this.btnUpdate.ActiveCornerRadius = 20;
            this.btnUpdate.ActiveFillColor = System.Drawing.Color.White;
            this.btnUpdate.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.ButtonText = "Update Attendance";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleCornerRadius = 20;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.IdleForecolor = System.Drawing.Color.White;
            this.btnUpdate.IdleLineColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(49, 325);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(201, 41);
            this.btnUpdate.TabIndex = 65;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UpdateAttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(812, 394);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbRollNo);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.DGVUpdateAttendance);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateAttendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateAttendanceForm";
            this.Load += new System.EventHandler(this.UpdateAttendanceForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUpdateAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVUpdateAttendance;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbId;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbRollNo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbDate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbStatus;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
    }
}