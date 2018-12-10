namespace HamroSchool
{
    partial class frmClassFeeEntry
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
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbFName = new System.Windows.Forms.ComboBox();
            this.tblfeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_hamroschoolDataSet37 = new HamroSchool.db_hamroschoolDataSet37();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFee = new System.Windows.Forms.TextBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.tblclassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_hamroschoolDataSet36 = new HamroSchool.db_hamroschoolDataSet36();
            this.tblclass1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_hamroschoolDataSet40 = new HamroSchool.db_hamroschoolDataSet40();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.ClassFeedataGridView = new System.Windows.Forms.DataGridView();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblclassFeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_hamroschoolDataSet38 = new HamroSchool.db_hamroschoolDataSet38();
            this.tbl_classTableAdapter = new HamroSchool.db_hamroschoolDataSet36TableAdapters.tbl_classTableAdapter();
            this.tbl_feeTableAdapter = new HamroSchool.db_hamroschoolDataSet37TableAdapters.tbl_feeTableAdapter();
            this.tbl_classFeeTableAdapter = new HamroSchool.db_hamroschoolDataSet38TableAdapters.tbl_classFeeTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchMonth = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchClass = new System.Windows.Forms.ComboBox();
            this.tblclassFeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_hamroschoolDataSet41 = new HamroSchool.db_hamroschoolDataSet41();
            this.label6 = new System.Windows.Forms.Label();
            this.db_hamroschoolDataSet39 = new HamroSchool.db_hamroschoolDataSet39();
            this.tblclass1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_class1TableAdapter = new HamroSchool.db_hamroschoolDataSet39TableAdapters.tbl_class1TableAdapter();
            this.tbl_class1TableAdapter1 = new HamroSchool.db_hamroschoolDataSet40TableAdapters.tbl_class1TableAdapter();
            this.tbl_classFeeTableAdapter1 = new HamroSchool.db_hamroschoolDataSet41TableAdapters.tbl_classFeeTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblfeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclass1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet40)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassFeedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclassFeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet38)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblclassFeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclass1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMonth);
            this.groupBox1.Controls.Add(this.cmbFName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbFee);
            this.groupBox1.Controls.Add(this.cmbClass);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Fee Info";
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(130, 125);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(257, 23);
            this.cmbMonth.TabIndex = 7;
            // 
            // cmbFName
            // 
            this.cmbFName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblfeeBindingSource, "feeName", true));
            this.cmbFName.DataSource = this.tblfeeBindingSource;
            this.cmbFName.DisplayMember = "feeName";
            this.cmbFName.FormattingEnabled = true;
            this.cmbFName.Location = new System.Drawing.Point(130, 82);
            this.cmbFName.Name = "cmbFName";
            this.cmbFName.Size = new System.Drawing.Size(257, 23);
            this.cmbFName.TabIndex = 6;
            this.cmbFName.ValueMember = "feeName";
            // 
            // tblfeeBindingSource
            // 
            this.tblfeeBindingSource.DataMember = "tbl_fee";
            this.tblfeeBindingSource.DataSource = this.db_hamroschoolDataSet37;
            // 
            // db_hamroschoolDataSet37
            // 
            this.db_hamroschoolDataSet37.DataSetName = "db_hamroschoolDataSet37";
            this.db_hamroschoolDataSet37.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fee Name";
            // 
            // cmbFee
            // 
            this.cmbFee.Location = new System.Drawing.Point(130, 171);
            this.cmbFee.Name = "cmbFee";
            this.cmbFee.Size = new System.Drawing.Size(257, 21);
            this.cmbFee.TabIndex = 2;
            // 
            // cmbClass
            // 
            this.cmbClass.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblclassBindingSource, "class", true));
            this.cmbClass.DataSource = this.tblclass1BindingSource1;
            this.cmbClass.DisplayMember = "class";
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(130, 41);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(257, 23);
            this.cmbClass.TabIndex = 1;
            this.cmbClass.ValueMember = "class";
            // 
            // tblclassBindingSource
            // 
            this.tblclassBindingSource.DataMember = "tbl_class";
            this.tblclassBindingSource.DataSource = this.db_hamroschoolDataSet36;
            // 
            // db_hamroschoolDataSet36
            // 
            this.db_hamroschoolDataSet36.DataSetName = "db_hamroschoolDataSet36";
            this.db_hamroschoolDataSet36.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblclass1BindingSource1
            // 
            this.tblclass1BindingSource1.DataMember = "tbl_class1";
            this.tblclass1BindingSource1.DataSource = this.db_hamroschoolDataSet40;
            // 
            // db_hamroschoolDataSet40
            // 
            this.db_hamroschoolDataSet40.DataSetName = "db_hamroschoolDataSet40";
            this.db_hamroschoolDataSet40.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Location = new System.Drawing.Point(62, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 73);
            this.panel1.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(281, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(191, 21);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 32);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(103, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(14, 21);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 32);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // ClassFeedataGridView
            // 
            this.ClassFeedataGridView.AllowUserToOrderColumns = true;
            this.ClassFeedataGridView.AutoGenerateColumns = false;
            this.ClassFeedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassFeedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.classDataGridViewTextBoxColumn,
            this.feeCategoryDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.feeDataGridViewTextBoxColumn});
            this.ClassFeedataGridView.DataSource = this.tblclassFeeBindingSource;
            this.ClassFeedataGridView.Location = new System.Drawing.Point(483, 120);
            this.ClassFeedataGridView.Name = "ClassFeedataGridView";
            this.ClassFeedataGridView.Size = new System.Drawing.Size(438, 334);
            this.ClassFeedataGridView.TabIndex = 7;
            this.ClassFeedataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassFeedataGridView_CellDoubleClick);
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // feeCategoryDataGridViewTextBoxColumn
            // 
            this.feeCategoryDataGridViewTextBoxColumn.DataPropertyName = "feeCategory";
            this.feeCategoryDataGridViewTextBoxColumn.HeaderText = "Fee Category";
            this.feeCategoryDataGridViewTextBoxColumn.Name = "feeCategoryDataGridViewTextBoxColumn";
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            // 
            // feeDataGridViewTextBoxColumn
            // 
            this.feeDataGridViewTextBoxColumn.DataPropertyName = "fee";
            this.feeDataGridViewTextBoxColumn.HeaderText = "Fee";
            this.feeDataGridViewTextBoxColumn.Name = "feeDataGridViewTextBoxColumn";
            // 
            // tblclassFeeBindingSource
            // 
            this.tblclassFeeBindingSource.DataMember = "tbl_classFee";
            this.tblclassFeeBindingSource.DataSource = this.db_hamroschoolDataSet38;
            // 
            // db_hamroschoolDataSet38
            // 
            this.db_hamroschoolDataSet38.DataSetName = "db_hamroschoolDataSet38";
            this.db_hamroschoolDataSet38.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_classTableAdapter
            // 
            this.tbl_classTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_feeTableAdapter
            // 
            this.tbl_feeTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_classFeeTableAdapter
            // 
            this.tbl_classFeeTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchMonth);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.searchClass);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(483, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 81);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search by Class and Month";
            // 
            // searchMonth
            // 
            this.searchMonth.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblfeeBindingSource, "feeName", true));
            this.searchMonth.FormattingEnabled = true;
            this.searchMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.searchMonth.Location = new System.Drawing.Point(261, 48);
            this.searchMonth.Name = "searchMonth";
            this.searchMonth.Size = new System.Drawing.Size(126, 23);
            this.searchMonth.TabIndex = 10;
            this.searchMonth.SelectedIndexChanged += new System.EventHandler(this.searchMonth_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Month";
            // 
            // searchClass
            // 
            this.searchClass.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblclassBindingSource, "class", true));
            this.searchClass.DataSource = this.tblclassFeeBindingSource1;
            this.searchClass.DisplayMember = "class";
            this.searchClass.FormattingEnabled = true;
            this.searchClass.Location = new System.Drawing.Point(30, 48);
            this.searchClass.Name = "searchClass";
            this.searchClass.Size = new System.Drawing.Size(134, 23);
            this.searchClass.TabIndex = 8;
            this.searchClass.ValueMember = "class";
            this.searchClass.SelectedIndexChanged += new System.EventHandler(this.searchClass_SelectedIndexChanged);
            // 
            // tblclassFeeBindingSource1
            // 
            this.tblclassFeeBindingSource1.DataMember = "tbl_classFee";
            this.tblclassFeeBindingSource1.DataSource = this.db_hamroschoolDataSet41;
            // 
            // db_hamroschoolDataSet41
            // 
            this.db_hamroschoolDataSet41.DataSetName = "db_hamroschoolDataSet41";
            this.db_hamroschoolDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Class";
            // 
            // db_hamroschoolDataSet39
            // 
            this.db_hamroschoolDataSet39.DataSetName = "db_hamroschoolDataSet39";
            this.db_hamroschoolDataSet39.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblclass1BindingSource
            // 
            this.tblclass1BindingSource.DataMember = "tbl_class1";
            this.tblclass1BindingSource.DataSource = this.db_hamroschoolDataSet39;
            // 
            // tbl_class1TableAdapter
            // 
            this.tbl_class1TableAdapter.ClearBeforeFill = true;
            // 
            // tbl_class1TableAdapter1
            // 
            this.tbl_class1TableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_classFeeTableAdapter1
            // 
            this.tbl_classFeeTableAdapter1.ClearBeforeFill = true;
            // 
            // frmClassFeeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 466);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ClassFeedataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmClassFeeEntry";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClassEntry";
            this.Load += new System.EventHandler(this.frmClassFeeEntry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblfeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclass1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet40)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClassFeedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclassFeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet38)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblclassFeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclass1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cmbFee;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView ClassFeedataGridView;
        private db_hamroschoolDataSet36 db_hamroschoolDataSet36;
        private System.Windows.Forms.BindingSource tblclassBindingSource;
        private db_hamroschoolDataSet36TableAdapters.tbl_classTableAdapter tbl_classTableAdapter;
        private db_hamroschoolDataSet37 db_hamroschoolDataSet37;
        private System.Windows.Forms.BindingSource tblfeeBindingSource;
        private db_hamroschoolDataSet37TableAdapters.tbl_feeTableAdapter tbl_feeTableAdapter;
        private db_hamroschoolDataSet38 db_hamroschoolDataSet38;
        private System.Windows.Forms.BindingSource tblclassFeeBindingSource;
        private db_hamroschoolDataSet38TableAdapters.tbl_classFeeTableAdapter tbl_classFeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox searchMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox searchClass;
        private System.Windows.Forms.Label label6;
        private db_hamroschoolDataSet39 db_hamroschoolDataSet39;
        private System.Windows.Forms.BindingSource tblclass1BindingSource;
        private db_hamroschoolDataSet39TableAdapters.tbl_class1TableAdapter tbl_class1TableAdapter;
        private db_hamroschoolDataSet40 db_hamroschoolDataSet40;
        private System.Windows.Forms.BindingSource tblclass1BindingSource1;
        private db_hamroschoolDataSet40TableAdapters.tbl_class1TableAdapter tbl_class1TableAdapter1;
        private db_hamroschoolDataSet41 db_hamroschoolDataSet41;
        private System.Windows.Forms.BindingSource tblclassFeeBindingSource1;
        private db_hamroschoolDataSet41TableAdapters.tbl_classFeeTableAdapter tbl_classFeeTableAdapter1;
    }
}