namespace HamroSchool
{
    partial class frmSchoolEntry
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.schooldataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.websiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblschoolBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.db_hamroschoolDataSet13 = new HamroSchool.db_hamroschoolDataSet13();
            this.db_hamroschoolDataSet9 = new HamroSchool.db_hamroschoolDataSet9();
            this.tblschoolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_schoolTableAdapter = new HamroSchool.db_hamroschoolDataSet9TableAdapters.tbl_schoolTableAdapter();
            this.db_hamroschoolDataSet10 = new HamroSchool.db_hamroschoolDataSet10();
            this.tblschoolBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_schoolTableAdapter1 = new HamroSchool.db_hamroschoolDataSet10TableAdapters.tbl_schoolTableAdapter();
            this.db_hamroschoolDataSet11 = new HamroSchool.db_hamroschoolDataSet11();
            this.tblschoolBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_schoolTableAdapter2 = new HamroSchool.db_hamroschoolDataSet11TableAdapters.tbl_schoolTableAdapter();
            this.tbl_schoolTableAdapter3 = new HamroSchool.db_hamroschoolDataSet13TableAdapters.tbl_schoolTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Website = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Fax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schooldataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblschoolBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblschoolBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblschoolBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblschoolBindingSource2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(22, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 81);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(525, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 34);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(373, 29);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 34);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(204, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(35, 29);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(95, 34);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // schooldataGridView
            // 
            this.schooldataGridView.AutoGenerateColumns = false;
            this.schooldataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.schooldataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.websiteDataGridViewTextBoxColumn});
            this.schooldataGridView.DataSource = this.tblschoolBindingSource3;
            this.schooldataGridView.Location = new System.Drawing.Point(21, 278);
            this.schooldataGridView.Name = "schooldataGridView";
            this.schooldataGridView.Size = new System.Drawing.Size(649, 203);
            this.schooldataGridView.TabIndex = 13;
            this.schooldataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.schooldataGridView_CellDoubleClick);
            this.schooldataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.schooldataGridView_DataBindingComplete);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "School Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact No";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "fax";
            this.faxDataGridViewTextBoxColumn.HeaderText = "Fax No";
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email ID";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // websiteDataGridViewTextBoxColumn
            // 
            this.websiteDataGridViewTextBoxColumn.DataPropertyName = "website";
            this.websiteDataGridViewTextBoxColumn.HeaderText = "Website";
            this.websiteDataGridViewTextBoxColumn.Name = "websiteDataGridViewTextBoxColumn";
            // 
            // tblschoolBindingSource3
            // 
            this.tblschoolBindingSource3.DataMember = "tbl_school";
            this.tblschoolBindingSource3.DataSource = this.db_hamroschoolDataSet13;
            // 
            // db_hamroschoolDataSet13
            // 
            this.db_hamroschoolDataSet13.DataSetName = "db_hamroschoolDataSet13";
            this.db_hamroschoolDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_hamroschoolDataSet9
            // 
            this.db_hamroschoolDataSet9.DataSetName = "db_hamroschoolDataSet9";
            this.db_hamroschoolDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblschoolBindingSource
            // 
            this.tblschoolBindingSource.DataMember = "tbl_school";
            this.tblschoolBindingSource.DataSource = this.db_hamroschoolDataSet9;
            // 
            // tbl_schoolTableAdapter
            // 
            this.tbl_schoolTableAdapter.ClearBeforeFill = true;
            // 
            // db_hamroschoolDataSet10
            // 
            this.db_hamroschoolDataSet10.DataSetName = "db_hamroschoolDataSet10";
            this.db_hamroschoolDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblschoolBindingSource1
            // 
            this.tblschoolBindingSource1.DataMember = "tbl_school";
            this.tblschoolBindingSource1.DataSource = this.db_hamroschoolDataSet10;
            // 
            // tbl_schoolTableAdapter1
            // 
            this.tbl_schoolTableAdapter1.ClearBeforeFill = true;
            // 
            // db_hamroschoolDataSet11
            // 
            this.db_hamroschoolDataSet11.DataSetName = "db_hamroschoolDataSet11";
            this.db_hamroschoolDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblschoolBindingSource2
            // 
            this.tblschoolBindingSource2.DataMember = "tbl_school";
            this.tblschoolBindingSource2.DataSource = this.db_hamroschoolDataSet11;
            // 
            // tbl_schoolTableAdapter2
            // 
            this.tbl_schoolTableAdapter2.ClearBeforeFill = true;
            // 
            // tbl_schoolTableAdapter3
            // 
            this.tbl_schoolTableAdapter3.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Website);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Fax);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Contact);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 156);
            this.panel1.TabIndex = 14;
            // 
            // Website
            // 
            this.Website.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Website.Location = new System.Drawing.Point(448, 114);
            this.Website.Name = "Website";
            this.Website.Size = new System.Drawing.Size(202, 21);
            this.Website.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Website";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(448, 64);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(202, 21);
            this.Email.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(340, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email ID";
            // 
            // Fax
            // 
            this.Fax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fax.Location = new System.Drawing.Point(448, 19);
            this.Fax.Name = "Fax";
            this.Fax.Size = new System.Drawing.Size(202, 21);
            this.Fax.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fax Number";
            // 
            // Contact
            // 
            this.Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Location = new System.Drawing.Point(114, 117);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(202, 21);
            this.Contact.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Contact Number";
            // 
            // SAdd
            // 
            this.SAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAdd.Location = new System.Drawing.Point(114, 67);
            this.SAdd.Name = "SAdd";
            this.SAdd.Size = new System.Drawing.Size(202, 21);
            this.SAdd.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Address";
            // 
            // SName
            // 
            this.SName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SName.Location = new System.Drawing.Point(114, 18);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(202, 21);
            this.SName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "School Name";
            // 
            // frmSchoolEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.schooldataGridView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSchoolEntry";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "             School  Entry";
            this.Load += new System.EventHandler(this.frmSchoolEntry_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schooldataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblschoolBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblschoolBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblschoolBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblschoolBindingSource2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView schooldataGridView;
        private db_hamroschoolDataSet9 db_hamroschoolDataSet9;
        private System.Windows.Forms.BindingSource tblschoolBindingSource;
        private db_hamroschoolDataSet9TableAdapters.tbl_schoolTableAdapter tbl_schoolTableAdapter;
        private db_hamroschoolDataSet10 db_hamroschoolDataSet10;
        private System.Windows.Forms.BindingSource tblschoolBindingSource1;
        private db_hamroschoolDataSet10TableAdapters.tbl_schoolTableAdapter tbl_schoolTableAdapter1;
        private db_hamroschoolDataSet11 db_hamroschoolDataSet11;
        private System.Windows.Forms.BindingSource tblschoolBindingSource2;
        private db_hamroschoolDataSet11TableAdapters.tbl_schoolTableAdapter tbl_schoolTableAdapter2;
        private db_hamroschoolDataSet13 db_hamroschoolDataSet13;
        private System.Windows.Forms.BindingSource tblschoolBindingSource3;
        private db_hamroschoolDataSet13TableAdapters.tbl_schoolTableAdapter tbl_schoolTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn websiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Website;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Fax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Contact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SName;
        private System.Windows.Forms.Label label1;
    }
}