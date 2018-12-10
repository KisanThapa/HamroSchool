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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        static int a=1;
        private void LabelPassword_Click(object sender, EventArgs e)
        {

        }

        private void LabelUsername_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
       public string str = ConfigurationManager.ConnectionStrings["myconnection"].ToString();
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (txtBoxusername.Text == "")
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxusername.Focus();
                return;
            }
            if (txtBoxpassword.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxpassword.Focus();
                return;
            }
            if (cmbBoxusertype.Text == ""||cmbBoxusertype.Text=="Enter the Post")
            {
                MessageBox.Show("Please select valid user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBoxusertype.Focus();
                return;
            }
           
            if(cmbBoxusertype.Text=="Admin"|| cmbBoxusertype.Text=="Lecturer"||cmbBoxusertype.Text=="Accountant")
            {
                if (a < 5)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(str);

                        SqlDataAdapter da = new SqlDataAdapter("select username, passwrd, usertype from tbl_userReg where username='" + txtBoxusername.Text + "' and passwrd ='" + txtBoxpassword.Text + "' and usertype='" + cmbBoxusertype.Text + "'", conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            
                            if (cmbBoxusertype.Text == "Admin")
                            {
                                frmMain obj = new frmMain();
                                obj.user.Text = cmbBoxusertype.Text;
                                obj.label4.Text = txtBoxusername.Text;
                                this.Hide();
                                obj.Show();

                            }
                            else if (cmbBoxusertype.Text == "Lecturer")
                            {
                                frmMain obj = new frmMain();
                                obj.user.Text = cmbBoxusertype.Text;
                                obj.label4.Text = txtBoxusername.Text;
                                this.Hide();
                                obj.Show();

                                obj.schoolEntryToolStripMenuItem.Enabled = false;
                                obj.classFeeEntryToolStripMenuItem.Enabled = false;
                                obj.sectionToolStripMenuItem.Enabled = false;
                                obj.departmentToolStripMenuItem.Enabled = false;
                                obj.bookEntryToolStripMenuItem.Enabled = true;
                                obj.bookDetailsToolStripMenuItem.Enabled = true;
                                obj.feeCategoryToolStripMenuItem.Enabled = false;
                                obj.classFeeEntryToolStripMenuItem.Enabled = false;
                                obj.subjectCategoryToolStripMenuItem.Enabled = false;

                                obj.deleteUserToolStripMenuItem.Enabled = false;
                                obj.loginDetailsToolStripMenuItem.Enabled = false;
                                obj.adminToolStripMenuItem.Enabled = false;

                                obj.profileEntryToolStripMenuItem.Enabled = false;
                            }
                            else if(cmbBoxusertype.Text=="Accountant")
                            {
                                frmMain obj = new frmMain();
                                obj.user.Text = cmbBoxusertype.Text;
                                obj.label4.Text = txtBoxusername.Text;
                                this.Hide();
                                obj.Show();
                            }

                            else
                            {
                                MessageBox.Show("Invalid! User Type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                cmbBoxusertype.SelectedIndex = 0;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalid! Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtBoxusername.Text = "";
                            txtBoxpassword.Text = "";
                            cmbBoxusertype.SelectedIndex = 0;
                            txtBoxusername.Focus();
                            a=a+1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("You Entered five times wrong input","Aborting",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid! User Type", "Warnig", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBoxusertype.SelectedIndex = 0;
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_hamroschoolDataSet22.tbl_dept' table. You can move, or remove it, as needed.
            this.tbl_deptTableAdapter.Fill(this.db_hamroschoolDataSet22.tbl_dept);
            cmbBoxusertype.SelectedIndex = 0;
        }

        private void textBoxusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBoxpassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBoxtype_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void forgetpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgetPassword obj = new frmForgetPassword();
            obj.Show();
            this.Hide();
        }

        private void txtBoxusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtBoxpassword.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void txtBoxpassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                cmbBoxusertype.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void cmbBoxusertype_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                btnLogin.Focus();
                e.Handled = true;
            }
            else
            {
                e.Handled = false;

            }
        }

        private void checkBoxshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxshowpassword.Checked)
            {
                txtBoxpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxpassword.UseSystemPasswordChar = true;
            }
        }

        private void txtBoxpassword_Enter(object sender, EventArgs e)
        {
            if (txtBoxpassword.ForeColor == Color.DarkGray)
            {
                txtBoxpassword.Clear();
                txtBoxpassword.ForeColor = Color.Black;
                txtBoxpassword.UseSystemPasswordChar = true;
            }
        }

        private void txtBoxusername_Leave(object sender, EventArgs e)
        {

            if (txtBoxusername.Text == "")
            {
                txtBoxusername.Text="Enter Username";
                txtBoxusername.ForeColor = Color.DarkGray;
                
            }
        }

        private void txtBoxusername_Enter(object sender, EventArgs e)
        {
            if(txtBoxusername.ForeColor==Color.DarkGray)
            {
                txtBoxusername.Clear();
                txtBoxusername.ForeColor = Color.Black;
            }
          
        }

        private void txtBoxpassword_Leave(object sender, EventArgs e)
        {
            if (txtBoxpassword.Text == "")
            {
                txtBoxpassword.Text = "Enter Password";
                txtBoxpassword.ForeColor = Color.DarkGray;
                txtBoxpassword.UseSystemPasswordChar = false;
            }
        }
    }
}