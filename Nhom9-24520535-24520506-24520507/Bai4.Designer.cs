namespace Nhom9_24520535_24520506_24520507
{
    partial class Bai4
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
            dGView_info = new DataGridView();
            Img = new DataGridViewImageColumn();
            MovieName = new DataGridViewTextBoxColumn();
            MovieDescription = new DataGridViewTextBoxColumn();
            URL = new DataGridViewLinkColumn();
            Progress_Start = new ProgressBar();
            btn_download = new Button();
            ((System.ComponentModel.ISupportInitialize)dGView_info).BeginInit();
            SuspendLayout();
            // 
            // dGView_info
            // 
            dGView_info.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGView_info.Columns.AddRange(new DataGridViewColumn[] { Img, MovieName, MovieDescription, URL });
            dGView_info.Location = new Point(12, -9);
            dGView_info.Name = "dGView_info";
            dGView_info.RowHeadersWidth = 62;
            dGView_info.RowTemplate.Height = 600;
            dGView_info.Size = new Size(1069, 633);
            dGView_info.TabIndex = 1;
            dGView_info.CellContentClick += dGView_info_CellContentClick;
            // 
            // Img
            // 
            Img.FillWeight = 400F;
            Img.HeaderText = "Poster";
            Img.MinimumWidth = 8;
            Img.Name = "Img";
            Img.ReadOnly = true;
            Img.Width = 400;
            // 
            // MovieName
            // 
            MovieName.FillWeight = 22.5398788F;
            MovieName.HeaderText = "Tên phim";
            MovieName.MinimumWidth = 8;
            MovieName.Name = "MovieName";
            MovieName.ReadOnly = true;
            MovieName.Width = 150;
            // 
            // MovieDescription
            // 
            MovieDescription.FillWeight = 165.2584F;
            MovieDescription.HeaderText = "Description";
            MovieDescription.MinimumWidth = 8;
            MovieDescription.Name = "MovieDescription";
            MovieDescription.ReadOnly = true;
            MovieDescription.Width = 150;
            // 
            // URL
            // 
            URL.FillWeight = 1209.09082F;
            URL.HeaderText = "Link Phim";
            URL.MinimumWidth = 8;
            URL.Name = "URL";
            URL.Width = 400;
            // 
            // Progress_Start
            // 
            Progress_Start.Location = new Point(601, 644);
            Progress_Start.Name = "Progress_Start";
            Progress_Start.Size = new Size(480, 63);
            Progress_Start.TabIndex = 2;
            Progress_Start.Click += Progress_Dowload_Click;
            // 
            // btn_download
            // 
            btn_download.Location = new Point(114, 644);
            btn_download.Name = "btn_download";
            btn_download.Size = new Size(366, 63);
            btn_download.TabIndex = 3;
            btn_download.Text = "Download";
            btn_download.UseVisualStyleBackColor = true;
            btn_download.Click += btn_download_Click;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 755);
            Controls.Add(btn_download);
            Controls.Add(Progress_Start);
            Controls.Add(dGView_info);
            Name = "Bai4";
            Text = "Bai4";
            ((System.ComponentModel.ISupportInitialize)dGView_info).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dGView_info;
        private DataGridViewImageColumn Img;
        private DataGridViewTextBoxColumn MovieName;
        private DataGridViewTextBoxColumn MovieDescription;
        private DataGridViewLinkColumn URL;
        private ProgressBar Progress_Start;
        private Button btn_download;
    }
}