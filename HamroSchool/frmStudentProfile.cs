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
using System.Drawing.Imaging;

namespace HamroSchool
{
    public partial class frmStudentProfile : Form
    {
        public frmStudentProfile()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lnklblBrowse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Select Image of Employee";
                openFileDialog1.ShowDialog();
                openFileDialog1.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files(*.*)|*.*";
                SPhoto.ImageLocation = openFileDialog1.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not Open Files:", ex.ToString());
            }
        }

        private void frmStudentProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet20.tbl_section' table. You can move, or remove it, as needed.
            this.tbl_sectionTableAdapter.Fill(this.db_hamroschoolDataSet20.tbl_section);
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet18.tbl_class' table. You can move, or remove it, as needed.
            this.tbl_classTableAdapter.Fill(this.db_hamroschoolDataSet18.tbl_class);

            if(StdFName.Text=="First Name")
            {
                StdFName.ForeColor = Color.DarkGray;
            }
            else
            {
                StdFName.ForeColor = Color.Black;
            }
            SClass.Text = "Choose Class";
            SSection.Text = "Choose Section";
            SStatus.SelectedIndex = 0;
            SReligion.SelectedIndex = 0;


            SbtnUpdate.Enabled = false;
            SbtnDelete.Enabled = false;
            SbtnSave.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void SReligion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            frmStudentDataGridView obj = new frmStudentDataGridView();
            this.Hide();
           // obj.MdiParent = this;
            obj.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            string sql = "delete from tbl_student where SID = '" + SID.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee " + StdFName.Text + " deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deletion Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string obj = "";
        public string checkgender()
        {
            if (radioButton1.Checked == true)
            {
                obj = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                obj = radioButton2.Text;
            }
            else
            {
                obj = radioButton3.Text;
            }
            return obj;
        }
        public String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SID.Text == "" || StdFName.Text == "" || SClass.Text == "" || SRoll.Text == "" || SSection.Text == "" || checkgender() == "" || SDOB.Text == "" || SStatus.Text == "" || SPAdd.Text == "" || SAddmissionDate.Text == "")
            {
                MessageBox.Show("Please Fill the Record Properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (string.IsNullOrEmpty(SID.Text))
                {
                    MessageBox.Show("Please enter Student ID");
                    SID.Focus();
                    return;
                }
                else
                {
                    try
                    {
                        SPhoto.Image.Save(Application.StartupPath + "\\images\\" + SID.Text + ".jpg", ImageFormat.Jpeg);

                        SqlConnection conn = new SqlConnection(str);
                        SqlCommand cmd = new SqlCommand("insert into tbl_student ([SID],[Sname],[class],[roll],[section],[gender],[DOB],[status],[FName],[MName],[Lguardian],[phone],[Padd],[Tadd],[addate],[religion],[comment],[preSname],[preSphone],[preSadd],[passed],[photo]) values('" + SID.Text + "','" + StdFName.Text + "','" + SClass.Text + "','" + SRoll.Text + "','" + SSection.Text + "','" + checkgender() + "','" + SDOB.Text + "','" + SStatus.Text + "','" + SFName.Text + "','" + SMName.Text + "','" + SLocalGuardian.Text + "','" + textBox3.Text + "','" + SPAdd.Text + "','" + STAdd.Text + "','" + SAddmissionDate.Text + "','" + SReligion.Text + "','" + SComment.Text + "','" + PreSName.Text + "','" + PreSPhone.Text + "','" + PreSAdd.Text + "','" + PassedClass.Text + "','" + SID.Text + "')", conn);

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Student record inserted Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("update tbl_student set Sname='" + StdFName.Text + "',class='" + SClass.Text +"',roll='"+ SRoll.Text + "', section ='"+ SSection.Text + "', gender = '" + checkgender().ToString() + "', DOB='" + SDOB.Text + "', status ='" + SStatus.Text + "', Fname ='" + SFName.Text + "', Mname = '" + SMName.Text + "', Lguardian = '" + SLocalGuardian.Text + "', phone = '" + textBox3.Text + "', Padd = '" + SPAdd.Text + "', Tadd = '" + STAdd.Text + "', addate = '" + SAddmissionDate.Text + "', religion = '" + SReligion.Text + "', comment = '" + SComment.Text + "', preSname = '" + PreSName.Text + "', preSphone = '" + PreSPhone.Text + "', preSadd= '" + PreSAdd.Text + "', passed = '" + PassedClass.Text + "', photo = '" + SID.Text + "' where SID = '" + SID.Text + "'", conn);

            try
            {

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch( Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
            finally
            {

                conn.Close();

            }
        }

        private void reset()
        {
            SID.Text = "";
            SRoll.Text = "";
            SClass.Text = "";
            StdFName.ForeColor = Color.DarkGray;
           
            SSection.Text = "";         
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;

            }
            SDOB.Text = DateTime.Now.ToShortDateString();
            SStatus.SelectedIndex = 0;
            SFName.Text = "";
            SMName.Text = "";
            SLocalGuardian.Text = "";
           // ParentsPno.Text = "";
            SPAdd.Text = "";
            STAdd.Text = "";
            SAddmissionDate.Text = DateTime.Now.ToShortDateString();
            SReligion.SelectedIndex = 0;
            SComment.Text = "";
            PreSName.Text = "";
            PreSPhone.Text = "";
            PreSAdd.Text = "";
            PassedClass.Text = "";
            SID.Text = "";

            SPhoto.ImageLocation=null;

        }

        private void SID_TextChanged(object sender, EventArgs e)
        {
            SbtnSave.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SName_Enter(object sender, EventArgs e)
        {
            if(StdFName.Text=="First Name")
            {
                StdFName.Text = "";
                StdFName.ForeColor = Color.Black;
            }
        }

        private void StdFName_Leave(object sender, EventArgs e)
        {
            if(StdFName.Text=="")
            {
                StdFName.ForeColor = Color.DarkGray;
                StdFName.Text = "First Name";
            }
        }

        private void StdMName_Enter(object sender, EventArgs e)
        {
           
        }

        private void StdMName_Leave(object sender, EventArgs e)
        {
           
        }

        private void StdLName_Enter(object sender, EventArgs e)
        {
           
        }

        private void StdLName_Leave(object sender, EventArgs e)
        {
           
        }

        private void StdFName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
