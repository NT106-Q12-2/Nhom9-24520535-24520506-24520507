using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom9_24520535_24520506_24520507
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private async void bt_Login_Click(object sender, EventArgs e)
        {
            await Main();
        }

        private async Task Main()
        {
            var based = tb_URL.Text;
            var url = based + "/auth/token";
            var username = tb_username.Text; 
            var password = tb_password.Text;
            using (var client = new HttpClient())
            {
                var content = new MultipartFormDataContent
                {
                    { new StringContent(username), "username" },
                    { new StringContent(password), "password" }
                };

                var response = await client.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    rtb_KetQua.Text = responseString;
                    return;
                }
                var responseObject = JObject.Parse(responseString);

                if (!response.IsSuccessStatusCode)
                {
                    var detail = responseObject["detail"].ToString();
                    rtb_KetQua.Text = detail;
                    return;
                }
               
                var tokenType = responseObject["token_type"].ToString();
                var accessToken = responseObject["access_token"].ToString();
                if (string.IsNullOrEmpty(accessToken))
                {
                    rtb_KetQua.Text = "Không nhận được access token!";
                    return;
                }

                rtb_KetQua.Text = $"{tokenType} {accessToken}\nĐăng nhập thành công";
            }
        }
    }
}
