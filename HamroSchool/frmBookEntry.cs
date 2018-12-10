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
    public partial class frmBookEntry : Form
    {
        public frmBookEntry()
        {
            InitializeComponent();
        }

        private void frmBookEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet51.tbl_subject' table. You can move, or remove it, as needed.
            this.tbl_subjectTableAdapter2.Fill(this.db_hamroschoolDataSet51.tbl_subject);
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet25.tbl_subject' table. You can move, or remove it, as needed.
            this.tbl_subjectTableAdapter1.Fill(this.db_hamroschoolDataSet25.tbl_subject);
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet24.tbl_subject' table. You can move, or remove it, as needed.
            //this.tbl_subjectTableAdapter.Fill(this.db_hamroschoolDataSet24.tbl_subject);
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet23.tbl_dept' table. You can move, or remove it, as needed.
            this.tbl_deptTableAdapter.Fill(this.db_hamroschoolDataSet23.tbl_dept);
            dept.Text = "Choose Department";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnViewRecord_Click(object sender, EventArgs e)
        {
            frmBookRecords obj = new frmBookRecords();
            obj.Show();
            //this.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            AccNo.Text = "";
            bookTitle.Text = "";
            author.Text = "";
            //sub.SelectedIndex = 0;
            dept.SelectedIndex=0;
            isbn.Text = "";
            edition.Text = "";
            publisher.Text = "";
            pubYear.Text = "";
            price.Text = "";
            volume.Text = "";
            reference.Text = "";
        }

        public String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(AccNo.Text))
            {
                MessageBox.Show("Please enter Accession ID");
                AccNo.Focus();
                return;

            }
            else
            {
                if (AccNo.Text == "" || bookTitle.Text == "" || author.Text==""|| dept.Text == "" || isbn.Text == "" || price.Text == "")
                {
                    MessageBox.Show("Please Fill the Record Properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                try
                {

                    SqlConnection conn = new SqlConnection(str);
                    SqlCommand cmd = new SqlCommand("insert into tbl_book ([AcNo],[title],[author],[sub],[dept],[isbn],[edition],[publisher],[pubYear],[price],[vol],[ref]) values('" + AccNo.Text + "','" + bookTitle.Text + "','"+ author.Text +"','" + sub.Text + "','" + dept.Text + "','" + isbn.Text + "','" + edition.Text + "','" + publisher.Text + "','" + pubYear.Text + "','" + price.Text + "','" + volume.Text + "','" + reference.Text + "')", conn);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Book record inserted Succesfully" /*"", MessageBoxButtons.OK, MessageBoxIcon.Information*/);

                        clear();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        //    MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                catch
                {

                }

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            string sql = "delete from tbl_book where AcNo = '" + AccNo.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book deleted successfully");

                clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Deletion Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("update tbl_book set title='" + bookTitle.Text + "',author= '"+ author.Text +"'sub='" + sub.Text + "',dept='" + dept.Text + "', isbn='" + isbn.Text + "',edition='" + edition.Text + "',publisher='" + publisher.Text + "',pubYear='" + pubYear.Text + "', price='" + price.Text + "', vol = '" + volume.Text + "', ref = '" + reference.Text + "'", conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successful");


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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void sub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
