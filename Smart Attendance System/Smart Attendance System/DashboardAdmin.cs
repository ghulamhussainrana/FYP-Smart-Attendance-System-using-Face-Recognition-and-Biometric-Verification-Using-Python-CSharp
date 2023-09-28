using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Attendance_System
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void btnTeacherReport_Click(object sender, EventArgs e)
        {
            try
            {
                TeacherReportUC reportuc = new TeacherReportUC();
                reportuc.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(reportuc);
                MainPanel.Controls["TeacherReportUC"].BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExitAdmin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                AddTeacherUC teacheruc = new AddTeacherUC();
                teacheruc.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(teacheruc);
                MainPanel.Controls["AddTeacherUC"].BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                StudentAddUC stduc = new StudentAddUC();
                stduc.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(stduc);
                MainPanel.Controls["StudentAddUC"].BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            lblName.Text = LoginForm.NameLogin;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }
    }
}
