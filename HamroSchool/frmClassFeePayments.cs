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
    public partial class frmClassFeePayments : Form
    {
        public frmClassFeePayments()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmClassFeePayments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet43.tbl_classFee' table. You can move, or remove it, as needed.
            this.tbl_classFeeTableAdapter.Fill(this.db_hamroschoolDataSet43.tbl_classFee);

        }

        public void gridview()
        {
            try
            {
                SqlConnection conn1 = new SqlConnection(str);
                string sql = "Select * from tbl_feepayment order by stdID asc";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn1);
                DataSet ds = new DataSet();
                da.Fill(ds);
                feedataGridView.DataSource = ds;
                feedataGridView.DataMember = ds.Tables[0].ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                FeeName.Text = feedataGridView.SelectedRows[0].Cells[0].Value.ToString();
                Month.Text = feedataGridView.SelectedRows[0].Cells[1].Value.ToString();
              
                
                FeeAmnt.Text = feedataGridView.SelectedRows[0].Cells[2].Value.ToString();
                //obj.Session.Text = feedataGridView.SelectedRows[0].Cells[].Value.ToString();

            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            GrandTotal.Text = FeeAmnt.Text;
        }

        private void TotalPaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(GrandTotal.Text) - Convert.ToDouble(TotalPaid.Text);

                CurrentDeu.Text = x.ToString();
            }
            catch (Exception)
            {

               
            }
           

        }

        private void PreDeu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double  x =  Convert.ToDouble(CurrentDeu.Text) + Convert.ToDouble(PreDeu.Text);
                CurrentDeu.Text = x.ToString();
            }
            catch (Exception ex)
            {
               
            }

        }

        private void Fine_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double z = Convert.ToDouble(Fine.Text) + Convert.ToDouble(CurrentDeu.Text);
                CurrentDeu.Text = z.ToString();
            }
            catch (Exception)
            {

               // throw;
            }
           
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            stdID.Text = "";
            StName.Text = "";
            Class.Text = "";
            Section.Text = "";
            Session.Text = "";

            FeeName.Text = "";
            Month.Text = "";
            Year.Text = "";
            FeeAmnt.Text = "";

            Fine.Text = "";
            PayDetails.Text = "";
            GrandTotal.Text = "";
            TotalPaid.Text = "";
            PayDate.Text = DateTime.Now.ToShortDateString();
            PreDeu.Text = "";
            CurrentDeu.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmClassFeeEntry obj = new frmClassFeeEntry();
            obj.Show();
            this.Hide();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ( StName.Text == "" || Class.Text == "" || FeeName.Text == "" || FeeAmnt.Text == "" )
            {
                MessageBox.Show("Please Fill the Record Properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (string.IsNullOrEmpty(stdID.Text))
                {
                    MessageBox.Show("Please enter Student ID");
                    stdID.Focus();
                    return;
                }
                else
                {
                    try
                    {
                        
                        SqlConnection conn = new SqlConnection(str);
                        SqlCommand cmd = new SqlCommand("insert into tbl_feepayment ([stdID],[stdName],[class],[section],[session],[feeName],[month],[year],[feeAmount],[fine],[payMode],[total],[totalpaid],[payDate],[preDeu],[currentDeu]) values('" + Convert.ToInt32(stdID.Text) + "','" + StName.Text + "','" + Class.Text + "','" + Section.Text + "','" + Session.Text + "','" + FeeName.Text + "','" + Month.Text + "','" + Year.Text + "','" + FeeAmnt.Text + "','" + Fine.Text + "','" + PayDetails.Text + "','" + GrandTotal.Text + "','" + TotalPaid.Text + "','" + PayDate.Text + "','" + PreDeu.Text + "','" + CurrentDeu.Text + "')", conn);

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Fee paid Succesfully");

                            reset();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Sorry! Exception occured" + ex);
                        }
                        finally
                        {
                            conn.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Please choose Student image", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        //throw;
                    }


                }


            }
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            frmFeeRecords obj = new frmFeeRecords();
            obj.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("update tbl_feepayment set stdName='" + StName.Text + "',class='" + Class.Text + "',section='" + Section.Text + "', session='" + Session.Text + "',feeName='" + FeeName.Text + "',month='" + Month.Text + "',year='" + Year.Text + "', feeAmount='" + FeeAmnt.Text + "', fine = '" + Fine.Text + "', payMode = '" + PayDetails.Text + "', total = '" + GrandTotal.Text + "', totalPaid = '" + TotalPaid.Text + "', payDate = '" + PayDate.Text + "', preDeu = '" + PreDeu.Text + "', currentDeu = '" + CurrentDeu.Text + "' where stdID = '" + stdID.Text + "'", conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successful!");


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

        private void btnSt_Click(object sender, EventArgs e)
        {
            frmFeeStudent obj = new frmFeeStudent();
            obj.Show();
            this.Hide();
        }
    }
}
