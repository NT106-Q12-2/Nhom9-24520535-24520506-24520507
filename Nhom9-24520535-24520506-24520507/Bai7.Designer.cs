namespace Nhom9_24520535_24520506_24520507
{
    partial class Bai7
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
            lb_TieuDe = new Label();
            bt_TaoTaiKhoan = new Button();
            lb_TieuDe2 = new Label();
            bt_DangNhap = new Button();
            lb_tieuDe3 = new Label();
            SuspendLayout();
            // 
            // lb_TieuDe
            // 
            lb_TieuDe.Location = new Point(12, 211);
            lb_TieuDe.Name = "lb_TieuDe";
            lb_TieuDe.Size = new Size(675, 38);
            lb_TieuDe.TabIndex = 0;
            lb_TieuDe.Text = "Bạn chưa có tài khoản?";
            lb_TieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bt_TaoTaiKhoan
            // 
            bt_TaoTaiKhoan.Location = new Point(494, 198);
            bt_TaoTaiKhoan.Name = "bt_TaoTaiKhoan";
            bt_TaoTaiKhoan.Size = new Size(318, 65);
            bt_TaoTaiKhoan.TabIndex = 1;
            bt_TaoTaiKhoan.Text = "-----Tạo tài khoản-----";
            bt_TaoTaiKhoan.UseVisualStyleBackColor = true;
            bt_TaoTaiKhoan.Click += bt_TaoTaiKhoan_Click;
            // 
            // lb_TieuDe2
            // 
            lb_TieuDe2.Location = new Point(12, 391);
            lb_TieuDe2.Name = "lb_TieuDe2";
            lb_TieuDe2.Size = new Size(675, 38);
            lb_TieuDe2.TabIndex = 2;
            lb_TieuDe2.Text = "Bạn đã có tài khoản?";
            lb_TieuDe2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bt_DangNhap
            // 
            bt_DangNhap.Location = new Point(494, 378);
            bt_DangNhap.Name = "bt_DangNhap";
            bt_DangNhap.Size = new Size(318, 65);
            bt_DangNhap.TabIndex = 3;
            bt_DangNhap.Text = "-----Đăng nhập-----";
            bt_DangNhap.UseVisualStyleBackColor = true;
            bt_DangNhap.Click += DangNhap_Click;
            // 
            // lb_tieuDe3
            // 
            lb_tieuDe3.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_tieuDe3.Location = new Point(12, 9);
            lb_tieuDe3.Name = "lb_tieuDe3";
            lb_tieuDe3.Size = new Size(1176, 93);
            lb_tieuDe3.TabIndex = 4;
            lb_tieuDe3.Text = "Hôm nay ăn gi?";
            lb_tieuDe3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Bai7
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1200, 594);
            Controls.Add(lb_tieuDe3);
            Controls.Add(bt_DangNhap);
            Controls.Add(lb_TieuDe2);
            Controls.Add(bt_TaoTaiKhoan);
            Controls.Add(lb_TieuDe);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Bai7";
            Text = "Bai7";
            ResumeLayout(false);
        }

        #endregion

        private Label lb_TieuDe;
        private Button bt_TaoTaiKhoan;
        private Label lb_TieuDe2;
        private Button bt_DangNhap;
        private Label lb_tieuDe3;
    }
}