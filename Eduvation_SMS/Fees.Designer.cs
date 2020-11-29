namespace Eduvation_SMS
{
    partial class Fees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fees));
            this.amount_textBox = new System.Windows.Forms.TextBox();
            this.amount_label = new System.Windows.Forms.Label();
            this.Period_picker = new System.Windows.Forms.DateTimePicker();
            this.period_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StdID_DD = new System.Windows.Forms.ComboBox();
            this.StdID_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.Num_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Name_label = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FeeDGV = new System.Windows.Forms.DataGridView();
            this.pay_Btn = new System.Windows.Forms.Button();
            this.SID_errorlabel = new System.Windows.Forms.Label();
            this.name_errorlabel = new System.Windows.Forms.Label();
            this.period_errorlabel = new System.Windows.Forms.Label();
            this.amount_errorlabel = new System.Windows.Forms.Label();
            this.num_errorlabel = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Left_panel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.right_panel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeeDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Left_panel
            // 
            this.Left_panel.Size = new System.Drawing.Size(309, 979);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.num_errorlabel);
            this.panel4.Controls.Add(this.amount_errorlabel);
            this.panel4.Controls.Add(this.period_errorlabel);
            this.panel4.Controls.Add(this.name_errorlabel);
            this.panel4.Controls.Add(this.SID_errorlabel);
            this.panel4.Controls.Add(this.pay_Btn);
            this.panel4.Controls.Add(this.amount_textBox);
            this.panel4.Controls.Add(this.amount_label);
            this.panel4.Controls.Add(this.Period_picker);
            this.panel4.Controls.Add(this.period_label);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.StdID_DD);
            this.panel4.Controls.Add(this.StdID_label);
            this.panel4.Controls.Add(this.name_textBox);
            this.panel4.Controls.Add(this.Num_textBox);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.Name_label);
            this.panel4.Controls.Add(this.ID_label);
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
            // amount_textBox
            // 
            this.amount_textBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_textBox.Location = new System.Drawing.Point(28, 670);
            this.amount_textBox.Name = "amount_textBox";
            this.amount_textBox.Size = new System.Drawing.Size(260, 32);
            this.amount_textBox.TabIndex = 31;
            this.amount_textBox.TextChanged += new System.EventHandler(this.amount_textBox_TextChanged);
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_label.ForeColor = System.Drawing.Color.White;
            this.amount_label.Location = new System.Drawing.Point(26, 632);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(79, 24);
            this.amount_label.TabIndex = 30;
            this.amount_label.Text = "Amount";
            // 
            // Period_picker
            // 
            this.Period_picker.CalendarForeColor = System.Drawing.Color.Black;
            this.Period_picker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Period_picker.CalendarTitleBackColor = System.Drawing.Color.Teal;
            this.Period_picker.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Period_picker.CustomFormat = "dd MMM yyyy";
            this.Period_picker.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Period_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Period_picker.Location = new System.Drawing.Point(28, 577);
            this.Period_picker.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.Period_picker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.Period_picker.Name = "Period_picker";
            this.Period_picker.Size = new System.Drawing.Size(259, 32);
            this.Period_picker.TabIndex = 29;
            this.Period_picker.ValueChanged += new System.EventHandler(this.Period_picker_ValueChanged);
            // 
            // period_label
            // 
            this.period_label.AutoSize = true;
            this.period_label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_label.ForeColor = System.Drawing.Color.White;
            this.period_label.Location = new System.Drawing.Point(25, 541);
            this.period_label.Name = "period_label";
            this.period_label.Size = new System.Drawing.Size(66, 24);
            this.period_label.TabIndex = 28;
            this.period_label.Text = "Period";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(63, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 47);
            this.label7.TabIndex = 27;
            this.label7.Text = "Accounts";
            // 
            // StdID_DD
            // 
            this.StdID_DD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StdID_DD.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdID_DD.FormattingEnabled = true;
            this.StdID_DD.Location = new System.Drawing.Point(27, 396);
            this.StdID_DD.Name = "StdID_DD";
            this.StdID_DD.Size = new System.Drawing.Size(259, 32);
            this.StdID_DD.TabIndex = 26;
            this.StdID_DD.SelectedIndexChanged += new System.EventHandler(this.StdID_DD_SelectedIndexChanged);
            this.StdID_DD.SelectionChangeCommitted += new System.EventHandler(this.StdID_DD_SelectionChangeCommitted);
            // 
            // StdID_label
            // 
            this.StdID_label.AutoSize = true;
            this.StdID_label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdID_label.ForeColor = System.Drawing.Color.White;
            this.StdID_label.Location = new System.Drawing.Point(22, 364);
            this.StdID_label.Name = "StdID_label";
            this.StdID_label.Size = new System.Drawing.Size(106, 24);
            this.StdID_label.TabIndex = 25;
            this.StdID_label.Text = "Student ID";
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textBox.Location = new System.Drawing.Point(26, 480);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(260, 32);
            this.name_textBox.TabIndex = 24;
            this.name_textBox.TextChanged += new System.EventHandler(this.name_textBox_TextChanged);
            // 
            // Num_textBox
            // 
            this.Num_textBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num_textBox.Location = new System.Drawing.Point(28, 315);
            this.Num_textBox.Name = "Num_textBox";
            this.Num_textBox.Size = new System.Drawing.Size(260, 32);
            this.Num_textBox.TabIndex = 23;
            this.Num_textBox.TextChanged += new System.EventHandler(this.Num_textBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Eduvation_SMS.Properties.Resources.feemanagement;
            this.pictureBox1.Location = new System.Drawing.Point(71, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.ForeColor = System.Drawing.Color.White;
            this.Name_label.Location = new System.Drawing.Point(19, 441);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(62, 24);
            this.Name_label.TabIndex = 21;
            this.Name_label.Text = "Name";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label.ForeColor = System.Drawing.Color.White;
            this.ID_label.Location = new System.Drawing.Point(24, 281);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(51, 24);
            this.ID_label.TabIndex = 20;
            this.ID_label.Text = "Num";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FeeDGV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox1.Location = new System.Drawing.Point(0, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 825);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment List";
            // 
            // FeeDGV
            // 
            this.FeeDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FeeDGV.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FeeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FeeDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.FeeDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeeDGV.GridColor = System.Drawing.Color.Black;
            this.FeeDGV.Location = new System.Drawing.Point(3, 36);
            this.FeeDGV.Name = "FeeDGV";
            this.FeeDGV.ReadOnly = true;
            this.FeeDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FeeDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.FeeDGV.RowHeadersWidth = 62;
            this.FeeDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.FeeDGV.RowTemplate.Height = 28;
            this.FeeDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FeeDGV.Size = new System.Drawing.Size(1092, 786);
            this.FeeDGV.TabIndex = 0;
            this.FeeDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FeeDGV_CellContentClick);
            // 
            // pay_Btn
            // 
            this.pay_Btn.BackColor = System.Drawing.Color.ForestGreen;
            this.pay_Btn.FlatAppearance.BorderSize = 4;
            this.pay_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pay_Btn.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_Btn.ForeColor = System.Drawing.Color.White;
            this.pay_Btn.Location = new System.Drawing.Point(26, 734);
            this.pay_Btn.Name = "pay_Btn";
            this.pay_Btn.Size = new System.Drawing.Size(264, 50);
            this.pay_Btn.TabIndex = 32;
            this.pay_Btn.Text = "PAY NOW";
            this.pay_Btn.UseVisualStyleBackColor = false;
            this.pay_Btn.Click += new System.EventHandler(this.pay_Btn_Click);
            // 
            // SID_errorlabel
            // 
            this.SID_errorlabel.AutoSize = true;
            this.SID_errorlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SID_errorlabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.SID_errorlabel.Location = new System.Drawing.Point(260, 359);
            this.SID_errorlabel.Name = "SID_errorlabel";
            this.SID_errorlabel.Size = new System.Drawing.Size(28, 29);
            this.SID_errorlabel.TabIndex = 40;
            this.SID_errorlabel.Text = "*";
            this.SID_errorlabel.Visible = false;
            // 
            // name_errorlabel
            // 
            this.name_errorlabel.AutoSize = true;
            this.name_errorlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_errorlabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.name_errorlabel.Location = new System.Drawing.Point(260, 448);
            this.name_errorlabel.Name = "name_errorlabel";
            this.name_errorlabel.Size = new System.Drawing.Size(28, 29);
            this.name_errorlabel.TabIndex = 41;
            this.name_errorlabel.Text = "*";
            this.name_errorlabel.Visible = false;
            // 
            // period_errorlabel
            // 
            this.period_errorlabel.AutoSize = true;
            this.period_errorlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period_errorlabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.period_errorlabel.Location = new System.Drawing.Point(260, 536);
            this.period_errorlabel.Name = "period_errorlabel";
            this.period_errorlabel.Size = new System.Drawing.Size(28, 29);
            this.period_errorlabel.TabIndex = 42;
            this.period_errorlabel.Text = "*";
            this.period_errorlabel.Visible = false;
            // 
            // amount_errorlabel
            // 
            this.amount_errorlabel.AutoSize = true;
            this.amount_errorlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_errorlabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.amount_errorlabel.Location = new System.Drawing.Point(262, 632);
            this.amount_errorlabel.Name = "amount_errorlabel";
            this.amount_errorlabel.Size = new System.Drawing.Size(28, 29);
            this.amount_errorlabel.TabIndex = 43;
            this.amount_errorlabel.Text = "*";
            this.amount_errorlabel.Visible = false;
            // 
            // num_errorlabel
            // 
            this.num_errorlabel.AutoSize = true;
            this.num_errorlabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_errorlabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.num_errorlabel.Location = new System.Drawing.Point(258, 277);
            this.num_errorlabel.Name = "num_errorlabel";
            this.num_errorlabel.Size = new System.Drawing.Size(28, 29);
            this.num_errorlabel.TabIndex = 44;
            this.num_errorlabel.Text = "*";
            this.num_errorlabel.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 979);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Fees";
            this.Text = "Fees";
            this.Load += new System.EventHandler(this.Fees_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.FeeDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox amount_textBox;
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.DateTimePicker Period_picker;
        private System.Windows.Forms.Label period_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox StdID_DD;
        private System.Windows.Forms.Label StdID_label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox Num_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView FeeDGV;
        private System.Windows.Forms.Button pay_Btn;
        private System.Windows.Forms.Label num_errorlabel;
        private System.Windows.Forms.Label amount_errorlabel;
        private System.Windows.Forms.Label period_errorlabel;
        private System.Windows.Forms.Label name_errorlabel;
        private System.Windows.Forms.Label SID_errorlabel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}