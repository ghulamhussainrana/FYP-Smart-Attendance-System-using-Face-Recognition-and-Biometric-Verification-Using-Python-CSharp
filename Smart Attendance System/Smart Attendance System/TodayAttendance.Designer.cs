namespace Smart_Attendance_System
{
    partial class TodayAttendance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodayAttendance));
            this.btnShowToday = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DGVTodayAttendance = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTodayAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowToday
            // 
            this.btnShowToday.ActiveBorderThickness = 1;
            this.btnShowToday.ActiveCornerRadius = 20;
            this.btnShowToday.ActiveFillColor = System.Drawing.Color.White;
            this.btnShowToday.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowToday.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowToday.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnShowToday.BackgroundImage")));
            this.btnShowToday.ButtonText = "Show Today\'s Attendance";
            this.btnShowToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowToday.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowToday.IdleBorderThickness = 1;
            this.btnShowToday.IdleCornerRadius = 20;
            this.btnShowToday.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShowToday.IdleForecolor = System.Drawing.Color.White;
            this.btnShowToday.IdleLineColor = System.Drawing.Color.White;
            this.btnShowToday.Location = new System.Drawing.Point(13, 330);
            this.btnShowToday.Margin = new System.Windows.Forms.Padding(5);
            this.btnShowToday.Name = "btnShowToday";
            this.btnShowToday.Size = new System.Drawing.Size(238, 41);
            this.btnShowToday.TabIndex = 53;
            this.btnShowToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShowToday.Click += new System.EventHandler(this.btnShowToday_Click);
            // 
            // DGVTodayAttendance
            // 
            this.DGVTodayAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVTodayAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTodayAttendance.Location = new System.Drawing.Point(13, 14);
            this.DGVTodayAttendance.Name = "DGVTodayAttendance";
            this.DGVTodayAttendance.Size = new System.Drawing.Size(525, 308);
            this.DGVTodayAttendance.TabIndex = 54;
            this.DGVTodayAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTodayAttendance_CellContentClick);
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
            this.btnUpdate.ButtonText = "Update Today\'s Attendance";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.IdleBorderThickness = 1;
            this.btnUpdate.IdleCornerRadius = 20;
            this.btnUpdate.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.IdleForecolor = System.Drawing.Color.White;
            this.btnUpdate.IdleLineColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(290, 330);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(248, 41);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // TodayAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.DGVTodayAttendance);
            this.Controls.Add(this.btnShowToday);
            this.Name = "TodayAttendance";
            this.Size = new System.Drawing.Size(553, 389);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTodayAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuThinButton2 btnShowToday;
        private System.Windows.Forms.DataGridView DGVTodayAttendance;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdate;
    }
}
