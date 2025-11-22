using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Lab4_24520535_24520506_24520507
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void webview_Click(object sender, EventArgs e)
        {

        }

        private async void Bai3_Load(object sender, EventArgs e)
        {
            await webview.EnsureCoreWebView2Async(null);
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if (webview.CoreWebView2 == null)
            {
                MessageBox.Show("WebView2 chưa sẵn sàng!");
                return;
            }

            string url = txt_address.Text.Trim();
            if (url != "")
                webview.CoreWebView2.Navigate(url);
        }

        private async void btn_downfiles_Click(object sender, EventArgs e)
        {

            try
            {
                var html = await webview.CoreWebView2
                    .ExecuteScriptAsync("document.documentElement.outerHTML;");

                html = System.Text.Json.JsonSerializer.Deserialize<string>(html);

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "HTML Files|*.html";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(save.FileName, html);
                    MessageBox.Show("Download HTML thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private async void btn_downresources_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy HTML
                string html = await webview.CoreWebView2
                    .ExecuteScriptAsync("document.documentElement.outerHTML;");
                html = System.Text.Json.JsonSerializer.Deserialize<string>(html);

                // 2. Parse HTML
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                var imgNodes = doc.DocumentNode.SelectNodes("//img");
                if (imgNodes == null)
                {
                    MessageBox.Show("Không tìm thấy hình ảnh!");
                    return;
                }

                FolderBrowserDialog fbd = new FolderBrowserDialog();
                if (fbd.ShowDialog() != DialogResult.OK) return;
                string folder = fbd.SelectedPath;

                WebClient wc = new WebClient();
                wc.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)");

                foreach (var img in imgNodes)
                {
                    try
                    {
                        string src = img.GetAttributeValue("src", "");
                        if (string.IsNullOrEmpty(src)) continue;

                        // Link tuyệt đối
                        if (!src.StartsWith("http"))
                        {
                            Uri baseUri = new Uri(txt_address.Text);
                            src = new Uri(baseUri, src).ToString();
                        }

                        string fileName = Path.GetFileName(src);
                        string savePath = Path.Combine(folder, fileName);

                        wc.DownloadFile(src, savePath);
                    }
                    catch (Exception exImg)
                    {
                        // Nếu 1 ảnh lỗi thì chỉ thông báo, không dừng cả chương trình
                        Console.WriteLine($"Lỗi tải ảnh: {exImg.Message}");
                    }
                }

                MessageBox.Show("Tải hình ảnh hoàn tất!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            webview.CoreWebView2.Reload();
        }
    }
}
    