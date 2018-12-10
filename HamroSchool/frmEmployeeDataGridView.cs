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
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace HamroSchool
{
    public partial class frmEmployeeDataGridView : Form
    {
        public frmEmployeeDataGridView()
        {
            InitializeComponent();
        }
        public void gridview()
        {
            try
            {
                SqlConnection conn1 = new SqlConnection(str);
                string sql = "Select * from tbl_employee";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                employeeDataGridView.DataSource = ds;
                employeeDataGridView.DataMember = ds.Tables[0].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           
        }
        public String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();
        private void frmEmployeeDataGridView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet12.tbl_employee' table. You can move, or remove it, as needed.
            this.tbl_employeeTableAdapter.Fill(this.db_hamroschoolDataSet12.tbl_employee);
            btnDelete.Enabled = false;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEmpProfile obj = new frmEmpProfile();
            obj.Show();
            this.Hide();
        }

        private void frmEmployeeDataGridView_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmEmpProfile obj = new frmEmpProfile();
            obj.Show();
        }

        private void btnIDSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_employee where EID = '" + txtID.Text + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            employeeDataGridView.DataSource = ds;
            employeeDataGridView.DataMember = ds.Tables[0].ToString();

        }

        private void employeeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

            try
            {

                frmEmpProfile obj = new frmEmpProfile();
                this.Hide();
                obj.Show();

                obj.EbtnUpdate.Enabled = true;
                obj.EbtnDelete.Enabled = true;
                obj.EID.Text = employeeDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                obj.EName.Text = employeeDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                obj.CitizenNo.Text = employeeDataGridView.SelectedRows[0].Cells[2].Value.ToString();

                if (employeeDataGridView.SelectedRows[0].Cells[3].Value.ToString() == "Male")
                {
                    obj.radioButton1.Checked = true;
                    obj.radioButton2.Checked = false;
                    obj.radioButton3.Checked = false;

                }

                if (employeeDataGridView.SelectedRows[0].Cells[3].Value.ToString() == "Female")
                {
                    obj.radioButton1.Checked = false;
                    obj.radioButton2.Checked = true;
                    obj.radioButton3.Checked = false;

                }

                if (employeeDataGridView.SelectedRows[0].Cells[3].Value.ToString() == "Not Specified")
                {
                    obj.radioButton1.Checked = false;
                    obj.radioButton2.Checked = false;
                    obj.radioButton3.Checked = true;

                }

                obj.MStatus.Text = employeeDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                obj.DOB.Text = employeeDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                obj.EFName.Text = employeeDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                obj.EMName.Text = employeeDataGridView.SelectedRows[0].Cells[7].Value.ToString();
                obj.EPAdd.Text = employeeDataGridView.SelectedRows[0].Cells[8].Value.ToString();
                obj.ETAdd.Text = employeeDataGridView.SelectedRows[0].Cells[9].Value.ToString();
                obj.EContact.Text = employeeDataGridView.SelectedRows[0].Cells[10].Value.ToString();
                obj.EReligion.Text = employeeDataGridView.SelectedRows[0].Cells[11].Value.ToString();
                obj.EDept.Text = employeeDataGridView.SelectedRows[0].Cells[12].Value.ToString();
                obj.Dateofjoining.Text = employeeDataGridView.SelectedRows[0].Cells[13].Value.ToString();

                obj.EExperience.Text = employeeDataGridView.SelectedRows[0].Cells[14].Value.ToString();
                obj.EEmail.Text = employeeDataGridView.SelectedRows[0].Cells[15].Value.ToString();
                obj.EPost.Text = employeeDataGridView.SelectedRows[0].Cells[16].Value.ToString();
                obj.EBankAcc.Text = employeeDataGridView.SelectedRows[0].Cells[17].Value.ToString();
                obj.EBSalary.Text = employeeDataGridView.SelectedRows[0].Cells[18].Value.ToString();
                obj.EQualification.Text = employeeDataGridView.SelectedRows[0].Cells[19].Value.ToString();
                obj.EComment.Text = employeeDataGridView.SelectedRows[0].Cells[20].Value.ToString();

                obj.EPhoto.ImageLocation = System.Windows.Forms.Application.StartupPath + "\\images\\" + obj.EID.Text + ".jpg";


            }
            catch (Exception)
            {

               // throw;
            } 

            
        }



        private void employeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
                btnDelete.Enabled = true;
            

            try
            {


            }
            catch (Exception )
            {

               // MessageBox.Show(ex.ToString());
            }

            
        }

        private void employeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            try
            {

            }
            catch (Exception)
            {

                // MessageBox.Show(ex.ToString());
            }
            
        }

        private void employeeDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            string sql = "select * from tbl_employee where name ='" + txtEName.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            employeeDataGridView.DataSource = ds;
            employeeDataGridView.DataMember = ds.Tables[0].ToString();


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            string sql = "select * from tbl_employee where dateofjoin between '"+ datefrom.Text +"' and '" + datefrom.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            employeeDataGridView.DataSource = ds;
            employeeDataGridView.DataMember = ds.Tables[0].ToString();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            string sql = "delete from tbl_employee where EID = '" + employeeDataGridView.SelectedRows[0].Cells[0].Value.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deletion Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void employeeDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            if (null != gridView)
            {
                foreach (DataGridViewRow r in gridView.Rows)
                {
                    gridView.Rows[r.Index].HeaderCell.Value = (r.Index + 1).ToString();
                }
            }
        }

        private void btnExptExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);

            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;

            ws.Cells[1, 1] = "Employee ID";
            ws.Cells[1, 2] = "Name";
            ws.Cells[1, 3] = "Citizenship No";
            ws.Cells[1, 4] = "Gender";
            ws.Cells[1, 5] = "Marital Status";
            ws.Cells[1, 6] = "Date of Birth";
            ws.Cells[1, 7] = "Fathers Name";
            ws.Cells[1, 8] = "Mothers Name";
            ws.Cells[1, 9] = "Permanent Address";
            ws.Cells[1, 10] = "Temporary Address";
            ws.Cells[1, 11] = "Contact No";
            ws.Cells[1, 12] = "Religion";
            ws.Cells[1, 13] = "Department";
            ws.Cells[1, 14] = "Date of Join";
            ws.Cells[1, 15] = "Experience";
            ws.Cells[1, 16] = "Email ID";
            ws.Cells[1, 17] = "Post";
            ws.Cells[1, 18] = "Bank Accountant No";
            ws.Cells[1, 19] = "Basic Salary";
            ws.Cells[1, 20] = "Qualification";
            ws.Cells[1, 21] = "Comment";

            for (int j = 2; j <= employeeDataGridView.Rows.Count; j++)
            {
                for (int i = 2; i <= 21; i++)
                {
                    ws.Cells[j, i] = employeeDataGridView.Rows[j - 2].Cells[i - 1].Value;
                }
            }
        }
    }
}
