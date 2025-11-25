using HtmlAgilityPack;
using HtmlAgilityPack.CssSelectors.NetCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Nhom9_24520535_24520506_24520507.Bai4;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nhom9_24520535_24520506_24520507
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        public class Movie
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string ImageUrl { get; set; }
            public string MovieUrl { get; set; }

        };
        public class CustomID
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Ticket { get; set; }
        }
        public List<Movie> listDataExport = new List<Movie>();
        bool is_dowload = false;
        const string baseURL = "https://betacinemas.vn/";
        public void GetHTML()
        {
            try
            {
                HtmlWeb html = new HtmlWeb()
                {
                    AutoDetectEncoding = false,
                    OverrideEncoding = Encoding.UTF8
                };

                var document = html.Load("https://betacinemas.vn/home.htm");


                var movieBlock = document
                    .DocumentNode
                    .QuerySelectorAll(".col-lg-16.col-md-16.col-sm-8.col-xs-8");

                for (int i = 0; i < movieBlock.Count; i += 2)
                {
                    var imageBlock = movieBlock[i];
                    var temp_movie = new Movie();
                    // image URL
                    var imgNode = imageBlock.QuerySelector("div.pi-img-wrapper img.img-responsive.border-radius-20");
                    string imgUrl = imgNode?.GetAttributeValue("src", "");
                    if (!string.IsNullOrEmpty(imgUrl) && imgUrl.StartsWith("/"))
                        imgUrl = "https://betacinemas.vn" + imgUrl;
                    temp_movie.ImageUrl = imgUrl;

                    if (i + 1 < movieBlock.Count)
                    {
                        var infoBlock = movieBlock[i + 1];
                        var infoNode = infoBlock.QuerySelector(".film-info.film-xs-info");

                        if (infoNode != null)
                        {
                            // Title & URL
                            var nameNode = infoNode.QuerySelector("h3 a");
                            temp_movie.Name = nameNode?.InnerText.Trim() ?? "";
                            temp_movie.MovieUrl = nameNode != null
                                ? "https://betacinemas.vn" + nameNode.GetAttributeValue("href", "")
                                : "";
                            // Description
                            var descNodes = infoNode.QuerySelectorAll("span");
                            string desc = "";
                            if (descNodes != null)
                            {
                                foreach (var node in descNodes)
                                {
                                    desc += node.InnerText.Trim() + " ";
                                    var nextNode = node.NextSibling;
                                    desc += Regex.Replace(nextNode.InnerText.Trim(), @"\s+", " ").Trim() + "\r\n";
                                }
                            }
                            temp_movie.Description = desc;
                        }
                    }
                    listDataExport.Add(temp_movie);
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void dGView_info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 0)
            {
                string url = dGView_info.Rows[e.RowIndex].Cells[3].Value.ToString();

                if (!string.IsNullOrEmpty(url))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
            }
        }
        private void Progress_Dowload_Click(object sender, EventArgs e)
        {

        }
        private void btn_download_Click(object sender, EventArgs e)
        {
            if (is_dowload == false)
            {
                is_dowload = true;
                GetHTML();

                dGView_info.Rows.Clear();
                Progress_Start.Minimum = 0;
                Progress_Start.Maximum = listDataExport.Count;
                Progress_Start.Value = 0;

                foreach (var movie in listDataExport)
                {
                    Image img = null;
                    using (WebClient wc = new WebClient())
                    {
                        byte[] bytes = wc.DownloadData(movie.ImageUrl);
                        using (var ms = new System.IO.MemoryStream(bytes))
                        {
                            img = Image.FromStream(ms);
                        }
                    }
                    dGView_info.Rows.Add(img,
                                           movie.Name ?? "",
                                           movie.Description ?? "",
                                           movie.MovieUrl ?? "");

                    Progress_Start.Value += 1;
                }
            } else
            {
                MessageBox.Show("Đã download");
            }

        }
    }
}
