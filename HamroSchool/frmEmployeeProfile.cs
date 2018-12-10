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
using System.Drawing.Imaging;

namespace HamroSchool
{
    public partial class frmEmpProfile : Form
    {
        public frmEmpProfile()
        {
            InitializeComponent();
        }

        private void grpBoxemployee_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void frmEmpProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet17.tbl_dept' table. You can move, or remove it, as needed.
            this.tbl_deptTableAdapter.Fill(this.db_hamroschoolDataSet17.tbl_dept);

            MStatus.SelectedIndex = 0;
            EDept.Text = "Choose Department";
            EDept.SelectedIndex =0;
            EReligion.SelectedIndex = 0;
            EPost.SelectedIndex = 0;

            EbtnDelete.Enabled = false;
            EbtnUpdate.Enabled = false;
            EbtnSave.Enabled = false;

        }

        private void cmbBoxMStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblstfExperience_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxstfExperience_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblstfBSalary_Click(object sender, EventArgs e)
        {

        }

        private void lnklblBrowse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                openFileDialog1.Title = "Select Image of Employee";
                openFileDialog1.ShowDialog();
                openFileDialog1.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files(*.*)|*.*";
                EPhoto.ImageLocation = openFileDialog1.FileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not Open Files:", ex.ToString());
            }
        }
        public String str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();

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

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (EID.Text == "" || EName.Text == "" || CitizenNo.Text == "" || MStatus.Text == ""|| EFName.Text == ""|| EMName.Text==""|| EPAdd.Text==""|| EReligion.Text=="" || EPost.Text==""|| EQualification.Text=="")
            {
               MessageBox.Show("Please Fill the Record Properly","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                if (string.IsNullOrEmpty(EID.Text))
                {
                    MessageBox.Show("Please enter Employee ID");
                    EID.Focus();
                    return;
                }
                else
                {
                    try
                    {
                        EPhoto.Image.Save(Application.StartupPath + "\\images\\" + EID.Text + ".jpg", ImageFormat.Jpeg);

                        SqlConnection conn = new SqlConnection(str);
                        SqlCommand cmd = new SqlCommand("insert into tbl_employee ([EID],[name],[citizen],[gender],[Mstatus],[DOB],[Fname],[Mname],[Padd],[Tadd],[contact],[religion],[dept],[dateofjoin],[exp],[email],[post],[acc],[salary],[qualification],[comment],[photo]) values('" + EID.Text + "','" + EName.Text + "','" + CitizenNo.Text + "','" + checkgender() + "','" + MStatus.Text + "','" + DOB.Text + "','" + EFName.Text + "','" + EMName.Text + "','" + EPAdd.Text + "','" + ETAdd.Text + "','" + EContact.Text + "','" + EReligion.Text + "','" + EDept.Text + "','" + Dateofjoining.Text + "','" + EExperience.Text + "','" + EEmail.Text + "','" + EPost.Text + "','" + EBankAcc.Text + "','" + EBSalary.Text + "','" + EQualification.Text + "','" + EComment.Text + "','" + EID.Text + "')", conn);

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Employee record inserted Succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

                        MessageBox.Show("Please choose Employee image","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                    

                }
              

            }

        }

        private void txtBoxstfID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EName.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void txtBoxstfName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CitizenNo.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void cmbBoxMStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DOB.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void cmbBoxGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MStatus.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void staffDOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EFName.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void txtBoxstfFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EMName.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void txtBoxstfMName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EPAdd.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void txtBoxstfPAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ETAdd.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void txtBoxstfTAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EContact.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void stfMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EReligion.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void stfTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void stfDept_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Dateofjoining.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void Dateofjoin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EExperience.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void stfExperience_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EEmail.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void stfEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EPost.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void stfBSalary_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == 13)
            {
                EQualification.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void stfDesignation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EbtnSave.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void stfQualification_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EComment.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void stfEmail_TextChanged(object sender, EventArgs e)
        {
            //if (EEmail.Text == "example@email.com")
            //{
            //    EEmail.ForeColor = System.Drawing.Color.Black;
            //    EEmail.Text = "";

            //}
        }

        private void stfEmail_Click(object sender, EventArgs e)
        {
            //EEmail.ForeColor = System.Drawing.Color.Black;
            //EEmail.Text = "";
        }

        private void stfBSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void CitizenNo_KeyPress(object sender, KeyPressEventArgs e)
        {

            //char ch = e.KeyChar;
            //if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 111 && ch != 109)
            //{
            //    e.Handled = true;
            //}
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            reset();

        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            frmEmployeeDataGridView obj = new frmEmployeeDataGridView();
            this.Hide();
            obj.Show();
           

        }

        private void EReligion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EDept.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void EPost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EBankAcc.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void EBankAcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EBSalary.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            string sql = "delete from tbl_employee where EID = '" + EID.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee " + EName.Text + " deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                reset();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Deletion Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("update tbl_employee set name='" + EName.Text + "',citizen='" + CitizenNo.Text + "',gender='" + checkgender().ToString() + "', Mstatus='" + MStatus.Text + "',DOB='" + DOB.Text + "',Fname='" + EFName.Text + "',Mname='" + EMName.Text + "', Padd='"+ EPAdd.Text +"', Tadd = '"+ ETAdd.Text +"', contact = '"+ EContact.Text +"', religion = '"+ EReligion.Text +"', dept = '"+ EDept.Text +"', dateofjoin = '"+ Dateofjoining.Text +"', exp = '"+ EExperience.Text +"', email = '"+ EEmail.Text +"', post = '"+ EPost.Text +"', acc = '"+ EBankAcc.Text +"', salary = '"+ EBSalary.Text +"', qualification = '"+ EQualification.Text +"', comment = '"+ EComment.Text +"', photo = '"+ EID.Text +"' where EID = '"+ EID.Text +"'", conn);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successful", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
               

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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_deptTableAdapter.FillBy(this.db_hamroschoolDataSet17.tbl_dept);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void reset()
        {
            EID.Text = "";
            EName.Text = "";
            CitizenNo.Text = "";

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            MStatus.SelectedIndex = 0;
            DOB.Text = DateTime.Now.ToShortDateString();
            EFName.Text = "";
            EMName.Text = "";
            EPAdd.Text = "";
            ETAdd.Text = "";
            EContact.Text = "";

            EDept.SelectedIndex = 0;
            Dateofjoining.Text = DateTime.Now.ToShortDateString();
            EExperience.Text = "";
            
            EEmail.Text = "";
            EPost.SelectedIndex = 0;
            EBankAcc.Text = "";
            EBSalary.Text = "";
            EComment.Text = "";
            EQualification.Text = "";

            EPhoto.ImageLocation = null;
        }

        private void EID_TextChanged(object sender, EventArgs e)
        {
            EbtnSave.Enabled = true;
        }
    }
}
