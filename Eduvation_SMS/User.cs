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

    public partial class User : Sample,IMethods
    {
        public User()
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

        public override void close_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void User_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public override void add_Btn_Click(object sender, EventArgs e)
        {
            
            try
            {

                if (UserID_textBox.Text == "") { UID_errorlabel.Visible = true; } else { UID_errorlabel.Visible = false; }
                if (username_textBox.Text == "") { UName_errorlabel.Visible = true; } else { UName_errorlabel.Visible = false; }
                if (userpswd_textBox.Text == "") { UPswd_errorlabel.Visible = true; } else { UPswd_errorlabel.Visible = false; }
                if (upswdrtype_textBox.Text == "") { uretypepswd_errorlabel.Visible = true; } else { uretypepswd_errorlabel.Visible = false; }
                if (upswdrtype_textBox.Text != userpswd_textBox.Text) { mismatched_label.Visible = true; } else { mismatched_label.Visible = false; }

                if (UID_errorlabel.Visible || UName_errorlabel.Visible ||UPswd_errorlabel.Visible || uretypepswd_errorlabel.Visible || mismatched_label.Visible)
                {
                    MainClass.MSGBox("Fields * are Mandatory","Fill all Fields", "ERROR");
                }
                else
                {
                    UsersDB usersDB = new UsersDB();
                    usersDB.Add(UserID_textBox, username_textBox, userpswd_textBox);
                    MainClass.reset_disable(panel4);
                    ShowData();
                }
                Disable_errorlabel();
            }
            catch 
            {

                MainClass.MSGBox("Something Went Wrong","ERROR", "ERROR");
            }

            
        }
        public override void edit_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserID_textBox.Text == "") { UID_errorlabel.Visible = true; } else { UID_errorlabel.Visible = false; }
                if (username_textBox.Text == "") { UName_errorlabel.Visible = true; } else { UName_errorlabel.Visible = false; }
                if (userpswd_textBox.Text == "") { UPswd_errorlabel.Visible = true; } else { UPswd_errorlabel.Visible = false; }
                if (upswdrtype_textBox.Text == "") { uretypepswd_errorlabel.Visible = true; } else { uretypepswd_errorlabel.Visible = false; }
                if (upswdrtype_textBox.Text != userpswd_textBox.Text) { mismatched_label.Visible = true; } else { mismatched_label.Visible = false; }

                if (UID_errorlabel.Visible || UName_errorlabel.Visible || UPswd_errorlabel.Visible || uretypepswd_errorlabel.Visible || mismatched_label.Visible)
                {
                    MainClass.MSGBox("Fields * are Mandatory", "Fill all Fields", "ERROR");
                }
                else
                {
                    UsersDB usersDB = new UsersDB();
                    usersDB.Edit(UserID_textBox, username_textBox, userpswd_textBox);
                    MainClass.reset_disable(panel4);
                    ShowData();

                }
                Disable_errorlabel();
            }
            catch
            {
                MainClass.MSGBox("Oops... User Not Updated", "Error", "Error");
            }
        }
        public override void reset_Btn_Click(object sender, EventArgs e)
        {
            MainClass.reset_enable(panel4);
            Disable_errorlabel();
        }
        //Delete Button
        public override void delete_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserID_textBox.Text == "")
                {
                    MainClass.MSGBox("Enter User ID", "Error", "Error");
                }
                else
                {
                    UsersDB usersDB = new UsersDB();
                    usersDB.Delete(UserID_textBox, username_textBox, userpswd_textBox);
                    MainClass.Disable(panel4);
                    ShowData();
                }
            }
            catch
            {
                MainClass.MSGBox("Oopss... User Not Deleted!!", "Error", "Error");
            }
            Disable_errorlabel();
        }
        //Cell Content Click Event To Load data from grid to Textbox
        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UserID_textBox.Text = UserDGV.SelectedRows[0].Cells[0].Value.ToString();
            username_textBox.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            userpswd_textBox.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
            upswdrtype_textBox.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
   
        }
        //Public Method to Disable Error Label declare in Interface
        public void Disable_errorlabel()
        {
            UID_errorlabel.Visible = false;
            UName_errorlabel.Visible = false;
            UPswd_errorlabel.Visible = false;
            uretypepswd_errorlabel.Visible = false;
        }
        //Text Changed Validation Area
        private void UserID_textBox_TextChanged(object sender, EventArgs e)
        {
            if (UserID_textBox.Text == "") { UID_errorlabel.Visible = true; } else { UID_errorlabel.Visible = false; }
        }

        private void username_textBox_TextChanged(object sender, EventArgs e)
        {
            if (username_textBox.Text == "") { UName_errorlabel.Visible = true; } else { UName_errorlabel.Visible = false; }
        }

        private void userpswd_textBox_TextChanged(object sender, EventArgs e)
        {
            if (userpswd_textBox.Text == "") { UPswd_errorlabel.Visible = true; } else { UPswd_errorlabel.Visible = false; }
        }

        private void upswdrtype_textBox_TextChanged(object sender, EventArgs e)
        {
            if (upswdrtype_textBox.Text == "") { uretypepswd_errorlabel.Visible = true; }else{ uretypepswd_errorlabel.Visible = false; }
        }

        private void upswdrtype_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (upswdrtype_textBox.Text != userpswd_textBox.Text) { mismatched_label.Visible = true; } else { mismatched_label.Visible = false; }
        }

        //Private method to Show Data on GridView
        public void ShowData() 
        {
            conn.Open();
            string query = "Select * from Users";
            SqlDataAdapter adpt = new SqlDataAdapter(query,conn);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adpt);
            var DS = new DataSet();
            adpt.Fill(DS);
            UserDGV.DataSource = DS.Tables[0];
            conn.Close();
        }       
    }
}
