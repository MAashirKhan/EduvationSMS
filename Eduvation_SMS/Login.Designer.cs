namespace Eduvation_SMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close_Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.showpswd_checkBox = new System.Windows.Forms.CheckBox();
            this.login_Btn = new System.Windows.Forms.Button();
            this.pswd_label = new System.Windows.Forms.Label();
            this.pswdTxt = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.username_errorlabel = new System.Windows.Forms.Label();
            this.pswd_errorlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.close_Btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(465, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 704);
            this.panel1.TabIndex = 0;
            // 
            // close_Btn
            // 
            this.close_Btn.BackColor = System.Drawing.Color.Red;
            this.close_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_Btn.Location = new System.Drawing.Point(445, 12);
            this.close_Btn.Name = "close_Btn";
            this.close_Btn.Size = new System.Drawing.Size(57, 50);
            this.close_Btn.TabIndex = 6;
            this.close_Btn.Text = "X";
            this.close_Btn.UseVisualStyleBackColor = false;
            this.close_Btn.Click += new System.EventHandler(this.close_Btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Eduvation_SMS.Properties.Resources.Login_panel1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(514, 704);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.showpswd_checkBox);
            this.panel2.Controls.Add(this.login_Btn);
            this.panel2.Controls.Add(this.pswd_label);
            this.panel2.Controls.Add(this.pswdTxt);
            this.panel2.Controls.Add(this.username_label);
            this.panel2.Controls.Add(this.usernameTxt);
            this.panel2.Controls.Add(this.login_label);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.username_errorlabel);
            this.panel2.Controls.Add(this.pswd_errorlabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 704);
            this.panel2.TabIndex = 1;
            // 
            // showpswd_checkBox
            // 
            this.showpswd_checkBox.AutoSize = true;
            this.showpswd_checkBox.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpswd_checkBox.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.showpswd_checkBox.Location = new System.Drawing.Point(47, 495);
            this.showpswd_checkBox.Name = "showpswd_checkBox";
            this.showpswd_checkBox.Size = new System.Drawing.Size(152, 25);
            this.showpswd_checkBox.TabIndex = 6;
            this.showpswd_checkBox.Text = "Show Password";
            this.showpswd_checkBox.UseVisualStyleBackColor = true;
            // 
            // login_Btn
            // 
            this.login_Btn.BackColor = System.Drawing.Color.ForestGreen;
            this.login_Btn.FlatAppearance.BorderSize = 3;
            this.login_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_Btn.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_Btn.Location = new System.Drawing.Point(47, 536);
            this.login_Btn.Name = "login_Btn";
            this.login_Btn.Size = new System.Drawing.Size(380, 77);
            this.login_Btn.TabIndex = 3;
            this.login_Btn.Text = "LOGIN";
            this.login_Btn.UseVisualStyleBackColor = false;
            this.login_Btn.Click += new System.EventHandler(this.login_Btn_Click);
            // 
            // pswd_label
            // 
            this.pswd_label.AutoSize = true;
            this.pswd_label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswd_label.Location = new System.Drawing.Point(43, 409);
            this.pswd_label.Name = "pswd_label";
            this.pswd_label.Size = new System.Drawing.Size(94, 24);
            this.pswd_label.TabIndex = 5;
            this.pswd_label.Text = "Password";
            // 
            // pswdTxt
            // 
            this.pswdTxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswdTxt.ForeColor = System.Drawing.Color.Green;
            this.pswdTxt.Location = new System.Drawing.Point(47, 445);
            this.pswdTxt.MaxLength = 20;
            this.pswdTxt.Name = "pswdTxt";
            this.pswdTxt.PasswordChar = '*';
            this.pswdTxt.Size = new System.Drawing.Size(380, 34);
            this.pswdTxt.TabIndex = 2;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(43, 329);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(100, 24);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Username";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.ForeColor = System.Drawing.Color.Green;
            this.usernameTxt.Location = new System.Drawing.Point(47, 363);
            this.usernameTxt.MaxLength = 50;
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(380, 32);
            this.usernameTxt.TabIndex = 1;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.ForeColor = System.Drawing.Color.White;
            this.login_label.Location = new System.Drawing.Point(155, 244);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(145, 54);
            this.login_label.TabIndex = 2;
            this.login_label.Text = "LOGIN";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Eduvation_SMS.Properties.Resources.loginicon;
            this.pictureBox2.Location = new System.Drawing.Point(132, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 188);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // username_errorlabel
            // 
            this.username_errorlabel.AutoSize = true;
            this.username_errorlabel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_errorlabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.username_errorlabel.Location = new System.Drawing.Point(396, 328);
            this.username_errorlabel.Name = "username_errorlabel";
            this.username_errorlabel.Size = new System.Drawing.Size(34, 36);
            this.username_errorlabel.TabIndex = 4;
            this.username_errorlabel.Text = "*";
            this.username_errorlabel.Visible = false;
            // 
            // pswd_errorlabel
            // 
            this.pswd_errorlabel.AutoSize = true;
            this.pswd_errorlabel.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswd_errorlabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.pswd_errorlabel.Location = new System.Drawing.Point(396, 409);
            this.pswd_errorlabel.Name = "pswd_errorlabel";
            this.pswd_errorlabel.Size = new System.Drawing.Size(34, 36);
            this.pswd_errorlabel.TabIndex = 0;
            this.pswd_errorlabel.Text = "*";
            this.pswd_errorlabel.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(979, 704);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label username_errorlabel;
        private System.Windows.Forms.Label pswd_errorlabel;
        private System.Windows.Forms.Label pswd_label;
        private System.Windows.Forms.TextBox pswdTxt;
        private System.Windows.Forms.Button login_Btn;
        private System.Windows.Forms.Button close_Btn;
        private System.Windows.Forms.CheckBox showpswd_checkBox;
    }
}