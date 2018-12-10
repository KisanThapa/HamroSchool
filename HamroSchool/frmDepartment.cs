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
    public partial class frmDepartment : Form
    {
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet16.tbl_dept' table. You can move, or remove it, as needed.
            this.tbl_deptTableAdapter.Fill(this.db_hamroschoolDataSet16.tbl_dept);

        }
        public void gridview()
        {
            SqlConnection conn1 = new SqlConnection(str);
            string sql = "Select * from tbl_dept order by DName asc";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DeptdataGridView.DataSource = ds;
            DeptdataGridView.DataMember = ds.Tables[0].ToString();
        }

        public String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DeptName.Text == "" || HeadofDept.Text == "")
            {
                MessageBox.Show("Please Fill the Record");
            }
            else
            {
                SqlConnection conn = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand("insert into tbl_dept ([DName],[Head]) values('" + DeptName.Text + "','" + HeadofDept.Text + "')", conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Department " + DeptName.Text + " inserted Successfully");

                    reset();
                    // reset();gridview();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed! " + ex.ToString());
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
            SqlCommand cmd = new SqlCommand("update tbl_dept set DName ='" + DeptName.Text + "' , Head = '" + HeadofDept.Text + "' where DName ='" + DeptName.Text + "' and Head ='" + HeadofDept.Text + "' ", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successful");
                gridview();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void DeptdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DeptName.Text = DeptdataGridView.SelectedRows[0].Cells[0].Value.ToString();
                HeadofDept.Text = DeptdataGridView.SelectedRows[0].Cells[1].Value.ToString();
                gridview();

            }
            catch
            {


            }
        }

        private void DeptdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void DeptdataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            string sql = "delete from tbl_dept where DName = '" + DeptName.Text + "' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Department deleted successfully");
                reset();
            }
            catch
            {
                MessageBox.Show("Unable to delete department");
            }
        }
        public void reset()
        {
            DeptName.Text = "";
            HeadofDept.Text = "";
            gridview();

        }
    }
}
