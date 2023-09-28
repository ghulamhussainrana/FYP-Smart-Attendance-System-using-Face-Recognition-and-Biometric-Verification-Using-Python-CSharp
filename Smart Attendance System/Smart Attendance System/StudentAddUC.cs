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
    public partial class StudentAddUC : UserControl
    {
        public StudentAddUC()
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
            tbDepartment.ValueMember = "DepName";
            tbDepartment.DataSource = dt;
            con.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Image";
            //ofd.Filter = "Image Files(*.JPEG,*.JPG,*.PNG,*.GIF,*.jpeg,*.jpg,*.png,*.gif)|*.JPEG,*.JPG,*.PNG,*.GIF,*.jpeg,*.jpg,*.png,*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                pictureBox1.Image = img;
            }*/
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                con.Open();
                string query = "INSERT INTO stddetails(RegistrationNo, StdName, stdRollNo, stdGender, stdDOB,Program,Department,stdPicture) VALUES ('" + tbRegNo.Text + "','" + tbName.Text + "','" + tbRollNo.Text + "','" + cbGender.Text + "','" + dateTimePicker1.Text + "','" + cbProgram.Text + "','" + tbDepartment.Text + "','" + pictureBox1.Image + "')";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Teacher Added Successful");
                con.Close();
                tbStdId.Text = ""; tbRegNo.Text = ""; tbName.Text = ""; tbRollNo.Text = "";
                cbGender.Text = "";
                cbProgram.Text = "";
                tbDepartment.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StudentAddUC_Load(object sender, EventArgs e)
        {
            fillcomboDep();
            String ID;
            con.Open();
            string query1 = "SELECT max(ID) from stddetails";
            MySqlCommand cmd1 = new MySqlCommand(query1, con);
            MySqlDataReader reader = cmd1.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                ID = reader.GetString(0);
                int ID1 = Convert.ToInt32(ID);
                ID1 = ID1 + 1;
                tbStdId.Text = ID1.ToString();
            }
            con.Close();
        }
    }
}
