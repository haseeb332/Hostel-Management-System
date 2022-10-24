using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Admin_A : Form
    {
        public Admin_A()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_A_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            login l = new login();
            l.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Manage_Rooms_Option manage = new Manage_Rooms_Option();
            manage.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Add_New_Student ads = new Add_New_Student();
            ads.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Add_Staff hel = new Add_Staff();
            hel.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Update_Student_Data usd = new Update_Student_Data();
            usd.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Update_Staff_Data ustd = new Update_Staff_Data();
            ustd.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Student_Staff_Accountscs ssa = new Student_Staff_Accountscs();
            ssa.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Hostel_Expenses he = new Hostel_Expenses();
            he.Show();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Visitorssss v = new Visitorssss();
            v.Show();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            Gym_ g = new Gym_();
            g.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Attendance_Form af = new Attendance_Form();
            af.Show();
        }
    }
}
