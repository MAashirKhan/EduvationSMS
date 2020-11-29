namespace Eduvation_SMS
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Fee_label = new System.Windows.Forms.Label();
            this.ClassDD = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Phone_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GenderDD = new System.Windows.Forms.ComboBox();
            this.ssss = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.SID_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Name_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.SName_errorlabel = new System.Windows.Forms.Label();
            this.GenderDD_errorlabel = new System.Windows.Forms.Label();
            this.class_errorlabel = new System.Windows.Forms.Label();
            this.phone_errorlabel = new System.Windows.Forms.Label();
            this.SID_errorlabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StudentDGV = new System.Windows.Forms.DataGridView();
            this.DOB_label = new System.Windows.Forms.Label();
            this.DOB_Picker = new System.Windows.Forms.DateTimePicker();
            this.DOB_errorlabel = new System.Windows.Forms.Label();
            this.Left_panel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Left_panel
            // 
            this.Left_panel.Size = new System.Drawing.Size(309, 906);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DOB_Picker);
            this.panel4.Controls.Add(this.DOB_label);
            this.panel4.Controls.Add(this.Fee_label);
            this.panel4.Controls.Add(this.ClassDD);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.Phone_textBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.GenderDD);
            this.panel4.Controls.Add(this.ssss);
            this.panel4.Controls.Add(this.name_textBox);
            this.panel4.Controls.Add(this.SID_textBox);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.Name_label);
            this.panel4.Controls.Add(this.ID_label);
            this.panel4.Controls.Add(this.SName_errorlabel);
            this.panel4.Controls.Add(this.GenderDD_errorlabel);
            this.panel4.Controls.Add(this.class_errorlabel);
            this.panel4.Controls.Add(this.phone_errorlabel);
            this.panel4.Controls.Add(this.SID_errorlabel);
            this.panel4.Controls.Add(this.DOB_errorlabel);
            this.panel4.Size = new System.Drawing.Size(309, 826);
            // 
            // back_Btn
            // 
            this.back_Btn.FlatAppearance.BorderSize = 0;
            // 
            // right_panel
            // 
            this.right_panel.Size = new System.Drawing.Size(1073, 906);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Size = new System.Drawing.Size(1073, 823);
            this.panel6.Controls.SetChildIndex(this.panel1, 0);
            this.panel6.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1073, 71);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(1073, 83);
            // 
            // close_Btn
            // 
            this.close_Btn.FlatAppearance.BorderSize = 0;
            this.close_Btn.Location = new System.Drawing.Point(996, 0);
            // 
            // Fee_label
            // 
            this.Fee_label.Location = new System.Drawing.Point(0, 0);
            this.Fee_label.Name = "Fee_label";
            this.Fee_label.Size = new System.Drawing.Size(100, 23);
            this.Fee_label.TabIndex = 68;
            // 
            // ClassDD
            // 
            this.ClassDD.BackColor = System.Drawing.Color.DimGray;
            this.ClassDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassDD.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassDD.ForeColor = System.Drawing.Color.White;
            this.ClassDD.FormattingEnabled = true;
            this.ClassDD.Items.AddRange(new object[] {
            "Select"});
            this.ClassDD.Location = new System.Drawing.Point(28, 702);
            this.ClassDD.Name = "ClassDD";
            this.ClassDD.Size = new System.Drawing.Size(259, 32);
            this.ClassDD.TabIndex = 56;
            this.ClassDD.SelectedIndexChanged += new System.EventHandler(this.ClassDD_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(62, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 47);
            this.label7.TabIndex = 55;
            this.label7.Text = "Students";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 664);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 54;
            this.label5.Text = "Class";
            // 
            // Phone_textBox
            // 
            this.Phone_textBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_textBox.Location = new System.Drawing.Point(26, 622);
            this.Phone_textBox.Name = "Phone_textBox";
            this.Phone_textBox.Size = new System.Drawing.Size(260, 32);
            this.Phone_textBox.TabIndex = 53;
            this.Phone_textBox.TextChanged += new System.EventHandler(this.Phone_textBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 586);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 52;
            this.label4.Text = "Phone";
            // 
            // GenderDD
            // 
            this.GenderDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GenderDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderDD.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderDD.ForeColor = System.Drawing.Color.White;
            this.GenderDD.FormattingEnabled = true;
            this.GenderDD.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderDD.Location = new System.Drawing.Point(27, 462);
            this.GenderDD.Name = "GenderDD";
            this.GenderDD.Size = new System.Drawing.Size(259, 32);
            this.GenderDD.TabIndex = 51;
            this.GenderDD.SelectedIndexChanged += new System.EventHandler(this.GenderDD_SelectedIndexChanged);
            // 
            // ssss
            // 
            this.ssss.AutoSize = true;
            this.ssss.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssss.ForeColor = System.Drawing.Color.White;
            this.ssss.Location = new System.Drawing.Point(23, 430);
            this.ssss.Name = "ssss";
            this.ssss.Size = new System.Drawing.Size(74, 24);
            this.ssss.TabIndex = 50;
            this.ssss.Text = "Gender";
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textBox.Location = new System.Drawing.Point(27, 385);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(260, 32);
            this.name_textBox.TabIndex = 49;
            this.name_textBox.TextChanged += new System.EventHandler(this.name_textBox_TextChanged);
            // 
            // SID_textBox
            // 
            this.SID_textBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SID_textBox.Location = new System.Drawing.Point(27, 300);
            this.SID_textBox.Name = "SID_textBox";
            this.SID_textBox.Size = new System.Drawing.Size(260, 32);
            this.SID_textBox.TabIndex = 48;
            this.SID_textBox.TextChanged += new System.EventHandler(this.TID_textBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Eduvation_SMS.Properties.Resources.student;
            this.pictureBox1.Location = new System.Drawing.Point(70, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.ForeColor = System.Drawing.Color.White;
            this.Name_label.Location = new System.Drawing.Point(23, 349);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(137, 24);
            this.Name_label.TabIndex = 46;
            this.Name_label.Text = "Student Name";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label.ForeColor = System.Drawing.Color.White;
            this.ID_label.Location = new System.Drawing.Point(23, 266);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(103, 24);
            this.ID_label.TabIndex = 45;
            this.ID_label.Text = "Student Id";
            // 
            // SName_errorlabel
            // 
            this.SName_errorlabel.AutoSize = true;
            this.SName_errorlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SName_errorlabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.SName_errorlabel.Location = new System.Drawing.Point(258, 349);
            this.SName_errorlabel.Name = "SName_errorlabel";
            this.SName_errorlabel.Size = new System.Drawing.Size(28, 29);
            this.SName_errorlabel.TabIndex = 64;
            this.SName_errorlabel.Text = "*";
            this.SName_errorlabel.Visible = false;
            // 
            // GenderDD_errorlabel
            // 
            this.GenderDD_errorlabel.AutoSize = true;
            this.GenderDD_errorlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderDD_errorlabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.GenderDD_errorlabel.Location = new System.Drawing.Point(259, 430);
            this.GenderDD_errorlabel.Name = "GenderDD_errorlabel";
            this.GenderDD_errorlabel.Size = new System.Drawing.Size(28, 29);
            this.GenderDD_errorlabel.TabIndex = 63;
            this.GenderDD_errorlabel.Text = "*";
            this.GenderDD_errorlabel.Visible = false;
            // 
            // class_errorlabel
            // 
            this.class_errorlabel.AutoSize = true;
            this.class_errorlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.class_errorlabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.class_errorlabel.Location = new System.Drawing.Point(259, 664);
            this.class_errorlabel.Name = "class_errorlabel";
            this.class_errorlabel.Size = new System.Drawing.Size(28, 29);
            this.class_errorlabel.TabIndex = 61;
            this.class_errorlabel.Text = "*";
            this.class_errorlabel.Visible = false;
            // 
            // phone_errorlabel
            // 
            this.phone_errorlabel.AutoSize = true;
            this.phone_errorlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_errorlabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.phone_errorlabel.Location = new System.Drawing.Point(259, 586);
            this.phone_errorlabel.Name = "phone_errorlabel";
            this.phone_errorlabel.Size = new System.Drawing.Size(28, 29);
            this.phone_errorlabel.TabIndex = 60;
            this.phone_errorlabel.Text = "*";
            this.phone_errorlabel.Visible = false;
            // 
            // SID_errorlabel
            // 
            this.SID_errorlabel.AutoSize = true;
            this.SID_errorlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SID_errorlabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.SID_errorlabel.Location = new System.Drawing.Point(259, 262);
            this.SID_errorlabel.Name = "SID_errorlabel";
            this.SID_errorlabel.Size = new System.Drawing.Size(28, 29);
            this.SID_errorlabel.TabIndex = 59;
            this.SID_errorlabel.Text = "*";
            this.SID_errorlabel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StudentDGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox1.Location = new System.Drawing.Point(0, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1073, 752);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students List";
            // 
            // StudentDGV
            // 
            this.StudentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.StudentDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentDGV.GridColor = System.Drawing.Color.Black;
            this.StudentDGV.Location = new System.Drawing.Point(3, 36);
            this.StudentDGV.Name = "StudentDGV";
            this.StudentDGV.ReadOnly = true;
            this.StudentDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StudentDGV.RowHeadersWidth = 62;
            this.StudentDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StudentDGV.RowTemplate.Height = 28;
            this.StudentDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentDGV.Size = new System.Drawing.Size(1067, 713);
            this.StudentDGV.TabIndex = 0;
            this.StudentDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentDGV_CellContentClick);
            // 
            // DOB_label
            // 
            this.DOB_label.AutoSize = true;
            this.DOB_label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB_label.ForeColor = System.Drawing.Color.White;
            this.DOB_label.Location = new System.Drawing.Point(23, 506);
            this.DOB_label.Name = "DOB_label";
            this.DOB_label.Size = new System.Drawing.Size(127, 24);
            this.DOB_label.TabIndex = 65;
            this.DOB_label.Text = "Date Of Birth";
            // 
            // DOB_Picker
            // 
            this.DOB_Picker.CalendarFont = new System.Drawing.Font("Tahoma", 12F);
            this.DOB_Picker.CalendarForeColor = System.Drawing.Color.ForestGreen;
            this.DOB_Picker.CalendarMonthBackground = System.Drawing.Color.White;
            this.DOB_Picker.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DOB_Picker.CalendarTitleForeColor = System.Drawing.Color.White;
            this.DOB_Picker.CustomFormat = " dd MMMM yyyy";
            this.DOB_Picker.Font = new System.Drawing.Font("Tahoma", 10F);
            this.DOB_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOB_Picker.Location = new System.Drawing.Point(26, 543);
            this.DOB_Picker.Name = "DOB_Picker";
            this.DOB_Picker.Size = new System.Drawing.Size(260, 32);
            this.DOB_Picker.TabIndex = 66;
            this.DOB_Picker.ValueChanged += new System.EventHandler(this.DOB_Picker_ValueChanged);
            // 
            // DOB_errorlabel
            // 
            this.DOB_errorlabel.AutoSize = true;
            this.DOB_errorlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB_errorlabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.DOB_errorlabel.Location = new System.Drawing.Point(258, 506);
            this.DOB_errorlabel.Name = "DOB_errorlabel";
            this.DOB_errorlabel.Size = new System.Drawing.Size(28, 29);
            this.DOB_errorlabel.TabIndex = 67;
            this.DOB_errorlabel.Text = "*";
            this.DOB_errorlabel.Visible = false;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 906);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Student";
            this.Load += new System.EventHandler(this.Student_Load);
            this.Left_panel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.right_panel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Fee_label;
        private System.Windows.Forms.ComboBox ClassDD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Phone_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox GenderDD;
        private System.Windows.Forms.Label ssss;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox SID_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label SName_errorlabel;
        private System.Windows.Forms.Label GenderDD_errorlabel;
        private System.Windows.Forms.Label class_errorlabel;
        private System.Windows.Forms.Label phone_errorlabel;
        private System.Windows.Forms.Label SID_errorlabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView StudentDGV;
        private System.Windows.Forms.DateTimePicker DOB_Picker;
        private System.Windows.Forms.Label DOB_label;
        private System.Windows.Forms.Label DOB_errorlabel;
    }
}