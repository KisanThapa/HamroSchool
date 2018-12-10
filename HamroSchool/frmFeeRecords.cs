using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace HamroSchool
{
    public partial class frmFeeRecords : Form
    {
        public frmFeeRecords()
        {
            InitializeComponent();
        }

        private void frmFeeRecords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet46.tbl_feepayment' table. You can move, or remove it, as needed.
            this.tbl_feepaymentTableAdapter2.Fill(this.db_hamroschoolDataSet46.tbl_feepayment);
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet45.tbl_feepayment' table. You can move, or remove it, as needed.
            this.tbl_feepaymentTableAdapter1.Fill(this.db_hamroschoolDataSet45.tbl_feepayment);
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet44.tbl_feepayment' table. You can move, or remove it, as needed.
            this.tbl_feepaymentTableAdapter.Fill(this.db_hamroschoolDataSet44.tbl_feepayment);

            
            cmbName.Text = "Choose Name";
        }

        public void gridview()
        {
            try
            {
                SqlConnection conn1 = new SqlConnection(str);
                string sql = "Select * from tbl_feepayment order by stdID asc";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                feeRecorddataGridView.DataSource = ds;
                feeRecorddataGridView.DataMember = ds.Tables[0].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        public String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();

        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_feepayment where stdID = '" + ID.Text + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            feeRecorddataGridView.DataSource = ds;
            feeRecorddataGridView.DataMember = ds.Tables[0].ToString();

        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_feepayment where stdName = '" + cmbName.Text + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            feeRecorddataGridView.DataSource = ds;
            feeRecorddataGridView.DataMember = ds.Tables[0].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void reset()
        {
            ID.Text = "";
            cmbName.Text = "";

            gridview();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmClassFeePayments obj = new frmClassFeePayments();
            obj.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;

                SqlConnection conn = new SqlConnection(str);
                SqlDataAdapter da = new SqlDataAdapter("select * from tbl_feepayment where stdID = '" + ID.Text + "'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                feeRecorddataGridView.DataSource = ds;
                feeRecorddataGridView.DataMember = ds.Tables[0].ToString();

            }
            else
            {
                e.Handled = false;
            }
        }

        private void feeRecorddataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {

                frmClassFeePayments obj = new frmClassFeePayments();
                this.Hide();
                obj.Show();

                obj.stdID.Text = feeRecorddataGridView.SelectedRows[0].Cells[0].Value.ToString();
                obj.StName.Text = feeRecorddataGridView.SelectedRows[0].Cells[1].Value.ToString();
                obj.Class.Text = feeRecorddataGridView.SelectedRows[0].Cells[2].Value.ToString();         

                obj.Section.Text = feeRecorddataGridView.SelectedRows[0].Cells[3].Value.ToString();
                obj.Session.Text = feeRecorddataGridView.SelectedRows[0].Cells[4].Value.ToString();
                obj.FeeName.Text = feeRecorddataGridView.SelectedRows[0].Cells[5].Value.ToString();
                obj.Month.Text = feeRecorddataGridView.SelectedRows[0].Cells[6].Value.ToString();
                obj.Year.Text = feeRecorddataGridView.SelectedRows[0].Cells[7].Value.ToString();
                obj.FeeAmnt.Text = feeRecorddataGridView.SelectedRows[0].Cells[8].Value.ToString();
                obj.Fine.Text = feeRecorddataGridView.SelectedRows[0].Cells[9].Value.ToString();
                obj.PayDetails.Text = feeRecorddataGridView.SelectedRows[0].Cells[10].Value.ToString();
                obj.GrandTotal.Text = feeRecorddataGridView.SelectedRows[0].Cells[11].Value.ToString();
                obj.TotalPaid.Text = feeRecorddataGridView.SelectedRows[0].Cells[12].Value.ToString();

                obj.PayDate.Text = feeRecorddataGridView.SelectedRows[0].Cells[13].Value.ToString();
                obj.PreDeu.Text = feeRecorddataGridView.SelectedRows[0].Cells[14].Value.ToString();
                obj.CurrentDeu.Text = feeRecorddataGridView.SelectedRows[0].Cells[15].Value.ToString();
               
            }
            catch (Exception)
            {

                // throw;
            }

        }
    }
}
