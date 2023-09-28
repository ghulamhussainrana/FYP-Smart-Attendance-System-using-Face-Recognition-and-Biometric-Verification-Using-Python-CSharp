using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Attendance_System
{
    public partial class DashboardFacultyUC : UserControl
    {
        public DashboardFacultyUC()
        {
            InitializeComponent();
        }

        private void btnStartRecognition_Click(object sender, EventArgs e)
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
    }
}
