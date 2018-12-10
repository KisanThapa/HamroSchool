namespace HamroSchool
{
    partial class frmStudentProfile
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SbtnRecords = new System.Windows.Forms.Button();
            this.SRoll = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SStatus = new System.Windows.Forms.ComboBox();
            this.Statuslbl = new System.Windows.Forms.Label();
            this.PreviousSchool = new System.Windows.Forms.GroupBox();
            this.PreSPhone = new System.Windows.Forms.TextBox();
            this.PassedClass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PreSAdd = new System.Windows.Forms.TextBox();
            this.P = new System.Windows.Forms.Label();
            this.PreSName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SReligion = new System.Windows.Forms.ComboBox();
            this.Religionlbl = new System.Windows.Forms.Label();
            this.SComment = new System.Windows.Forms.RichTextBox();
            this.SCommentlbl = new System.Windows.Forms.Label();
            this.SAddmissionDate = new System.Windows.Forms.DateTimePicker();
            this.lblstfDOJ = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ParentsPnolbl = new System.Windows.Forms.Label();
            this.SLocalGuardian = new System.Windows.Forms.TextBox();
            this.SLocalGuardianlbl = new System.Windows.Forms.Label();
            this.SMName = new System.Windows.Forms.TextBox();
            this.SFNamelbl = new System.Windows.Forms.Label();
            this.SFName = new System.Windows.Forms.TextBox();
            this.SMNamelbl = new System.Windows.Forms.Label();
            this.SSection = new System.Windows.Forms.ComboBox();
            this.tblsectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_hamroschoolDataSet20 = new HamroSchool.db_hamroschoolDataSet20();
            this.SSectionlbl = new System.Windows.Forms.Label();
            this.SClass = new System.Windows.Forms.ComboBox();
            this.tblclassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_hamroschoolDataSet18 = new HamroSchool.db_hamroschoolDataSet18();
            this.SClasslbl = new System.Windows.Forms.Label();
            this.Browseimage = new System.Windows.Forms.LinkLabel();
            this.SPhoto = new System.Windows.Forms.PictureBox();
            this.STAdd = new System.Windows.Forms.RichTextBox();
            this.SPAdd = new System.Windows.Forms.RichTextBox();
            this.lblstfTAdd = new System.Windows.Forms.Label();
            this.lblstfPAdd = new System.Windows.Forms.Label();
            this.SDOB = new System.Windows.Forms.DateTimePicker();
            this.SDOBlbl = new System.Windows.Forms.Label();
            this.SGenderlbl = new System.Windows.Forms.Label();
            this.StdFName = new System.Windows.Forms.TextBox();
            this.SNamelbl = new System.Windows.Forms.Label();
            this.SID = new System.Windows.Forms.TextBox();
            this.SRolllbl = new System.Windows.Forms.Label();
            this.panelbtn = new System.Windows.Forms.Panel();
            this.SbtnUpdate = new System.Windows.Forms.Button();
            this.SbtnDelete = new System.Windows.Forms.Button();
            this.SbtnNew = new System.Windows.Forms.Button();
            this.SbtnSave = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tbl_classTableAdapter = new HamroSchool.db_hamroschoolDataSet18TableAdapters.tbl_classTableAdapter();
            this.tbl_sectionTableAdapter = new HamroSchool.db_hamroschoolDataSet20TableAdapters.tbl_sectionTableAdapter();
            this.groupBox1.SuspendLayout();
            this.PreviousSchool.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblsectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPhoto)).BeginInit();
            this.panelbtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.SbtnRecords);
            this.groupBox1.Controls.Add(this.SRoll);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.SStatus);
            this.groupBox1.Controls.Add(this.Statuslbl);
            this.groupBox1.Controls.Add(this.PreviousSchool);
            this.groupBox1.Controls.Add(this.SReligion);
            this.groupBox1.Controls.Add(this.Religionlbl);
            this.groupBox1.Controls.Add(this.SComment);
            this.groupBox1.Controls.Add(this.SCommentlbl);
            this.groupBox1.Controls.Add(this.SAddmissionDate);
            this.groupBox1.Controls.Add(this.lblstfDOJ);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.SSection);
            this.groupBox1.Controls.Add(this.SSectionlbl);
            this.groupBox1.Controls.Add(this.SClass);
            this.groupBox1.Controls.Add(this.SClasslbl);
            this.groupBox1.Controls.Add(this.Browseimage);
            this.groupBox1.Controls.Add(this.SPhoto);
            this.groupBox1.Controls.Add(this.STAdd);
            this.groupBox1.Controls.Add(this.SPAdd);
            this.groupBox1.Controls.Add(this.lblstfTAdd);
            this.groupBox1.Controls.Add(this.lblstfPAdd);
            this.groupBox1.Controls.Add(this.SDOB);
            this.groupBox1.Controls.Add(this.SDOBlbl);
            this.groupBox1.Controls.Add(this.SGenderlbl);
            this.groupBox1.Controls.Add(this.StdFName);
            this.groupBox1.Controls.Add(this.SNamelbl);
            this.groupBox1.Controls.Add(this.SID);
            this.groupBox1.Controls.Add(this.SRolllbl);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 476);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Profile";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SbtnRecords
            // 
            this.SbtnRecords.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SbtnRecords.FlatAppearance.BorderSize = 0;
            this.SbtnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SbtnRecords.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SbtnRecords.ForeColor = System.Drawing.SystemColors.Window;
            this.SbtnRecords.Location = new System.Drawing.Point(309, 20);
            this.SbtnRecords.Name = "SbtnRecords";
            this.SbtnRecords.Size = new System.Drawing.Size(75, 24);
            this.SbtnRecords.TabIndex = 8;
            this.SbtnRecords.Text = "Records";
            this.SbtnRecords.UseVisualStyleBackColor = false;
            this.SbtnRecords.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // SRoll
            // 
            this.SRoll.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SRoll.Location = new System.Drawing.Point(527, 21);
            this.SRoll.Name = "SRoll";
            this.SRoll.Size = new System.Drawing.Size(111, 23);
            this.SRoll.TabIndex = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 99;
            this.label4.Text = "Roll No";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(282, 118);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(96, 19);
            this.radioButton3.TabIndex = 98;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Not Specified";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(209, 118);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 19);
            this.radioButton2.TabIndex = 97;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(152, 118);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 19);
            this.radioButton1.TabIndex = 96;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // SStatus
            // 
            this.SStatus.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SStatus.FormattingEnabled = true;
            this.SStatus.Items.AddRange(new object[] {
            "Choose Status",
            "Active",
            "Not Active"});
            this.SStatus.Location = new System.Drawing.Point(152, 146);
            this.SStatus.Name = "SStatus";
            this.SStatus.Size = new System.Drawing.Size(111, 23);
            this.SStatus.TabIndex = 95;
            // 
            // Statuslbl
            // 
            this.Statuslbl.AutoSize = true;
            this.Statuslbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statuslbl.Location = new System.Drawing.Point(23, 150);
            this.Statuslbl.Name = "Statuslbl";
            this.Statuslbl.Size = new System.Drawing.Size(39, 15);
            this.Statuslbl.TabIndex = 94;
            this.Statuslbl.Text = "Status";
            // 
            // PreviousSchool
            // 
            this.PreviousSchool.Controls.Add(this.PreSPhone);
            this.PreviousSchool.Controls.Add(this.PassedClass);
            this.PreviousSchool.Controls.Add(this.label2);
            this.PreviousSchool.Controls.Add(this.label1);
            this.PreviousSchool.Controls.Add(this.PreSAdd);
            this.PreviousSchool.Controls.Add(this.P);
            this.PreviousSchool.Controls.Add(this.PreSName);
            this.PreviousSchool.Controls.Add(this.label3);
            this.PreviousSchool.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousSchool.Location = new System.Drawing.Point(421, 297);
            this.PreviousSchool.Name = "PreviousSchool";
            this.PreviousSchool.Size = new System.Drawing.Size(351, 160);
            this.PreviousSchool.TabIndex = 93;
            this.PreviousSchool.TabStop = false;
            this.PreviousSchool.Text = "Previous School Record (if available)";
            // 
            // PreSPhone
            // 
            this.PreSPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreSPhone.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreSPhone.Location = new System.Drawing.Point(125, 57);
            this.PreSPhone.MaxLength = 10;
            this.PreSPhone.Name = "PreSPhone";
            this.PreSPhone.Size = new System.Drawing.Size(199, 23);
            this.PreSPhone.TabIndex = 83;
            // 
            // PassedClass
            // 
            this.PassedClass.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassedClass.FormattingEnabled = true;
            this.PassedClass.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.PassedClass.Location = new System.Drawing.Point(125, 121);
            this.PassedClass.Name = "PassedClass";
            this.PassedClass.Size = new System.Drawing.Size(111, 23);
            this.PassedClass.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 80;
            this.label2.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 78;
            this.label1.Text = "Passed Class";
            // 
            // PreSAdd
            // 
            this.PreSAdd.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreSAdd.Location = new System.Drawing.Point(125, 89);
            this.PreSAdd.Name = "PreSAdd";
            this.PreSAdd.Size = new System.Drawing.Size(199, 23);
            this.PreSAdd.TabIndex = 77;
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P.Location = new System.Drawing.Point(20, 28);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(78, 15);
            this.P.TabIndex = 74;
            this.P.Text = "School Name";
            // 
            // PreSName
            // 
            this.PreSName.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreSName.Location = new System.Drawing.Point(125, 25);
            this.PreSName.Name = "PreSName";
            this.PreSName.Size = new System.Drawing.Size(199, 23);
            this.PreSName.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 76;
            this.label3.Text = "Address";
            // 
            // SReligion
            // 
            this.SReligion.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SReligion.FormattingEnabled = true;
            this.SReligion.Items.AddRange(new object[] {
            "Choose Religion",
            "Hindu",
            "Muslim",
            "Christian",
            "Budhdha"});
            this.SReligion.Location = new System.Drawing.Point(495, 178);
            this.SReligion.Name = "SReligion";
            this.SReligion.Size = new System.Drawing.Size(143, 23);
            this.SReligion.TabIndex = 90;
            this.SReligion.SelectedIndexChanged += new System.EventHandler(this.SReligion_SelectedIndexChanged);
            // 
            // Religionlbl
            // 
            this.Religionlbl.AutoSize = true;
            this.Religionlbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Religionlbl.Location = new System.Drawing.Point(418, 181);
            this.Religionlbl.Name = "Religionlbl";
            this.Religionlbl.Size = new System.Drawing.Size(50, 15);
            this.Religionlbl.TabIndex = 89;
            this.Religionlbl.Text = "Religion";
            // 
            // SComment
            // 
            this.SComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SComment.Location = new System.Drawing.Point(495, 210);
            this.SComment.Name = "SComment";
            this.SComment.Size = new System.Drawing.Size(199, 72);
            this.SComment.TabIndex = 88;
            this.SComment.Text = "";
            // 
            // SCommentlbl
            // 
            this.SCommentlbl.AutoSize = true;
            this.SCommentlbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SCommentlbl.Location = new System.Drawing.Point(418, 213);
            this.SCommentlbl.Name = "SCommentlbl";
            this.SCommentlbl.Size = new System.Drawing.Size(61, 15);
            this.SCommentlbl.TabIndex = 87;
            this.SCommentlbl.Text = "Comment";
            // 
            // SAddmissionDate
            // 
            this.SAddmissionDate.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAddmissionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SAddmissionDate.Location = new System.Drawing.Point(527, 147);
            this.SAddmissionDate.Name = "SAddmissionDate";
            this.SAddmissionDate.Size = new System.Drawing.Size(111, 23);
            this.SAddmissionDate.TabIndex = 86;
            // 
            // lblstfDOJ
            // 
            this.lblstfDOJ.AutoSize = true;
            this.lblstfDOJ.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstfDOJ.Location = new System.Drawing.Point(418, 150);
            this.lblstfDOJ.Name = "lblstfDOJ";
            this.lblstfDOJ.Size = new System.Drawing.Size(90, 15);
            this.lblstfDOJ.TabIndex = 85;
            this.lblstfDOJ.Text = "Admission Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.ParentsPnolbl);
            this.groupBox2.Controls.Add(this.SLocalGuardian);
            this.groupBox2.Controls.Add(this.SLocalGuardianlbl);
            this.groupBox2.Controls.Add(this.SMName);
            this.groupBox2.Controls.Add(this.SFNamelbl);
            this.groupBox2.Controls.Add(this.SFName);
            this.groupBox2.Controls.Add(this.SMNamelbl);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 214);
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parents Infomation";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(143, 178);
            this.textBox5.MaxLength = 10;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(209, 23);
            this.textBox5.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 15);
            this.label6.TabIndex = 82;
            this.label6.Text = "Local Parent Ph. No.(opt)";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(143, 84);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(209, 23);
            this.textBox4.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 80;
            this.label5.Text = "Parents Occupation";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(143, 115);
            this.textBox3.MaxLength = 10;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 23);
            this.textBox3.TabIndex = 79;
            // 
            // ParentsPnolbl
            // 
            this.ParentsPnolbl.AutoSize = true;
            this.ParentsPnolbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParentsPnolbl.Location = new System.Drawing.Point(7, 119);
            this.ParentsPnolbl.Name = "ParentsPnolbl";
            this.ParentsPnolbl.Size = new System.Drawing.Size(88, 15);
            this.ParentsPnolbl.TabIndex = 78;
            this.ParentsPnolbl.Text = "Phone Number";
            // 
            // SLocalGuardian
            // 
            this.SLocalGuardian.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLocalGuardian.Location = new System.Drawing.Point(143, 147);
            this.SLocalGuardian.Name = "SLocalGuardian";
            this.SLocalGuardian.Size = new System.Drawing.Size(209, 23);
            this.SLocalGuardian.TabIndex = 73;
            // 
            // SLocalGuardianlbl
            // 
            this.SLocalGuardianlbl.AutoSize = true;
            this.SLocalGuardianlbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLocalGuardianlbl.Location = new System.Drawing.Point(6, 152);
            this.SLocalGuardianlbl.Name = "SLocalGuardianlbl";
            this.SLocalGuardianlbl.Size = new System.Drawing.Size(124, 15);
            this.SLocalGuardianlbl.TabIndex = 72;
            this.SLocalGuardianlbl.Text = "Local Parent(optional)";
            // 
            // SMName
            // 
            this.SMName.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMName.Location = new System.Drawing.Point(143, 53);
            this.SMName.Name = "SMName";
            this.SMName.Size = new System.Drawing.Size(209, 23);
            this.SMName.TabIndex = 71;
            // 
            // SFNamelbl
            // 
            this.SFNamelbl.AutoSize = true;
            this.SFNamelbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFNamelbl.Location = new System.Drawing.Point(6, 25);
            this.SFNamelbl.Name = "SFNamelbl";
            this.SFNamelbl.Size = new System.Drawing.Size(80, 15);
            this.SFNamelbl.TabIndex = 68;
            this.SFNamelbl.Text = "Fathers Name";
            // 
            // SFName
            // 
            this.SFName.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFName.Location = new System.Drawing.Point(143, 22);
            this.SFName.Name = "SFName";
            this.SFName.Size = new System.Drawing.Size(209, 23);
            this.SFName.TabIndex = 69;
            // 
            // SMNamelbl
            // 
            this.SMNamelbl.AutoSize = true;
            this.SMNamelbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMNamelbl.Location = new System.Drawing.Point(6, 56);
            this.SMNamelbl.Name = "SMNamelbl";
            this.SMNamelbl.Size = new System.Drawing.Size(86, 15);
            this.SMNamelbl.TabIndex = 70;
            this.SMNamelbl.Text = "Mothers Name";
            // 
            // SSection
            // 
            this.SSection.DataSource = this.tblsectionBindingSource;
            this.SSection.DisplayMember = "Name";
            this.SSection.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSection.FormattingEnabled = true;
            this.SSection.Location = new System.Drawing.Point(527, 84);
            this.SSection.Name = "SSection";
            this.SSection.Size = new System.Drawing.Size(111, 23);
            this.SSection.TabIndex = 83;
            this.SSection.ValueMember = "Name";
            // 
            // tblsectionBindingSource
            // 
            this.tblsectionBindingSource.DataMember = "tbl_section";
            this.tblsectionBindingSource.DataSource = this.db_hamroschoolDataSet20;
            // 
            // db_hamroschoolDataSet20
            // 
            this.db_hamroschoolDataSet20.DataSetName = "db_hamroschoolDataSet20";
            this.db_hamroschoolDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SSectionlbl
            // 
            this.SSectionlbl.AutoSize = true;
            this.SSectionlbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSectionlbl.Location = new System.Drawing.Point(418, 91);
            this.SSectionlbl.Name = "SSectionlbl";
            this.SSectionlbl.Size = new System.Drawing.Size(46, 15);
            this.SSectionlbl.TabIndex = 82;
            this.SSectionlbl.Text = "Section";
            // 
            // SClass
            // 
            this.SClass.DataSource = this.tblclassBindingSource;
            this.SClass.DisplayMember = "class";
            this.SClass.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SClass.FormattingEnabled = true;
            this.SClass.Location = new System.Drawing.Point(152, 85);
            this.SClass.Name = "SClass";
            this.SClass.Size = new System.Drawing.Size(111, 23);
            this.SClass.TabIndex = 81;
            this.SClass.ValueMember = "class";
            // 
            // tblclassBindingSource
            // 
            this.tblclassBindingSource.DataMember = "tbl_class";
            this.tblclassBindingSource.DataSource = this.db_hamroschoolDataSet18;
            // 
            // db_hamroschoolDataSet18
            // 
            this.db_hamroschoolDataSet18.DataSetName = "db_hamroschoolDataSet18";
            this.db_hamroschoolDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SClasslbl
            // 
            this.SClasslbl.AutoSize = true;
            this.SClasslbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SClasslbl.Location = new System.Drawing.Point(22, 89);
            this.SClasslbl.Name = "SClasslbl";
            this.SClasslbl.Size = new System.Drawing.Size(34, 15);
            this.SClasslbl.TabIndex = 80;
            this.SClasslbl.Text = "Class";
            // 
            // Browseimage
            // 
            this.Browseimage.AutoSize = true;
            this.Browseimage.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browseimage.Location = new System.Drawing.Point(751, 196);
            this.Browseimage.Name = "Browseimage";
            this.Browseimage.Size = new System.Drawing.Size(90, 17);
            this.Browseimage.TabIndex = 79;
            this.Browseimage.TabStop = true;
            this.Browseimage.Text = "Browse Image";
            this.Browseimage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblBrowse_LinkClicked);
            // 
            // SPhoto
            // 
            this.SPhoto.BackgroundImage = global::HamroSchool.Properties.Resources.photo2;
            this.SPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SPhoto.Image = global::HamroSchool.Properties.Resources.photo2;
            this.SPhoto.InitialImage = null;
            this.SPhoto.Location = new System.Drawing.Point(712, 20);
            this.SPhoto.Name = "SPhoto";
            this.SPhoto.Size = new System.Drawing.Size(170, 165);
            this.SPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SPhoto.TabIndex = 78;
            this.SPhoto.TabStop = false;
            // 
            // STAdd
            // 
            this.STAdd.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STAdd.Location = new System.Drawing.Point(151, 210);
            this.STAdd.Name = "STAdd";
            this.STAdd.Size = new System.Drawing.Size(209, 22);
            this.STAdd.TabIndex = 75;
            this.STAdd.Text = "";
            // 
            // SPAdd
            // 
            this.SPAdd.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SPAdd.Location = new System.Drawing.Point(151, 178);
            this.SPAdd.Name = "SPAdd";
            this.SPAdd.Size = new System.Drawing.Size(209, 22);
            this.SPAdd.TabIndex = 74;
            this.SPAdd.Text = "";
            // 
            // lblstfTAdd
            // 
            this.lblstfTAdd.AutoSize = true;
            this.lblstfTAdd.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstfTAdd.Location = new System.Drawing.Point(23, 213);
            this.lblstfTAdd.Name = "lblstfTAdd";
            this.lblstfTAdd.Size = new System.Drawing.Size(109, 15);
            this.lblstfTAdd.TabIndex = 73;
            this.lblstfTAdd.Text = "Temporary Address";
            // 
            // lblstfPAdd
            // 
            this.lblstfPAdd.AutoSize = true;
            this.lblstfPAdd.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstfPAdd.Location = new System.Drawing.Point(23, 181);
            this.lblstfPAdd.Name = "lblstfPAdd";
            this.lblstfPAdd.Size = new System.Drawing.Size(110, 15);
            this.lblstfPAdd.TabIndex = 72;
            this.lblstfPAdd.Text = "Permanent Address";
            // 
            // SDOB
            // 
            this.SDOB.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SDOB.Location = new System.Drawing.Point(527, 116);
            this.SDOB.Name = "SDOB";
            this.SDOB.Size = new System.Drawing.Size(111, 23);
            this.SDOB.TabIndex = 67;
            // 
            // SDOBlbl
            // 
            this.SDOBlbl.AutoSize = true;
            this.SDOBlbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDOBlbl.Location = new System.Drawing.Point(418, 121);
            this.SDOBlbl.Name = "SDOBlbl";
            this.SDOBlbl.Size = new System.Drawing.Size(73, 15);
            this.SDOBlbl.TabIndex = 66;
            this.SDOBlbl.Text = "Date of Birth";
            // 
            // SGenderlbl
            // 
            this.SGenderlbl.AutoSize = true;
            this.SGenderlbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SGenderlbl.Location = new System.Drawing.Point(23, 121);
            this.SGenderlbl.Name = "SGenderlbl";
            this.SGenderlbl.Size = new System.Drawing.Size(45, 15);
            this.SGenderlbl.TabIndex = 64;
            this.SGenderlbl.Text = "Gender";
            // 
            // StdFName
            // 
            this.StdFName.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdFName.ForeColor = System.Drawing.Color.DarkGray;
            this.StdFName.Location = new System.Drawing.Point(152, 53);
            this.StdFName.Name = "StdFName";
            this.StdFName.Size = new System.Drawing.Size(486, 23);
            this.StdFName.TabIndex = 63;
            this.StdFName.Text = "Student Name";
            this.StdFName.TextChanged += new System.EventHandler(this.StdFName_TextChanged);
            this.StdFName.Enter += new System.EventHandler(this.SName_Enter);
            this.StdFName.Leave += new System.EventHandler(this.StdFName_Leave);
            // 
            // SNamelbl
            // 
            this.SNamelbl.AutoSize = true;
            this.SNamelbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNamelbl.Location = new System.Drawing.Point(22, 56);
            this.SNamelbl.Name = "SNamelbl";
            this.SNamelbl.Size = new System.Drawing.Size(83, 15);
            this.SNamelbl.TabIndex = 62;
            this.SNamelbl.Text = "Student Name";
            // 
            // SID
            // 
            this.SID.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SID.Location = new System.Drawing.Point(152, 21);
            this.SID.Name = "SID";
            this.SID.Size = new System.Drawing.Size(143, 23);
            this.SID.TabIndex = 60;
            this.SID.TextChanged += new System.EventHandler(this.SID_TextChanged);
            // 
            // SRolllbl
            // 
            this.SRolllbl.AutoSize = true;
            this.SRolllbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SRolllbl.Location = new System.Drawing.Point(23, 25);
            this.SRolllbl.Name = "SRolllbl";
            this.SRolllbl.Size = new System.Drawing.Size(109, 15);
            this.SRolllbl.TabIndex = 59;
            this.SRolllbl.Text = "Student ID (Add ID)";
            // 
            // panelbtn
            // 
            this.panelbtn.BackColor = System.Drawing.SystemColors.Window;
            this.panelbtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelbtn.Controls.Add(this.SbtnUpdate);
            this.panelbtn.Controls.Add(this.SbtnDelete);
            this.panelbtn.Controls.Add(this.SbtnNew);
            this.panelbtn.Controls.Add(this.SbtnSave);
            this.panelbtn.Location = new System.Drawing.Point(913, 1);
            this.panelbtn.Name = "panelbtn";
            this.panelbtn.Size = new System.Drawing.Size(152, 476);
            this.panelbtn.TabIndex = 62;
            // 
            // SbtnUpdate
            // 
            this.SbtnUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SbtnUpdate.FlatAppearance.BorderSize = 0;
            this.SbtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SbtnUpdate.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SbtnUpdate.ForeColor = System.Drawing.SystemColors.Window;
            this.SbtnUpdate.Location = new System.Drawing.Point(34, 243);
            this.SbtnUpdate.Name = "SbtnUpdate";
            this.SbtnUpdate.Size = new System.Drawing.Size(85, 35);
            this.SbtnUpdate.TabIndex = 7;
            this.SbtnUpdate.Text = "Update";
            this.SbtnUpdate.UseVisualStyleBackColor = false;
            this.SbtnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // SbtnDelete
            // 
            this.SbtnDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SbtnDelete.FlatAppearance.BorderSize = 0;
            this.SbtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SbtnDelete.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SbtnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.SbtnDelete.Location = new System.Drawing.Point(34, 344);
            this.SbtnDelete.Name = "SbtnDelete";
            this.SbtnDelete.Size = new System.Drawing.Size(85, 35);
            this.SbtnDelete.TabIndex = 6;
            this.SbtnDelete.Text = "Delete";
            this.SbtnDelete.UseVisualStyleBackColor = false;
            this.SbtnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // SbtnNew
            // 
            this.SbtnNew.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SbtnNew.FlatAppearance.BorderSize = 0;
            this.SbtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SbtnNew.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SbtnNew.ForeColor = System.Drawing.SystemColors.Window;
            this.SbtnNew.Location = new System.Drawing.Point(34, 144);
            this.SbtnNew.Name = "SbtnNew";
            this.SbtnNew.Size = new System.Drawing.Size(85, 35);
            this.SbtnNew.TabIndex = 5;
            this.SbtnNew.Text = "New";
            this.SbtnNew.UseVisualStyleBackColor = false;
            this.SbtnNew.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // SbtnSave
            // 
            this.SbtnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SbtnSave.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.SbtnSave.FlatAppearance.BorderSize = 0;
            this.SbtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SbtnSave.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SbtnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.SbtnSave.Location = new System.Drawing.Point(34, 51);
            this.SbtnSave.Name = "SbtnSave";
            this.SbtnSave.Size = new System.Drawing.Size(85, 34);
            this.SbtnSave.TabIndex = 4;
            this.SbtnSave.Text = "Save";
            this.SbtnSave.UseVisualStyleBackColor = false;
            this.SbtnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tbl_classTableAdapter
            // 
            this.tbl_classTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_sectionTableAdapter
            // 
            this.tbl_sectionTableAdapter.ClearBeforeFill = true;
            // 
            // frmStudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 477);
            this.Controls.Add(this.panelbtn);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmStudentProfile";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                                                                                " +
    "   Student Profile";
            this.Load += new System.EventHandler(this.frmStudentProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PreviousSchool.ResumeLayout(false);
            this.PreviousSchool.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblsectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPhoto)).EndInit();
            this.panelbtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblstfTAdd;
        private System.Windows.Forms.Label lblstfPAdd;
        private System.Windows.Forms.Label SMNamelbl;
        private System.Windows.Forms.Label SFNamelbl;
        private System.Windows.Forms.Label SDOBlbl;
        private System.Windows.Forms.Label SGenderlbl;
        private System.Windows.Forms.Label SNamelbl;
        private System.Windows.Forms.Label SRolllbl;
        private System.Windows.Forms.Panel panelbtn;
        private System.Windows.Forms.Label SClasslbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ParentsPnolbl;
        private System.Windows.Forms.Label SLocalGuardianlbl;
        private System.Windows.Forms.Label SSectionlbl;
        private System.Windows.Forms.Label Religionlbl;
        private System.Windows.Forms.Label SCommentlbl;
        private System.Windows.Forms.Label lblstfDOJ;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox PreviousSchool;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label P;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Statuslbl;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.LinkLabel Browseimage;
        public System.Windows.Forms.PictureBox SPhoto;
        public System.Windows.Forms.RichTextBox STAdd;
        public System.Windows.Forms.RichTextBox SPAdd;
        public System.Windows.Forms.TextBox SMName;
        public System.Windows.Forms.TextBox SFName;
        public System.Windows.Forms.DateTimePicker SDOB;
        public System.Windows.Forms.TextBox StdFName;
        public System.Windows.Forms.TextBox SID;
        public System.Windows.Forms.ComboBox SClass;
        public System.Windows.Forms.TextBox SLocalGuardian;
        public System.Windows.Forms.ComboBox SSection;
        public System.Windows.Forms.ComboBox SReligion;
        public System.Windows.Forms.RichTextBox SComment;
        public System.Windows.Forms.DateTimePicker SAddmissionDate;
        public System.Windows.Forms.ComboBox PassedClass;
        public System.Windows.Forms.TextBox PreSAdd;
        public System.Windows.Forms.TextBox PreSName;
        public System.Windows.Forms.ComboBox SStatus;
        public System.Windows.Forms.RadioButton radioButton3;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
        public System.Windows.Forms.TextBox SRoll;
        public System.Windows.Forms.Button SbtnUpdate;
        public System.Windows.Forms.Button SbtnDelete;
        public System.Windows.Forms.Button SbtnNew;
        public System.Windows.Forms.Button SbtnSave;
        public System.Windows.Forms.Button SbtnRecords;
        private db_hamroschoolDataSet18 db_hamroschoolDataSet18;
        private System.Windows.Forms.BindingSource tblclassBindingSource;
        private db_hamroschoolDataSet18TableAdapters.tbl_classTableAdapter tbl_classTableAdapter;
        private db_hamroschoolDataSet20 db_hamroschoolDataSet20;
        private System.Windows.Forms.BindingSource tblsectionBindingSource;
        private db_hamroschoolDataSet20TableAdapters.tbl_sectionTableAdapter tbl_sectionTableAdapter;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox PreSPhone;
        public System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
    }
}