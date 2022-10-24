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
    public partial class Staff_login : Form
    {
        public string connection_string = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=hello;Password=hello";
        public Staff_login()
        {
            InitializeComponent();
        }

        private void Staff_login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }

        private void stlogin_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            staff_signup ss = new staff_signup();
            ss.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string id = " ";
            string pass = " ";
            OracleConnection ocl = new OracleConnection(connection_string);
            ocl.Open();
            string query = "select username,password from stafflogin where username='" + student_username.Text + "'";
            OracleCommand cmd = new OracleCommand(query, ocl);
            OracleDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                id = r["username"].ToString();
                pass = r["password"].ToString();
                //  MessageBox.Show(id + pass);
            }

            ocl.Close();

            if (staff_username.Text == " " || password_staff.Text == " ")
            {
                MessageBox.Show("Please Enter Username and Password.\n Thank You!");
            }
            else if (student_username.Text == id && password_staff.Text == pass)
            {
                this.Hide();
                Staff_I si = new Staff_I();
                si.Show();
            }
            else
            {
                student_username.ResetText();
                password_staff.ResetText();
                MessageBox.Show("Please Enter Correct Username and Password\nThank You!");
            }
        }
    }
}
