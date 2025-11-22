namespace Lab4_24520535_24520506_24520507
{
    partial class Bai1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private void InitializeComponent()
        {
            tb_URL = new TextBox();
            lb_URL = new Label();
            bt_Get = new Button();
            rtb_NoiDung = new RichTextBox();
            lb_NoiDung = new Label();
            SuspendLayout();
            // 
            // tb_URL
            // 
            tb_URL.Location = new Point(12, 56);
            tb_URL.Name = "tb_URL";
            tb_URL.Size = new Size(665, 40);
            tb_URL.TabIndex = 0;
            // 
            // lb_URL
            // 
            lb_URL.AutoSize = true;
            lb_URL.Location = new Point(12, 9);
            lb_URL.Name = "lb_URL";
            lb_URL.Size = new Size(252, 33);
            lb_URL.TabIndex = 1;
            lb_URL.Text = "Hãy nhập đường dẫn ";
            lb_URL.Click += lb_URL_Click;
            // 
            // bt_Get
            // 
            bt_Get.Location = new Point(868, 51);
            bt_Get.Name = "bt_Get";
            bt_Get.Size = new Size(176, 49);
            bt_Get.TabIndex = 2;
            bt_Get.Text = "Get";
            bt_Get.UseVisualStyleBackColor = true;
            bt_Get.Click += bt_Get_Click;
            // 
            // rtb_NoiDung
            // 
            rtb_NoiDung.Location = new Point(6, 170);
            rtb_NoiDung.Name = "rtb_NoiDung";
            rtb_NoiDung.Size = new Size(810, 412);
            rtb_NoiDung.TabIndex = 3;
            rtb_NoiDung.Text = "";
            // 
            // lb_NoiDung
            // 
            lb_NoiDung.AutoSize = true;
            lb_NoiDung.Location = new Point(12, 119);
            lb_NoiDung.Name = "lb_NoiDung";
            lb_NoiDung.Size = new Size(208, 33);
            lb_NoiDung.TabIndex = 4;
            lb_NoiDung.Text = "Nội dung HTML ";
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 594);
            Controls.Add(lb_NoiDung);
            Controls.Add(rtb_NoiDung);
            Controls.Add(bt_Get);
            Controls.Add(lb_URL);
            Controls.Add(tb_URL);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Bai1";
            Text = "Bai1";
            Load += Bai1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        #endregion

        private TextBox tb_URL;
        private Label lb_URL;
        private Button bt_Get;
        private RichTextBox rtb_NoiDung;
        private Label lb_NoiDung;
    }
}
