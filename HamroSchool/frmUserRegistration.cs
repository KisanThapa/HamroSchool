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
    public partial class frmUserRegistration : Form
    {
        public frmUserRegistration()
        {
            InitializeComponent();
        }

        private void frmUserRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet53.tbl_userReg' table. You can move, or remove it, as needed.
            this.tbl_userRegTableAdapter.Fill(this.db_hamroschoolDataSet53.tbl_userReg);
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet52.tbl_user' table. You can move, or remove it, as needed.
            //this.tbl_userTableAdapter.Fill(this.db_hamroschoolDataSet52.tbl_user);

        }

        private void btNew_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void gridview()
        {
            SqlConnection conn1 = new SqlConnection(str);
            string sql = "Select * from tbl_userReg order by username asc";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn1);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();
        }


        public String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();

        private void reset()
        {
            fullName.Text = "";
            userName.Text = "";
            password.Text = "";
            confirmPassword.Text = "";
            phone.Text = "";
            email.Text = "";
            gridview();
        }

        private void btSave_Click(object sender, EventArgs e)
        {

            if (password.Text==confirmPassword.Text)
            {
                SqlConnection conn = new SqlConnection(str);
                SqlCommand cmd = new SqlCommand("insert into tbl_userReg ([name],[username],[password],[usertype],[phone],[email]) values('" + fullName.Text + "','" + userName.Text + "','" + password.Text + "','" + usertype.Text + "','" + phone.Text + "','" + email + "')", conn);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User inserted Succesfully:", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridview();


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
            else
            {
                MessageBox.Show("Please confirm password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();
            }
          

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("update tbl_userReg set name='" + fullName.Text + "', password='"+ password.Text +"',usertype='"+ usertype.Text +"', phone='"+  phone.Text +"', email ='" + email.Text + "'", conn);

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

        private void btDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            string sql = "delete from tbl_userReg where name = '" + userName.Text + "' ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Department deleted successfully","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                reset();
            }
            catch
            {
                MessageBox.Show("Unable to delete department","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                fullName.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                userName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                password.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                confirmPassword.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                usertype.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                phone.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                email.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                

                gridview();

            }
            catch
            {


            }
        }
    }
}
