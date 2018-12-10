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
    public partial class frmSchoolEntry : Form
    {
        public frmSchoolEntry()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmSchoolEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet13.tbl_school' table. You can move, or remove it, as needed.
            this.tbl_schoolTableAdapter3.Fill(this.db_hamroschoolDataSet13.tbl_school);
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet11.tbl_school' table. You can move, or remove it, as needed.
            //this.tbl_schoolTableAdapter2.Fill(this.db_hamroschoolDataSet11.tbl_school);
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet10.tbl_school' table. You can move, or remove it, as needed.
            //this.tbl_schoolTableAdapter1.Fill(this.db_hamroschoolDataSet10.tbl_school);
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet9.tbl_school' table. You can move, or remove it, as needed.
            this.tbl_schoolTableAdapter.Fill(this.db_hamroschoolDataSet9.tbl_school);

        }

        public void gridview()
        {
            SqlConnection conn1 = new SqlConnection(str);
            string sql = "Select * from tbl_school order by name asc";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            schooldataGridView.DataSource = ds;
            schooldataGridView.DataMember = ds.Tables[0].ToString();
        }
        public String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();

        private void schooldataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SName.Text == "" || SAdd.Text=="")
            {
                MessageBox.Show("Please Fill the Record");
            }
            else
            {
                SqlConnection conn = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand("insert into tbl_school ([name],[address],[contact],[fax],[email],[website]) values('" + SName.Text + "','"+ SAdd.Text +"','"+ Contact.Text +"','"+ Fax.Text +"','"+ Email.Text +"','"+ Website.Text +"')", conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("School record inserted Successfully");
                    reset();
                    //gridview();
                   
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
            SqlCommand cmd = new SqlCommand("update tbl_school set name ='" + SName.Text + "' , address = '" + SAdd.Text + "',contact='"+ Contact.Text +"',fax='"+ Fax.Text +"',email='"+ Email.Text +"',website='"+ Website.Text +"' where name ='" + SName.Text + "' ", conn);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            string sql = "delete from tbl_school where name = '" + SName.Text + "' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("School deleted successfully");

               // gridview();

                reset();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Deletion Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void reset()
        {
            SName.Text = "";
            SAdd.Text = "";
            Contact.Text = "";
            Fax.Text = "";
            Email.Text = "";
            Website.Text = "";

            gridview();

        }

        private void schooldataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                SName.Text = schooldataGridView.SelectedRows[0].Cells[0].Value.ToString();
                SAdd.Text = schooldataGridView.SelectedRows[0].Cells[1].Value.ToString();

                Contact.Text = schooldataGridView.SelectedRows[0].Cells[2].Value.ToString();
                Fax.Text = schooldataGridView.SelectedRows[0].Cells[3].Value.ToString();


                Email.Text = schooldataGridView.SelectedRows[0].Cells[4].Value.ToString();
                Website.Text = schooldataGridView.SelectedRows[0].Cells[5].Value.ToString();


                gridview();

            }
            catch
            {


            }
        }
    }
}
