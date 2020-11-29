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
    public class login 
    {
        private string uname, password;

        public string UNAME 
        {
            get { return uname; }
            set { uname = value; }
        }
        public string PSWD 
        {
            get { return password; }
            set { password = value; }
        }
    }
    interface IMethods
    {
        void Disable_errorlabel();
        void ShowData();

    }
    interface FillClasses
    {
        void FillClass();
    }
    interface FillStudents
    {
        void FillStudent();
    }
    
    public class MainClass
    {
        
        public static string con_string() 
        {
            return @"Data Source=DESKTOP-KQBH18B\SQLEXPRESS;Initial Catalog=Eduvation_SMS;Integrated Security=True";
        } 
       
        // Method For Showing Message Box instead of using default method of Message box we create
        // method where we just pass the caption, message, and type

        public static DialogResult MSGBox(string msg, string caption, string type)
        {
            if (type == "Success") // If the message result is success we return this
            {
                return MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else  // If the message result is error then return this
            {
                return MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Disable Method

        // Method for Reset Disable so here we pass a container or panel so all the control in that 
        // container is reset and disable.

        public static void reset_disable(Panel panel) // panel means that container
        {
            foreach (Control c in panel.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                    t.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)c;
                    comboBox.Enabled = false;
                    comboBox.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)c;
                    radioButton.Enabled = false;
                    radioButton.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)c;
                    checkBox.Enabled = false;
                    checkBox.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)c;
                    dateTimePicker.Enabled = false;
                    dateTimePicker.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button button = (Button)c;
                    button.Enabled = false;
                }
            }
        }

        //Now we create method for the Disable where we pass the container or panel as an argument
        //Container is Diable

        public static void Disable(Panel panel) // panel means that container
        {
            foreach (Control c in panel.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = false;
                }
                if (c is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)c;
                    comboBox.Enabled = false;
                }
                if (c is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)c;
                    radioButton.Enabled = false;

                }
                if (c is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)c;
                    checkBox.Enabled = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)c;
                    dateTimePicker.Enabled = false;
                }
                if (c is Button)
                {
                    Button button = (Button)c;
                    button.Enabled = false;
                }
            }
        }

        //Enable Method

        // Method for Reset & Enable so here we pass a container or panel so all the control in that 
        // container is reset and enable.

        public static void reset_enable(Panel panel) // panel means that container
        {
            foreach (Control c in panel.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)c;
                    comboBox.Enabled = true;
                    comboBox.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)c;
                    radioButton.Enabled = true;
                    radioButton.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)c;
                    checkBox.Enabled = true;
                    checkBox.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)c;
                    dateTimePicker.Enabled = true;
                    dateTimePicker.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button button = (Button)c;
                    button.Enabled = true;
                }
               
            }
        }

        public static void reset_enable(GroupBox groupBox) // Enable reset With groupbox as parameter 
        {
            foreach (Control c in groupBox.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                    t.Text = "";
                }
                if (c is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)c;
                    comboBox.Enabled = true;
                    comboBox.SelectedIndex = -1;
                }
                if (c is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)c;
                    radioButton.Enabled = true;
                    radioButton.Checked = false;
                }
                if (c is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)c;
                    checkBox.Enabled = true;
                    checkBox.Checked = false;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)c;
                    dateTimePicker.Enabled = true;
                    dateTimePicker.Value = DateTime.Now;
                }
                if (c is Button)
                {
                    Button button = (Button)c;
                    button.Enabled = true;
                }
            }
        }

        //Now we create method for the Enable where we pass the container or panel as an argument
        //Container is Enable

        public static void Enable(Panel panel) // panel means that container
        {
            foreach (Control c in panel.Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    t.Enabled = true;
                }
                if (c is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)c;
                    comboBox.Enabled = true;
                }
                if (c is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)c;
                    radioButton.Enabled = true;

                }
                if (c is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)c;
                    checkBox.Enabled = true;
                }
                if (c is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)c;
                    dateTimePicker.Enabled = true;
                }
                if (c is Button)
                {
                    Button button = (Button)c;
                    button.Enabled = true;
                }
            }
        }
    }
}
