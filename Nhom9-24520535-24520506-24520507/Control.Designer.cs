namespace Nhom9_24520535_24520506_24520507
{
    partial class Control
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
            bt_ThemMon = new Button();
            tabControlDoAn = new TabControl();
            tabPageALL = new TabPage();
            tabPageMy = new TabPage();
            tabControlDoAn.SuspendLayout();
            SuspendLayout();
            // 
            // bt_ThemMon
            // 
            bt_ThemMon.Location = new Point(727, 26);
            bt_ThemMon.Name = "bt_ThemMon";
            bt_ThemMon.Size = new Size(198, 80);
            bt_ThemMon.TabIndex = 0;
            bt_ThemMon.Text = "Thêm Món Ăn";
            bt_ThemMon.UseVisualStyleBackColor = true;
            bt_ThemMon.Click += bt_ThemMon_Click;
            // 
            // tabControlDoAn
            // 
            tabControlDoAn.Controls.Add(tabPageALL);
            tabControlDoAn.Controls.Add(tabPageMy);
            tabControlDoAn.Location = new Point(42, 211);
            tabControlDoAn.Name = "tabControlDoAn";
            tabControlDoAn.SelectedIndex = 0;
            tabControlDoAn.Size = new Size(795, 490);
            tabControlDoAn.TabIndex = 1;
            tabControlDoAn.Tag = "ALL";
            // 
            // tabPageALL
            // 
            tabPageALL.Location = new Point(4, 42);
            tabPageALL.Name = "tabPageALL";
            tabPageALL.Padding = new Padding(3);
            tabPageALL.Size = new Size(787, 444);
            tabPageALL.TabIndex = 0;
            tabPageALL.Text = "ALL";
            tabPageALL.UseVisualStyleBackColor = true;
            tabPageALL.Click += tabPageALL_Click;
            // 
            // tabPageMy
            // 
            tabPageMy.Location = new Point(4, 34);
            tabPageMy.Name = "tabPageMy";
            tabPageMy.Padding = new Padding(3);
            tabPageMy.Size = new Size(787, 452);
            tabPageMy.TabIndex = 1;
            tabPageMy.Text = "Của tôi";
            tabPageMy.UseVisualStyleBackColor = true;
            // 
            // Control
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 748);
            Controls.Add(tabControlDoAn);
            Controls.Add(bt_ThemMon);
            Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Control";
            Text = "Control";
            tabControlDoAn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button bt_ThemMon;
        private TabControl tabControlDoAn;
        private TabPage tabPageALL;
        private TabPage tabPageMy;
    }
}