using MySql.Data.MySqlClient;
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
    public partial class UpdateAttendanceForm : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;username=root;password=;database=attendancedb;SSL Mode=None;");
        public UpdateAttendanceForm()
        {
            InitializeComponent();
        }
        int index;

        public void populate()
        {
            try
            {
                var dateonly = DateTime.Today.ToString("yyyy-MM-dd");
                con.Open();
                string Select = "select* from stdattendance where Date = '" + dateonly + "'";
                MySqlCommand cmd = new MySqlCommand(Select, con);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                DGVUpdateAttendance.DataSource = ds.Tables[0];
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
        private void UpdateAttendanceForm_Load(object sender, EventArgs e)
        {
            try
            {
                var dateonly = DateTime.Today.ToString("yyyy-MM-dd");
                con.Open();
                string Select = "select* from stdattendance where Date = '" + dateonly + "'";
                MySqlCommand cmd = new MySqlCommand(Select, con);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                DGVUpdateAttendance.DataSource = ds.Tables[0];
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

        private void DGVUpdateAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = DGVUpdateAttendance.Rows[index];
            tbId.Text = row.Cells[0].Value.ToString();
            tbName.Text = row.Cells[1].Value.ToString();
            tbRollNo.Text = row.Cells[2].Value.ToString();
            tbDate.Text = row.Cells[3].Value.ToString();
            tbTime.Text = row.Cells[4].Value.ToString();
            tbStatus.Text = row.Cells[5].Value.ToString();
            /*tbId.Text = DGVUpdateAttendance.Rows[0].Cells[0].Value.ToString();
            tbName.Text = DGVUpdateAttendance.SelectedRows[0].Cells[1].Value.ToString();
            tbRollNo.Text = DGVUpdateAttendance.SelectedRows[0].Cells[2].Value.ToString();
            tbDate.Text = DGVUpdateAttendance.SelectedRows[0].Cells[3].Value.ToString();
            tbTime.Text = DGVUpdateAttendance.SelectedRows[0].Cells[4].Value.ToString();
            tbStatus.Text = DGVUpdateAttendance.SelectedRows[0].Cells[5].Value.ToString();*/
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbId.Text == "" || tbName.Text == "" || tbRollNo.Text == "" || tbDate.Text == "" || tbTime.Text == "" || tbStatus.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "Update stdattendance set Name='" + tbName.Text + "', RollNo='" + tbRollNo.Text + "', Status='" + tbStatus.Text + "' where ID=" + tbId.Text + "";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance Updated Successfully");
                    con.Close();
                    populate();
                }
                tbId.Text = "";
                tbName.Text = "";
                tbRollNo.Text = "";
                tbDate.Text = "";
                tbTime.Text = "";
                tbStatus.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
