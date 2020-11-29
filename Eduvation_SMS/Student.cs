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
    public partial class Student : Sample, IMethods, FillClasses
    {
        public Student()
        {
            InitializeComponent();
        }
        //The connection String is recieving here from Main Class 
        SqlConnection conn = new SqlConnection(MainClass.con_string());

        public override void add_Btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (SID_textBox.Text == "") { SID_errorlabel.Visible = true; } else { SID_errorlabel.Visible = false; }
                if (name_textBox.Text == "") { SName_errorlabel.Visible = true; } else { SName_errorlabel.Visible = false; }
                if (GenderDD.SelectedIndex == -1) { GenderDD_errorlabel.Visible = true; } else { GenderDD_errorlabel.Visible = false; }
                if (DOB_Picker.Text == "") { DOB_errorlabel.Visible = true; } else { DOB_errorlabel.Visible = false; }
                if (Phone_textBox.Text == "") { phone_errorlabel.Visible = true; } else { phone_errorlabel.Visible = false; }
                if (ClassDD.SelectedIndex == -1) { class_errorlabel.Visible = true; } else { class_errorlabel.Visible = false; }

                if (SID_errorlabel.Visible || SName_errorlabel.Visible || GenderDD_errorlabel.Visible || DOB_errorlabel.Visible || phone_errorlabel.Visible || class_errorlabel.Visible )
                {
                    MainClass.MSGBox("Fields * are Mandatory", "Fill all Fields", "ERROR");
                }
                else
                {
                    StudentDB studentDB = new StudentDB();
                    studentDB.Add(SID_textBox, name_textBox, GenderDD, DOB_Picker, Phone_textBox, ClassDD);
                    MainClass.reset_disable(panel4);
                    ShowData();
                }
                Disable_errorlabel();
            }
            catch (Exception ex)
            {

                MainClass.MSGBox(ex.Message, "ERROR", "ERROR");
            }


        }
        public override void reset_Btn_Click(object sender, EventArgs e)
        {
            MainClass.reset_enable(panel4);
            Disable_errorlabel();
        }
        public override void edit_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SID_textBox.Text == "") { SID_errorlabel.Visible = true; } else { SID_errorlabel.Visible = false; }
                if (name_textBox.Text == "") { SName_errorlabel.Visible = true; } else { SName_errorlabel.Visible = false; }
                if (GenderDD.SelectedIndex == -1) { GenderDD_errorlabel.Visible = true; } else { GenderDD_errorlabel.Visible = false; }
                if (DOB_Picker.Text == "") { DOB_errorlabel.Visible = true; } else { DOB_errorlabel.Visible = false; }
                if (Phone_textBox.Text == "") { phone_errorlabel.Visible = true; } else { phone_errorlabel.Visible = false; }
                if (ClassDD.SelectedIndex == -1) { class_errorlabel.Visible = true; } else { class_errorlabel.Visible = false; }
               
                if (SID_errorlabel.Visible || SName_errorlabel.Visible || GenderDD_errorlabel.Visible || DOB_errorlabel.Visible || phone_errorlabel.Visible || class_errorlabel.Visible )

                {
                    MainClass.MSGBox("Fields * are Mandatory", "Fill all Fields", "ERROR");
                }
                else
                {
                    StudentDB studentDB = new StudentDB();
                    studentDB.Edit(SID_textBox, name_textBox, GenderDD, DOB_Picker, Phone_textBox, ClassDD);
                    MainClass.reset_disable(panel4);
                    ShowData();
                }
                Disable_errorlabel();
            }
            catch(Exception m)
            {
                MainClass.MSGBox(m.Message, "Error", "Error");
            }
        }

        public override void delete_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SID_textBox.Text == "")
                {
                    MainClass.MSGBox("Enter Student Id", "Error", "Error");
                }
                else
                {
                    StudentDB studentDB = new StudentDB();
                    studentDB.Delete(SID_textBox, name_textBox, GenderDD, DOB_Picker, Phone_textBox, ClassDD);
                    MainClass.Disable(panel4);
                    ShowData();
                }
            }
            catch
            {
                MainClass.MSGBox("Oopss... Student Not Deleted!!", "Error", "Error");
            }
            Disable_errorlabel();
        }


        public override void close_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            FillClass();
            ShowData();
        }

        public override void back_Btn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        //Public Method to getclasses from classes and display in DD using interface and inheritance
        public void FillClass()
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("Select [Class Name] FROM Classes", conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Class Name", typeof(string));
            dt.Load(reader);
            ClassDD.ValueMember = "Class Name";
            ClassDD.DisplayMember = "Class Name";
            ClassDD.DataSource = dt;
            conn.Close();
        }
        //Public Method to Disable Error Label declare in Interface
        public void Disable_errorlabel()
        {
            SID_errorlabel.Visible = false;
            SName_errorlabel.Visible = false;
            GenderDD_errorlabel.Visible = false;
            phone_errorlabel.Visible = false;
            class_errorlabel.Visible = false;
            
        }
        //Private method to Show Data on GridView
        public void ShowData()
        {
            conn.Open();
            string query = "Select * from Student";
            SqlDataAdapter adpt = new SqlDataAdapter(query, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adpt);
            var DS = new DataSet();
            adpt.Fill(DS);
            StudentDGV.DataSource = DS.Tables[0];
            conn.Close();
        }
       
        private void TID_textBox_TextChanged(object sender, EventArgs e)
        {
            if (SID_textBox.Text == "") { SID_errorlabel.Visible = true; } else { SID_errorlabel.Visible = false; }
            
        }

        private void name_textBox_TextChanged(object sender, EventArgs e)
        {
            if (name_textBox.Text == "") { SName_errorlabel.Visible = true; } else { SName_errorlabel.Visible = false; }
        }

        private void GenderDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GenderDD.SelectedIndex == -1) { GenderDD_errorlabel.Visible = true; } else { GenderDD_errorlabel.Visible = false; }
        }

        private void Phone_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Phone_textBox.Text == "") { phone_errorlabel.Visible = true; } else { phone_errorlabel.Visible = false; }
        }

        private void ClassDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClassDD.SelectedIndex == -1) { class_errorlabel.Visible = true; } else { class_errorlabel.Visible = false; }   
        }
        private void DOB_Picker_ValueChanged(object sender, EventArgs e)
        {
            if (DOB_Picker.Text == "") { DOB_errorlabel.Visible = true; } else { DOB_errorlabel.Visible = false; }
        }

        private void StudentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SID_textBox.Text = StudentDGV.SelectedRows[0].Cells[0].Value.ToString();
            name_textBox.Text = StudentDGV.SelectedRows[0].Cells[1].Value.ToString();
            GenderDD.SelectedItem = StudentDGV.SelectedRows[0].Cells[2].Value.ToString();
            DOB_Picker.Text = StudentDGV.SelectedRows[0].Cells[3].Value.ToString();
            Phone_textBox.Text = StudentDGV.SelectedRows[0].Cells[4].Value.ToString();
            ClassDD.SelectedValue = StudentDGV.SelectedRows[0].Cells[5].Value.ToString();
        }
    }
}
