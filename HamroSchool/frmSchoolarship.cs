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
    public partial class frmSchoolarship : Form
    {
        public frmSchoolarship()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmSchoolarship_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet42.tbl_schoolarship' table. You can move, or remove it, as needed.
            this.tbl_schoolarshipTableAdapter.Fill(this.db_hamroschoolDataSet42.tbl_schoolarship);

        }

        public void gridview()
        {
            SqlConnection conn1 = new SqlConnection(str);
            string sql = "Select * from tbl_schoolarship";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            SclrshipdataGridView.DataSource = ds;
            SclrshipdataGridView.DataMember = ds.Tables[0].ToString();
        }
        private void reset()
        {
            ScName.Text = "";
            Amount.Text = "";
            describe.Text = "";
            gridview();

        }

        public String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();
        private void btnNew_Click(object sender, EventArgs e)
        {
            reset();
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ScName.Text == "" || Amount.Text == "" || describe.Text == "" )
            {
                MessageBox.Show("Please Fill the Record Properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                try
                {

                    SqlConnection conn = new SqlConnection(str);
                    SqlCommand cmd = new SqlCommand("insert into tbl_schoolarship ([scName],[amount],[description]) values('" + ScName.Text + "','" + Amount.Text + "','" + describe.Text + "')", conn);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Schoolarship inserted Succesfully:");
                        gridview();
                        reset();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problem is:" + ex);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("update tbl_schoolarship set amount='" + Amount.Text + "',description='" + describe.Text + "' where scName = '"+ ScName.Text + "'", conn);

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            string sql = "delete from tbl_schoolarship where scName = '" + ScName.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Schoolarship deleted successfully");

                gridview();

                reset();

            }
            catch
            {


            }
        }

        private void SclrshipdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                ScName.Text = SclrshipdataGridView.SelectedRows[0].Cells[0].Value.ToString();
                Amount.Text = SclrshipdataGridView.SelectedRows[0].Cells[1].Value.ToString();

                describe.Text = SclrshipdataGridView.SelectedRows[0].Cells[2].Value.ToString();

                gridview();

                btnSave.Enabled = false;

            }
            catch
            {


            }
        }

        private void ScName_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
