using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;
//using IronPython.Hosting;

namespace Smart_Attendance_System
{
    public partial class DashboardFaculty : Form
    {
        public DashboardFaculty()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;username=root;password=;database=attendancedb;SSL Mode=None;allow zero datetime=True;");
        private void populate()
        {
            //con.Open();
            //string query = "Select tasktodo from todolist";
            //MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
            //MySqlCommandBuilder builder = new MySqlCommandBuilder(sda);
            //var ds = new DataSet();
            //sda.Fill(ds);
            //DGVtodolist.DataSource = ds.Tables[0];
            //con.Close();
            lblName.Text = LoginForm.NameLogin;
        }
        public void run_cmd(string cmd, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = cmd;
            start.Arguments = args;
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            try
            {
                DashboardFacultyUC dashboarduc = new DashboardFacultyUC();
                dashboarduc.Dock = DockStyle.Fill;
                panelMain.Controls.Add(dashboarduc);
                panelMain.Controls["DashboardUC"].BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            populate();
        }

        private void btnAttendanceReport_Click(object sender, EventArgs e)
        {
            try
            {
                AttendanceReportUC attendanceuc = new AttendanceReportUC();
                attendanceuc.Dock = DockStyle.Fill;
                panelMain.Controls.Add(attendanceuc);
                panelMain.Controls["AttendanceReportUC"].BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            try
            {
                AboutUsUC aboutusuc = new AboutUsUC();
                aboutusuc.Dock = DockStyle.Fill;
                panelMain.Controls.Add(aboutusuc);
                panelMain.Controls["AboutUsUC"].BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTodayAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                TodayAttendance todayuc = new TodayAttendance();
                todayuc.Dock = DockStyle.Fill;
                panelMain.Controls.Add(todayuc);
                panelMain.Controls["TodayAttendance"].BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStartRecognition_Click(object sender, EventArgs e)
        {
            /*var p1 = Python.CreateEngine();
            try
            {
                p1.ExecuteFile("G:\\BS CS\\FYP\\FYP_Project\\testingproject.py");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
            try
            {
                DashboardFaculty obj = new DashboardFaculty();
                
                string pythonpath = @"C:\Users\ghula\AppData\Local\Programs\Python\Python39\python.exe";
                string filepath = @"G:\BSCS\FYP\FYP_Project\FaceRecognition\AttendenceProject.py";
                MessageBox.Show("Press 'q' to quit recognition!!!");
                obj.run_cmd(pythonpath, filepath);
                MessageBox.Show("Attendance marked in Database!!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFpEnroll_Click(object sender, EventArgs e)
        {
            try
            {
                FpEnrollmentForm fpenroll = new FpEnrollmentForm();
                fpenroll.Show();
                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFpverify_Click(object sender, EventArgs e)
        {
            try
            {
                FpVerificationForm fpenroll = new FpVerificationForm();
                fpenroll.Show();
                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DashboardFaculty obj = new DashboardFaculty();
                MessageBox.Show("Press 'q' to quit recognition!!!");
                string pythonpath = @"C:\Users\ghula\AppData\Local\Programs\Python\Python39\python.exe";
                string filepath = @"G:\BSCS\FYP\FYP_Project\FaceRecognition\AttendenceProject.py";

                obj.run_cmd(pythonpath, filepath);
                MessageBox.Show("Attendance marked in Database!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            try
            {
                FpVerificationForm fpenroll = new FpVerificationForm();
                fpenroll.Show();
                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            try
            {
                FpEnrollmentForm fpenroll = new FpEnrollmentForm();
                fpenroll.Show();
                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbAddStd_Click(object sender, EventArgs e)
        {
            try
            {
                StudentAddUC stduc = new StudentAddUC();
                stduc.Dock = DockStyle.Fill;
                panelMain.Controls.Add(stduc);
                panelMain.Controls["StudentAddUC"].BringToFront();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DashboardFaculty_Load(object sender, EventArgs e)
        {

        }
    }
}
