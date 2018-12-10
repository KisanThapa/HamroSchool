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
    public partial class frmClassEntry : Form
    {
        public frmClassEntry()
        {
            InitializeComponent();
        }

        private void frmClassEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet49.tbl_class' table. You can move, or remove it, as needed.
            this.tbl_classTableAdapter.Fill(this.db_hamroschoolDataSet49.tbl_class);

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Class.Text = "";
        }

        public void gridview()
        {
            SqlConnection conn1 = new SqlConnection(str);
            string sql = "Select * from tbl_class order by class asc";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();
        }

        public String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Class.Text == "")
            {
                MessageBox.Show("Please Fill the Record Properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                SqlConnection conn = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand("insert into tbl_class ([class]) values('" + Class.Text + "')", conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Class inserted Succesfully:", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridview();
                    Class.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            SqlCommand cmd = new SqlCommand("update tbl_class set class='" + Class.Text + "'", conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successful !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            string sql = "delete from tbl_class where class = '" + Class.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Class deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Class.Text = "";
                gridview();

             }
            catch
            {


            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Class.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
               
                gridview();

                // btnSave.Enabled = false;
            }
            catch
            {


            }
        }
    }
}
