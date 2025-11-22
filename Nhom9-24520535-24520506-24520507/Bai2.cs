using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Tar;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Nhom9_24520535_24520506_24520507
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btn_Download_Click(object sender, EventArgs e)
        {
            try
            {
                string url = txtURl.Text;       // URL cần download
                string fileUrl = txtFilePath.Text;  // Đường dẫn lưu file HTML

                if (url == "" || fileUrl == "")
                {
                    MessageBox.Show("Vui lòng nhập URL và đường dẫn file!");
                    return;
                }

                // Khởi tạo WebClient
                WebClient myClient = new WebClient();

                // Đọc nội dung web vào Stream (OpenRead)
                Stream response = myClient.OpenRead(url);

                // Tải file về theo đường dẫn mà user nhập
                myClient.DownloadFile(url, fileUrl);

                // Đọc nội dung file đã lưu để hiển thị
                string html = File.ReadAllText(fileUrl);
                rtb_context.Text = html;

                MessageBox.Show("Download thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txtURl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
