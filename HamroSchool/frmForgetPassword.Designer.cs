namespace HamroSchool
{
    partial class frmForgetPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserType = new System.Windows.Forms.ComboBox();
            this.labeltype = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Labelpassword = new System.Windows.Forms.Label();
            this.Labelusername = new System.Windows.Forms.Label();
            this.FName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PhoneNo = new System.Windows.Forms.MaskedTextBox();
            this.lblstfTelephone = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.lblstfEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserType
            // 
            this.UserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserType.FormattingEnabled = true;
            this.UserType.Items.AddRange(new object[] {
            "Enter the Post",
            "Admin",
            "Student"});
            this.UserType.Location = new System.Drawing.Point(130, 148);
            this.UserType.Name = "UserType";
            this.UserType.Size = new System.Drawing.Size(158, 24);
            this.UserType.TabIndex = 13;
            // 
            // labeltype
            // 
            this.labeltype.AutoSize = true;
            this.labeltype.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltype.Location = new System.Drawing.Point(25, 151);
            this.labeltype.Name = "labeltype";
            this.labeltype.Size = new System.Drawing.Size(80, 19);
            this.labeltype.TabIndex = 12;
            this.labeltype.Text = "User Type : ";
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(130, 100);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(158, 23);
            this.Password.TabIndex = 11;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(130, 53);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(158, 23);
            this.Username.TabIndex = 10;
            // 
            // Labelpassword
            // 
            this.Labelpassword.AutoSize = true;
            this.Labelpassword.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelpassword.Location = new System.Drawing.Point(24, 102);
            this.Labelpassword.Name = "Labelpassword";
            this.Labelpassword.Size = new System.Drawing.Size(78, 19);
            this.Labelpassword.TabIndex = 9;
            this.Labelpassword.Text = "Password : ";
            // 
            // Labelusername
            // 
            this.Labelusername.AutoSize = true;
            this.Labelusername.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labelusername.Location = new System.Drawing.Point(24, 55);
            this.Labelusername.Name = "Labelusername";
            this.Labelusername.Size = new System.Drawing.Size(82, 19);
            this.Labelusername.TabIndex = 8;
            this.Labelusername.Text = "Username : ";
            // 
            // FName
            // 
            this.FName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FName.Location = new System.Drawing.Point(130, 12);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(158, 23);
            this.FName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Full Name";
            // 
            // PhoneNo
            // 
            this.PhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNo.Location = new System.Drawing.Point(130, 202);
            this.PhoneNo.Mask = "000000000";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Size = new System.Drawing.Size(158, 21);
            this.PhoneNo.TabIndex = 79;
            // 
            // lblstfTelephone
            // 
            this.lblstfTelephone.AutoSize = true;
            this.lblstfTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstfTelephone.Location = new System.Drawing.Point(25, 203);
            this.lblstfTelephone.Name = "lblstfTelephone";
            this.lblstfTelephone.Size = new System.Drawing.Size(98, 16);
            this.lblstfTelephone.TabIndex = 78;
            this.lblstfTelephone.Text = "Phone Number";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.DarkGray;
            this.Email.Location = new System.Drawing.Point(130, 248);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(158, 21);
            this.Email.TabIndex = 81;
            this.Email.Text = "example@email.com";
            // 
            // lblstfEmail
            // 
            this.lblstfEmail.AutoSize = true;
            this.lblstfEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstfEmail.Location = new System.Drawing.Point(25, 251);
            this.lblstfEmail.Name = "lblstfEmail";
            this.lblstfEmail.Size = new System.Drawing.Size(42, 16);
            this.lblstfEmail.TabIndex = 80;
            this.lblstfEmail.Text = "Email";
            // 
            // frmForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 324);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.lblstfEmail);
            this.Controls.Add(this.PhoneNo);
            this.Controls.Add(this.lblstfTelephone);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserType);
            this.Controls.Add(this.labeltype);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Labelpassword);
            this.Controls.Add(this.Labelusername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmForgetPassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forget  Password";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmForgetPassword_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UserType;
        private System.Windows.Forms.Label labeltype;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label Labelpassword;
        private System.Windows.Forms.Label Labelusername;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox PhoneNo;
        private System.Windows.Forms.Label lblstfTelephone;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label lblstfEmail;
    }
}