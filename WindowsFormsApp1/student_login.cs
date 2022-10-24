using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class student_login : Form
    {
        public string connection_string = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=hello;Password=hello";

        public student_login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Slogin_btn_Click(object sender, EventArgs e)
        {
            string id = " ";
            string pass = " ";
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            string query = "select username,password from studentlogin where username='" + student_username.Text + "'";
            OracleCommand cmd = new OracleCommand(query, ocl);
            OracleDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                id = r["username"].ToString();
                pass = r["password"].ToString();
                //  MessageBox.Show(id + pass);
            }

            ocl.Close();

            if (student_username.Text == " " || password_student.Text == " ")
            {
                MessageBox.Show("Please Enter Username and Password.\n Thank You!");
            }
            else if (student_username.Text == id && password_student.Text == pass)
            {
                this.Hide();
                Student_A student = new Student_A();
                student.Show();
            }
            else
            {
                student_username.ResetText();
                password_student.ResetText();
                MessageBox.Show("Please Enter Correct Username and Password\nThank You!");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            student_signup student = new student_signup();
            student.Show();
        }
    }
 }
    
