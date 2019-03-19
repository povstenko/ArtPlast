namespace StekloMaster
{
	partial class fMainDemo
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.tbxNewLogin = new System.Windows.Forms.TextBox();
            this.tbxNewSurname = new System.Windows.Forms.TextBox();
            this.tbxNewName = new System.Windows.Forms.TextBox();
            this.tbxNewEmail = new System.Windows.Forms.TextBox();
            this.chbxAdmin = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(123, 71);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(95, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxPassword);
            this.groupBox1.Controls.Add(this.tbxLogin);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "login";
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(9, 19);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(209, 20);
            this.tbxLogin.TabIndex = 1;
            this.tbxLogin.Text = "povstenko";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(9, 45);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(206, 20);
            this.tbxPassword.TabIndex = 2;
            this.tbxPassword.Text = "qwerty";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox2);
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(242, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 587);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "main";
            this.groupBox2.Visible = false;
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(123, 97);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(92, 23);
            this.btnRegistration.TabIndex = 3;
            this.btnRegistration.Text = "btnRegistration";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chbxAdmin);
            this.groupBox3.Controls.Add(this.tbxNewEmail);
            this.groupBox3.Controls.Add(this.tbxNewSurname);
            this.groupBox3.Controls.Add(this.tbxNewName);
            this.groupBox3.Controls.Add(this.tbxNewPassword);
            this.groupBox3.Controls.Add(this.btnRegistration);
            this.groupBox3.Controls.Add(this.tbxNewLogin);
            this.groupBox3.Location = new System.Drawing.Point(12, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 133);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "registration";
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.Location = new System.Drawing.Point(9, 45);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.Size = new System.Drawing.Size(100, 20);
            this.tbxNewPassword.TabIndex = 2;
            this.tbxNewPassword.Text = "qwerty";
            // 
            // tbxNewLogin
            // 
            this.tbxNewLogin.Location = new System.Drawing.Point(9, 19);
            this.tbxNewLogin.Name = "tbxNewLogin";
            this.tbxNewLogin.Size = new System.Drawing.Size(100, 20);
            this.tbxNewLogin.TabIndex = 1;
            this.tbxNewLogin.Text = "povstenko";
            // 
            // tbxNewSurname
            // 
            this.tbxNewSurname.Location = new System.Drawing.Point(115, 45);
            this.tbxNewSurname.Name = "tbxNewSurname";
            this.tbxNewSurname.Size = new System.Drawing.Size(100, 20);
            this.tbxNewSurname.TabIndex = 5;
            this.tbxNewSurname.Text = "Povstenko";
            // 
            // tbxNewName
            // 
            this.tbxNewName.Location = new System.Drawing.Point(115, 19);
            this.tbxNewName.Name = "tbxNewName";
            this.tbxNewName.Size = new System.Drawing.Size(100, 20);
            this.tbxNewName.TabIndex = 4;
            this.tbxNewName.Text = "Vitaly";
            // 
            // tbxNewEmail
            // 
            this.tbxNewEmail.Location = new System.Drawing.Point(9, 71);
            this.tbxNewEmail.Name = "tbxNewEmail";
            this.tbxNewEmail.Size = new System.Drawing.Size(206, 20);
            this.tbxNewEmail.TabIndex = 6;
            this.tbxNewEmail.Text = "vitaly.povstenko@gmail.com";
            // 
            // chbxAdmin
            // 
            this.chbxAdmin.AutoSize = true;
            this.chbxAdmin.Location = new System.Drawing.Point(9, 98);
            this.chbxAdmin.Name = "chbxAdmin";
            this.chbxAdmin.Size = new System.Drawing.Size(63, 17);
            this.chbxAdmin.TabIndex = 7;
            this.chbxAdmin.Text = "IsAdmin";
            this.chbxAdmin.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(718, 264);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(6, 291);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(718, 290);
            this.listBox2.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(46, 402);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "StekloShop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.TextBox tbxNewLogin;
        private System.Windows.Forms.CheckBox chbxAdmin;
        private System.Windows.Forms.TextBox tbxNewEmail;
        private System.Windows.Forms.TextBox tbxNewSurname;
        private System.Windows.Forms.TextBox tbxNewName;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnRefresh;
    }
}

