namespace HamroSchool
{
    partial class frmEmpProfile
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
            this.grpBoxemployee = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.EPost = new System.Windows.Forms.ComboBox();
            this.pst = new System.Windows.Forms.Label();
            this.EBankAcc = new System.Windows.Forms.TextBox();
            this.EReligion = new System.Windows.Forms.ComboBox();
            this.Religionlbl = new System.Windows.Forms.Label();
            this.AccNolbl = new System.Windows.Forms.Label();
            this.CitizenNo = new System.Windows.Forms.TextBox();
            this.CitizenNolbl = new System.Windows.Forms.Label();
            this.lnklblBrowse = new System.Windows.Forms.LinkLabel();
            this.EQualification = new System.Windows.Forms.RichTextBox();
            this.EComment = new System.Windows.Forms.RichTextBox();
            this.lblstfQualification = new System.Windows.Forms.Label();
            this.stfCommentlbl = new System.Windows.Forms.Label();
            this.EBSalary = new System.Windows.Forms.TextBox();
            this.lblstfBSalary = new System.Windows.Forms.Label();
            this.EEmail = new System.Windows.Forms.TextBox();
            this.lblstfEmail = new System.Windows.Forms.Label();
            this.EPhoto = new System.Windows.Forms.PictureBox();
            this.EExperience = new System.Windows.Forms.TextBox();
            this.lblstfExperience = new System.Windows.Forms.Label();
            this.Dateofjoining = new System.Windows.Forms.DateTimePicker();
            this.lblstfDOJ = new System.Windows.Forms.Label();
            this.EDept = new System.Windows.Forms.ComboBox();
            this.tbldeptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_hamroschoolDataSet17 = new HamroSchool.db_hamroschoolDataSet17();
            this.lblstfDept = new System.Windows.Forms.Label();
            this.EContact = new System.Windows.Forms.MaskedTextBox();
            this.Contact = new System.Windows.Forms.Label();
            this.ETAdd = new System.Windows.Forms.RichTextBox();
            this.EPAdd = new System.Windows.Forms.RichTextBox();
            this.lblstfTAdd = new System.Windows.Forms.Label();
            this.lblstfPAdd = new System.Windows.Forms.Label();
            this.EMName = new System.Windows.Forms.TextBox();
            this.lblstfMName = new System.Windows.Forms.Label();
            this.EFName = new System.Windows.Forms.TextBox();
            this.lblstfFName = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.lblstfDOB = new System.Windows.Forms.Label();
            this.MStatus = new System.Windows.Forms.ComboBox();
            this.lblstfMStatus = new System.Windows.Forms.Label();
            this.lblstfGender = new System.Windows.Forms.Label();
            this.EName = new System.Windows.Forms.TextBox();
            this.lblstfName = new System.Windows.Forms.Label();
            this.EID = new System.Windows.Forms.TextBox();
            this.lblstfID = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelbtn = new System.Windows.Forms.Panel();
            this.btnGetData = new System.Windows.Forms.Button();
            this.EbtnUpdate = new System.Windows.Forms.Button();
            this.EbtnDelete = new System.Windows.Forms.Button();
            this.EbtnReset = new System.Windows.Forms.Button();
            this.EbtnSave = new System.Windows.Forms.Button();
            this.tbl_deptTableAdapter = new HamroSchool.db_hamroschoolDataSet17TableAdapters.tbl_deptTableAdapter();
            this.grpBoxemployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldeptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet17)).BeginInit();
            this.panelbtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxemployee
            // 
            this.grpBoxemployee.BackColor = System.Drawing.SystemColors.Control;
            this.grpBoxemployee.Controls.Add(this.radioButton3);
            this.grpBoxemployee.Controls.Add(this.radioButton2);
            this.grpBoxemployee.Controls.Add(this.radioButton1);
            this.grpBoxemployee.Controls.Add(this.EPost);
            this.grpBoxemployee.Controls.Add(this.pst);
            this.grpBoxemployee.Controls.Add(this.EBankAcc);
            this.grpBoxemployee.Controls.Add(this.EReligion);
            this.grpBoxemployee.Controls.Add(this.Religionlbl);
            this.grpBoxemployee.Controls.Add(this.AccNolbl);
            this.grpBoxemployee.Controls.Add(this.CitizenNo);
            this.grpBoxemployee.Controls.Add(this.CitizenNolbl);
            this.grpBoxemployee.Controls.Add(this.lnklblBrowse);
            this.grpBoxemployee.Controls.Add(this.EQualification);
            this.grpBoxemployee.Controls.Add(this.EComment);
            this.grpBoxemployee.Controls.Add(this.lblstfQualification);
            this.grpBoxemployee.Controls.Add(this.stfCommentlbl);
            this.grpBoxemployee.Controls.Add(this.EBSalary);
            this.grpBoxemployee.Controls.Add(this.lblstfBSalary);
            this.grpBoxemployee.Controls.Add(this.EEmail);
            this.grpBoxemployee.Controls.Add(this.lblstfEmail);
            this.grpBoxemployee.Controls.Add(this.EPhoto);
            this.grpBoxemployee.Controls.Add(this.EExperience);
            this.grpBoxemployee.Controls.Add(this.lblstfExperience);
            this.grpBoxemployee.Controls.Add(this.Dateofjoining);
            this.grpBoxemployee.Controls.Add(this.lblstfDOJ);
            this.grpBoxemployee.Controls.Add(this.EDept);
            this.grpBoxemployee.Controls.Add(this.lblstfDept);
            this.grpBoxemployee.Controls.Add(this.EContact);
            this.grpBoxemployee.Controls.Add(this.Contact);
            this.grpBoxemployee.Controls.Add(this.ETAdd);
            this.grpBoxemployee.Controls.Add(this.EPAdd);
            this.grpBoxemployee.Controls.Add(this.lblstfTAdd);
            this.grpBoxemployee.Controls.Add(this.lblstfPAdd);
            this.grpBoxemployee.Controls.Add(this.EMName);
            this.grpBoxemployee.Controls.Add(this.lblstfMName);
            this.grpBoxemployee.Controls.Add(this.EFName);
            this.grpBoxemployee.Controls.Add(this.lblstfFName);
            this.grpBoxemployee.Controls.Add(this.DOB);
            this.grpBoxemployee.Controls.Add(this.lblstfDOB);
            this.grpBoxemployee.Controls.Add(this.MStatus);
            this.grpBoxemployee.Controls.Add(this.lblstfMStatus);
            this.grpBoxemployee.Controls.Add(this.lblstfGender);
            this.grpBoxemployee.Controls.Add(this.EName);
            this.grpBoxemployee.Controls.Add(this.lblstfName);
            this.grpBoxemployee.Controls.Add(this.EID);
            this.grpBoxemployee.Controls.Add(this.lblstfID);
            this.grpBoxemployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxemployee.Location = new System.Drawing.Point(3, 0);
            this.grpBoxemployee.Name = "grpBoxemployee";
            this.grpBoxemployee.Size = new System.Drawing.Size(793, 605);
            this.grpBoxemployee.TabIndex = 0;
            this.grpBoxemployee.TabStop = false;
            this.grpBoxemployee.Text = "Personal Profile";
            this.grpBoxemployee.Enter += new System.EventHandler(this.grpBoxemployee_Enter);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(311, 126);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(98, 19);
            this.radioButton3.TabIndex = 49;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Not Specified";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(225, 126);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 19);
            this.radioButton2.TabIndex = 48;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(152, 126);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 19);
            this.radioButton1.TabIndex = 47;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // EPost
            // 
            this.EPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPost.FormattingEnabled = true;
            this.EPost.Items.AddRange(new object[] {
            "Choose Post",
            "Principal",
            "Vice-Principal",
            "Teacher",
            "Staff",
            "Peon"});
            this.EPost.Location = new System.Drawing.Point(553, 391);
            this.EPost.Name = "EPost";
            this.EPost.Size = new System.Drawing.Size(151, 23);
            this.EPost.TabIndex = 46;
            this.EPost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EPost_KeyPress);
            // 
            // pst
            // 
            this.pst.AutoSize = true;
            this.pst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pst.Location = new System.Drawing.Point(439, 395);
            this.pst.Name = "pst";
            this.pst.Size = new System.Drawing.Size(35, 16);
            this.pst.TabIndex = 45;
            this.pst.Text = "Post";
            // 
            // EBankAcc
            // 
            this.EBankAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EBankAcc.Location = new System.Drawing.Point(553, 433);
            this.EBankAcc.Name = "EBankAcc";
            this.EBankAcc.Size = new System.Drawing.Size(199, 21);
            this.EBankAcc.TabIndex = 44;
            this.EBankAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EBankAcc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EBankAcc_KeyPress);
            // 
            // EReligion
            // 
            this.EReligion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EReligion.FormattingEnabled = true;
            this.EReligion.Items.AddRange(new object[] {
            "Choose Religion",
            "Hindu",
            "Muslim",
            "Christian",
            "Budhdha"});
            this.EReligion.Location = new System.Drawing.Point(152, 414);
            this.EReligion.Name = "EReligion";
            this.EReligion.Size = new System.Drawing.Size(199, 23);
            this.EReligion.TabIndex = 43;
            this.EReligion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EReligion_KeyPress);
            // 
            // Religionlbl
            // 
            this.Religionlbl.AutoSize = true;
            this.Religionlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Religionlbl.Location = new System.Drawing.Point(21, 415);
            this.Religionlbl.Name = "Religionlbl";
            this.Religionlbl.Size = new System.Drawing.Size(58, 16);
            this.Religionlbl.TabIndex = 42;
            this.Religionlbl.Text = "Religion";
            // 
            // AccNolbl
            // 
            this.AccNolbl.AutoSize = true;
            this.AccNolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNolbl.Location = new System.Drawing.Point(440, 433);
            this.AccNolbl.Name = "AccNolbl";
            this.AccNolbl.Size = new System.Drawing.Size(86, 16);
            this.AccNolbl.TabIndex = 40;
            this.AccNolbl.Text = "Bank Acc No";
            // 
            // CitizenNo
            // 
            this.CitizenNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CitizenNo.Location = new System.Drawing.Point(153, 90);
            this.CitizenNo.Name = "CitizenNo";
            this.CitizenNo.Size = new System.Drawing.Size(199, 21);
            this.CitizenNo.TabIndex = 39;
            this.CitizenNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CitizenNo_KeyPress);
            // 
            // CitizenNolbl
            // 
            this.CitizenNolbl.AutoSize = true;
            this.CitizenNolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CitizenNolbl.Location = new System.Drawing.Point(20, 93);
            this.CitizenNolbl.Name = "CitizenNolbl";
            this.CitizenNolbl.Size = new System.Drawing.Size(93, 16);
            this.CitizenNolbl.TabIndex = 38;
            this.CitizenNolbl.Text = "Citizenship No";
            // 
            // lnklblBrowse
            // 
            this.lnklblBrowse.AutoSize = true;
            this.lnklblBrowse.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblBrowse.Location = new System.Drawing.Point(646, 202);
            this.lnklblBrowse.Name = "lnklblBrowse";
            this.lnklblBrowse.Size = new System.Drawing.Size(96, 16);
            this.lnklblBrowse.TabIndex = 37;
            this.lnklblBrowse.TabStop = true;
            this.lnklblBrowse.Text = "Browse Image";
            this.lnklblBrowse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblBrowse_LinkClicked);
            // 
            // EQualification
            // 
            this.EQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EQualification.Location = new System.Drawing.Point(553, 512);
            this.EQualification.Name = "EQualification";
            this.EQualification.Size = new System.Drawing.Size(199, 26);
            this.EQualification.TabIndex = 36;
            this.EQualification.Text = "";
            this.EQualification.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stfQualification_KeyPress);
            // 
            // EComment
            // 
            this.EComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EComment.Location = new System.Drawing.Point(553, 554);
            this.EComment.Name = "EComment";
            this.EComment.Size = new System.Drawing.Size(199, 27);
            this.EComment.TabIndex = 35;
            this.EComment.Text = "";
            this.EComment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stfDesignation_KeyPress);
            // 
            // lblstfQualification
            // 
            this.lblstfQualification.AutoSize = true;
            this.lblstfQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstfQualification.Location = new System.Drawing.Point(440, 515);
            this.lblstfQualification.Name = "lblstfQualification";
            this.lblstfQualification.Size = new System.Drawing.Size(81, 16);
            this.lblstfQualification.TabIndex = 34;
            this.lblstfQualification.Text = "Qualification";
            // 
            // stfCommentlbl
            // 
            this.stfCommentlbl.AutoSize = true;
            this.stfCommentlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stfCommentlbl.Location = new System.Drawing.Point(440, 557);
            this.stfCommentlbl.Name = "stfCommentlbl";
            this.stfCommentlbl.Size = new System.Drawing.Size(65, 16);
            this.stfCommentlbl.TabIndex = 33;
            this.stfCommentlbl.Text = "Comment";
            // 
            // EBSalary
            // 
            this.EBSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EBSalary.Location = new System.Drawing.Point(553, 472);
            this.EBSalary.Name = "EBSalary";
            this.EBSalary.Size = new System.Drawing.Size(199, 21);
            this.EBSalary.TabIndex = 32;
            this.EBSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EBSalary.TextChanged += new System.EventHandler(this.stfBSalary_TextChanged);
            this.EBSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stfBSalary_KeyPress);
            // 
            // lblstfBSalary
            // 
            this.lblstfBSalary.AutoSize = true;
            this.lblstfBSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstfBSalary.Location = new System.Drawing.Point(440, 475);
            this.lblstfBSalary.Name = "lblstfBSalary";
            this.lblstfBSalary.Size = new System.Drawing.Size(84, 16);
            this.lblstfBSalary.TabIndex = 31;
            this.lblstfBSalary.Text = "Basic Salary";
            this.lblstfBSalary.Click += new System.EventHandler(this.lblstfBSalary_Click);
            // 
            // EEmail
            // 
            this.EEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EEmail.ForeColor = System.Drawing.Color.Black;
            this.EEmail.Location = new System.Drawing.Point(153, 561);
            this.EEmail.Name = "EEmail";
            this.EEmail.Size = new System.Drawing.Size(199, 21);
            this.EEmail.TabIndex = 30;
            this.EEmail.Click += new System.EventHandler(this.stfEmail_Click);
            this.EEmail.TextChanged += new System.EventHandler(this.stfEmail_TextChanged);
            this.EEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stfEmail_KeyPress);
            // 
            // lblstfEmail
            // 
            this.lblstfEmail.AutoSize = true;
            this.lblstfEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstfEmail.Location = new System.Drawing.Point(20, 564);
            this.lblstfEmail.Name = "lblstfEmail";
            this.lblstfEmail.Size = new System.Drawing.Size(42, 16);
            this.lblstfEmail.TabIndex = 29;
            this.lblstfEmail.Text = "Email";
            // 
            // EPhoto
            // 
            this.EPhoto.BackgroundImage = global::HamroSchool.Properties.Resources.photo;
            this.EPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EPhoto.InitialImage = null;
            this.EPhoto.Location = new System.Drawing.Point(603, 22);
            this.EPhoto.Name = "EPhoto";
            this.EPhoto.Size = new System.Drawing.Size(170, 165);
            this.EPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EPhoto.TabIndex = 28;
            this.EPhoto.TabStop = false;
            // 
            // EExperience
            // 
            this.EExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EExperience.Location = new System.Drawing.Point(153, 525);
            this.EExperience.Name = "EExperience";
            this.EExperience.Size = new System.Drawing.Size(199, 21);
            this.EExperience.TabIndex = 27;
            this.EExperience.TextChanged += new System.EventHandler(this.txtBoxstfExperience_TextChanged);
            this.EExperience.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stfExperience_KeyPress);
            // 
            // lblstfExperience
            // 
            this.lblstfExperience.AutoSize = true;
            this.lblstfExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstfExperience.Location = new System.Drawing.Point(20, 525);
            this.lblstfExperience.Name = "lblstfExperience";
            this.lblstfExperience.Size = new System.Drawing.Size(76, 16);
            this.lblstfExperience.TabIndex = 26;
            this.lblstfExperience.Text = "Experience";
            this.lblstfExperience.Click += new System.EventHandler(this.lblstfExperience_Click);
            // 
            // Dateofjoining
            // 
            this.Dateofjoining.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dateofjoining.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dateofjoining.Location = new System.Drawing.Point(152, 487);
            this.Dateofjoining.Name = "Dateofjoining";
            this.Dateofjoining.Size = new System.Drawing.Size(111, 21);
            this.Dateofjoining.TabIndex = 25;
            this.Dateofjoining.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dateofjoin_KeyPress);
            // 
            // lblstfDOJ
            // 
            this.lblstfDOJ.AutoSize = true;
            this.lblstfDOJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstfDOJ.Location = new System.Drawing.Point(20, 492);
            this.lblstfDOJ.Name = "lblstfDOJ";
            this.lblstfDOJ.Size = new System.Drawing.Size(97, 16);
            this.lblstfDOJ.TabIndex = 24;
            this.lblstfDOJ.Text = "Date of Joining";
            // 
            // EDept
            // 
            this.EDept.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbldeptBindingSource, "DName", true));
            this.EDept.DataSource = this.tbldeptBindingSource;
            this.EDept.DisplayMember = "DName";
            this.EDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDept.FormattingEnabled = true;
            this.EDept.Location = new System.Drawing.Point(153, 449);
            this.EDept.Name = "EDept";
            this.EDept.Size = new System.Drawing.Size(199, 23);
            this.EDept.TabIndex = 23;
            this.EDept.ValueMember = "DName";
            this.EDept.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stfDept_KeyPress);
            // 
            // tbldeptBindingSource
            // 
            this.tbldeptBindingSource.DataMember = "tbl_dept";
            this.tbldeptBindingSource.DataSource = this.db_hamroschoolDataSet17;
            // 
            // db_hamroschoolDataSet17
            // 
            this.db_hamroschoolDataSet17.DataSetName = "db_hamroschoolDataSet17";
            this.db_hamroschoolDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblstfDept
            // 
            this.lblstfDept.AutoSize = true;
            this.lblstfDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstfDept.Location = new System.Drawing.Point(20, 453);
            this.lblstfDept.Name = "lblstfDept";
            this.lblstfDept.Size = new System.Drawing.Size(78, 16);
            this.lblstfDept.TabIndex = 22;
            this.lblstfDept.Text = "Department";
            // 
            // EContact
            // 
            this.EContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EContact.Location = new System.Drawing.Point(153, 378);
            this.EContact.Mask = "0000000000";
            this.EContact.Name = "EContact";
            this.EContact.Size = new System.Drawing.Size(111, 21);
            this.EContact.TabIndex = 20;
            this.EContact.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.EContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stfMobile_KeyPress);
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Location = new System.Drawing.Point(20, 381);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(104, 16);
            this.Contact.TabIndex = 18;
            this.Contact.Text = "Contact Number";
            // 
            // ETAdd
            // 
            this.ETAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ETAdd.Location = new System.Drawing.Point(152, 338);
            this.ETAdd.Name = "ETAdd";
            this.ETAdd.Size = new System.Drawing.Size(267, 26);
            this.ETAdd.TabIndex = 17;
            this.ETAdd.Text = "";
            this.ETAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxstfTAdd_KeyPress);
            // 
            // EPAdd
            // 
            this.EPAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPAdd.Location = new System.Drawing.Point(153, 298);
            this.EPAdd.Name = "EPAdd";
            this.EPAdd.Size = new System.Drawing.Size(267, 27);
            this.EPAdd.TabIndex = 16;
            this.EPAdd.Text = "";
            this.EPAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxstfPAdd_KeyPress);
            // 
            // lblstfTAdd
            // 
            this.lblstfTAdd.AutoSize = true;
            this.lblstfTAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstfTAdd.Location = new System.Drawing.Point(20, 341);
            this.lblstfTAdd.Name = "lblstfTAdd";
            this.lblstfTAdd.Size = new System.Drawing.Size(129, 16);
            this.lblstfTAdd.TabIndex = 15;
            this.lblstfTAdd.Text = "Temporary Address";
            // 
            // lblstfPAdd
            // 
            this.lblstfPAdd.AutoSize = true;
            this.lblstfPAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstfPAdd.Location = new System.Drawing.Point(20, 301);
            this.lblstfPAdd.Name = "lblstfPAdd";
            this.lblstfPAdd.Size = new System.Drawing.Size(127, 16);
            this.lblstfPAdd.TabIndex = 14;
            this.lblstfPAdd.Text = "Permanent Address";
            // 
            // EMName
            // 
            this.EMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMName.Location = new System.Drawing.Point(153, 261);
            this.EMName.Name = "EMName";
            this.EMName.Size = new System.Drawing.Size(266, 21);
            this.EMName.TabIndex = 13;
            this.EMName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxstfMName_KeyPress);
            // 
            // lblstfMName
            // 
            this.lblstfMName.AutoSize = true;
            this.lblstfMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstfMName.Location = new System.Drawing.Point(20, 264);
            this.lblstfMName.Name = "lblstfMName";
            this.lblstfMName.Size = new System.Drawing.Size(96, 16);
            this.lblstfMName.TabIndex = 12;
            this.lblstfMName.Text = "Mothers Name";
            // 
            // EFName
            // 
            this.EFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EFName.Location = new System.Drawing.Point(153, 227);
            this.EFName.Name = "EFName";
            this.EFName.Size = new System.Drawing.Size(266, 21);
            this.EFName.TabIndex = 11;
            this.EFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxstfFName_KeyPress);
            // 
            // lblstfFName
            // 
            this.lblstfFName.AutoSize = true;
            this.lblstfFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstfFName.Location = new System.Drawing.Point(20, 233);
            this.lblstfFName.Name = "lblstfFName";
            this.lblstfFName.Size = new System.Drawing.Size(93, 16);
            this.lblstfFName.TabIndex = 10;
            this.lblstfFName.Text = "Fathers Name";
            // 
            // DOB
            // 
            this.DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOB.Location = new System.Drawing.Point(153, 194);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(111, 21);
            this.DOB.TabIndex = 9;
            this.DOB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.staffDOB_KeyPress);
            // 
            // lblstfDOB
            // 
            this.lblstfDOB.AutoSize = true;
            this.lblstfDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstfDOB.Location = new System.Drawing.Point(20, 203);
            this.lblstfDOB.Name = "lblstfDOB";
            this.lblstfDOB.Size = new System.Drawing.Size(80, 16);
            this.lblstfDOB.TabIndex = 8;
            this.lblstfDOB.Text = "Date of Birth";
            // 
            // MStatus
            // 
            this.MStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MStatus.FormattingEnabled = true;
            this.MStatus.Items.AddRange(new object[] {
            "Choose Marital Status",
            "Married",
            "Unmarried"});
            this.MStatus.Location = new System.Drawing.Point(153, 159);
            this.MStatus.Name = "MStatus";
            this.MStatus.Size = new System.Drawing.Size(151, 23);
            this.MStatus.TabIndex = 7;
            this.MStatus.SelectedIndexChanged += new System.EventHandler(this.cmbBoxMStatus_SelectedIndexChanged);
            this.MStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBoxMStatus_KeyPress);
            // 
            // lblstfMStatus
            // 
            this.lblstfMStatus.AutoSize = true;
            this.lblstfMStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstfMStatus.Location = new System.Drawing.Point(20, 167);
            this.lblstfMStatus.Name = "lblstfMStatus";
            this.lblstfMStatus.Size = new System.Drawing.Size(88, 16);
            this.lblstfMStatus.TabIndex = 6;
            this.lblstfMStatus.Text = "Marital Status";
            // 
            // lblstfGender
            // 
            this.lblstfGender.AutoSize = true;
            this.lblstfGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstfGender.Location = new System.Drawing.Point(20, 132);
            this.lblstfGender.Name = "lblstfGender";
            this.lblstfGender.Size = new System.Drawing.Size(53, 16);
            this.lblstfGender.TabIndex = 4;
            this.lblstfGender.Text = "Gender";
            // 
            // EName
            // 
            this.EName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EName.Location = new System.Drawing.Point(153, 55);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(266, 21);
            this.EName.TabIndex = 3;
            this.EName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxstfName_KeyPress);
            // 
            // lblstfName
            // 
            this.lblstfName.AutoSize = true;
            this.lblstfName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstfName.Location = new System.Drawing.Point(20, 58);
            this.lblstfName.Name = "lblstfName";
            this.lblstfName.Size = new System.Drawing.Size(110, 16);
            this.lblstfName.TabIndex = 2;
            this.lblstfName.Text = "Employee Name";
            // 
            // EID
            // 
            this.EID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EID.Location = new System.Drawing.Point(153, 23);
            this.EID.Name = "EID";
            this.EID.Size = new System.Drawing.Size(111, 21);
            this.EID.TabIndex = 1;
            this.EID.TextChanged += new System.EventHandler(this.EID_TextChanged);
            this.EID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxstfID_KeyPress);
            // 
            // lblstfID
            // 
            this.lblstfID.AutoSize = true;
            this.lblstfID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstfID.Location = new System.Drawing.Point(20, 26);
            this.lblstfID.Name = "lblstfID";
            this.lblstfID.Size = new System.Drawing.Size(86, 16);
            this.lblstfID.TabIndex = 0;
            this.lblstfID.Text = "Employee ID";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelbtn
            // 
            this.panelbtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelbtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelbtn.Controls.Add(this.btnGetData);
            this.panelbtn.Controls.Add(this.EbtnUpdate);
            this.panelbtn.Controls.Add(this.EbtnDelete);
            this.panelbtn.Controls.Add(this.EbtnReset);
            this.panelbtn.Controls.Add(this.EbtnSave);
            this.panelbtn.Location = new System.Drawing.Point(796, 2);
            this.panelbtn.Name = "panelbtn";
            this.panelbtn.Size = new System.Drawing.Size(154, 355);
            this.panelbtn.TabIndex = 1;
            // 
            // btnGetData
            // 
            this.btnGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetData.Location = new System.Drawing.Point(24, 298);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(112, 41);
            this.btnGetData.TabIndex = 8;
            this.btnGetData.Text = "Records";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // EbtnUpdate
            // 
            this.EbtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EbtnUpdate.Location = new System.Drawing.Point(24, 236);
            this.EbtnUpdate.Name = "EbtnUpdate";
            this.EbtnUpdate.Size = new System.Drawing.Size(112, 41);
            this.EbtnUpdate.TabIndex = 7;
            this.EbtnUpdate.Text = "Update";
            this.EbtnUpdate.UseVisualStyleBackColor = true;
            this.EbtnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // EbtnDelete
            // 
            this.EbtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EbtnDelete.Location = new System.Drawing.Point(24, 166);
            this.EbtnDelete.Name = "EbtnDelete";
            this.EbtnDelete.Size = new System.Drawing.Size(112, 41);
            this.EbtnDelete.TabIndex = 6;
            this.EbtnDelete.Text = "Delete";
            this.EbtnDelete.UseVisualStyleBackColor = true;
            this.EbtnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // EbtnReset
            // 
            this.EbtnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EbtnReset.Location = new System.Drawing.Point(24, 90);
            this.EbtnReset.Name = "EbtnReset";
            this.EbtnReset.Size = new System.Drawing.Size(112, 41);
            this.EbtnReset.TabIndex = 5;
            this.EbtnReset.Text = "Reset";
            this.EbtnReset.UseVisualStyleBackColor = true;
            this.EbtnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // EbtnSave
            // 
            this.EbtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EbtnSave.Location = new System.Drawing.Point(24, 17);
            this.EbtnSave.Name = "EbtnSave";
            this.EbtnSave.Size = new System.Drawing.Size(112, 41);
            this.EbtnSave.TabIndex = 4;
            this.EbtnSave.Text = "Save";
            this.EbtnSave.UseVisualStyleBackColor = true;
            this.EbtnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbl_deptTableAdapter
            // 
            this.tbl_deptTableAdapter.ClearBeforeFill = true;
            // 
            // frmEmpProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(951, 607);
            this.Controls.Add(this.panelbtn);
            this.Controls.Add(this.grpBoxemployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEmpProfile";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                                                 Employee Profile";
            this.Load += new System.EventHandler(this.frmEmpProfile_Load);
            this.grpBoxemployee.ResumeLayout(false);
            this.grpBoxemployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbldeptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet17)).EndInit();
            this.panelbtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxemployee;
        private System.Windows.Forms.Label lblstfDOB;
        private System.Windows.Forms.Label lblstfMStatus;
        private System.Windows.Forms.Label lblstfGender;
        private System.Windows.Forms.Label lblstfName;
        private System.Windows.Forms.Label lblstfID;
        private System.Windows.Forms.Label lblstfMName;
        private System.Windows.Forms.Label lblstfFName;
        private System.Windows.Forms.Label lblstfTAdd;
        private System.Windows.Forms.Label lblstfPAdd;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label lblstfExperience;
        private System.Windows.Forms.Label lblstfDOJ;
        private System.Windows.Forms.Label lblstfDept;
        private System.Windows.Forms.Label lblstfQualification;
        private System.Windows.Forms.Label stfCommentlbl;
        private System.Windows.Forms.Label lblstfBSalary;
        private System.Windows.Forms.Label lblstfEmail;
        private System.Windows.Forms.LinkLabel lnklblBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelbtn;
        private System.Windows.Forms.Label CitizenNolbl;
        private System.Windows.Forms.Label Religionlbl;
        private System.Windows.Forms.Label AccNolbl;
        private System.Windows.Forms.Label pst;
        public System.Windows.Forms.DateTimePicker DOB;
        public System.Windows.Forms.ComboBox MStatus;
        public System.Windows.Forms.TextBox EName;
        public System.Windows.Forms.TextBox EID;
        public System.Windows.Forms.TextBox EMName;
        public System.Windows.Forms.TextBox EFName;
        public System.Windows.Forms.RichTextBox ETAdd;
        public System.Windows.Forms.RichTextBox EPAdd;
        public System.Windows.Forms.MaskedTextBox EContact;
        public System.Windows.Forms.TextBox EExperience;
        public System.Windows.Forms.DateTimePicker Dateofjoining;
        public System.Windows.Forms.ComboBox EDept;
        public System.Windows.Forms.RichTextBox EQualification;
        public System.Windows.Forms.RichTextBox EComment;
        public System.Windows.Forms.TextBox EBSalary;
        public System.Windows.Forms.TextBox EEmail;
        public System.Windows.Forms.PictureBox EPhoto;
        public System.Windows.Forms.TextBox CitizenNo;
        public System.Windows.Forms.TextBox EBankAcc;
        public System.Windows.Forms.ComboBox EReligion;
        public System.Windows.Forms.ComboBox EPost;
        public System.Windows.Forms.RadioButton radioButton3;
        public System.Windows.Forms.RadioButton radioButton2;
        public System.Windows.Forms.RadioButton radioButton1;
        private db_hamroschoolDataSet17 db_hamroschoolDataSet17;
        private System.Windows.Forms.BindingSource tbldeptBindingSource;
        private db_hamroschoolDataSet17TableAdapters.tbl_deptTableAdapter tbl_deptTableAdapter;
        public System.Windows.Forms.Button EbtnUpdate;
        public System.Windows.Forms.Button EbtnDelete;
        public System.Windows.Forms.Button EbtnReset;
        public System.Windows.Forms.Button EbtnSave;
        public System.Windows.Forms.Button btnGetData;
    }
}