namespace Eduvation_SMS
{
    partial class User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mismatched_label = new System.Windows.Forms.Label();
            this.upswdrtype_textBox = new System.Windows.Forms.TextBox();
            this.retypePswd_label = new System.Windows.Forms.Label();
            this.userpswd_textBox = new System.Windows.Forms.TextBox();
            this.amount_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.UserID_textBox = new System.Windows.Forms.TextBox();
            this.Name_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.UID_errorlabel = new System.Windows.Forms.Label();
            this.UName_errorlabel = new System.Windows.Forms.Label();
            this.UPswd_errorlabel = new System.Windows.Forms.Label();
            this.uretypepswd_errorlabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UserDGV = new System.Windows.Forms.DataGridView();
            this.Left_panel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Left_panel
            // 
            this.Left_panel.Size = new System.Drawing.Size(309, 979);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.mismatched_label);
            this.panel4.Controls.Add(this.upswdrtype_textBox);
            this.panel4.Controls.Add(this.retypePswd_label);
            this.panel4.Controls.Add(this.userpswd_textBox);
            this.panel4.Controls.Add(this.amount_label);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.username_textBox);
            this.panel4.Controls.Add(this.UserID_textBox);
            this.panel4.Controls.Add(this.Name_label);
            this.panel4.Controls.Add(this.ID_label);
            this.panel4.Controls.Add(this.UID_errorlabel);
            this.panel4.Controls.Add(this.UName_errorlabel);
            this.panel4.Controls.Add(this.UPswd_errorlabel);
            this.panel4.Controls.Add(this.uretypepswd_errorlabel);
            this.panel4.Size = new System.Drawing.Size(309, 899);
            // 
            // back_Btn
            // 
            this.back_Btn.FlatAppearance.BorderSize = 0;
            // 
            // right_panel
            // 
            this.right_panel.Size = new System.Drawing.Size(1098, 979);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Size = new System.Drawing.Size(1098, 896);
            this.panel6.Controls.SetChildIndex(this.panel1, 0);
            this.panel6.Controls.SetChildIndex(this.groupBox1, 0);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1098, 71);
            // 
            // panel5
            // 
            this.panel5.Size = new System.Drawing.Size(1098, 83);
            // 
            // close_Btn
            // 
            this.close_Btn.FlatAppearance.BorderSize = 0;
            this.close_Btn.Location = new System.Drawing.Point(1021, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Eduvation_SMS.Properties.Resources.shift;
            this.pictureBox1.Location = new System.Drawing.Point(66, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // mismatched_label
            // 
            this.mismatched_label.AutoSize = true;
            this.mismatched_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mismatched_label.ForeColor = System.Drawing.Color.Red;
            this.mismatched_label.Location = new System.Drawing.Point(21, 527);
            this.mismatched_label.Name = "mismatched_label";
            this.mismatched_label.Size = new System.Drawing.Size(127, 20);
            this.mismatched_label.TabIndex = 37;
            this.mismatched_label.Text = "MISMATCHED";
            this.mismatched_label.Visible = false;
            // 
            // upswdrtype_textBox
            // 
            this.upswdrtype_textBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upswdrtype_textBox.Location = new System.Drawing.Point(25, 594);
            this.upswdrtype_textBox.Name = "upswdrtype_textBox";
            this.upswdrtype_textBox.PasswordChar = '*';
            this.upswdrtype_textBox.Size = new System.Drawing.Size(260, 32);
            this.upswdrtype_textBox.TabIndex = 36;
            this.upswdrtype_textBox.TextChanged += new System.EventHandler(this.upswdrtype_textBox_TextChanged);
            this.upswdrtype_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.upswdrtype_textBox_Validating);
            // 
            // retypePswd_label
            // 
            this.retypePswd_label.AutoSize = true;
            this.retypePswd_label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retypePswd_label.ForeColor = System.Drawing.Color.White;
            this.retypePswd_label.Location = new System.Drawing.Point(23, 556);
            this.retypePswd_label.Name = "retypePswd_label";
            this.retypePswd_label.Size = new System.Drawing.Size(174, 24);
            this.retypePswd_label.TabIndex = 35;
            this.retypePswd_label.Text = "Re-Type Password";
            // 
            // userpswd_textBox
            // 
            this.userpswd_textBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userpswd_textBox.Location = new System.Drawing.Point(25, 486);
            this.userpswd_textBox.Name = "userpswd_textBox";
            this.userpswd_textBox.PasswordChar = '*';
            this.userpswd_textBox.Size = new System.Drawing.Size(260, 32);
            this.userpswd_textBox.TabIndex = 34;
            this.userpswd_textBox.TextChanged += new System.EventHandler(this.userpswd_textBox_TextChanged);
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_label.ForeColor = System.Drawing.Color.White;
            this.amount_label.Location = new System.Drawing.Point(23, 448);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(94, 24);
            this.amount_label.TabIndex = 33;
            this.amount_label.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(94, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 47);
            this.label7.TabIndex = 32;
            this.label7.Text = "Users";
            // 
            // username_textBox
            // 
            this.username_textBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_textBox.Location = new System.Drawing.Point(28, 398);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(260, 32);
            this.username_textBox.TabIndex = 31;
            this.username_textBox.TextChanged += new System.EventHandler(this.username_textBox_TextChanged);
            // 
            // UserID_textBox
            // 
            this.UserID_textBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID_textBox.Location = new System.Drawing.Point(30, 313);
            this.UserID_textBox.Name = "UserID_textBox";
            this.UserID_textBox.Size = new System.Drawing.Size(260, 32);
            this.UserID_textBox.TabIndex = 30;
            this.UserID_textBox.TextChanged += new System.EventHandler(this.UserID_textBox_TextChanged);
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.ForeColor = System.Drawing.Color.White;
            this.Name_label.Location = new System.Drawing.Point(21, 359);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(100, 24);
            this.Name_label.TabIndex = 29;
            this.Name_label.Text = "Username";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label.ForeColor = System.Drawing.Color.White;
            this.ID_label.Location = new System.Drawing.Point(26, 279);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(31, 24);
            this.ID_label.TabIndex = 28;
            this.ID_label.Text = "ID";
            // 
            // UID_errorlabel
            // 
            this.UID_errorlabel.AutoSize = true;
            this.UID_errorlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UID_errorlabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.UID_errorlabel.Location = new System.Drawing.Point(257, 279);
            this.UID_errorlabel.Name = "UID_errorlabel";
            this.UID_errorlabel.Size = new System.Drawing.Size(28, 29);
            this.UID_errorlabel.TabIndex = 38;
            this.UID_errorlabel.Text = "*";
            this.UID_errorlabel.Visible = false;
            // 
            // UName_errorlabel
            // 
            this.UName_errorlabel.AutoSize = true;
            this.UName_errorlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UName_errorlabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.UName_errorlabel.Location = new System.Drawing.Point(257, 359);
            this.UName_errorlabel.Name = "UName_errorlabel";
            this.UName_errorlabel.Size = new System.Drawing.Size(28, 29);
            this.UName_errorlabel.TabIndex = 39;
            this.UName_errorlabel.Text = "*";
            this.UName_errorlabel.Visible = false;
            // 
            // UPswd_errorlabel
            // 
            this.UPswd_errorlabel.AutoSize = true;
            this.UPswd_errorlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPswd_errorlabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.UPswd_errorlabel.Location = new System.Drawing.Point(257, 449);
            this.UPswd_errorlabel.Name = "UPswd_errorlabel";
            this.UPswd_errorlabel.Size = new System.Drawing.Size(28, 29);
            this.UPswd_errorlabel.TabIndex = 40;
            this.UPswd_errorlabel.Text = "*";
            this.UPswd_errorlabel.Visible = false;
            // 
            // uretypepswd_errorlabel
            // 
            this.uretypepswd_errorlabel.AutoSize = true;
            this.uretypepswd_errorlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uretypepswd_errorlabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.uretypepswd_errorlabel.Location = new System.Drawing.Point(257, 556);
            this.uretypepswd_errorlabel.Name = "uretypepswd_errorlabel";
            this.uretypepswd_errorlabel.Size = new System.Drawing.Size(28, 29);
            this.uretypepswd_errorlabel.TabIndex = 41;
            this.uretypepswd_errorlabel.Text = "*";
            this.uretypepswd_errorlabel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UserDGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox1.Location = new System.Drawing.Point(0, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 825);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users List";
            // 
            // UserDGV
            // 
            this.UserDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.UserDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.UserDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserDGV.GridColor = System.Drawing.Color.Black;
            this.UserDGV.Location = new System.Drawing.Point(3, 36);
            this.UserDGV.Name = "UserDGV";
            this.UserDGV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.UserDGV.RowHeadersWidth = 62;
            this.UserDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UserDGV.RowTemplate.Height = 28;
            this.UserDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDGV.Size = new System.Drawing.Size(1092, 786);
            this.UserDGV.TabIndex = 0;
            this.UserDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDGV_CellContentClick);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 979);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.UserDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label mismatched_label;
        private System.Windows.Forms.TextBox upswdrtype_textBox;
        private System.Windows.Forms.Label retypePswd_label;
        private System.Windows.Forms.TextBox userpswd_textBox;
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox UserID_textBox;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label UID_errorlabel;
        private System.Windows.Forms.Label UName_errorlabel;
        private System.Windows.Forms.Label UPswd_errorlabel;
        private System.Windows.Forms.Label uretypepswd_errorlabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView UserDGV;
    }
}