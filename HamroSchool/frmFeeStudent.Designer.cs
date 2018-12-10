namespace HamroSchool
{
    partial class frmFeeStudent
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.tblstudentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_hamroschoolDataSet48 = new HamroSchool.db_hamroschoolDataSet48();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblstudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_hamroschoolDataSet47 = new HamroSchool.db_hamroschoolDataSet47();
            this.tbl_studentTableAdapter = new HamroSchool.db_hamroschoolDataSet47TableAdapters.tbl_studentTableAdapter();
            this.tbl_studentTableAdapter1 = new HamroSchool.db_hamroschoolDataSet48TableAdapters.tbl_studentTableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet48)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet47)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbName);
            this.groupBox2.Location = new System.Drawing.Point(342, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "By Student Name";
            // 
            // cmbName
            // 
            this.cmbName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblstudentBindingSource1, "Sname", true));
            this.cmbName.DataSource = this.tblstudentBindingSource1;
            this.cmbName.DisplayMember = "Sname";
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(39, 46);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(160, 21);
            this.cmbName.TabIndex = 0;
            this.cmbName.ValueMember = "Sname";
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
            // 
            // tblstudentBindingSource1
            // 
            this.tblstudentBindingSource1.DataMember = "tbl_student";
            this.tblstudentBindingSource1.DataSource = this.db_hamroschoolDataSet48;
            // 
            // db_hamroschoolDataSet48
            // 
            this.db_hamroschoolDataSet48.DataSetName = "db_hamroschoolDataSet48";
            this.db_hamroschoolDataSet48.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Location = new System.Drawing.Point(29, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "By Student ID";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(33, 47);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(160, 20);
            this.ID.TabIndex = 0;
            this.ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.rollDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.paddDataGridViewTextBoxColumn,
            this.taddDataGridViewTextBoxColumn,
            this.addateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblstudentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(773, 329);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "SID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "Sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Student Name";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // rollDataGridViewTextBoxColumn
            // 
            this.rollDataGridViewTextBoxColumn.DataPropertyName = "roll";
            this.rollDataGridViewTextBoxColumn.HeaderText = "Roll no";
            this.rollDataGridViewTextBoxColumn.Name = "rollDataGridViewTextBoxColumn";
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // paddDataGridViewTextBoxColumn
            // 
            this.paddDataGridViewTextBoxColumn.DataPropertyName = "Padd";
            this.paddDataGridViewTextBoxColumn.HeaderText = "Permanent Address";
            this.paddDataGridViewTextBoxColumn.Name = "paddDataGridViewTextBoxColumn";
            // 
            // taddDataGridViewTextBoxColumn
            // 
            this.taddDataGridViewTextBoxColumn.DataPropertyName = "Tadd";
            this.taddDataGridViewTextBoxColumn.HeaderText = "Temporary Address";
            this.taddDataGridViewTextBoxColumn.Name = "taddDataGridViewTextBoxColumn";
            // 
            // addateDataGridViewTextBoxColumn
            // 
            this.addateDataGridViewTextBoxColumn.DataPropertyName = "addate";
            this.addateDataGridViewTextBoxColumn.HeaderText = "Admission Date";
            this.addateDataGridViewTextBoxColumn.Name = "addateDataGridViewTextBoxColumn";
            // 
            // tblstudentBindingSource
            // 
            this.tblstudentBindingSource.DataMember = "tbl_student";
            this.tblstudentBindingSource.DataSource = this.db_hamroschoolDataSet47;
            // 
            // db_hamroschoolDataSet47
            // 
            this.db_hamroschoolDataSet47.DataSetName = "db_hamroschoolDataSet47";
            this.db_hamroschoolDataSet47.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_studentTableAdapter
            // 
            this.tbl_studentTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_studentTableAdapter1
            // 
            this.tbl_studentTableAdapter1.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(698, 29);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 31);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmFeeStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 504);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmFeeStudent";
            this.ShowIcon = false;
            this.Text = "                                                                                 " +
    "                         Student Details";
            this.Load += new System.EventHandler(this.frmFeeStudent_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet48)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet47)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_hamroschoolDataSet47 db_hamroschoolDataSet47;
        private System.Windows.Forms.BindingSource tblstudentBindingSource;
        private db_hamroschoolDataSet47TableAdapters.tbl_studentTableAdapter tbl_studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addateDataGridViewTextBoxColumn;
        private db_hamroschoolDataSet48 db_hamroschoolDataSet48;
        private System.Windows.Forms.BindingSource tblstudentBindingSource1;
        private db_hamroschoolDataSet48TableAdapters.tbl_studentTableAdapter tbl_studentTableAdapter1;
        private System.Windows.Forms.Button btnClose;
    }
}