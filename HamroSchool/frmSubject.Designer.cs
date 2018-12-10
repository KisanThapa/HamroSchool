namespace HamroSchool
{
    partial class frmSubject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.subCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.subdataGridView = new System.Windows.Forms.DataGridView();
            this.subCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblsubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_hamroschoolDataSet50 = new HamroSchool.db_hamroschoolDataSet50();
            this.tbl_subjectTableAdapter = new HamroSchool.db_hamroschoolDataSet50TableAdapters.tbl_subjectTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsubjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet50)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Location = new System.Drawing.Point(48, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 73);
            this.panel1.TabIndex = 8;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.subName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 143);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject Entry";
            // 
            // subCode
            // 
            this.subCode.Location = new System.Drawing.Point(141, 39);
            this.subCode.Name = "subCode";
            this.subCode.Size = new System.Drawing.Size(229, 21);
            this.subCode.TabIndex = 9;
            this.subCode.TextChanged += new System.EventHandler(this.subCode_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Subject Code";
            // 
            // subName
            // 
            this.subName.Location = new System.Drawing.Point(141, 87);
            this.subName.Name = "subName";
            this.subName.Size = new System.Drawing.Size(229, 21);
            this.subName.TabIndex = 2;
            this.subName.TextChanged += new System.EventHandler(this.subCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Name";
            // 
            // subdataGridView
            // 
            this.subdataGridView.AutoGenerateColumns = false;
            this.subdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subCodeDataGridViewTextBoxColumn,
            this.subNameDataGridViewTextBoxColumn});
            this.subdataGridView.DataSource = this.tblsubjectBindingSource;
            this.subdataGridView.Location = new System.Drawing.Point(468, 22);
            this.subdataGridView.Name = "subdataGridView";
            this.subdataGridView.Size = new System.Drawing.Size(243, 236);
            this.subdataGridView.TabIndex = 9;
            this.subdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subdataGridView_CellClick);
            this.subdataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subdataGridView_CellDoubleClick);
            // 
            // subCodeDataGridViewTextBoxColumn
            // 
            this.subCodeDataGridViewTextBoxColumn.DataPropertyName = "subCode";
            this.subCodeDataGridViewTextBoxColumn.HeaderText = "Subject Code";
            this.subCodeDataGridViewTextBoxColumn.Name = "subCodeDataGridViewTextBoxColumn";
            // 
            // subNameDataGridViewTextBoxColumn
            // 
            this.subNameDataGridViewTextBoxColumn.DataPropertyName = "subName";
            this.subNameDataGridViewTextBoxColumn.HeaderText = "Subject Name";
            this.subNameDataGridViewTextBoxColumn.Name = "subNameDataGridViewTextBoxColumn";
            // 
            // tblsubjectBindingSource
            // 
            this.tblsubjectBindingSource.DataMember = "tbl_subject";
            this.tblsubjectBindingSource.DataSource = this.db_hamroschoolDataSet50;
            // 
            // db_hamroschoolDataSet50
            // 
            this.db_hamroschoolDataSet50.DataSetName = "db_hamroschoolDataSet50";
            this.db_hamroschoolDataSet50.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_subjectTableAdapter
            // 
            this.tbl_subjectTableAdapter.ClearBeforeFill = true;
            // 
            // frmSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 296);
            this.Controls.Add(this.subdataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmSubject";
            this.ShowIcon = false;
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.frmSubject_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblsubjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet50)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox subCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView subdataGridView;
        private db_hamroschoolDataSet50 db_hamroschoolDataSet50;
        private System.Windows.Forms.BindingSource tblsubjectBindingSource;
        private db_hamroschoolDataSet50TableAdapters.tbl_subjectTableAdapter tbl_subjectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subNameDataGridViewTextBoxColumn;
    }
}