using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Eduvation_SMS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        //The connection String is recieving here from Main Class 
        SqlConnection conn = new SqlConnection(MainClass.con_string());
        private void close_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void teacher_Btn_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.Show();
            this.Hide();
        }

        private void Std_Btn_Click(object sender, EventArgs e)
        {
            Student std = new Student();
            std.Show();
            this.Hide();
        }

        private void Class_Btn_Click(object sender, EventArgs e)
        {
            Classes classes = new Classes();
            classes.Show();
            this.Hide();
        }

        private void Fee_Btn_Click(object sender, EventArgs e)
        {
            Fees fees = new Fees();
            fees.Show();
            this.Hide();
        }

        private void Users_Btn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Show();
            this.Hide();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter std = new SqlDataAdapter("Select count(*) from Student",conn);
            DataTable dt = new DataTable();
            std.Fill(dt);
            Student_label.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter teacher = new SqlDataAdapter("Select count(*) from Teacher", conn);
            DataTable dt2 = new DataTable();
            teacher.Fill(dt2);
            Teacher_label.Text = dt2.Rows[0][0].ToString();
            SqlDataAdapter classes = new SqlDataAdapter("Select count(*) from Classes", conn);
            DataTable dt3 = new DataTable();
            classes.Fill(dt3);
            class_label.Text = dt3.Rows[0][0].ToString();
            conn.Close();
        }

        private void Logout_Btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
