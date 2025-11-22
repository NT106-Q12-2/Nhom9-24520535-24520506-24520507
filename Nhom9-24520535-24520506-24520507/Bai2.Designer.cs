namespace Nhom9_24520535_24520506_24520507
{
    partial class Bai2
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
            txtURl = new TextBox();
            txtFilePath = new TextBox();
            btn_Download = new Button();
            rtb_context = new RichTextBox();
            SuspendLayout();
            // 
            // txtURl
            // 
            txtURl.Location = new Point(100, 12);
            txtURl.Name = "txtURl";
            txtURl.Size = new Size(373, 27);
            txtURl.TabIndex = 0;
            txtURl.TextChanged += txtURl_TextChanged;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(100, 58);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(373, 27);
            txtFilePath.TabIndex = 1;
            // 
            // btn_Download
            // 
            btn_Download.Location = new Point(560, 12);
            btn_Download.Name = "btn_Download";
            btn_Download.Size = new Size(94, 29);
            btn_Download.TabIndex = 2;
            btn_Download.Text = "Download";
            btn_Download.UseVisualStyleBackColor = true;
            btn_Download.Click += btn_Download_Click;
            // 
            // rtb_context
            // 
            rtb_context.Location = new Point(100, 150);
            rtb_context.Name = "rtb_context";
            rtb_context.Size = new Size(554, 260);
            rtb_context.TabIndex = 4;
            rtb_context.Text = "";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtb_context);
            Controls.Add(btn_Download);
            Controls.Add(txtFilePath);
            Controls.Add(txtURl);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtURl;
        private TextBox txtFilePath;
        private Button btn_Download;
        private RichTextBox rtb_context;
    }
}