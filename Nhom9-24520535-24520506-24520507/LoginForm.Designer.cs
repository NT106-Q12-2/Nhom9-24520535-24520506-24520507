namespace Nhom9_24520535_24520506_24520507
{
    partial class LoginForm
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
            lb_Login = new Label();
            lb_username = new Label();
            tb_userName = new TextBox();
            lb_passWord = new Label();
            tb_passWord = new TextBox();
            bt_DangNhap = new Button();
            SuspendLayout();
            // 
            // lb_Login
            // 
            lb_Login.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_Login.Location = new Point(12, 47);
            lb_Login.Name = "lb_Login";
            lb_Login.Size = new Size(1176, 79);
            lb_Login.TabIndex = 0;
            lb_Login.Text = "Đăng Nhập";
            lb_Login.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_username
            // 
            lb_username.Location = new Point(12, 199);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(675, 38);
            lb_username.TabIndex = 1;
            lb_username.Text = "UserName";
            lb_username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_userName
            // 
            tb_userName.Location = new Point(527, 199);
            tb_userName.Name = "tb_userName";
            tb_userName.Size = new Size(462, 40);
            tb_userName.TabIndex = 2;
            // 
            // lb_passWord
            // 
            lb_passWord.Location = new Point(12, 311);
            lb_passWord.Name = "lb_passWord";
            lb_passWord.Size = new Size(675, 38);
            lb_passWord.TabIndex = 3;
            lb_passWord.Text = "PassWord";
            lb_passWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_passWord
            // 
            tb_passWord.Location = new Point(527, 311);
            tb_passWord.Name = "tb_passWord";
            tb_passWord.Size = new Size(462, 40);
            tb_passWord.TabIndex = 4;
            // 
            // bt_DangNhap
            // 
            bt_DangNhap.Location = new Point(527, 446);
            bt_DangNhap.Name = "bt_DangNhap";
            bt_DangNhap.Size = new Size(205, 69);
            bt_DangNhap.TabIndex = 5;
            bt_DangNhap.Text = "Đăng Nhập";
            bt_DangNhap.UseVisualStyleBackColor = true;
            bt_DangNhap.Click += bt_DangNhap_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 594);
            Controls.Add(bt_DangNhap);
            Controls.Add(tb_passWord);
            Controls.Add(lb_passWord);
            Controls.Add(tb_userName);
            Controls.Add(lb_username);
            Controls.Add(lb_Login);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Login;
        private Label lb_username;
        private TextBox tb_userName;
        private Label lb_passWord;
        private TextBox tb_passWord;
        private Button bt_DangNhap;
    }
}