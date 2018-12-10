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

namespace HamroSchool
{
    public partial class frmSection : Form
    {
        public frmSection()
        {
            InitializeComponent();
        }

        private void frmSection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet14.tbl_section' table. You can move, or remove it, as needed.
            this.tbl_sectionTableAdapter.Fill(this.db_hamroschoolDataSet14.tbl_section);

        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            txtSection.Text = "";
        }

        public void gridview()
        {
            SqlConnection conn1 = new SqlConnection(str);
            string sql = "Select * from tbl_section order by Name asc";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            sectiondataGridView.DataSource = ds;
            sectiondataGridView.DataMember = ds.Tables[0].ToString();
        }
        public String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();


        private void btnSave_Click(object sender, EventArgs e)
        {
            if ( txtSection.Text == "")
            {
                MessageBox.Show("Please Fill the Record");
            }
            else
            {
                SqlConnection conn = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand("insert into tbl_section ([Name]) values('" + txtSection.Text + "')", conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Section " + txtSection.Text + " inserted Successfully");
                    gridview();
                    try
                    {
                        for (int i = 0; i <= sectiondataGridView.Rows.Count - 1; i++)
                        {
                            if (sectiondataGridView.Rows[i].Cells[0].Value.ToString() == txtSection.Text)
                            {
                                sectiondataGridView.Rows[i].Selected = true;
                            }
                            else
                            {
                                sectiondataGridView.Rows[i].Selected = false;
                            }
                        }
                    }
                    catch
                    {

                    }
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

            try
            {
                for (int i = 0; i <= sectiondataGridView.Rows.Count - 1; i++)
                {
                    if (sectiondataGridView.Rows[i].Cells[0].Value.ToString() == txtSection.Text)
                    {
                        sectiondataGridView.Rows[i].Selected = true;
                    }
                    else
                    {
                        sectiondataGridView.Rows[i].Selected = false;
                    }
                }
            }
            catch
            {


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("update tbl_section set Name = '" + txtSection.Text + "' where Name ='" + txtSection.Text + "' ", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successful");
                gridview();

                
                //txtSection.Clear();
                txtSection.Focus();

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            string sql = "delete from tbl_section where Name = '" + txtSection.Text + "' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Section " + txtSection.Text + " deleted successfully");

                gridview();

                txtSection.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Deletion Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void sectiondataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtSection.Text = sectiondataGridView.SelectedRows[0].Cells[0].Value.ToString();
                gridview();

            }
            catch
            {


            }
        }

        private void sectiondataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txtSection.Text = sectiondataGridView.SelectedRows[0].Cells[0].Value.ToString();
                gridview();

            }
            catch
            {


            }
            try
            {
                for (int i = 0; i <= sectiondataGridView.Rows.Count - 1; i++)
                {
                    if (sectiondataGridView.Rows[i].Cells[0].Value.ToString() == txtSection.Text)
                    {
                        sectiondataGridView.Rows[i].Selected = true;
                    }
                    else
                    {
                        sectiondataGridView.Rows[i].Selected = false;
                    }
                }
            }
            catch
            {


            }
        }

        private void sectiondataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void sectiondataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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
