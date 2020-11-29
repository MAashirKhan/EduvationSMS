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
    public abstract class ClassDBQueries 
    {
        public static string connectionString = MainClass.con_string();
        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;

        public abstract void add(TextBox textBox);
        public abstract void edit(TextBox name);
        public abstract void delete(TextBox textbox);        
    }
    public class ClassDB : ClassDBQueries
    {
        int classid = 0;
        public ClassDB() :base()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public override void add(TextBox textbox)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("Insert into Classes values( '" + textbox.Text + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MainClass.MSGBox(textbox.Text + " Inserted Successfully", "Success", "Success");
            sqlConnection.Close();
        }
        public override void edit(TextBox name)
        {
            sqlConnection.Open();
            string query = "Update Classes set [Class Name] = @classname where [Class ID] = @classid";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@classid", classid);
            sqlCommand.Parameters.AddWithValue("@classname", name.Text);
            sqlCommand.ExecuteNonQuery();
            MainClass.MSGBox(name.Text + " Updated Successfully", "Success", "Success");
            sqlConnection.Close();

        }
        public override void delete(TextBox textbox)
        {
            sqlConnection.Open();
            string query = "Delete from Classes where [Class Name]= @classname;";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@classname", textbox.Text);
            sqlCommand.ExecuteNonQuery();
            MainClass.MSGBox(textbox.Text + " Deleted Successfully", "Success", "Success");
            sqlConnection.Close();
        }
    }
}
