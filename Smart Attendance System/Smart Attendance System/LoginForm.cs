using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using Linq.Csv;

namespace Smart_Attendance_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;username=root;password=;database=attendancedb;SSL Mode=None;allow zero datetime=True;");
        public static string NameLogin = "";
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        /*public void Create_CSV()
        {
            string[][] data = new string[][] { new string[] { "1", "2", "3" }, new string[] { "one", "two", "three" } };

            using (var fs = File.Open(@"C:\Users\ghula\Pictures\out.csv", FileMode.OpenOrCreate, FileAccess.Write))
            {
                fs.WriteCsv(data, d => $"Column 1 - {string.Join(" ", d)}", d => $"Column 2 - {string.Join(" ", d)}");
            }
        }*/

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(rbFaculty.Checked)
            {
                string user = tbUsername.Text;
                string pass = tbPassword.Text;

                con.Open();
                String qry = "Select count(*) from lecturer where LecturerName='" + user + "'and Password = '" + pass + "' ";
                MySqlDataAdapter sda1 = new MySqlDataAdapter(qry, con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                if (dt1.Rows[0][0].ToString() == "1")
                {
                    DashboardFaculty dashboard = new DashboardFaculty();
                    dashboard.Show();
                    this.Hide();
                    NameLogin = user;
                    MessageBox.Show("Login Successfull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Create_CSV();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password. Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            else if(rbAdmin.Checked)
            {
                string user = tbUsername.Text;
                string pass = tbPassword.Text;

                con.Open();
                String qry = "Select count(*) from admintable where Aname='" + user + "'and Apassword = '" + pass + "' ";
                MySqlDataAdapter sda1 = new MySqlDataAdapter(qry, con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                if (dt1.Rows[0][0].ToString() == "1")
                {
                    DashboardAdmin dashboardadmin = new DashboardAdmin();
                    dashboardadmin.Show();
                    this.Hide();
                    NameLogin = user;
                    MessageBox.Show("Login Successfull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password. Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Information is missing. Please select your role and enter user name and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void tbPassword_OnValueChanged(object sender, EventArgs e)
        {
            tbPassword.isPassword = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
