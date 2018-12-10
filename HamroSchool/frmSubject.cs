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
    public partial class frmSubject : Form
    {
        public frmSubject()
        {
            InitializeComponent();
        }

        public void gridview()
        {
            SqlConnection conn1 = new SqlConnection(str);
            string sql = "Select * from tbl_subject order by subCode asc";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            subdataGridView.DataSource = ds;
            subdataGridView.DataMember = ds.Tables[0].ToString();
        }

        public String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();

        private void frmSubject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet50.tbl_subject' table. You can move, or remove it, as needed.
            this.tbl_subjectTableAdapter.Fill(this.db_hamroschoolDataSet50.tbl_subject);
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            subCode.Text = "";
            subName.Text = "";
            gridview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (subCode.Text == "" || subName.Text == "" )
            {
                MessageBox.Show("Please Fill the Record Properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

               

                    SqlConnection conn = new SqlConnection(str);
                    SqlCommand cmd = new SqlCommand("insert into tbl_subject ([subCode],[subName]) values('" + subCode.Text + "','" + subName.Text + "')", conn);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Subject inserted Succesfully","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        
                        reset();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed","",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            SqlCommand cmd = new SqlCommand("update tbl_subject set subName='" + subName.Text + "' where subCode = '" + subCode + "'", conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successful !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;
                gridview();

            }
            catch/*( Exception ex)*/
            {

                MessageBox.Show("Not updated","",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            finally
            {

                conn.Close();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            if (subCode.Text != "" || subName.Text != "")
            {
                string sql = "delete from tbl_subject where subCode = '" + subCode.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = false;
                    btnUpdate.Enabled = false;
                    reset();

                }
                catch
                {
                }
            }
            else
            {

                string sql = "delete from tbl_subject where subCode = '" + subdataGridView.SelectedRows[0].Cells[0].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    reset();
                }
                catch
                {

                }
            }

           
        }

        private void subdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               

                subCode.Text = subdataGridView.SelectedRows[0].Cells[0].Value.ToString();
                subName.Text = subdataGridView.SelectedRows[0].Cells[1].Value.ToString();

                gridview();

                // btnSave.Enabled = false;
            }
            catch
            {


            }
        }

        private void subdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void subCode_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }
    }
}
