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
    public partial class Teacher : Sample, IMethods, FillClasses
    {
       
        public Teacher()
        {
            InitializeComponent();
        }
        //The connection String is recieving here from Main Class 
        SqlConnection conn = new SqlConnection(MainClass.con_string());
        public override void back_Btn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
        private void Teacher_Load(object sender, EventArgs e)
        {
            FillClass();
            ShowData();
        }
        public override void add_Btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (TID_textBox.Text == "") { TID_errorlabel.Visible = true; } else { TID_errorlabel.Visible = false; }
                if (name_textBox.Text == "") { TName_errorlabel.Visible = true; } else { TName_errorlabel.Visible = false; }
                if (GenderDD.SelectedIndex == -1) { GenderDD_errorlabel.Visible = true; } else { GenderDD_errorlabel.Visible = false; }
                if (Phone_textBox.Text == "") { phone_errorlabel.Visible = true; } else { phone_errorlabel.Visible = false; }
                if (ClassDD.SelectedIndex == -1) { class_errorlabel.Visible = true; } else { class_errorlabel.Visible = false; }
                if (Address_textBox.Text == "") { address_errorlabel.Visible = true; } else { address_errorlabel.Visible = false; }

                if (TID_errorlabel.Visible || TName_errorlabel.Visible || GenderDD_errorlabel.Visible || phone_errorlabel.Visible || class_errorlabel.Visible || address_errorlabel.Visible)
                {
                    MainClass.MSGBox("Fields * are Mandatory", "Fill all Fields", "ERROR");
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Teacher values( " + TID_textBox.Text + ",'" + name_textBox.Text + "','" + GenderDD.SelectedItem.ToString() + "','" +Phone_textBox.Text+ "','"+ClassDD.SelectedValue.ToString()+ "','"+Address_textBox.Text+ "')", conn);
                    cmd.ExecuteNonQuery();
                    MainClass.MSGBox(name_textBox.Text + " Inserted Successfully", "Success", "Success");
                    conn.Close();
                    MainClass.reset_disable(panel4);
                    ShowData();
                }
                Disable_errorlabel();
            }
            catch(Exception ex)
            {

                MainClass.MSGBox(ex.Message, "ERROR", "ERROR");
            }

        }
        public override void edit_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TID_textBox.Text == "") { TID_errorlabel.Visible = true; } else { TID_errorlabel.Visible = false; }
                if (name_textBox.Text == "") { TName_errorlabel.Visible = true; } else { TName_errorlabel.Visible = false; }
                if (GenderDD.SelectedIndex == -1) { GenderDD_errorlabel.Visible = true; } else { GenderDD_errorlabel.Visible = false; }
                if (Phone_textBox.Text == "") { phone_errorlabel.Visible = true; } else { phone_errorlabel.Visible = false; }
                if (ClassDD.SelectedIndex == -1) { class_errorlabel.Visible = true; } else { class_errorlabel.Visible = false; }
                if (Address_textBox.Text == "") { address_errorlabel.Visible = true; } else { address_errorlabel.Visible = false; }

                if (TID_errorlabel.Visible || TName_errorlabel.Visible || GenderDD_errorlabel.Visible || phone_errorlabel.Visible || class_errorlabel.Visible || address_errorlabel.Visible)

                {
                    MainClass.MSGBox("Fields * are Mandatory", "Fill all Fields", "ERROR");
                }
                else
                {
                    conn.Open();
                    string query = @"Update Teacher set [Teacher ID] = @id, 
                                                        [Teacher Name] = @tname ,
                                                        [Teacher Gender] = @tgender,
                                                        [Teacher Phone] = @phone,
                                                        [Teacher Class Assigned] = @class,
                                                        [Teacher Address] = @address where [Teacher ID] = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", TID_textBox.Text);
                    cmd.Parameters.AddWithValue("@tname", name_textBox.Text);
                    cmd.Parameters.AddWithValue("@tgender", GenderDD.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@phone", Phone_textBox.Text);
                    cmd.Parameters.AddWithValue("@class", ClassDD.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@address", Address_textBox.Text);
                    cmd.ExecuteNonQuery();
                    MainClass.MSGBox(name_textBox.Text + " Updated Successfully", "Success", "Success");
                    conn.Close();
                    MainClass.reset_disable(panel4);
                    ShowData();
                }
                Disable_errorlabel();
            }
            catch
            {
                MainClass.MSGBox("Oops... Teacher Not Updated", "Error", "Error");
            }

        }
        public override void reset_Btn_Click(object sender, EventArgs e)
        {
            MainClass.reset_enable(panel4);
            Disable_errorlabel();
        }
        public override void delete_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (TID_textBox.Text == "")
                {
                    MainClass.MSGBox("Enter Teacher Id", "Error", "Error");
                }
                else
                {
                    conn.Open();
                    string query = "Delete from Teacher where [Teacher ID]=" + TID_textBox.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MainClass.MSGBox(name_textBox.Text + " Deleted Successfully", "Success", "Success");
                    conn.Close();
                    MainClass.Disable(panel4);
                    ShowData();
                }
            }
            catch
            {
                MainClass.MSGBox("Oopss... Teacher Not Deleted!!", "Error", "Error");
            }
            Disable_errorlabel();
        }
        public override void close_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            TID_errorlabel.Visible = false;
            TName_errorlabel.Visible = false;
            GenderDD_errorlabel.Visible = false;
            phone_errorlabel.Visible = false;
            class_errorlabel.Visible = false;
            address_errorlabel.Visible = false;
        }
        //Private method to Show Data on GridView
        public void ShowData()
        {
            conn.Open();
            string query = "Select * from Teacher";
            SqlDataAdapter adpt = new SqlDataAdapter(query, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adpt);
            var DS = new DataSet();
            adpt.Fill(DS);  
            TeacherDGV.DataSource = DS.Tables[0];
            conn.Close();
        }
        //Text Validation
        private void ID_textBox_TextChanged(object sender, EventArgs e)
        {
            if (TID_textBox.Text == "") { TID_errorlabel.Visible = true; } else { TID_errorlabel.Visible = false; }
            
        }

        private void name_textBox_TextChanged(object sender, EventArgs e)
        {
            if (name_textBox.Text == "") { TName_errorlabel.Visible = true; } else { TName_errorlabel.Visible = false; }
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

        private void Address_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Address_textBox.Text == "") { address_errorlabel.Visible = true; } else { address_errorlabel.Visible = false; }
        }

        private void TeacherDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TID_textBox.Text = TeacherDGV.SelectedRows[0].Cells[0].Value.ToString();
            name_textBox.Text = TeacherDGV.SelectedRows[0].Cells[1].Value.ToString();
            GenderDD.SelectedItem = TeacherDGV.SelectedRows[0].Cells[2].Value.ToString(); 
            Phone_textBox.Text = TeacherDGV.SelectedRows[0].Cells[3].Value.ToString();
            ClassDD.SelectedValue = TeacherDGV.SelectedRows[0].Cells[4].Value.ToString();
            Address_textBox.Text = TeacherDGV.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
