namespace HamroSchool
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxshowpassword = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbBoxusertype = new System.Windows.Forms.ComboBox();
            this.labeltype = new System.Windows.Forms.Label();
            this.txtBoxpassword = new System.Windows.Forms.TextBox();
            this.txtBoxusername = new System.Windows.Forms.TextBox();
            this.Labelpassword = new System.Windows.Forms.Label();
            this.Labelusername = new System.Windows.Forms.Label();
            this.forgetpassword = new System.Windows.Forms.LinkLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.db_hamroschoolDataSet22 = new HamroSchool.db_hamroschoolDataSet22();
            this.tbldeptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_deptTableAdapter = new HamroSchool.db_hamroschoolDataSet22TableAdapters.tbl_deptTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldeptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBoxshowpassword);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.forgetpassword);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(417, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 415);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "|";
            // 
            // checkBoxshowpassword
            // 
            this.checkBoxshowpassword.AutoSize = true;
            this.checkBoxshowpassword.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxshowpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxshowpassword.Location = new System.Drawing.Point(30, 346);
            this.checkBoxshowpassword.Name = "checkBoxshowpassword";
            this.checkBoxshowpassword.Size = new System.Drawing.Size(142, 23);
            this.checkBoxshowpassword.TabIndex = 15;
            this.checkBoxshowpassword.Text = "Show Password";
            this.checkBoxshowpassword.UseVisualStyleBackColor = true;
            this.checkBoxshowpassword.CheckedChanged += new System.EventHandler(this.checkBoxshowpassword_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmbBoxusertype);
            this.panel2.Controls.Add(this.labeltype);
            this.panel2.Controls.Add(this.txtBoxpassword);
            this.panel2.Controls.Add(this.txtBoxusername);
            this.panel2.Controls.Add(this.Labelpassword);
            this.panel2.Controls.Add(this.Labelusername);
            this.panel2.Location = new System.Drawing.Point(23, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 218);
            this.panel2.TabIndex = 1;
            // 
            // cmbBoxusertype
            // 
            this.cmbBoxusertype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxusertype.FormattingEnabled = true;
            this.cmbBoxusertype.Items.AddRange(new object[] {
            "Choose Post",
            "Admin",
            "Lecturer",
            "Accountant"});
            this.cmbBoxusertype.Location = new System.Drawing.Point(119, 161);
            this.cmbBoxusertype.Name = "cmbBoxusertype";
            this.cmbBoxusertype.Size = new System.Drawing.Size(158, 24);
            this.cmbBoxusertype.TabIndex = 14;
            this.cmbBoxusertype.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBoxusertype_KeyPress);
            // 
            // labeltype
            // 
            this.labeltype.AutoSize = true;
            this.labeltype.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltype.Location = new System.Drawing.Point(14, 164);
            this.labeltype.Name = "labeltype";
            this.labeltype.Size = new System.Drawing.Size(86, 19);
            this.labeltype.TabIndex = 13;
            this.labeltype.Text = "USER TYPE : ";
            // 
            // txtBoxpassword
            // 
            this.txtBoxpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxpassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxpassword.Location = new System.Drawing.Point(119, 98);
            this.txtBoxpassword.Name = "txtBoxpassword";
            this.txtBoxpassword.Size = new System.Drawing.Size(158, 23);
            this.txtBoxpassword.TabIndex = 12;
            this.txtBoxpassword.Text = "Enter Password";
            this.txtBoxpassword.Enter += new System.EventHandler(this.txtBoxpassword_Enter);
            this.txtBoxpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxpassword_KeyPress);
            this.txtBoxpassword.Leave += new System.EventHandler(this.txtBoxpassword_Leave);
            // 
            // txtBoxusername
            // 
            this.txtBoxusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxusername.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBoxusername.Location = new System.Drawing.Point(119, 33);
            this.txtBoxusername.Name = "txtBoxusername";
            this.txtBoxusername.Size = new System.Drawing.Size(158, 23);
            this.txtBoxusername.TabIndex = 11;
            this.txtBoxusername.Text = "Enter Username";
            this.txtBoxusername.Enter += new System.EventHandler(this.txtBoxusername_Enter);
            this.txtBoxusername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxusername_KeyPress);
            this.txtBoxusername.Leave += new System.EventHandler(this.txtBoxusername_Leave);
            // 
            // Labelpassword
            // 
            this.Labelpassword.AutoSize = true;
            this.Labelpassword.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelpassword.Location = new System.Drawing.Point(13, 100);
            this.Labelpassword.Name = "Labelpassword";
            this.Labelpassword.Size = new System.Drawing.Size(92, 19);
            this.Labelpassword.TabIndex = 10;
            this.Labelpassword.Text = "PASSWORD : ";
            // 
            // Labelusername
            // 
            this.Labelusername.AutoSize = true;
            this.Labelusername.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelusername.Location = new System.Drawing.Point(13, 35);
            this.Labelusername.Name = "Labelusername";
            this.Labelusername.Size = new System.Drawing.Size(91, 19);
            this.Labelusername.TabIndex = 9;
            this.Labelusername.Text = "USERNAME : ";
            // 
            // forgetpassword
            // 
            this.forgetpassword.AutoSize = true;
            this.forgetpassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetpassword.LinkColor = System.Drawing.Color.Black;
            this.forgetpassword.Location = new System.Drawing.Point(202, 347);
            this.forgetpassword.Name = "forgetpassword";
            this.forgetpassword.Size = new System.Drawing.Size(122, 20);
            this.forgetpassword.TabIndex = 9;
            this.forgetpassword.TabStop = true;
            this.forgetpassword.Text = "Forget Password";
            this.forgetpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgetpassword_LinkClicked);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(199, 292);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CLOSE";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(40, 292);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 33);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // db_hamroschoolDataSet22
            // 
            this.db_hamroschoolDataSet22.DataSetName = "db_hamroschoolDataSet22";
            this.db_hamroschoolDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbldeptBindingSource
            // 
            this.tbldeptBindingSource.DataMember = "tbl_dept";
            this.tbldeptBindingSource.DataSource = this.db_hamroschoolDataSet22;
            // 
            // tbl_deptTableAdapter
            // 
            this.tbl_deptTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 415);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "© 2015   Kisan Thapa";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 415);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                      Hamro School";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldeptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel forgetpassword;
        private db_hamroschoolDataSet22 db_hamroschoolDataSet22;
        private System.Windows.Forms.BindingSource tbldeptBindingSource;
        private db_hamroschoolDataSet22TableAdapters.tbl_deptTableAdapter tbl_deptTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxshowpassword;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ComboBox cmbBoxusertype;
        private System.Windows.Forms.Label labeltype;
        private System.Windows.Forms.TextBox txtBoxpassword;
        private System.Windows.Forms.TextBox txtBoxusername;
        private System.Windows.Forms.Label Labelpassword;
        private System.Windows.Forms.Label Labelusername;
        private System.Windows.Forms.Label label2;
    }
}

