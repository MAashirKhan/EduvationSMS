using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Eduvation_SMS
{
    abstract class UsersDBQueries
    {
        public static string connectionString = MainClass.con_string();
        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;
        public abstract void Add(TextBox uid, TextBox uname, TextBox pswd);

        public abstract void Edit(TextBox uid, TextBox uname,TextBox pswd);

        public abstract void Delete(TextBox uid, TextBox uname, TextBox pswd);
    }
    class UsersDB : UsersDBQueries
    {
        public UsersDB() : base()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        public override void Add(TextBox uid, TextBox uname, TextBox pswd)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("Insert into Users values( " + uid.Text + ",'" + uname.Text + "','" + pswd.Text + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MainClass.MSGBox(uname.Text + " Inserted Successfully", "Success", "Success");
            sqlConnection.Close();
        }
        public override void Edit(TextBox uid, TextBox uname, TextBox pswd)
        {
            sqlConnection.Open();
            string query = "Update Users set user_Name = @uname , " + "user_Password = @pswd where user_ID = @id";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", uid.Text);
            sqlCommand.Parameters.AddWithValue("@uname", uname.Text);
            sqlCommand.Parameters.AddWithValue("@pswd", pswd.Text);
            sqlCommand.ExecuteNonQuery();
            MainClass.MSGBox(uname.Text + " Updated Successfully", "Success", "Success");
            sqlConnection.Close();
        }
        public override void Delete(TextBox uid, TextBox uname, TextBox pswd)
        {
            sqlConnection.Open();
            string query = "Delete from Users where user_ID=" + uid.Text + ";";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MainClass.MSGBox(uname.Text + " Deleted Successfully", "Success", "Success");
            sqlConnection.Close();
        }
    }
}
