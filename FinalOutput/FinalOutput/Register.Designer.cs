namespace FinalOutput
{
    partial class RegForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnregister = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.bdayDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbsex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnregister);
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.bdayDatePicker);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtconfirm);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbsex);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtlname);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtfname);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 500);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(25, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 19);
            this.label11.TabIndex = 41;
            this.label11.Text = "Sex";
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.Chartreuse;
            this.btnregister.Location = new System.Drawing.Point(253, 389);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(128, 34);
            this.btnregister.TabIndex = 40;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Red;
            this.btncancel.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(65, 389);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(128, 34);
            this.btncancel.TabIndex = 39;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // bdayDatePicker
            // 
            this.bdayDatePicker.Location = new System.Drawing.Point(241, 130);
            this.bdayDatePicker.Name = "bdayDatePicker";
            this.bdayDatePicker.Size = new System.Drawing.Size(189, 20);
            this.bdayDatePicker.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(237, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 37;
            this.label8.Text = "Birthday";
            // 
            // txtconfirm
            // 
            this.txtconfirm.Location = new System.Drawing.Point(241, 331);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.Size = new System.Drawing.Size(189, 20);
            this.txtconfirm.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(237, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Confirm Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(241, 264);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(189, 20);
            this.txtpassword.TabIndex = 34;
            this.txtpassword.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(237, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(241, 198);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(189, 20);
            this.txtusername.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(237, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Username";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(29, 331);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(189, 20);
            this.txtemail.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(24, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Email";
            // 
            // cmbsex
            // 
            this.cmbsex.FormattingEnabled = true;
            this.cmbsex.Location = new System.Drawing.Point(28, 264);
            this.cmbsex.Name = "cmbsex";
            this.cmbsex.Size = new System.Drawing.Size(189, 21);
            this.cmbsex.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-32, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Sex";
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(28, 198);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(190, 20);
            this.txtlname.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(25, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Last Name";
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(28, 130);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(190, 20);
            this.txtfname.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(24, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkOrange;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(235, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(82, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Register";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(578, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 42);
            this.label12.TabIndex = 8;
            this.label12.Text = "BE";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(606, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 42);
            this.label13.TabIndex = 9;
            this.label13.Text = "PART";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(684, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 42);
            this.label14.TabIndex = 10;
            this.label14.Text = "OF";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(735, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 42);
            this.label15.TabIndex = 11;
            this.label15.Text = "US";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalOutput.Properties.Resources.burger2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegForm";
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DateTimePicker bdayDatePicker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtconfirm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbsex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}