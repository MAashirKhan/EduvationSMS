using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Eduvation_SMS
{
    abstract class StudentDBQueries
    {
        public static string connectionString = MainClass.con_string();
        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;
        public abstract void Add(TextBox sid, TextBox sname, ComboBox gender, DateTimePicker DOB_Picker, TextBox phone, ComboBox classassigned);

        public abstract void Edit(TextBox sid, TextBox sname, ComboBox gender, DateTimePicker DOB_Picker, TextBox phone, ComboBox classassigned);

        public abstract void Delete(TextBox sid, TextBox sname, ComboBox gender, DateTimePicker DOB_Picker, TextBox phone, ComboBox classassigned);
    }
    class StudentDB : StudentDBQueries
    {
        public StudentDB() : base()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public override void Add(TextBox sid, TextBox sname, ComboBox gender,DateTimePicker DOB_Picker, TextBox phone, ComboBox classassigned)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("Insert into Student values( " + sid.Text + ",'" + sname.Text + "','" + gender.SelectedItem.ToString() + "','" + DOB_Picker.Text + "','" +phone.Text + "','" + classassigned.SelectedValue.ToString() + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MainClass.MSGBox(sname.Text + " Inserted Successfully", "Success", "Success");
            sqlConnection.Close();
        }
        public override void Edit(TextBox sid, TextBox sname, ComboBox gender, DateTimePicker DOB_Picker, TextBox phone, ComboBox classassigned)
        {

            sqlConnection.Open();
            string query = @"Update Student set [Student ID] = @id, 
                                                        [Student Name] = @sname ,
                                                        [Gender] = @sgender, [Date Of Birth] = @dob,
                                                        [Phone] = @phone,
                                                        [Class Assigned] = @class where [Student ID] = @id";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", sid.Text);
            sqlCommand.Parameters.AddWithValue("@sname", sname.Text);
            sqlCommand.Parameters.AddWithValue("@sgender", gender.SelectedItem.ToString());
            sqlCommand.Parameters.AddWithValue("@dob", DOB_Picker.Text);
            sqlCommand.Parameters.AddWithValue("@phone", phone.Text);
            sqlCommand.Parameters.AddWithValue("@class", classassigned.SelectedValue.ToString());
            sqlCommand.ExecuteNonQuery();
            MainClass.MSGBox(sname.Text + " Updated Successfully", "Success", "Success");
            sqlConnection.Close();

        }
        public override void Delete(TextBox sid, TextBox sname, ComboBox gender, DateTimePicker DOB_Picker, TextBox phone, ComboBox classassigned)
        {
            sqlConnection.Open();
            string query = "Delete from Student where [Student ID]=" + sid.Text + ";";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MainClass.MSGBox(sname.Text + " Deleted Successfully", "Success", "Success");
            sqlConnection.Close();
        }
    }
}
