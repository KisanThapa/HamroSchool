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
using System.Drawing.Imaging;
using Microsoft.Office.Interop.Excel;



namespace HamroSchool
{
    public partial class frmStudentDataGridView : Form
    {
        public frmStudentDataGridView()
        {
            InitializeComponent();
        }

        public void gridview()
        {
            try
            {
                SqlConnection conn1 = new SqlConnection(str);
                string sql = "Select * from tbl_student";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                studentdataGridView.DataSource = ds;
                studentdataGridView.DataMember = ds.Tables[0].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            }

        private void frmStudentDataGridView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet15.tbl_student' table. You can move, or remove it, as needed.
            this.tbl_studentTableAdapter.Fill(this.db_hamroschoolDataSet15.tbl_student);
            btnDelete.Enabled = false;

        }

        private void frmStudentDataGridView_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStudentProfile obj = new frmStudentProfile();
            obj.Show();
        }

        public String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();
        private void studentdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(btnDelete.Enabled==false)
            {
                btnDelete.Enabled = true;
            }

            try
            {
                  

            }
            catch (Exception)
            {

                //throw;
            }
            
        }

        private void studentdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                frmStudentProfile obj = new frmStudentProfile();
                this.Hide();
                obj.Show();

                obj.SbtnUpdate.Enabled = true;
                obj.SbtnDelete.Enabled = true;


                obj.SID.Text = studentdataGridView.SelectedRows[0].Cells[0].Value.ToString();
                obj.StdFName.ForeColor = Color.Black;
                obj.StdFName.Text = studentdataGridView.SelectedRows[0].Cells[1].Value.ToString();
                obj.SClass.Text = studentdataGridView.SelectedRows[0].Cells[2].Value.ToString();
                obj.SRoll.Text = studentdataGridView.SelectedRows[0].Cells[3].Value.ToString();
                obj.SSection.Text = studentdataGridView.SelectedRows[0].Cells[4].Value.ToString();

                if (studentdataGridView.SelectedRows[0].Cells[5].Value.ToString() == "Male")
                {
                    obj.radioButton1.Checked = true;
                    obj.radioButton2.Checked = false;
                    obj.radioButton3.Checked = false;

                }

                if (studentdataGridView.SelectedRows[0].Cells[5].Value.ToString() == "Female")
                {
                    obj.radioButton1.Checked = false;
                    obj.radioButton2.Checked = true;
                    obj.radioButton3.Checked = false;

                }

                if (studentdataGridView.SelectedRows[0].Cells[5].Value.ToString() == "Not Specified")
                {
                    obj.radioButton1.Checked = false;
                    obj.radioButton2.Checked = false;
                    obj.radioButton3.Checked = true;

                }

                obj.SDOB.Text = studentdataGridView.SelectedRows[0].Cells[6].Value.ToString();

                obj.SStatus.Text = studentdataGridView.SelectedRows[0].Cells[7].Value.ToString();
                obj.SFName.Text = studentdataGridView.SelectedRows[0].Cells[8].Value.ToString();
                obj.SMName.Text = studentdataGridView.SelectedRows[0].Cells[9].Value.ToString();
                obj.SLocalGuardian.Text = studentdataGridView.SelectedRows[0].Cells[10].Value.ToString();

                obj.textBox3.Text = studentdataGridView.SelectedRows[0].Cells[11].Value.ToString();


                obj.SPAdd.Text = studentdataGridView.SelectedRows[0].Cells[12].Value.ToString();
                obj.STAdd.Text = studentdataGridView.SelectedRows[0].Cells[13].Value.ToString();
                obj.SAddmissionDate.Text = studentdataGridView.SelectedRows[0].Cells[14].Value.ToString();
                obj.SReligion.Text = studentdataGridView.SelectedRows[0].Cells[15].Value.ToString();
                obj.SComment.Text = studentdataGridView.SelectedRows[0].Cells[16].Value.ToString();
                obj.PreSName.Text = studentdataGridView.SelectedRows[0].Cells[17].Value.ToString();
                obj.PreSPhone.Text = studentdataGridView.SelectedRows[0].Cells[18].Value.ToString();
                obj.PreSAdd.Text = studentdataGridView.SelectedRows[0].Cells[19].Value.ToString();
                obj.PassedClass.Text = studentdataGridView.SelectedRows[0].Cells[20].Value.ToString();

                obj.SPhoto.ImageLocation = System.Windows.Forms.Application.StartupPath + "\\images\\" + obj.SID.Text + ".jpg";


            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void studentdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {

               


            }
            catch (Exception)
            {

                //throw;
            }

        }

        private void btnIDSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(str);
                string sql = "select * from tbl_student where SID ='" + txtID.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                

                studentdataGridView.DataSource = ds;
                studentdataGridView.DataMember = ds.Tables[0].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("No Results Found!");
                //throw;
            }
           
        }

        private void txtSName_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmStudentProfile obj = new frmStudentProfile();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(str);
                string sql = "select * from tbl_student where SID ='" + txtID.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);


                studentdataGridView.DataSource = ds;
                studentdataGridView.DataMember = ds.Tables[0].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("No Results Found!");
                //throw;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            string sql = "delete from tbl_student where SID = '" + studentdataGridView.SelectedRows[0].Cells[0].Value.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student record deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deletion Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void studentdataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);

            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;

            ws.Cells[1, 1] = "Student ID";
            ws.Cells[1, 2] = "Student Name";
            ws.Cells[1, 3] = "Class";
            ws.Cells[1, 4] = "Roll No";
            ws.Cells[1, 5] = "Section";
            ws.Cells[1, 6] = "Gender";
            ws.Cells[1, 7] = "Date of Birth";
            ws.Cells[1, 8] = "Activity Status";
            ws.Cells[1, 9] = "Fathers Name";
            ws.Cells[1, 10] = "Mothers Name";
            ws.Cells[1, 11] = "Local Guardian Name";
            ws.Cells[1, 12] = "Phone No";
            ws.Cells[1, 13] = "Permanent Address";
            ws.Cells[1, 14] = "Temporary Address";
            ws.Cells[1, 15] = "Admission Date";
            ws.Cells[1, 16] = "Religion";
            ws.Cells[1, 17] = "Comment";
            ws.Cells[1, 18] = "Previous School's Name";
            ws.Cells[1, 19] = "Previous School's Phone";
            ws.Cells[1, 20] = "Previous School Address ";
            ws.Cells[1, 21] = "Passed Class";

            for (int j = 2; j <= studentdataGridView.Rows.Count; j++)
            {
                for (int i = 2; i <= 21; i++)
                {
                    ws.Cells[j, i] = studentdataGridView.Rows[j - 2].Cells[i - 1].Value;
                }
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            frmStudentProfile obj = new frmStudentProfile();
            obj.Show();
            this.Hide();
        }
    }
}
