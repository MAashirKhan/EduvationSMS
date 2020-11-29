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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void close_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //The connection String is recieving here from Main Class 
        SqlConnection conn = new SqlConnection(MainClass.con_string());
        private void login_Btn_Click(object sender, EventArgs e)
        {
            //Encapsulation Set the textbox in private variable of login 
            user_login lg = new user_login();
            lg.UNAME = usernameTxt.Text;
            lg.PSWD = pswdTxt.Text;
            if (usernameTxt.Text == "") { username_errorlabel.Visible = true; } else { username_errorlabel.Visible = false; }
            if (pswdTxt.Text == "") { pswd_errorlabel.Visible = true; } else { pswd_errorlabel.Visible = false; }

            if (username_errorlabel.Visible || pswd_errorlabel.Visible)
            {
                MainClass.MSGBox("Field with * are mandatory.", "Error", "Error");
            }
            else
            {
                conn.Open();
                string query = "SELECT * FROM Users WHERE [user_Name] ='" + lg.UNAME + "' AND [user_Password] ='" + lg.PSWD + "'"; ;
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MainClass.MSGBox("Login SucessFully", "Congrats","Success");
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MainClass.MSGBox("Invalid Details","ERROR","Error");
                }
                conn.Close();
            }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "") { username_errorlabel.Visible = true; } else { username_errorlabel.Visible = false; }
        }

        private void pswdTxt_TextChanged(object sender, EventArgs e)
        {
            if (pswdTxt.Text == "") { pswd_errorlabel.Visible = true; } else { pswd_errorlabel.Visible = false; }
        }
    }
}
