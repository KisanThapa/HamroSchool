namespace HamroSchool
{
    partial class frmFeeCategory
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
            this.feeName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.feedataGridView = new System.Windows.Forms.DataGridView();
            this.feeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblfeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_hamroschoolDataSet35 = new HamroSchool.db_hamroschoolDataSet35();
            this.tbl_feeTableAdapter = new HamroSchool.db_hamroschoolDataSet35TableAdapters.tbl_feeTableAdapter();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet35)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.feeName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fee Name";
            // 
            // feeName
            // 
            this.feeName.Location = new System.Drawing.Point(63, 54);
            this.feeName.Name = "feeName";
            this.feeName.Size = new System.Drawing.Size(274, 21);
            this.feeName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Location = new System.Drawing.Point(49, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 73);
            this.panel1.TabIndex = 5;
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
            // feedataGridView
            // 
            this.feedataGridView.AllowUserToOrderColumns = true;
            this.feedataGridView.AutoGenerateColumns = false;
            this.feedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feeNameDataGridViewTextBoxColumn});
            this.feedataGridView.DataSource = this.tblfeeBindingSource;
            this.feedataGridView.Location = new System.Drawing.Point(64, 258);
            this.feedataGridView.Name = "feedataGridView";
            this.feedataGridView.Size = new System.Drawing.Size(343, 219);
            this.feedataGridView.TabIndex = 6;
            this.feedataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.feedataGridView_CellDoubleClick);
            this.feedataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.feedataGridView_DataBindingComplete);
            // 
            // feeNameDataGridViewTextBoxColumn
            // 
            this.feeNameDataGridViewTextBoxColumn.DataPropertyName = "feeName";
            this.feeNameDataGridViewTextBoxColumn.HeaderText = "Fee Name";
            this.feeNameDataGridViewTextBoxColumn.Name = "feeNameDataGridViewTextBoxColumn";
            this.feeNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // tblfeeBindingSource
            // 
            this.tblfeeBindingSource.DataMember = "tbl_fee";
            this.tblfeeBindingSource.DataSource = this.db_hamroschoolDataSet35;
            // 
            // db_hamroschoolDataSet35
            // 
            this.db_hamroschoolDataSet35.DataSetName = "db_hamroschoolDataSet35";
            this.db_hamroschoolDataSet35.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_feeTableAdapter
            // 
            this.tbl_feeTableAdapter.ClearBeforeFill = true;
            // 
            // frmFeeCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 498);
            this.Controls.Add(this.feedataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmFeeCategory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fee Category";
            this.Load += new System.EventHandler(this.frmFeeCategory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblfeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet35)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox feeName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView feedataGridView;
        private db_hamroschoolDataSet35 db_hamroschoolDataSet35;
        private System.Windows.Forms.BindingSource tblfeeBindingSource;
        private db_hamroschoolDataSet35TableAdapters.tbl_feeTableAdapter tbl_feeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeNameDataGridViewTextBoxColumn;
    }
}