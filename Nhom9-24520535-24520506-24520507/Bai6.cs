using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Nhom9_24520535_24520506_24520507
{
    public partial class Bai6 : Form
    {
        public Bai6()
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

                client.DefaultRequestHeaders.Authorization = new
                System.Net.Http.Headers.AuthenticationHeaderValue(tokenType, accessToken);

                client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

                var getUserUrl = based + "/api/v1/user/me";
                var getUserResponse = await client.GetAsync(getUserUrl);
                var getUserResponseString = await getUserResponse.Content.ReadAsStringAsync();
                rtb_KetQua.Text += getUserResponseString;
            }
        }
    }
}
