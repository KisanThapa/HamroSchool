namespace HamroSchool
{
    partial class frmBookEntry
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
            this.author = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.reference = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pubYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.publisher = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.isbn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.ComboBox();
            this.tbldeptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_hamroschoolDataSet23 = new HamroSchool.db_hamroschoolDataSet23();
            this.edition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bookTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnViewRecord = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sub = new System.Windows.Forms.ComboBox();
            this.tblsubjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_hamroschoolDataSet25 = new HamroSchool.db_hamroschoolDataSet25();
            this.AccNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbl_deptTableAdapter = new HamroSchool.db_hamroschoolDataSet23TableAdapters.tbl_deptTableAdapter();
            this.db_hamroschoolDataSet24 = new HamroSchool.db_hamroschoolDataSet24();
            this.tblsubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_subjectTableAdapter = new HamroSchool.db_hamroschoolDataSet24TableAdapters.tbl_subjectTableAdapter();
            this.tbl_subjectTableAdapter1 = new HamroSchool.db_hamroschoolDataSet25TableAdapters.tbl_subjectTableAdapter();
            this.db_hamroschoolDataSet51 = new HamroSchool.db_hamroschoolDataSet51();
            this.tblsubjectBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_subjectTableAdapter2 = new HamroSchool.db_hamroschoolDataSet51TableAdapters.tbl_subjectTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbldeptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsubjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsubjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsubjectBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.author);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.reference);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.volume);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pubYear);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.publisher);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.isbn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dept);
            this.groupBox1.Controls.Add(this.edition);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.bookTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnViewRecord);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sub);
            this.groupBox1.Controls.Add(this.AccNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 486);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(138, 99);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(240, 21);
            this.author.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Author";
            // 
            // reference
            // 
            this.reference.Location = new System.Drawing.Point(137, 425);
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(191, 43);
            this.reference.TabIndex = 22;
            this.reference.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 433);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "References";
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(138, 387);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(164, 21);
            this.volume.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 390);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Volume";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(139, 350);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(139, 21);
            this.price.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Price";
            // 
            // pubYear
            // 
            this.pubYear.Location = new System.Drawing.Point(139, 314);
            this.pubYear.Name = "pubYear";
            this.pubYear.Size = new System.Drawing.Size(121, 21);
            this.pubYear.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Publishing Year";
            // 
            // publisher
            // 
            this.publisher.Location = new System.Drawing.Point(139, 279);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(240, 21);
            this.publisher.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Publisher";
            // 
            // isbn
            // 
            this.isbn.Location = new System.Drawing.Point(139, 208);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(163, 21);
            this.isbn.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "ISBN No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Department";
            // 
            // dept
            // 
            this.dept.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbldeptBindingSource, "DName", true));
            this.dept.DataSource = this.tbldeptBindingSource;
            this.dept.DisplayMember = "DName";
            this.dept.FormattingEnabled = true;
            this.dept.Location = new System.Drawing.Point(139, 170);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(191, 23);
            this.dept.TabIndex = 9;
            this.dept.ValueMember = "DName";
            // 
            // tbldeptBindingSource
            // 
            this.tbldeptBindingSource.DataMember = "tbl_dept";
            this.tbldeptBindingSource.DataSource = this.db_hamroschoolDataSet23;
            // 
            // db_hamroschoolDataSet23
            // 
            this.db_hamroschoolDataSet23.DataSetName = "db_hamroschoolDataSet23";
            this.db_hamroschoolDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // edition
            // 
            this.edition.Location = new System.Drawing.Point(139, 244);
            this.edition.Name = "edition";
            this.edition.Size = new System.Drawing.Size(163, 21);
            this.edition.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Edition ";
            // 
            // bookTitle
            // 
            this.bookTitle.Location = new System.Drawing.Point(139, 65);
            this.bookTitle.Name = "bookTitle";
            this.bookTitle.Size = new System.Drawing.Size(240, 21);
            this.bookTitle.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Book Title";
            // 
            // btnViewRecord
            // 
            this.btnViewRecord.Location = new System.Drawing.Point(305, 23);
            this.btnViewRecord.Name = "btnViewRecord";
            this.btnViewRecord.Size = new System.Drawing.Size(121, 29);
            this.btnViewRecord.TabIndex = 4;
            this.btnViewRecord.Text = "View Records";
            this.btnViewRecord.UseVisualStyleBackColor = true;
            this.btnViewRecord.Click += new System.EventHandler(this.btnViewRecord_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subject";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // sub
            // 
            this.sub.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblsubjectBindingSource2, "subName", true));
            this.sub.DataSource = this.tblsubjectBindingSource2;
            this.sub.DisplayMember = "subName";
            this.sub.FormattingEnabled = true;
            this.sub.Location = new System.Drawing.Point(139, 134);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(191, 23);
            this.sub.TabIndex = 2;
            this.sub.ValueMember = "subName";
            this.sub.SelectedIndexChanged += new System.EventHandler(this.sub_SelectedIndexChanged);
            // 
            // tblsubjectBindingSource1
            // 
            this.tblsubjectBindingSource1.DataMember = "tbl_subject";
            this.tblsubjectBindingSource1.DataSource = this.db_hamroschoolDataSet25;
            // 
            // db_hamroschoolDataSet25
            // 
            this.db_hamroschoolDataSet25.DataSetName = "db_hamroschoolDataSet25";
            this.db_hamroschoolDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AccNo
            // 
            this.AccNo.Location = new System.Drawing.Point(139, 28);
            this.AccNo.Name = "AccNo";
            this.AccNo.Size = new System.Drawing.Size(121, 21);
            this.AccNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accession No";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(502, 31);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(85, 37);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(502, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 37);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(502, 165);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 37);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(502, 233);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 37);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbl_deptTableAdapter
            // 
            this.tbl_deptTableAdapter.ClearBeforeFill = true;
            // 
            // db_hamroschoolDataSet24
            // 
            this.db_hamroschoolDataSet24.DataSetName = "db_hamroschoolDataSet24";
            this.db_hamroschoolDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblsubjectBindingSource
            // 
            this.tblsubjectBindingSource.DataMember = "tbl_subject";
            this.tblsubjectBindingSource.DataSource = this.db_hamroschoolDataSet24;
            // 
            // tbl_subjectTableAdapter
            // 
            this.tbl_subjectTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_subjectTableAdapter1
            // 
            this.tbl_subjectTableAdapter1.ClearBeforeFill = true;
            // 
            // db_hamroschoolDataSet51
            // 
            this.db_hamroschoolDataSet51.DataSetName = "db_hamroschoolDataSet51";
            this.db_hamroschoolDataSet51.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblsubjectBindingSource2
            // 
            this.tblsubjectBindingSource2.DataMember = "tbl_subject";
            this.tblsubjectBindingSource2.DataSource = this.db_hamroschoolDataSet51;
            // 
            // tbl_subjectTableAdapter2
            // 
            this.tbl_subjectTableAdapter2.ClearBeforeFill = true;
            // 
            // frmBookEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 503);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBookEntry";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                              Boo" +
    "k Enrty";
            this.Load += new System.EventHandler(this.frmBookEntry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbldeptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsubjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsubjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsubjectBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnViewRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private db_hamroschoolDataSet23 db_hamroschoolDataSet23;
        private System.Windows.Forms.BindingSource tbldeptBindingSource;
        private db_hamroschoolDataSet23TableAdapters.tbl_deptTableAdapter tbl_deptTableAdapter;
        private db_hamroschoolDataSet24 db_hamroschoolDataSet24;
        private System.Windows.Forms.BindingSource tblsubjectBindingSource;
        private db_hamroschoolDataSet24TableAdapters.tbl_subjectTableAdapter tbl_subjectTableAdapter;
        private db_hamroschoolDataSet25 db_hamroschoolDataSet25;
        private System.Windows.Forms.BindingSource tblsubjectBindingSource1;
        private db_hamroschoolDataSet25TableAdapters.tbl_subjectTableAdapter tbl_subjectTableAdapter1;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.RichTextBox reference;
        public System.Windows.Forms.TextBox volume;
        public System.Windows.Forms.TextBox price;
        public System.Windows.Forms.TextBox pubYear;
        public System.Windows.Forms.TextBox publisher;
        public System.Windows.Forms.TextBox isbn;
        public System.Windows.Forms.ComboBox dept;
        public System.Windows.Forms.TextBox edition;
        public System.Windows.Forms.TextBox bookTitle;
        public System.Windows.Forms.ComboBox sub;
        public System.Windows.Forms.TextBox AccNo;
        public System.Windows.Forms.TextBox author;
        private db_hamroschoolDataSet51 db_hamroschoolDataSet51;
        private System.Windows.Forms.BindingSource tblsubjectBindingSource2;
        private db_hamroschoolDataSet51TableAdapters.tbl_subjectTableAdapter tbl_subjectTableAdapter2;
    }
}