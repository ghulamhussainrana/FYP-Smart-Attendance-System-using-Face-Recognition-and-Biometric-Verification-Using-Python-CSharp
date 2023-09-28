using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Smart_Attendance_System
{
    public partial class AttendanceReportUC : UserControl
    {
        public AttendanceReportUC()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;username=root;password=;database=attendancedb;SSL Mode=None;");

        private void fillcomboSubject()
        {
            con.Close();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Select SubjectName from subjecttable WHERE TeacherName = '" + LoginForm.NameLogin + "'", con);
            MySqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SubjectName", typeof(string));
            dt.Load(rdr);
            comboBox1.ValueMember = "SubjectName";
            comboBox1.DataSource = dt;
            con.Close();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cbSearch.Text == "Date")
            {
                try
                {
                    con.Open();
                    string Select = "select* from attendancetest where Date between '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "' and TeacherName = '" + LoginForm.NameLogin + "' ";
                    MySqlCommand cmd = new MySqlCommand(Select, con);
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    DGVAttendanceReport.DataSource = ds.Tables[0];
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (cbSearch.Text == "Subject")
            {
                try
                {
                    con.Open();
                    string Select = "select* from attendancetest where Date between '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "' and TeacherName = '" + LoginForm.NameLogin + "' ";
                    MySqlCommand cmd = new MySqlCommand(Select, con);
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    DGVAttendanceReport.DataSource = ds.Tables[0];
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (cbSearch.Text == "Roll No")
            {
                try
                {
                    con.Open();
                    string roll = comboBox1.Text;
                    //string Select = "select* from attendancetest where Date between '" + dateTimePicker1.Text + "' and '" + dateTimePicker2.Text + "' and TeacherName = '" + LoginForm.NameLogin + "' ";
                    string Select = "select* from attendancetest where RollNo = '" + roll + "'";
                    MySqlCommand cmd = new MySqlCommand(Select, con);
                    MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    DGVAttendanceReport.DataSource = ds.Tables[0];
                    con.Close();
                    comboBox1.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AttendanceReportUC_Load(object sender, EventArgs e)
        {

        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearch.Text == "Subject")
            {
                fillcomboSubject();
            }
            else
            {
                comboBox1.Text = "";
            }
            
        }
    }
}
