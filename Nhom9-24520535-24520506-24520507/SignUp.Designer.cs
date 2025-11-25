namespace Nhom9_24520535_24520506_24520507
{
    partial class SignUp
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            cboSex = new ComboBox();
            dtpBirthday = new DateTimePicker();
            txtLanguage = new TextBox();
            txtPhone = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(48, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(302, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Đăng Ký Tài Khoản";
            lblTitle.Click += lblTitle_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(30, 70);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(350, 31);
            txtUsername.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(30, 120);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(350, 31);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(30, 170);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(350, 31);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(30, 220);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(350, 31);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(30, 270);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(350, 31);
            txtLastName.TabIndex = 5;
            // 
            // cboSex
            // 
            cboSex.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboSex.Location = new Point(30, 320);
            cboSex.Name = "cboSex";
            cboSex.Size = new Size(350, 33);
            cboSex.TabIndex = 6;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Format = DateTimePickerFormat.Short;
            dtpBirthday.Location = new Point(30, 370);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(350, 31);
            dtpBirthday.TabIndex = 7;
            // 
            // txtLanguage
            // 
            txtLanguage.Location = new Point(30, 420);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.PlaceholderText = "Language";
            txtLanguage.Size = new Size(350, 31);
            txtLanguage.TabIndex = 8;
            txtLanguage.TextChanged += txtLanguage_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(30, 470);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "Phone";
            txtPhone.Size = new Size(350, 31);
            txtPhone.TabIndex = 9;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(120, 530);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(180, 40);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Đăng ký";
            btnRegister.Click += btnRegister_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 600);
            Controls.Add(lblTitle);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(cboSex);
            Controls.Add(dtpBirthday);
            Controls.Add(txtLanguage);
            Controls.Add(txtPhone);
            Controls.Add(btnRegister);
            Name = "SignUp";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnRegister;

        #endregion
    }
}
