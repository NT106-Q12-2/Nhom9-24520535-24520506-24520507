using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Nhom9_24520535_24520506_24520507.Bai7;

namespace Nhom9_24520535_24520506_24520507
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void bt_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                await Main();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private async Task Main()
        {
            var client = ApiClient.Client;
            var url = "https://nt106.uitiot.vn/auth/token";
            var username = tb_userName.Text;
            var password = tb_passWord.Text;


            var content = new MultipartFormDataContent
            {
                { new StringContent(username), "username" },
                { new StringContent(password), "password" }
            };
            // Xóa Accept cũ để không bị duplicate
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.PostAsync(url, content);
            var responseString = await response.Content.ReadAsStringAsync();

            var responseObject = JObject.Parse(responseString);

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Lỗi Đăng nhập: { response.StatusCode}");
                return;
            }

            var tokenType = responseObject["token_type"]?.ToString();
            var accessToken = responseObject["access_token"]?.ToString();
            var refreshToken = responseObject["refresh_token"]?.ToString();

            if (string.IsNullOrEmpty(accessToken))
            {
                MessageBox.Show("không nhận được token");
                return;
            }
            Global.TokenType = tokenType;
            Global.AccessToken = accessToken;
            Global.RefreshToken = refreshToken;
            client.DefaultRequestHeaders.Authorization = new
            System.Net.Http.Headers.AuthenticationHeaderValue(tokenType, accessToken);
            MessageBox.Show("Đăng nhập thành công");
            Control c = new Control();
            c.Show();
            this.Hide();
        }
    }
}