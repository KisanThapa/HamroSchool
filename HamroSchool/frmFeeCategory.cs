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
    public partial class frmFeeCategory : Form
    {
        public frmFeeCategory()
        {
            InitializeComponent();
        }

        public void gridview()
        {
            SqlConnection conn1 = new SqlConnection(str);
            string sql = "Select * from tbl_fee order by feeName asc";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            feedataGridView.DataSource = ds;
            feedataGridView.DataMember = ds.Tables[0].ToString();
        }
        public String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();

        private void frmFeeCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet35.tbl_fee' table. You can move, or remove it, as needed.
            this.tbl_feeTableAdapter.Fill(this.db_hamroschoolDataSet35.tbl_fee);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            feeName.Text = "";
            gridview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (feeName.Text == "")
            {
                MessageBox.Show("Please Fill the Record");
            }
            else
            {
                SqlConnection conn = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand("insert into tbl_fee ([feeName]) values('" + feeName.Text + "')", conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fee Category inserted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    feeName.Clear();
                    gridview();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }

            
        }

       


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            try
            {

                SqlCommand cmd = new SqlCommand("update tbl_fee set feeName='" + feeName.Text + "' where feeName='"+ feeName.Text +"'" , conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridview();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void feedataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                feeName.Text = feedataGridView.SelectedRows[0].Cells[0].Value.ToString();
                gridview();

            }
            catch
            {


            }
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            string sql = "delete from tbl_fee where feeName = '" + feeName.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Class Category deleted successfully");

                gridview();

                feeName.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Deletion Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void feedataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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
    }
}
