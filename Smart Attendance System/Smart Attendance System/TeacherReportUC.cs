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
    public partial class TeacherReportUC : UserControl
    {
        public TeacherReportUC()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;username=root;password=;database=attendancedb;SSL Mode=None;");
        private void fillcomboDep()
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Select DepName from departmenttable", con);
            MySqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("DepName", typeof(string));
            dt.Load(rdr);
            cbDepartment.ValueMember = "DepName";
            cbDepartment.DataSource = dt;
            con.Close();
        }
        private void fillcomboTeacher()
        {
            con.Close();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Select LecturerName from lecturer WHERE Department = '" + cbDepartment.Text + "'", con);
            MySqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("LecturerName", typeof(string));
            dt.Load(rdr);
            cbTeacher.ValueMember = "LecturerName";
            cbTeacher.DataSource = dt;
            con.Close();
            
        }
        private void fillcomboSubject()
        {
            con.Close();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Select SubjectName from subjecttable WHERE TeacherName = '" + cbTeacher.Text + "'", con);
            MySqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("SubjectName", typeof(string));
            dt.Load(rdr);
            cbSubject.ValueMember = "SubjectName";
            cbSubject.DataSource = dt;
            con.Close();
        }
        public void populate()
        {
            try
            {
                con.Open();
                string Select = "select* from attendancetest where Department = '" + cbDepartment.Text + "' AND TeacherName = '" + cbTeacher.Text + "' AND SubjectName = '" + cbSubject.Text + "'";
                MySqlCommand cmd = new MySqlCommand(Select, con);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                DGVreport.DataSource = ds.Tables[0];
                con.Close();

                /*con.Open();
                string q = "SELECT * FROM stdattendance where AttendanceDate = ";
                MySqlCommand cmd = new MySqlCommand(q, con);
                var reader = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                DGVTodayAttendance.DataSource = table;
                con.Close();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void TeacherReportUC_Load(object sender, EventArgs e)
        {
            
            fillcomboDep();
            
        }
        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillcomboTeacher();

        }
        private void cbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillcomboSubject();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
