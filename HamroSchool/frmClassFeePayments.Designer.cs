namespace HamroSchool
{
    partial class frmClassFeePayments
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
            this.btnSt = new System.Windows.Forms.Button();
            this.Session = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Section = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stdID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.FeeName = new System.Windows.Forms.ComboBox();
            this.FeeAmnt = new System.Windows.Forms.TextBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CurrentDeu = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PreDeu = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PayDate = new System.Windows.Forms.DateTimePicker();
            this.TotalPaid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PayDetails = new System.Windows.Forms.ComboBox();
            this.GrandTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Fine = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnPaid = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.feedataGridView = new System.Windows.Forms.DataGridView();
            this.feeCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblclassFeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_hamroschoolDataSet43 = new HamroSchool.db_hamroschoolDataSet43();
            this.tbl_classFeeTableAdapter = new HamroSchool.db_hamroschoolDataSet43TableAdapters.tbl_classFeeTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclassFeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet43)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSt);
            this.groupBox1.Controls.Add(this.Session);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Section);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Class);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.StName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.stdID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Info";
            // 
            // btnSt
            // 
            this.btnSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSt.Location = new System.Drawing.Point(230, 23);
            this.btnSt.Name = "btnSt";
            this.btnSt.Size = new System.Drawing.Size(57, 23);
            this.btnSt.TabIndex = 10;
            this.btnSt.Text = "...";
            this.btnSt.UseVisualStyleBackColor = true;
            this.btnSt.Click += new System.EventHandler(this.btnSt_Click);
            // 
            // Session
            // 
            this.Session.Location = new System.Drawing.Point(108, 154);
            this.Session.Name = "Session";
            this.Session.Size = new System.Drawing.Size(90, 20);
            this.Session.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Session";
            // 
            // Section
            // 
            this.Section.Location = new System.Drawing.Point(108, 122);
            this.Section.Name = "Section";
            this.Section.Size = new System.Drawing.Size(90, 20);
            this.Section.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Section";
            // 
            // Class
            // 
            this.Class.Location = new System.Drawing.Point(108, 90);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(90, 20);
            this.Class.TabIndex = 5;
            this.Class.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Class";
            // 
            // StName
            // 
            this.StName.Location = new System.Drawing.Point(108, 58);
            this.StName.Name = "StName";
            this.StName.Size = new System.Drawing.Size(188, 20);
            this.StName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Name";
            // 
            // stdID
            // 
            this.stdID.Location = new System.Drawing.Point(108, 26);
            this.stdID.Name = "stdID";
            this.stdID.Size = new System.Drawing.Size(107, 20);
            this.stdID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCalculate);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.FeeName);
            this.groupBox2.Controls.Add(this.FeeAmnt);
            this.groupBox2.Controls.Add(this.Year);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Month);
            this.groupBox2.Location = new System.Drawing.Point(12, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fee Info";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(253, 61);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(84, 21);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Fee Name";
            // 
            // FeeName
            // 
            this.FeeName.FormattingEnabled = true;
            this.FeeName.Location = new System.Drawing.Point(108, 19);
            this.FeeName.Name = "FeeName";
            this.FeeName.Size = new System.Drawing.Size(121, 21);
            this.FeeName.TabIndex = 9;
            // 
            // FeeAmnt
            // 
            this.FeeAmnt.Location = new System.Drawing.Point(108, 125);
            this.FeeAmnt.Name = "FeeAmnt";
            this.FeeAmnt.Size = new System.Drawing.Size(121, 20);
            this.FeeAmnt.TabIndex = 8;
            // 
            // Year
            // 
            this.Year.FormattingEnabled = true;
            this.Year.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016"});
            this.Year.Location = new System.Drawing.Point(108, 89);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(121, 21);
            this.Year.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Fee Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Month";
            // 
            // Month
            // 
            this.Month.FormattingEnabled = true;
            this.Month.Items.AddRange(new object[] {
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
            this.Month.Location = new System.Drawing.Point(108, 53);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(121, 21);
            this.Month.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CurrentDeu);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.PreDeu);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.PayDate);
            this.groupBox3.Controls.Add(this.TotalPaid);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.PayDetails);
            this.groupBox3.Controls.Add(this.GrandTotal);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Fine);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 374);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(724, 160);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment Details";
            // 
            // CurrentDeu
            // 
            this.CurrentDeu.Location = new System.Drawing.Point(513, 108);
            this.CurrentDeu.Name = "CurrentDeu";
            this.CurrentDeu.Size = new System.Drawing.Size(179, 20);
            this.CurrentDeu.TabIndex = 23;
            this.CurrentDeu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(397, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Current Deu";
            // 
            // PreDeu
            // 
            this.PreDeu.Location = new System.Drawing.Point(513, 69);
            this.PreDeu.Name = "PreDeu";
            this.PreDeu.Size = new System.Drawing.Size(179, 20);
            this.PreDeu.TabIndex = 21;
            this.PreDeu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PreDeu.TextChanged += new System.EventHandler(this.PreDeu_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(397, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Prevision Deu";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(397, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Payment Date";
            // 
            // PayDate
            // 
            this.PayDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PayDate.Location = new System.Drawing.Point(513, 30);
            this.PayDate.Name = "PayDate";
            this.PayDate.Size = new System.Drawing.Size(99, 20);
            this.PayDate.TabIndex = 18;
            // 
            // TotalPaid
            // 
            this.TotalPaid.Location = new System.Drawing.Point(108, 130);
            this.TotalPaid.Name = "TotalPaid";
            this.TotalPaid.Size = new System.Drawing.Size(179, 20);
            this.TotalPaid.TabIndex = 17;
            this.TotalPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalPaid.TextChanged += new System.EventHandler(this.TotalPaid_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Total Paid";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Payment Mode";
            // 
            // PayDetails
            // 
            this.PayDetails.FormattingEnabled = true;
            this.PayDetails.Items.AddRange(new object[] {
            "By Cash",
            "By Check",
            "By Credit Card"});
            this.PayDetails.Location = new System.Drawing.Point(108, 54);
            this.PayDetails.Name = "PayDetails";
            this.PayDetails.Size = new System.Drawing.Size(179, 21);
            this.PayDetails.TabIndex = 14;
            // 
            // GrandTotal
            // 
            this.GrandTotal.Location = new System.Drawing.Point(108, 91);
            this.GrandTotal.Name = "GrandTotal";
            this.GrandTotal.Size = new System.Drawing.Size(179, 20);
            this.GrandTotal.TabIndex = 13;
            this.GrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Grand Total";
            // 
            // Fine
            // 
            this.Fine.Location = new System.Drawing.Point(108, 19);
            this.Fine.Name = "Fine";
            this.Fine.Size = new System.Drawing.Size(179, 20);
            this.Fine.TabIndex = 11;
            this.Fine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Fine.TextChanged += new System.EventHandler(this.Fine_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Fine";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnData);
            this.panel1.Controls.Add(this.btnPaid);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Location = new System.Drawing.Point(503, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 174);
            this.panel1.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(22, 105);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(22, 134);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(22, 74);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(75, 23);
            this.btnData.TabIndex = 2;
            this.btnData.Text = "Get Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnPaid
            // 
            this.btnPaid.Location = new System.Drawing.Point(22, 44);
            this.btnPaid.Name = "btnPaid";
            this.btnPaid.Size = new System.Drawing.Size(75, 23);
            this.btnPaid.TabIndex = 1;
            this.btnPaid.Text = "Paid";
            this.btnPaid.UseVisualStyleBackColor = true;
            this.btnPaid.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(22, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // feedataGridView
            // 
            this.feedataGridView.AutoGenerateColumns = false;
            this.feedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.feedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feeCategoryDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.feeDataGridViewTextBoxColumn});
            this.feedataGridView.DataSource = this.tblclassFeeBindingSource;
            this.feedataGridView.Location = new System.Drawing.Point(392, 209);
            this.feedataGridView.Name = "feedataGridView";
            this.feedataGridView.Size = new System.Drawing.Size(344, 159);
            this.feedataGridView.TabIndex = 4;
            this.feedataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // feeCategoryDataGridViewTextBoxColumn
            // 
            this.feeCategoryDataGridViewTextBoxColumn.DataPropertyName = "feeCategory";
            this.feeCategoryDataGridViewTextBoxColumn.HeaderText = "feeCategory";
            this.feeCategoryDataGridViewTextBoxColumn.Name = "feeCategoryDataGridViewTextBoxColumn";
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "month";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            // 
            // feeDataGridViewTextBoxColumn
            // 
            this.feeDataGridViewTextBoxColumn.DataPropertyName = "fee";
            this.feeDataGridViewTextBoxColumn.HeaderText = "fee";
            this.feeDataGridViewTextBoxColumn.Name = "feeDataGridViewTextBoxColumn";
            // 
            // tblclassFeeBindingSource
            // 
            this.tblclassFeeBindingSource.DataMember = "tbl_classFee";
            this.tblclassFeeBindingSource.DataSource = this.db_hamroschoolDataSet43;
            // 
            // db_hamroschoolDataSet43
            // 
            this.db_hamroschoolDataSet43.DataSetName = "db_hamroschoolDataSet43";
            this.db_hamroschoolDataSet43.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_classFeeTableAdapter
            // 
            this.tbl_classFeeTableAdapter.ClearBeforeFill = true;
            // 
            // frmClassFeePayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 541);
            this.Controls.Add(this.feedataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmClassFeePayments";
            this.ShowIcon = false;
            this.Text = "                                                                                 " +
    "        Class Fee Payments";
            this.Load += new System.EventHandler(this.frmClassFeePayments_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblclassFeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_hamroschoolDataSet43)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnPaid;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView feedataGridView;
        private db_hamroschoolDataSet43 db_hamroschoolDataSet43;
        private System.Windows.Forms.BindingSource tblclassFeeBindingSource;
        private db_hamroschoolDataSet43TableAdapters.tbl_classFeeTableAdapter tbl_classFeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox Session;
        public System.Windows.Forms.TextBox Section;
        public System.Windows.Forms.TextBox Class;
        public System.Windows.Forms.TextBox StName;
        public System.Windows.Forms.TextBox stdID;
        public System.Windows.Forms.ComboBox FeeName;
        public System.Windows.Forms.TextBox FeeAmnt;
        public System.Windows.Forms.ComboBox Year;
        public System.Windows.Forms.ComboBox Month;
        public System.Windows.Forms.TextBox CurrentDeu;
        public System.Windows.Forms.TextBox PreDeu;
        public System.Windows.Forms.DateTimePicker PayDate;
        public System.Windows.Forms.TextBox TotalPaid;
        public System.Windows.Forms.ComboBox PayDetails;
        public System.Windows.Forms.TextBox GrandTotal;
        public System.Windows.Forms.TextBox Fine;
    }
}