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
    public partial class Classes : Sample, IMethods
    {
        public Classes()
        {
            InitializeComponent();
        }
        //The connection String is recieving here from Main Class 
        SqlConnection conn = new SqlConnection(MainClass.con_string());

        int classid;
        //Public Method to Disable Error Label declare in Interface
        public void Disable_errorlabel()
        {
            classname_errorlabel.Visible = false;
        }
        public void ShowData() 
        {
            conn.Open();
            string query = "Select * from Classes";
            SqlDataAdapter adpt = new SqlDataAdapter(query, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adpt);
            var DS = new DataSet();
            adpt.Fill(DS);
            ClassDGV.DataSource = DS.Tables[0];
            conn.Close();
        }
        public override void back_Btn_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        public override void close_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Add Button
        public override void add_Btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (classesname_textBox.Text == "") { classname_errorlabel.Visible = true; } else { classname_errorlabel.Visible = false; }

                if (classname_errorlabel.Visible)
                {
                    MainClass.MSGBox("Fields * are Mandatory", "Fill all Fields", "ERROR");
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Classes values( '" + classesname_textBox.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                    MainClass.MSGBox(classesname_textBox.Text + " Inserted Successfully", "Success", "Success");
                    conn.Close();
                    MainClass.reset_disable(panel4);
                    ShowData();
                }
                Disable_errorlabel();
            }
            catch
            {

                MainClass.MSGBox("Something Went Wrong", "ERROR", "ERROR");
            }
        }
        //Reset Button
        public override void reset_Btn_Click(object sender, EventArgs e)
        {
            MainClass.reset_enable(panel4);
            Disable_errorlabel();
        }
        //Edit Button
        public override void edit_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (classesname_textBox.Text == "") { classname_errorlabel.Visible = true; } else { classname_errorlabel.Visible = false; }

                if (classname_errorlabel.Visible)
                {
                    MainClass.MSGBox("Fields * are Mandatory", "Fill all Fields", "ERROR");
                }
                else
                {
                    conn.Open();
                    string query = "Update Classes set [Class Name] = @classname where [Class ID] = @classid";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@classid",classid);
                    cmd.Parameters.AddWithValue("@classname", classesname_textBox.Text);
                    cmd.ExecuteNonQuery();
                    MainClass.MSGBox(classesname_textBox.Text + " Updated Successfully", "Success", "Success");
                    conn.Close();
                    MainClass.reset_disable(panel4);
                    ShowData();

                }
                Disable_errorlabel();
            }
            catch
            {
                MainClass.MSGBox("Oops... Class Not Updated", "Error", "Error");
            }
        }
        //Text Changed Validating Area
        private void classesname_textBox_TextChanged(object sender, EventArgs e)
        {
            if(classesname_textBox.Text == "") { classname_errorlabel.Visible = true; }else { classname_errorlabel.Visible = false; };
        }
        //Cell Content Click Event To Load data from grid to Textbox
        private void ClassDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            classid = int.Parse(ClassDGV.Rows[e.RowIndex].Cells[0].Value.ToString());
            classesname_textBox.Text = ClassDGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void Classes_Load(object sender, EventArgs e)
        {
            ShowData();
        }
        //Delete Button
        public override void delete_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (classesname_textBox.Text == "")
                {
                    MainClass.MSGBox("Enter Class Name", "Error", "Error");
                }
                else
                {
                    conn.Open();
                    string query = "Delete from Classes where [Class Name]= @classname;";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@classname", classesname_textBox.Text);
                    cmd.ExecuteNonQuery();
                    MainClass.MSGBox(classesname_textBox.Text + " Deleted Successfully", "Success", "Success");
                    conn.Close();
                    MainClass.Disable(panel4);
                    ShowData();
                }
            }
            catch
            {
                MainClass.MSGBox("Oopss... Class Not Deleted!!", "Error", "Error");
            }
            Disable_errorlabel();
        }
    }
}
