using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace HamroSchool
{
    public partial class frmMain : Form
    { 

        public frmMain()
        {
            InitializeComponent();

            timer1.Start();



        }

      
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            
        }

        private void gotoLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin lfrm = new frmLogin();
            lfrm.Show();
        }

        private void wordPadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Wordpad.exe");
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("TaskMgr.exe");
        }

        private void mSWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Winword.exe");
        }

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profileEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmEmpProfile obj = new frmEmpProfile();
            obj.MdiParent = this;
            obj.Show();

            
        }

        private void profileEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmStudentProfile obj = new frmStudentProfile();
            obj.MdiParent = this;
            obj.Show();
        }

        private void aboutSchoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutSchool obj = new frmAboutSchool();
            obj.MdiParent = this;
            obj.Show();
        }

        private void aboutDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutDev obj = new frmAboutDev();
            obj.MdiParent = this;
            obj.Show();
        }

        private void user_Click(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void schoolEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSchoolEntry obj = new frmSchoolEntry();
            obj.Show();
            obj.MdiParent = this;
        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClassEntry obj = new frmClassEntry();
            obj.Show();
            obj.MdiParent = this;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.time_lbl.Text = dt.ToString();
        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSection obj = new frmSection();
            obj.Show();
            obj.MdiParent = this;
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartment obj = new frmDepartment();
            obj.Show();
            obj.MdiParent = this;
        }

        private void bookEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookEntry obj = new frmBookEntry();
            obj.Show();
            obj.MdiParent = this;
        }

        private void bookDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookRecords obj = new frmBookRecords();
            obj.Show();
            obj.MdiParent = this;
        }

        private void feeCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFeeCategory obj = new frmFeeCategory();
            obj.Show();
            obj.MdiParent = this;
        }

        private void classFeeEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClassFeeEntry obj = new frmClassFeeEntry();
            obj.Show();
            obj.MdiParent = this;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void searchSudentRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClassFeePayments obj = new frmClassFeePayments();
            obj.Show();
            obj.MdiParent = this;

        }

        private void schoolorshipEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSchoolarship obj = new frmSchoolarship();
            obj.Show();
            obj.MdiParent = this;
        }

        private void subjectCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubject obj = new frmSubject();
            obj.Show();
            obj.MdiParent = this;
        }

        private void searchEmployeeRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void classFeePaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClassFeePayments obj = new frmClassFeePayments();
            obj.Show();
            obj.MdiParent = this;
        }

        private void studentsRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentDataGridView obj = new frmStudentDataGridView();
            obj.Show();
            obj.MdiParent = this;
        }

        private void employeeRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeDataGridView obj = new frmEmployeeDataGridView();
            obj.Show();
            obj.MdiParent = this;
        }

        private void bookRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookRecords obj = new frmBookRecords();
            obj.Show();
            obj.MdiParent = this;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserRegistration frm = new frmUserRegistration();
            frm.Show();
            frm.MdiParent = this;
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserRegistration frm = new frmUserRegistration();
            frm.Show();
            frm.MdiParent = this;
        }

        private void loginDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserRegistration frm = new frmUserRegistration();
            frm.Show();
            frm.MdiParent = this;
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void attendanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void userRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentProfile obj = new frmStudentProfile();
            obj.MdiParent = this;
            obj.Show();
        }

        private void employeeToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

            frmEmpProfile obj = new frmEmpProfile();
            obj.MdiParent = this;
            obj.Show();
        }

        private void feePaymentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmClassFeePayments obj = new frmClassFeePayments();
            obj.Show();
            obj.MdiParent = this;
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin lfrm = new frmLogin();
            lfrm.Show();
        }

        private void user_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin lfrm = new frmLogin();
            lfrm.Show();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
