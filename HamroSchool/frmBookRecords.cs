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
    public partial class frmBookRecords : Form
    {
        public frmBookRecords()
        {
            InitializeComponent();

           
        }
        public String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();


        public void gridview()
        {
            try
            {
                SqlConnection conn1 = new SqlConnection(str);
                string sql = "Select * from tbl_book";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                BookdataGridView.DataSource = ds;
                BookdataGridView.DataMember = ds.Tables[0].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }


        private void frmBookRecords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet34.tbl_book' table. You can move, or remove it, as needed.
            this.tbl_bookTableAdapter4.Fill(this.db_hamroschoolDataSet34.tbl_book);



            // TODO: This line of code loads data into the 'db_hamroschoolDataSet33.tbl_dept' table. You can move, or remove it, as needed.
            this.tbl_deptTableAdapter.Fill(this.db_hamroschoolDataSet33.tbl_dept);
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet32.tbl_book' table. You can move, or remove it, as needed.
            this.tbl_bookTableAdapter3.Fill(this.db_hamroschoolDataSet32.tbl_book);
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet30.tbl_book' table. You can move, or remove it, as needed.
            this.tbl_bookTableAdapter2.Fill(this.db_hamroschoolDataSet30.tbl_book);
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet28.tbl_book' table. You can move, or remove it, as needed.
            this.tbl_bookTableAdapter1.Fill(this.db_hamroschoolDataSet28.tbl_book);
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet27.tbl_book' table. You can move, or remove it, as needed.
            this.tbl_bookTableAdapter.Fill(this.db_hamroschoolDataSet27.tbl_book);


           
            cmbBookTitle.Text = "Choose Book Title";
          
            
            gridview();

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmBookRecords_FormClosed(object sender, FormClosedEventArgs e)
        {
            //frmBookEntry obj = new frmBookEntry();
            //obj.Show();
            //this.Hide();
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookTitle_Enter(object sender, EventArgs e)
        {
           
        }

        private void bookTitle_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void authorName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SqlConnection conn = new SqlConnection(str);
                SqlDataAdapter da = new SqlDataAdapter("select * from tbl_book where author = '" + authorName.Text + "'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                BookdataGridView.DataSource = ds;
                BookdataGridView.DataMember = ds.Tables[0].ToString();

            }
            else
            {
                e.Handled = false;
            }
        }

        private void accNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SqlConnection conn = new SqlConnection(str);
                SqlDataAdapter da = new SqlDataAdapter("select * from tbl_book where AcNo = '" + accNo.Text + "'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                BookdataGridView.DataSource = ds;
                BookdataGridView.DataMember = ds.Tables[0].ToString();

            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnResetTitle_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            gridview();
            cmbBookTitle.Text = "Choose Book Title";
            cmbAuthorName.Text = "Choose Author";
            cmbAccNo.Text = "Choose Accession";
            cmbDept.Text = "Choose Department";
            

            btnDelete.Visible = false;
            btnUpdate.Visible = false;
        }

        private void cmbBookTitle_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_book where title = '" + cmbBookTitle.Text + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            BookdataGridView.DataSource = ds;
            BookdataGridView.DataMember = ds.Tables[0].ToString();

        }

        private void cmbAuthorName_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_book where author = '" + cmbAuthorName.Text + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            BookdataGridView.DataSource = ds;
            BookdataGridView.DataMember = ds.Tables[0].ToString();

        }

        private void cmbAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(str);
                SqlDataAdapter da = new SqlDataAdapter("select * from tbl_book where AcNo = '" + cmbAccNo.Text + "'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                BookdataGridView.DataSource = ds;
                BookdataGridView.DataMember = ds.Tables[0].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw;
            }
           
        }

        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_book where dept = '" + cmbDept.Text + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            BookdataGridView.DataSource = ds;
            BookdataGridView.DataMember = ds.Tables[0].ToString();

        }

        private void btnResetAuthor_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnResetAcc_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnResetDept_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            gridview();

            reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            string sql = "delete from tbl_book where AcNo = '" + BookdataGridView.SelectedRows[0].Cells[0].Value.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book record deleted successfully");
                gridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deletion Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //frmBookEntry obj = new frmBookEntry();
            //obj.Show();
            this.Hide();
        }

        private void BookdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnDelete.Visible == false||btnUpdate.Visible==false)
            {
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
            }
           
                         
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ReturnBook();
        }

        private void ReturnBook()
        {
            try
            {

                frmBookEntry obj = new frmBookEntry();
                this.Hide();
                obj.Show();


                obj.AccNo.Text = BookdataGridView.SelectedRows[0].Cells[0].Value.ToString();
                obj.bookTitle.Text = BookdataGridView.SelectedRows[0].Cells[1].Value.ToString();
                obj.author.Text = BookdataGridView.SelectedRows[0].Cells[2].Value.ToString();

                obj.sub.Text = BookdataGridView.SelectedRows[0].Cells[3].Value.ToString();
                obj.sub.Text = BookdataGridView.SelectedRows[0].Cells[4].Value.ToString();
                obj.dept.Text = BookdataGridView.SelectedRows[0].Cells[6].Value.ToString();

                obj.isbn.Text = BookdataGridView.SelectedRows[0].Cells[7].Value.ToString();
                obj.edition.Text = BookdataGridView.SelectedRows[0].Cells[8].Value.ToString();
                obj.publisher.Text = BookdataGridView.SelectedRows[0].Cells[9].Value.ToString();

                obj.pubYear.Text = BookdataGridView.SelectedRows[0].Cells[10].Value.ToString();
                obj.price.Text = BookdataGridView.SelectedRows[0].Cells[11].Value.ToString();
                obj.volume.Text = BookdataGridView.SelectedRows[0].Cells[12].Value.ToString();

                obj.reference.Text = BookdataGridView.SelectedRows[0].Cells[13].Value.ToString();

            }
            catch (Exception)
            {

                //throw;
            }

        }

        private void BookdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ReturnBook();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void tabControl1_TabStopChanged(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAuthorName.Text = "Choose Author";
            cmbAccNo.Text = "Choose Accession";

            cmbDept.Text = "Choose Department";
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            disable();
        }
        private void disable()
        {

            btnDelete.Visible = false;
            btnUpdate.Visible = false;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void BookdataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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

        private void ExptTitle_Click(object sender, EventArgs e)
        {
            export();
        }

        private void export()
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();

            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);

            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;

            ws.Cells[1, 1] = "Accession Number";
            ws.Cells[1, 2] = "Book Title";
            ws.Cells[1, 3] = "Book Author";
            ws.Cells[1, 4] = "Subject";
            ws.Cells[1, 5] = "Department";
            ws.Cells[1, 6] = "ISBN Number";
            ws.Cells[1, 7] = "Edition";
            ws.Cells[1, 8] = "Publisher";
            ws.Cells[1, 9] = "Publishing Year";
            ws.Cells[1, 10] = "Book Price";
            ws.Cells[1, 11] = "Volume";
            ws.Cells[1, 12] = "Reference";

            for (int j = 2; j <= BookdataGridView.Rows.Count; j++)
            {
                for (int i = 2; i <= 12; i++)
                {
                    ws.Cells[j, i] = BookdataGridView.Rows[j - 2].Cells[i - 1].Value;
                }
            }

        }

        private void ExptBook_Click(object sender, EventArgs e)
        {
            export();
        }

        private void ExptAcc_Click(object sender, EventArgs e)
        {
            export();
        }

        private void ExptDept_Click(object sender, EventArgs e)
        {
            export();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            export();
        }
    }
}
