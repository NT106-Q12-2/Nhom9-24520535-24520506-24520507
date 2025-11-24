namespace Nhom9_24520535_24520506_24520507
{
    partial class Bai6
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
            lb_URL = new Label();
            tb_URL = new TextBox();
            lb_username = new Label();
            tb_username = new TextBox();
            lb_password = new Label();
            tb_password = new TextBox();
            rtb_KetQua = new RichTextBox();
            bt_Login = new Button();
            SuspendLayout();
            // 
            // lb_URL
            // 
            lb_URL.AutoSize = true;
            lb_URL.Location = new Point(94, 75);
            lb_URL.Name = "lb_URL";
            lb_URL.Size = new Size(69, 33);
            lb_URL.TabIndex = 1;
            lb_URL.Text = "URL";
            // 
            // tb_URL
            // 
            tb_URL.Location = new Point(263, 72);
            tb_URL.Name = "tb_URL";
            tb_URL.Size = new Size(545, 40);
            tb_URL.TabIndex = 2;
            // 
            // lb_username
            // 
            lb_username.Location = new Point(43, 165);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(173, 33);
            lb_username.TabIndex = 3;
            lb_username.Text = "UserName";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(263, 165);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(545, 40);
            tb_username.TabIndex = 4;
            // 
            // lb_password
            // 
            lb_password.Location = new Point(43, 263);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(173, 33);
            lb_password.TabIndex = 5;
            lb_password.Text = "PassWord";
            // 
            // tb_password
            // 
            tb_password.Location = new Point(263, 263);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(545, 40);
            tb_password.TabIndex = 6;
            // 
            // rtb_KetQua
            // 
            rtb_KetQua.Location = new Point(43, 364);
            rtb_KetQua.Name = "rtb_KetQua";
            rtb_KetQua.Size = new Size(784, 218);
            rtb_KetQua.TabIndex = 7;
            rtb_KetQua.Text = "";
            // 
            // bt_Login
            // 
            bt_Login.Location = new Point(958, 169);
            bt_Login.Name = "bt_Login";
            bt_Login.Size = new Size(185, 134);
            bt_Login.TabIndex = 8;
            bt_Login.Text = "Login";
            bt_Login.UseVisualStyleBackColor = true;
            bt_Login.Click += bt_Login_Click;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 594);
            Controls.Add(bt_Login);
            Controls.Add(rtb_KetQua);
            Controls.Add(tb_password);
            Controls.Add(lb_password);
            Controls.Add(tb_username);
            Controls.Add(lb_username);
            Controls.Add(tb_URL);
            Controls.Add(lb_URL);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Bai6";
            Text = "Bai6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_URL;
        private TextBox tb_URL;
        private Label lb_username;
        private TextBox tb_username;
        private Label lb_password;
        private TextBox tb_password;
        private RichTextBox rtb_KetQua;
        private Button bt_Login;
    }
}