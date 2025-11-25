using Newtonsoft.Json;
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
using static Nhom9_24520535_24520506_24520507.Bai7;

namespace Nhom9_24520535_24520506_24520507
{
    public partial class SignUp : Form
    {

        public SignUp()
        {
            InitializeComponent();

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
        private void txtLanguage_TextChanged(object sender, EventArgs e)
        {
     
        }


        // Lớp request gửi đi
        public class UserCreateRequest
        {
            public string username { get; set; }
            public string email { get; set; }
            public string password { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public int sex { get; set; }
            public DateTime birthday { get; set; }
            public string language { get; set; }
            public string phone { get; set; }
        }

        // Lớp response nhận về
        public class UserResponse
        {
            public string id { get; set; }
            public string username { get; set; }
            public string email { get; set; }
            public bool email_verified { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
            public string avatar { get; set; }
            public int sex { get; set; }
            public DateTime birthday { get; set; }
            public string language { get; set; }
            public string phone { get; set; }
            public bool phone_verified { get; set; }
            public bool is_active { get; set; }
            public bool is_superuser { get; set; }
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            var client = ApiClient.Client;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var url = "https://nt106.uitiot.vn/api/v1/user/signup";

            var newUser = new UserCreateRequest
            {
                username = txtUsername.Text,
                email = txtEmail.Text,
                password = txtPassword.Text,
                first_name = txtFirstName.Text,
                last_name = txtLastName.Text,
                sex = cboSex.SelectedIndex,
                birthday = dtpBirthday.Value.Date,
                language = txtLanguage.Text,
                phone = txtPhone.Text
            };

            var json = JsonConvert.SerializeObject(newUser);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var userResponse = JsonConvert.DeserializeObject<UserResponse>(responseString);
                    MessageBox.Show($"Đăng kí thành công\n" +
                            $"ID: {userResponse.id}\n" +
                            $"Username: {userResponse.username}\n" +
                            $"Email: {userResponse.email}\n" +
                            $"Email Verified: {userResponse.email_verified}\n" +
                            $"First Name: {userResponse.first_name}\n" +
                            $"Last Name: {userResponse.last_name}\n" +
                            $"Avatar: {userResponse.avatar}\n" +
                            $"Sex: {userResponse.sex}\n" +
                            $"Birthday: {userResponse.birthday:yyyy-MM-dd}\n" +
                            $"Language: {userResponse.language}\n" +
                            $"Phone: {userResponse.phone}\n" +
                            $"Phone Verified: {userResponse.phone_verified}\n" +
                            $"Is Active: {userResponse.is_active}\n" +
                            $"Is Superuser: {userResponse.is_superuser}"
                        );
                }
                else
                {
                    if (response.Content.Headers.ContentType.MediaType == "application/json")
                    {
                        var errorResponse = JObject.Parse(responseString);
                        var details = errorResponse["detail"];
                        string msg = "Lỗi validation:\n";
                        foreach (var detail in details)
                        {
                            msg += $"- Vị trí: {string.Join(", ", detail["loc"])}\n";
                            msg += $"  Thông báo: {detail["msg"]}\n";
                            msg += $"  Loại lỗi: {detail["type"]}\n";
                        }
                        MessageBox.Show(msg);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi API: " + responseString);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ngoại lệ: " + ex.Message);
            }
        }
    }
}
