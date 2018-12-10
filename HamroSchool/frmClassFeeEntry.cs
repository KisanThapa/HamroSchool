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
    public partial class frmClassFeeEntry : Form
    {
        public frmClassFeeEntry()
        {
            InitializeComponent();
        }

        private void frmClassFeeEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet41.tbl_classFee' table. You can move, or remove it, as needed.
            this.tbl_classFeeTableAdapter1.Fill(this.db_hamroschoolDataSet41.tbl_classFee);
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet40.tbl_class1' table. You can move, or remove it, as needed.
            //this.tbl_class1TableAdapter1.Fill(this.db_hamroschoolDataSet40.tbl_class1);
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet39.tbl_class1' table. You can move, or remove it, as needed.
            // this.tbl_class1TableAdapter.Fill(this.db_hamroschoolDataSet39.tbl_class1);
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet38.tbl_classFee' table. You can move, or remove it, as needed.
            //this.tbl_classFeeTableAdapter.Fill(this.db_hamroschoolDataSet38.tbl_classFee);
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet37.tbl_fee' table. You can move, or remove it, as needed.
            this.tbl_feeTableAdapter.Fill(this.db_hamroschoolDataSet37.tbl_fee);
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet36.tbl_class' table. You can move, or remove it, as needed.
            // this.tbl_classTableAdapter.Fill(this.db_hamroschoolDataSet36.tbl_class);
            gridview();
        }

        public void gridview()
        {
            SqlConnection conn1 = new SqlConnection(str);
            string sql = "Select * from tbl_classFee order by class asc";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ClassFeedataGridView.DataSource = ds;
            ClassFeedataGridView.DataMember = ds.Tables[0].ToString();
        }

        public String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("update tbl_classFee set class='" + cmbClass.Text + "',feeCategory='" + cmbFName.Text + "',month='" + cmbMonth + "', fee='" + cmbFee.Text + "'", conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successful !");
                gridview();

            }
            catch/*( Exception ex)*/
            {

                MessageBox.Show("Not updated");

            }
            finally
            {

                conn.Close();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbClass.Text == "" || cmbFee.Text == "" || cmbFName.Text == "" || cmbMonth.Text == "")
            {
                MessageBox.Show("Please Fill the Record Properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                try
                {

                    SqlConnection conn = new SqlConnection(str);
                    SqlCommand cmd = new SqlCommand("insert into tbl_classFee ([class],[feeCategory],[month],[fee]) values('" + cmbClass.Text + "','" + cmbFName.Text + "','" + cmbMonth.Text + "','" + cmbFee.Text + "')", conn);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Fee inserted Succesfully","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        gridview();
                        reset();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed !","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Please choose Employee image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }
        private void reset()
        {
            cmbClass.Text = "";
            cmbFee.Text = "";
            cmbFName.Text = "";
            cmbMonth.Text = "";
            gridview();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            string sql = "delete from tbl_classFee where class = '" + cmbClass.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Class Category deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                gridview();

                reset();

            }
            catch
            {


            }
        }

        private void ClassFeedataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                cmbClass.Text = ClassFeedataGridView.SelectedRows[0].Cells[0].Value.ToString();
                cmbFName.Text = ClassFeedataGridView.SelectedRows[0].Cells[1].Value.ToString();

                cmbMonth.Text = ClassFeedataGridView.SelectedRows[0].Cells[2].Value.ToString();
                cmbFee.Text = ClassFeedataGridView.SelectedRows[0].Cells[3].Value.ToString();
                gridview();

               // btnSave.Enabled = false;
            }
            catch
            {


            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void searchClass_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_classFee where class = '" + cmbClass.Text + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ClassFeedataGridView.DataSource = ds;
            ClassFeedataGridView.DataMember = ds.Tables[0].ToString();
        }

        private void searchMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_classFee where month = '" + cmbMonth.Text + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            ClassFeedataGridView.DataSource = ds;
            ClassFeedataGridView.DataMember = ds.Tables[0].ToString();
        }
    }
}
