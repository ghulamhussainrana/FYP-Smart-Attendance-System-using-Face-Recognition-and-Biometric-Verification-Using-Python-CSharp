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
    public partial class AddTeacherUC : UserControl
    {
        public AddTeacherUC()
        {
            InitializeComponent();
        }
        int index;
        
        MySqlConnection con = new MySqlConnection("server=localhost;username=root;password=;database=attendancedb;SSL Mode=None;");

        public void populate()
        {
            try
            {
                con.Open();
                string Select = "select* from lecturer";
                MySqlCommand cmd = new MySqlCommand(Select, con);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                DGVaddteacher.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void get_max_id()
        {
            String ID;
            con.Open();
            string query1 = "SELECT max(LecturerID) from lecturer";
            MySqlCommand cmd1 = new MySqlCommand(query1, con);
            MySqlDataReader reader = cmd1.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                ID = reader.GetString(0);
                int ID1 = Convert.ToInt32(ID);
                ID1 = ID1 + 1;
                tbTeacherid.Text = ID1.ToString();
            }
            con.Close();
        }
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO lecturer(LecturerID,LecturerName, Password, Subject, Department, LectureTime) VALUES ('" + tbTeacherid.Text + "','" + tbTeacherName.Text + "','" + tbPass.Text + "','" + tbSubject.Text + "','" + tbDepartment.Text + "','" + dateTimePicker1.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Teacher Added Successful");
                con.Close();
                get_max_id();
                tbTeacherName.Text = ""; tbDepartment.Text = ""; tbSubject.Text = ""; tbPass.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddTeacherUC_Load(object sender, EventArgs e)
        {
            populate();
            get_max_id();
            /*String ID;
            con.Open();
            string query1 = "SELECT max(LecturerID) from lecturer";
            MySqlCommand cmd1 = new MySqlCommand(query1, con);
            MySqlDataReader reader = cmd1.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                ID = reader.GetString(0);
                int ID1 = Convert.ToInt32(ID);
                ID1 = ID1 + 1;
                tbTeacherid.Text = ID1.ToString();
            }
            con.Close();*/
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbTeacherName.Text == "" || tbSubject.Text == "" || tbPass.Text == "" || tbDepartment.Text == "" || dateTimePicker1.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    con.Open();
                    string query = "Update lecturer set LecturerName='" + tbTeacherName.Text + "', Password='" + tbPass.Text + "', Subject='" + tbSubject.Text + "', Department='" + tbDepartment.Text + "',LectureTime='" + dateTimePicker1.Text + "' WHERE LecturerID =" + tbTeacherid.Text + "";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfully");
                    con.Close();
                    populate();
                }
                get_max_id();
                tbTeacherName.Text = "";
                tbSubject.Text = "";
                tbPass.Text = "";
                tbDepartment.Text = "";
                dateTimePicker1.Text = "00:00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGVaddteacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = DGVaddteacher.Rows[index];
            tbTeacherid.Text = row.Cells[0].Value.ToString();
            tbTeacherName.Text = row.Cells[1].Value.ToString();
            tbPass.Text = row.Cells[2].Value.ToString();
            tbSubject.Text = row.Cells[3].Value.ToString();
            tbDepartment.Text = row.Cells[4].Value.ToString();
            dateTimePicker1.Text = row.Cells[5].Value.ToString();
        }

        private void DGVaddteacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
