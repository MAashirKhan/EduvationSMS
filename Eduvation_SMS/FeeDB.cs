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
    abstract class FeeDBQueries
    {
        public static string connectionString = MainClass.con_string();
        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;
        public abstract void Add(TextBox feenum,  ComboBox sid, TextBox sname, DateTimePicker period,TextBox amount);

        public abstract void Edit(TextBox feenum, ComboBox sid, TextBox sname, DateTimePicker period, TextBox amount);

        public abstract void Delete(TextBox feenum, ComboBox sid, TextBox sname, DateTimePicker period, TextBox amount);
    }
    class FeeDB : FeeDBQueries
    {
        public FeeDB() :base()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        public override void Add(TextBox feenum, ComboBox sid, TextBox sname, DateTimePicker period, TextBox amount)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand("Insert into Fees values( " + feenum.Text + ",'" + sid.SelectedValue.ToString() + "','" + sname.Text + "','" + period.Text + "','" + amount.Text + "')", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MainClass.MSGBox("Fee Inserted Successfully", "Success", "Success");
            sqlConnection.Close();
        }
        public override void Edit(TextBox feenum, ComboBox sid, TextBox sname, DateTimePicker period, TextBox amount)
        {
            sqlConnection.Open();
            string query = @"Update Fees set [Fee Num] = @num,
                                                     [Std ID] = @sid, 
                                                     [Std Name] = @sname ,
                                                     [Fee Period] = @period,
                                                     [Fee Amount] = @fee where [Fee Num] = @num";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@num", feenum.Text);
            sqlCommand.Parameters.AddWithValue("@sid", sid.SelectedValue.ToString());
            sqlCommand.Parameters.AddWithValue("@sname", sname.Text);
            sqlCommand.Parameters.AddWithValue("@period", period.Text);
            sqlCommand.Parameters.AddWithValue("@fee", amount.Text);
            sqlCommand.ExecuteNonQuery();
            MainClass.MSGBox(sname.Text + " Updated Successfully", "Success", "Success");
            sqlConnection.Close();
        }
        public override void Delete(TextBox feenum, ComboBox sid, TextBox sname, DateTimePicker period, TextBox amount)
        {
            sqlConnection.Open();
            string query = "Delete from Fees where [Fee Num]=" + feenum.Text + ";";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            MainClass.MSGBox("Fee Deleted Successfully", "Success", "Success");
            sqlConnection.Close();
        }
    }
}
