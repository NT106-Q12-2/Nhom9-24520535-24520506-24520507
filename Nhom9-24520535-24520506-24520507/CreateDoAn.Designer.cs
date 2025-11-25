namespace Nhom9_24520535_24520506_24520507
{
    partial class CreateDoAn
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
         private System.Windows.Forms.Label lblTenMonAn;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblHinhAnh;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnAddMonAn;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTenMonAn = new Label();
            txtTenMonAn = new TextBox();
            lblGia = new Label();
            txtGia = new TextBox();
            lblMoTa = new Label();
            txtMoTa = new TextBox();
            lblHinhAnh = new Label();
            txtHinhAnh = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            btnAddMonAn = new Button();
            SuspendLayout();
            // 
            // lblTenMonAn
            // 
            lblTenMonAn.AutoSize = true;
            lblTenMonAn.Location = new Point(30, 30);
            lblTenMonAn.Name = "lblTenMonAn";
            lblTenMonAn.Size = new Size(104, 25);
            lblTenMonAn.TabIndex = 0;
            lblTenMonAn.Text = "Tên món ăn";
            // 
            // txtTenMonAn
            // 
            txtTenMonAn.Location = new Point(150, 27);
            txtTenMonAn.Name = "txtTenMonAn";
            txtTenMonAn.Size = new Size(300, 31);
            txtTenMonAn.TabIndex = 1;
            // 
            // lblGia
            // 
            lblGia.AutoSize = true;
            lblGia.Location = new Point(30, 70);
            lblGia.Name = "lblGia";
            lblGia.Size = new Size(37, 25);
            lblGia.TabIndex = 2;
            lblGia.Text = "Giá";
            // 
            // txtGia
            // 
            txtGia.Location = new Point(150, 67);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(300, 31);
            txtGia.TabIndex = 3;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(30, 110);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(59, 25);
            lblMoTa.TabIndex = 4;
            lblMoTa.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(150, 107);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(300, 60);
            txtMoTa.TabIndex = 5;
            // 
            // lblHinhAnh
            // 
            lblHinhAnh.AutoSize = true;
            lblHinhAnh.Location = new Point(30, 180);
            lblHinhAnh.Name = "lblHinhAnh";
            lblHinhAnh.Size = new Size(129, 25);
            lblHinhAnh.TabIndex = 6;
            lblHinhAnh.Text = "Hình ảnh (URL)";
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Location = new Point(150, 177);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(300, 31);
            txtHinhAnh.TabIndex = 7;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(30, 220);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(65, 25);
            lblDiaChi.TabIndex = 8;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(150, 217);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(300, 31);
            txtDiaChi.TabIndex = 9;
            // 
            // btnAddMonAn
            // 
            btnAddMonAn.Location = new Point(200, 270);
            btnAddMonAn.Name = "btnAddMonAn";
            btnAddMonAn.Size = new Size(120, 35);
            btnAddMonAn.TabIndex = 10;
            btnAddMonAn.Text = "Thêm món ăn";
            btnAddMonAn.Click += btnAddMonAn_Click;
            // 
            // CreateDoAn
            // 
            ClientSize = new Size(500, 327);
            Controls.Add(lblTenMonAn);
            Controls.Add(txtTenMonAn);
            Controls.Add(lblGia);
            Controls.Add(txtGia);
            Controls.Add(lblMoTa);
            Controls.Add(txtMoTa);
            Controls.Add(lblHinhAnh);
            Controls.Add(txtHinhAnh);
            Controls.Add(lblDiaChi);
            Controls.Add(txtDiaChi);
            Controls.Add(btnAddMonAn);
            Name = "CreateDoAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm Món Ăn";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
    }
}