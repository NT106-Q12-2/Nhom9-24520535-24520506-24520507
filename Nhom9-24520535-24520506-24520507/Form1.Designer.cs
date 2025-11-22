namespace Nhom9_24520535_24520506_24520507
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_bai2 = new Button();
            btn_bai3 = new Button();
            btn_bai1 = new Button();
            SuspendLayout();
            // 
            // btn_bai2
            // 
            btn_bai2.Location = new Point(78, 176);
            btn_bai2.Name = "btn_bai2";
            btn_bai2.Size = new Size(178, 71);
            btn_bai2.TabIndex = 0;
            btn_bai2.Text = "Bài 2";
            btn_bai2.UseVisualStyleBackColor = true;
            btn_bai2.Click += btn_bai2_Click;
            // 
            // btn_bai3
            // 
            btn_bai3.Location = new Point(460, 23);
            btn_bai3.Name = "btn_bai3";
            btn_bai3.Size = new Size(178, 71);
            btn_bai3.TabIndex = 1;
            btn_bai3.Text = "Bài 3";
            btn_bai3.UseVisualStyleBackColor = true;
            btn_bai3.Click += btn_bai3_Click;
            // 
            // btn_bai1
            // 
            btn_bai1.Location = new Point(78, 23);
            btn_bai1.Name = "btn_bai1";
            btn_bai1.Size = new Size(178, 71);
            btn_bai1.TabIndex = 2;
            btn_bai1.Text = "Bài 1";
            btn_bai1.UseVisualStyleBackColor = true;
            btn_bai1.Click += btn_bai1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_bai1);
            Controls.Add(btn_bai3);
            Controls.Add(btn_bai2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_bai2;
        private Button btn_bai3;
        private Button btn_bai1;
    }
}
