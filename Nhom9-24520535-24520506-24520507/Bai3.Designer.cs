namespace Lab4_24520535_24520506_24520507
{
    partial class Bai3
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
            txt_address = new TextBox();
            btn_load = new Button();
            btn_downfiles = new Button();
            btn_downresources = new Button();
            btn_reload = new Button();
            webview = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webview).BeginInit();
            SuspendLayout();
            // 
            // txt_address
            // 
            txt_address.Location = new Point(150, 14);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(491, 27);
            txt_address.TabIndex = 0;
            // 
            // btn_load
            // 
            btn_load.Location = new Point(12, 12);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(94, 29);
            btn_load.TabIndex = 1;
            btn_load.Text = "Load";
            btn_load.UseVisualStyleBackColor = true;
            btn_load.Click += btn_load_Click;
            // 
            // btn_downfiles
            // 
            btn_downfiles.Location = new Point(469, 76);
            btn_downfiles.Name = "btn_downfiles";
            btn_downfiles.Size = new Size(94, 29);
            btn_downfiles.TabIndex = 2;
            btn_downfiles.Text = "Down Files";
            btn_downfiles.UseVisualStyleBackColor = true;
            btn_downfiles.Click += btn_downfiles_Click;
            // 
            // btn_downresources
            // 
            btn_downresources.Location = new Point(595, 76);
            btn_downresources.Name = "btn_downresources";
            btn_downresources.Size = new Size(183, 29);
            btn_downresources.TabIndex = 3;
            btn_downresources.Text = "Down Resources";
            btn_downresources.UseVisualStyleBackColor = true;
            btn_downresources.Click += btn_downresources_Click;
            // 
            // btn_reload
            // 
            btn_reload.Location = new Point(684, 14);
            btn_reload.Name = "btn_reload";
            btn_reload.Size = new Size(94, 29);
            btn_reload.TabIndex = 4;
            btn_reload.Text = "Reload";
            btn_reload.UseVisualStyleBackColor = true;
            btn_reload.Click += btn_reload_Click;
            // 
            // webview
            // 
            webview.AllowExternalDrop = true;
            webview.CreationProperties = null;
            webview.DefaultBackgroundColor = Color.White;
            webview.Location = new Point(38, 118);
            webview.Name = "webview";
            webview.Size = new Size(720, 320);
            webview.TabIndex = 5;
            webview.ZoomFactor = 1D;
            webview.Click += webview_Click;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(webview);
            Controls.Add(btn_reload);
            Controls.Add(btn_downresources);
            Controls.Add(btn_downfiles);
            Controls.Add(btn_load);
            Controls.Add(txt_address);
            Name = "Bai3";
            Text = "Bai3";
            Load += Bai3_Load;
            ((System.ComponentModel.ISupportInitialize)webview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_address;
        private Button btn_load;
        private Button btn_downfiles;
        private Button btn_downresources;
        private Button btn_reload;
        private Microsoft.Web.WebView2.WinForms.WebView2 webview;
    }
}