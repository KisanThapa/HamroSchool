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
using System.IO;


namespace HamroSchool
{
    public partial class frmFeeStudent : Form
    {
        public frmFeeStudent()
        {
            InitializeComponent();
        }

        public void gridview()
        {
            try
            {
                SqlConnection conn1 = new SqlConnection(str);
                string sql = "Select * from tbl_student";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = ds.Tables[0].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }


        public String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();

        private void frmFeeStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet48.tbl_student' table. You can move, or remove it, as needed.
            this.tbl_studentTableAdapter1.Fill(this.db_hamroschoolDataSet48.tbl_student);
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet47.tbl_student' table. You can move, or remove it, as needed.
            this.tbl_studentTableAdapter.Fill(this.db_hamroschoolDataSet47.tbl_student);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmClassFeePayments obj = new frmClassFeePayments();
                obj.Show();
                obj.stdID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                obj.StName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                obj.Class.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                obj.Section.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                this.Hide();
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(str);
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_student where Sname = '" + cmbName.Text + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmClassFeePayments obj = new frmClassFeePayments();
            obj.Show();
            this.Hide();
        }

        private void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                SqlConnection conn = new SqlConnection(str);
                SqlDataAdapter da = new SqlDataAdapter("select * from tbl_student where Sname = '" + cmbName.Text + "'", conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = ds.Tables[0].ToString();
                e.Handled = true;

            }
            else
            {
                e.Handled = false;

            }
        }
    }
}
