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
    public partial class Fees : Sample, IMethods, FillStudents
    {
        public Fees()
        {
            InitializeComponent();
        }
        //The connection String is recieving here from Main Class 
        SqlConnection conn = new SqlConnection(MainClass.con_string());

        public override void add_Btn_Click(object sender, EventArgs e)
        {
            try
            {

               
                if (Num_textBox.Text == "") { num_errorlabel.Visible = true; } else { num_errorlabel.Visible = false; }
                if (StdID_DD.SelectedIndex == -1) { SID_errorlabel.Visible = true; } else { SID_errorlabel.Visible = false; }
                if (name_textBox.Text == "") { name_errorlabel.Visible = true; } else { name_errorlabel.Visible = false; }
                if (Period_picker.Text == "") { period_errorlabel.Visible = true; } else { period_errorlabel.Visible = false; }
                if (amount_textBox.Text == "") { amount_errorlabel.Visible = true; } else { amount_errorlabel.Visible = false; }

                if (num_errorlabel.Visible || SID_errorlabel.Visible || name_errorlabel.Visible || period_errorlabel.Visible || amount_errorlabel.Visible || period_errorlabel.Visible || amount_errorlabel.Visible)
                {
                    MainClass.MSGBox("Fields * are Mandatory", "Fill all Fields", "ERROR");
                }
                else
                {

                        FeeDB feeDB = new FeeDB();
                        feeDB.Add(Num_textBox, StdID_DD, name_textBox, Period_picker, amount_textBox);
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
                if (Num_textBox.Text == "") { num_errorlabel.Visible = true; } else { num_errorlabel.Visible = false; }
                if (StdID_DD.SelectedIndex == -1) { SID_errorlabel.Visible = true; } else { SID_errorlabel.Visible = false; }
                if (name_textBox.Text == "") { name_errorlabel.Visible = true; } else { name_errorlabel.Visible = false; }
                if (Period_picker.Text == "") { period_errorlabel.Visible = true; } else { period_errorlabel.Visible = false; }
                if (amount_textBox.Text == "") { amount_errorlabel.Visible = true; } else { amount_errorlabel.Visible = false; }

                if (num_errorlabel.Visible || SID_errorlabel.Visible || name_errorlabel.Visible || period_errorlabel.Visible || amount_errorlabel.Visible )

                {
                    MainClass.MSGBox("Fields * are Mandatory", "Fill all Fields", "ERROR");
                }
                else
                {

                    FeeDB feeDB = new FeeDB();
                    feeDB.Edit(Num_textBox, StdID_DD, name_textBox, Period_picker, amount_textBox);
                    MainClass.reset_disable(panel4);
                    ShowData();
                }
                Disable_errorlabel();
            }
            catch (Exception m)
            {
                MainClass.MSGBox(m.Message, "Error", "Error");
            }
        }

        public override void delete_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Num_textBox.Text == "")
                {
                    MainClass.MSGBox("Enter Fee Id", "Error", "Error");
                }
                else
                {
                    FeeDB feeDB = new FeeDB();
                    feeDB.Delete(Num_textBox, StdID_DD, name_textBox, Period_picker, amount_textBox);
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
        //Public Method to getclasses from classes and display in DD using interface and inheritance
        public void FillStudent()
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("Select [Student ID] FROM Student", conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Student ID", typeof(int));
            dt.Load(reader);
            StdID_DD.ValueMember = "Student ID";
            StdID_DD.DisplayMember = "Student ID";
            StdID_DD.DataSource = dt;
            conn.Close();
        }
        //Public Method to Disable Error Label declare in Interface
        public void Disable_errorlabel()
        {
            num_errorlabel.Visible = false;
            SID_errorlabel.Visible = false;
            name_errorlabel.Visible = false;
            period_errorlabel.Visible = false;
            amount_errorlabel.Visible = false;
        }
        //Private method to Show Data on GridView
        public void ShowData()
        {
            conn.Open();
            string query = "Select * from Fees";
            SqlDataAdapter adpt = new SqlDataAdapter(query, conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adpt);
            var DS = new DataSet();
            adpt.Fill(DS);
            FeeDGV.DataSource = DS.Tables[0];
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

        private void Num_textBox_TextChanged(object sender, EventArgs e)
        {
            if (Num_textBox.Text == "") { num_errorlabel.Visible = true; } else { num_errorlabel.Visible = false; }
          
        }

        private void StdID_DD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StdID_DD.SelectedIndex == -1) { SID_errorlabel.Visible = true; } else { SID_errorlabel.Visible = false; }
            
        }

        private void name_textBox_TextChanged(object sender, EventArgs e)
        {
            if (name_textBox.Text == "") { name_errorlabel.Visible = true; } else { name_errorlabel.Visible = false; }
            
        }

        private void Period_picker_ValueChanged(object sender, EventArgs e)
        {
            if (Period_picker.Text == "") { period_errorlabel.Visible = true; } else { period_errorlabel.Visible = false; }
           
        }

        private void amount_textBox_TextChanged(object sender, EventArgs e)
        {
            if (amount_textBox.Text == "") { amount_errorlabel.Visible = true; } else { amount_errorlabel.Visible = false; }
        }

        private void StdID_DD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            conn.Open();
            string query = "Select * from Student where [Student ID] =  "+StdID_DD.SelectedValue.ToString()+"";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                name_textBox.Text = dr["Student Name"].ToString();
            }
            conn.Close();
        }

        private void Fees_Load(object sender, EventArgs e)
        {
            FillStudent();
            ShowData();
        }

        private void FeeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Num_textBox.Text = FeeDGV.SelectedRows[0].Cells[0].Value.ToString();
            StdID_DD.SelectedItem = FeeDGV.SelectedRows[0].Cells[1].Value.ToString();
            name_textBox.Text = FeeDGV.SelectedRows[0].Cells[2].Value.ToString();
            Period_picker.Text = FeeDGV.SelectedRows[0].Cells[3].Value.ToString();
            amount_textBox.Text = FeeDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("FEE RECIEPT", new Font("Tahoma", 25, FontStyle.Bold),Brushes.ForestGreen, new Point(250));
            e.Graphics.DrawString(FeeDGV.SelectedRows[0].Cells[0].Value.ToString(), new Font("Tahoma", 25, FontStyle.Bold), Brushes.Black, new Point(320, 50));
            e.Graphics.DrawString("Reciept Number: ", new Font("Tahoma", 25, FontStyle.Bold), Brushes.Black, new Point(20, 50));
            e.Graphics.DrawString(FeeDGV.SelectedRows[0].Cells[1].Value.ToString(), new Font("Tahoma", 25, FontStyle.Bold), Brushes.Black, new Point(300, 90));
            e.Graphics.DrawString("Student ID: ", new Font("Tahoma", 25, FontStyle.Bold), Brushes.Black, new Point(20, 80));
            e.Graphics.DrawString(FeeDGV.SelectedRows[0].Cells[2].Value.ToString(), new Font("Tahoma", 25, FontStyle.Bold), Brushes.Black, new Point(300, 120));
            e.Graphics.DrawString("Student Name: ", new Font("Tahoma", 25, FontStyle.Bold), Brushes.Black, new Point(20, 120));
            e.Graphics.DrawString(FeeDGV.SelectedRows[0].Cells[3].Value.ToString(), new Font("Tahoma", 25, FontStyle.Bold), Brushes.Black, new Point(300, 160));
            e.Graphics.DrawString("Period: ", new Font("Tahoma", 25, FontStyle.Bold), Brushes.Black, new Point(20, 160));
            e.Graphics.DrawString(FeeDGV.SelectedRows[0].Cells[4].Value.ToString(), new Font("Tahoma", 25, FontStyle.Bold), Brushes.Black, new Point(300, 200));
            e.Graphics.DrawString("Fee Amount: ", new Font("Tahoma", 25, FontStyle.Bold), Brushes.Black, new Point(20, 200));
        }

        private void pay_Btn_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
