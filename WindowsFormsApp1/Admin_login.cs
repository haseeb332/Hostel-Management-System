using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace WindowsFormsApp1
{
    public partial class Admin_login : Form
    {
        public string con = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=hello;Password=hello";
        public Admin_login()
        {
            InitializeComponent();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
        
        private void login_btn_Click(object sender, EventArgs e)
        {
            string id = " ";
            string pass = " ";
            OracleConnection ocl = new OracleConnection(con);
            ocl.Open();
            string query = "select username,password from admin where username='" + admin_username.Text + "'";
            OracleCommand cmd = new OracleCommand(query, ocl);
            OracleDataReader r = cmd.ExecuteReader();
            if(r.Read())
            {
                id = r["username"].ToString();
                pass = r["password"].ToString();
              //  MessageBox.Show(id + pass);
            }

            ocl.Close();
           
            if (admin_username.Text == " " || password_admin.Text == " ")
            {
                MessageBox.Show("Please Enter Username and Password.\n Thank You!");
            }
            else if (admin_username.Text == id && password_admin.Text == pass)
            {
                this.Hide();
                Admin_A admin_a = new Admin_A();
                admin_a.Show();
            }
            else
            {
                admin_username.ResetText();
                password_admin.ResetText();
                MessageBox.Show("Please Enter Correct Username and Password\nThank You!");
            }

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

        private void Admin_login_Load(object sender, EventArgs e)
        {

        }

        private void admin_username_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
