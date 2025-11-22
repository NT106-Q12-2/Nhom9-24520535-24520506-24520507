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
            SuspendLayout();
            // 
            // btn_bai2
            // 
            btn_bai2.Location = new Point(95, 173);
            btn_bai2.Name = "btn_bai2";
            btn_bai2.Size = new Size(178, 71);
            btn_bai2.TabIndex = 0;
            btn_bai2.Text = "Bài 2";
            btn_bai2.UseVisualStyleBackColor = true;
            btn_bai2.Click += btn_bai2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_bai2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_bai2;
    }
}
