namespace HamroSchool
{
    partial class frmFeeRecords
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
            this.feeRecorddataGridView = new System.Windows.Forms.DataGridView();
            this.stdIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payModeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preDeuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentDeuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblfeepaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_hamroschoolDataSet44 = new HamroSchool.db_hamroschoolDataSet44();
            this.tbl_feepaymentTableAdapter = new HamroSchool.db_hamroschoolDataSet44TableAdapters.tbl_feepaymentTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.tblfeepaymentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.db_hamroschoolDataSet46 = new HamroSchool.db_hamroschoolDataSet46();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.db_hamroschoolDataSet45 = new HamroSchool.db_hamroschoolDataSet45();
            this.tblfeepaymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_feepaymentTableAdapter1 = new HamroSchool.db_hamroschoolDataSet45TableAdapters.tbl_feepaymentTableAdapter();
            this.tbl_feepaymentTableAdapter2 = new HamroSchool.db_hamroschoolDataSet46TableAdapters.tbl_feepaymentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.feeRecorddataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfeepaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet44)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblfeepaymentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet46)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfeepaymentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // feeRecorddataGridView
            // 
            this.feeRecorddataGridView.AutoGenerateColumns = false;
            this.feeRecorddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feeRecorddataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdIDDataGridViewTextBoxColumn,
            this.stdNameDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.sessionDataGridViewTextBoxColumn,
            this.feeNameDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.feeAmountDataGridViewTextBoxColumn,
            this.fineDataGridViewTextBoxColumn,
            this.payModeDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.totalPaidDataGridViewTextBoxColumn,
            this.payDateDataGridViewTextBoxColumn,
            this.preDeuDataGridViewTextBoxColumn,
            this.currentDeuDataGridViewTextBoxColumn});
            this.feeRecorddataGridView.DataSource = this.tblfeepaymentBindingSource;
            this.feeRecorddataGridView.Location = new System.Drawing.Point(6, 151);
            this.feeRecorddataGridView.Name = "feeRecorddataGridView";
            this.feeRecorddataGridView.Size = new System.Drawing.Size(1130, 325);
            this.feeRecorddataGridView.TabIndex = 0;
            this.feeRecorddataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.feeRecorddataGridView_CellDoubleClick);
            // 
            // stdIDDataGridViewTextBoxColumn
            // 
            this.stdIDDataGridViewTextBoxColumn.DataPropertyName = "stdID";
            this.stdIDDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.stdIDDataGridViewTextBoxColumn.Name = "stdIDDataGridViewTextBoxColumn";
            // 
            // stdNameDataGridViewTextBoxColumn
            // 
            this.stdNameDataGridViewTextBoxColumn.DataPropertyName = "stdName";
            this.stdNameDataGridViewTextBoxColumn.HeaderText = "Student Name";
            this.stdNameDataGridViewTextBoxColumn.Name = "stdNameDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            // 
            // sessionDataGridViewTextBoxColumn
            // 
            this.sessionDataGridViewTextBoxColumn.DataPropertyName = "session";
            this.sessionDataGridViewTextBoxColumn.HeaderText = "Session";
            this.sessionDataGridViewTextBoxColumn.Name = "sessionDataGridViewTextBoxColumn";
            // 
            // feeNameDataGridViewTextBoxColumn
            // 
            this.feeNameDataGridViewTextBoxColumn.DataPropertyName = "feeName";
            this.feeNameDataGridViewTextBoxColumn.HeaderText = "Fee Cateogory";
            this.feeNameDataGridViewTextBoxColumn.Name = "feeNameDataGridViewTextBoxColumn";
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // feeAmountDataGridViewTextBoxColumn
            // 
            this.feeAmountDataGridViewTextBoxColumn.DataPropertyName = "feeAmount";
            this.feeAmountDataGridViewTextBoxColumn.HeaderText = "Fee Amount";
            this.feeAmountDataGridViewTextBoxColumn.Name = "feeAmountDataGridViewTextBoxColumn";
            // 
            // fineDataGridViewTextBoxColumn
            // 
            this.fineDataGridViewTextBoxColumn.DataPropertyName = "fine";
            this.fineDataGridViewTextBoxColumn.HeaderText = "Fine";
            this.fineDataGridViewTextBoxColumn.Name = "fineDataGridViewTextBoxColumn";
            // 
            // payModeDataGridViewTextBoxColumn
            // 
            this.payModeDataGridViewTextBoxColumn.DataPropertyName = "payMode";
            this.payModeDataGridViewTextBoxColumn.HeaderText = "Payment Mode";
            this.payModeDataGridViewTextBoxColumn.Name = "payModeDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // totalPaidDataGridViewTextBoxColumn
            // 
            this.totalPaidDataGridViewTextBoxColumn.DataPropertyName = "totalPaid";
            this.totalPaidDataGridViewTextBoxColumn.HeaderText = "Total Paid";
            this.totalPaidDataGridViewTextBoxColumn.Name = "totalPaidDataGridViewTextBoxColumn";
            // 
            // payDateDataGridViewTextBoxColumn
            // 
            this.payDateDataGridViewTextBoxColumn.DataPropertyName = "payDate";
            this.payDateDataGridViewTextBoxColumn.HeaderText = "Payment Date";
            this.payDateDataGridViewTextBoxColumn.Name = "payDateDataGridViewTextBoxColumn";
            // 
            // preDeuDataGridViewTextBoxColumn
            // 
            this.preDeuDataGridViewTextBoxColumn.DataPropertyName = "preDeu";
            this.preDeuDataGridViewTextBoxColumn.HeaderText = "Previous Deu";
            this.preDeuDataGridViewTextBoxColumn.Name = "preDeuDataGridViewTextBoxColumn";
            // 
            // currentDeuDataGridViewTextBoxColumn
            // 
            this.currentDeuDataGridViewTextBoxColumn.DataPropertyName = "currentDeu";
            this.currentDeuDataGridViewTextBoxColumn.HeaderText = "Current Deu";
            this.currentDeuDataGridViewTextBoxColumn.Name = "currentDeuDataGridViewTextBoxColumn";
            // 
            // tblfeepaymentBindingSource
            // 
            this.tblfeepaymentBindingSource.DataMember = "tbl_feepayment";
            this.tblfeepaymentBindingSource.DataSource = this.db_hamroschoolDataSet44;
            // 
            // db_hamroschoolDataSet44
            // 
            this.db_hamroschoolDataSet44.DataSetName = "db_hamroschoolDataSet44";
            this.db_hamroschoolDataSet44.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_feepaymentTableAdapter
            // 
            this.tbl_feepaymentTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Location = new System.Drawing.Point(21, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "By Student ID";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(33, 47);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(160, 20);
            this.ID.TabIndex = 0;
            this.ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbName);
            this.groupBox2.Location = new System.Drawing.Point(359, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "By Student Name";
            // 
            // cmbName
            // 
            this.cmbName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblfeepaymentBindingSource2, "stdName", true));
            this.cmbName.DataSource = this.tblfeepaymentBindingSource2;
            this.cmbName.DisplayMember = "stdName";
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(39, 46);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(160, 21);
            this.cmbName.TabIndex = 0;
            this.cmbName.ValueMember = "stdName";
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
            // 
            // tblfeepaymentBindingSource2
            // 
            this.tblfeepaymentBindingSource2.DataMember = "tbl_feepayment";
            this.tblfeepaymentBindingSource2.DataSource = this.db_hamroschoolDataSet46;
            // 
            // db_hamroschoolDataSet46
            // 
            this.db_hamroschoolDataSet46.DataSetName = "db_hamroschoolDataSet46";
            this.db_hamroschoolDataSet46.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Export Excel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(654, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 100);
            this.panel1.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(236, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // db_hamroschoolDataSet45
            // 
            this.db_hamroschoolDataSet45.DataSetName = "db_hamroschoolDataSet45";
            this.db_hamroschoolDataSet45.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblfeepaymentBindingSource1
            // 
            this.tblfeepaymentBindingSource1.DataMember = "tbl_feepayment";
            this.tblfeepaymentBindingSource1.DataSource = this.db_hamroschoolDataSet45;
            // 
            // tbl_feepaymentTableAdapter1
            // 
            this.tbl_feepaymentTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_feepaymentTableAdapter2
            // 
            this.tbl_feepaymentTableAdapter2.ClearBeforeFill = true;
            // 
            // frmFeeRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.feeRecorddataGridView);
            this.Name = "frmFeeRecords";
            this.ShowIcon = false;
            this.Text = "Fee Records";
            this.Load += new System.EventHandler(this.frmFeeRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.feeRecorddataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfeepaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet44)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblfeepaymentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet46)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfeepaymentBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView feeRecorddataGridView;
        private db_hamroschoolDataSet44 db_hamroschoolDataSet44;
        private System.Windows.Forms.BindingSource tblfeepaymentBindingSource;
        private db_hamroschoolDataSet44TableAdapters.tbl_feepaymentTableAdapter tbl_feepaymentTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payModeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preDeuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentDeuDataGridViewTextBoxColumn;
        private db_hamroschoolDataSet45 db_hamroschoolDataSet45;
        private System.Windows.Forms.BindingSource tblfeepaymentBindingSource1;
        private db_hamroschoolDataSet45TableAdapters.tbl_feepaymentTableAdapter tbl_feepaymentTableAdapter1;
        private db_hamroschoolDataSet46 db_hamroschoolDataSet46;
        private System.Windows.Forms.BindingSource tblfeepaymentBindingSource2;
        private db_hamroschoolDataSet46TableAdapters.tbl_feepaymentTableAdapter tbl_feepaymentTableAdapter2;
        private System.Windows.Forms.TextBox ID;
    }
}