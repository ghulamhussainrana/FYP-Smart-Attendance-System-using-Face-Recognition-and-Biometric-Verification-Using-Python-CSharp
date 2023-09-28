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
    public partial class TodayAttendance : UserControl
    {
        public TodayAttendance()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost;username=root;password=;database=attendancedb;SSL Mode=None;");
        //;allow zero datetime=True
        private void btnShowToday_Click(object sender, EventArgs e)
        {
            try
            {
                var dateonly = DateTime.Today.ToString("yyyy-MM-dd");
                con.Open();
                string Select = "select* from attendancetest where Date = '"+ dateonly + "'";
                MySqlCommand cmd = new MySqlCommand(Select, con);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                DGVTodayAttendance.DataSource = ds.Tables[0];
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DGVTodayAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAttendanceForm update = new UpdateAttendanceForm();
            update.Show();
            
        }
    }
}
