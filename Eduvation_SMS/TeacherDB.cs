using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Eduvation_SMS
{
    abstract class TeacherDBQueries
    {
        public static string connectionString = MainClass.con_string();
        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;
        public abstract void Add(TextBox tid, TextBox tname, ComboBox gender, TextBox phone, ComboBox classassigned, TextBox address);

        public abstract void Edit(TextBox tid, TextBox tname, ComboBox gender, TextBox phone, ComboBox classassigned, TextBox address);

        public abstract void Delete(TextBox tid, TextBox tname, ComboBox gender, TextBox phone, ComboBox classassigned, TextBox address);
    }
    class TeacherDB : TeacherDBQueries
    {
        public TeacherDB() : base()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public override void Add(TextBox tid, TextBox tname, ComboBox gender, TextBox phone, ComboBox classassigned, TextBox address)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("Insert into Teacher values( " + tid.Text + ",'" + tname.Text + "','" + gender.SelectedItem.ToString() + "','" + phone.Text + "','" + classassigned.SelectedValue.ToString() + "','" + address.Text + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MainClass.MSGBox(tname.Text + " Inserted Successfully", "Success", "Success");
            sqlConnection.Close();
        }
        public override void Edit(TextBox tid, TextBox tname, ComboBox gender, TextBox phone, ComboBox classassigned, TextBox address)
        {
            sqlConnection.Open();
            string query = @"Update Teacher set [Teacher ID] = @id, 
                                                        [Teacher Name] = @tname ,
                                                        [Teacher Gender] = @tgender,
                                                        [Teacher Phone] = @phone,
                                                        [Teacher Class Assigned] = @class,
                                                        [Teacher Address] = @address where [Teacher ID] = @id";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", tid.Text);
            sqlCommand.Parameters.AddWithValue("@tname", tname.Text);
            sqlCommand.Parameters.AddWithValue("@tgender", gender.SelectedItem.ToString());
            sqlCommand.Parameters.AddWithValue("@phone", phone.Text);
            sqlCommand.Parameters.AddWithValue("@class", classassigned.SelectedValue.ToString());
            sqlCommand.Parameters.AddWithValue("@address", address.Text);
            sqlCommand.ExecuteNonQuery();
            MainClass.MSGBox(tname.Text + " Updated Successfully", "Success", "Success");
            sqlConnection.Close();
        }
        public override void Delete(TextBox tid, TextBox tname, ComboBox gender, TextBox phone, ComboBox classassigned, TextBox address)
        {
            sqlConnection.Open();
            string query = "Delete from Teacher where [Teacher ID]=" + tid.Text + ";";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MainClass.MSGBox(tname.Text + " Deleted Successfully", "Success", "Success");
            sqlConnection.Close();
        }
    }
}
