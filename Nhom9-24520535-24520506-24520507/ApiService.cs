using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static Nhom9_24520535_24520506_24520507.ApiService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Nhom9_24520535_24520506_24520507
{
    public class ApiService
    {
        private readonly HttpClient _client;

        public ApiService()
        {
            _client = ApiClient.Client;
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task LoginUser(string username, string password)
        {
            var client = ApiClient.Client;
            var url = "https://nt106.uitiot.vn/auth/token";

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
            Control control = new Control();
            control.Show();
        }

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
        public async Task CreateUser(string username, string email, string password, string first_name,
            string last_name, int sex, DateTime birthday, string language, string phone)
        {
            var client = ApiClient.Client;
            var url = "https://nt106.uitiot.vn/api/v1/user/signup";

            var newUser = new UserCreateRequest
            {
                username = username,
                email = email,
                password = password,
                first_name = first_name,
                last_name = last_name,
                sex = sex,
                birthday = birthday,
                language = language,
                phone = phone
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

        public class UserListRequest
        {
            public int current { get; set; }
            public int pageSize { get; set; }
        }
        public class UserListResponse
        {
            public List<UserResponse> data { get; set; }
            public int total { get; set; }
        }


        public async Task<List<UserResponse>> GetAllUsers(int current = 1, int pageSize = 5)
        {
            var client = ApiClient.Client;
            var request = new UserListRequest { current = current, pageSize = pageSize };
            var json = JsonConvert.SerializeObject(request);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var url = "https://nt106.uitiot.vn/api/v1/user/all";

            for (int attempt = 0; attempt < 2; attempt++) // tối đa retry 1 lần nếu refresh token
            {
                try
                {
                    var response = await client.PostAsync(url, content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        bool refreshed = await TokenHelper.RefreshAccessToken();
                        if (!refreshed)
                        {
                            MessageBox.Show("Token hết hạn, vui lòng đăng nhập lại.");
                            return new List<UserResponse>();
                        }
                        continue; // retry lần nữa với token mới
                    }

                    if (response.IsSuccessStatusCode)
                    {
                        var userListResponse = JsonConvert.DeserializeObject<UserListResponse>(responseString);
                        return userListResponse?.data ?? new List<UserResponse>();
                    }
                    else if (response.Content.Headers.ContentType?.MediaType == "application/json")
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

                    break; // không retry nếu status khác 401
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show("Lỗi kết nối API: " + ex.Message);
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khác: " + ex.Message);
                    break;
                }
            }

            return new List<UserResponse>();
        }


        public async Task<UserResponse> GetUser()
        {
            var client = ApiClient.Client;
            var url = "https://nt106.uitiot.vn/api/v1/user/me";
            for (int attempt = 0; attempt < 2; attempt++)
            {
                try
                {
                    // Gửi request
                    var response = await client.GetAsync(url);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        bool refreshed = await TokenHelper.RefreshAccessToken();
                        if (!refreshed)
                        {
                            MessageBox.Show("Token hết hạn, vui lòng đăng nhập lại.");
                            return new UserResponse();
                        }
                        continue; // retry lần nữa với token mới
                    }

                    if (response.IsSuccessStatusCode)
                    {
                        var userResponse = JsonConvert.DeserializeObject<UserResponse>(responseString);
                        return userResponse;
                    }
                    else if (response.Content.Headers.ContentType?.MediaType == "application/json")
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

                    break; // không retry nếu status khác 401
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show("Lỗi kết nối API: " + ex.Message);
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khác: " + ex.Message);
                    break;
                }
            }
            return new UserResponse();
        }

        public async Task<bool> PutUsername(string newUsername)
        {
            var client = ApiClient.Client;
            var url = "https://nt106.uitiot.vn/api/v1/user/{username}";
            var requestBody = new { username = newUsername };
            var json = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            for (int attempt = 0; attempt < 2; attempt++)
            {
                try
                {
                    var response = await client.PutAsync(url, content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        bool refreshed = await TokenHelper.RefreshAccessToken();
                        if (!refreshed)
                        {
                            MessageBox.Show("Token hết hạn, vui lòng đăng nhập lại.");
                            return false;
                        }
                        continue;
                    }

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Cập nhật username thành công!");
                        return true;
                    }
                    else if (response.Content.Headers.ContentType?.MediaType == "application/json")
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

                    break;
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show("Lỗi kết nối API: " + ex.Message);
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khác: " + ex.Message);
                    break;
                }
            }

            return false;
        }

        public async Task<bool> DeleteUserAsync(string username)
        {
            var client = ApiClient.Client;
            var url = $"https://nt106.uitiot.vn/api/v1/user/{username}";

            for (int attempt = 0; attempt < 2; attempt++)
            {
                try
                {
                    var response = await client.DeleteAsync(url);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        bool refreshed = await TokenHelper.RefreshAccessToken();
                        if (!refreshed)
                        {
                            MessageBox.Show("Token hết hạn, vui lòng đăng nhập lại.");
                            return false;
                        }
                        continue;
                    }

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Xóa user thành công!");
                        return true;
                    }
                    else if (response.Content.Headers.ContentType?.MediaType == "application/json")
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

                    break;
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show("Lỗi kết nối API: " + ex.Message);
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khác: " + ex.Message);
                    break;
                }
            }

            return false;
        }

        public async Task<bool> DeleteIdUser(int id)
        {
            try
            {
                var client = ApiClient.Client;
                var url = $"https://nt106.uitiot.vn/api/v1/user/{id}";
                for (int attemp = 0; attemp < 2; attemp++)
                {
                    var response = await client.DeleteAsync(url);
                    var responseString = await response.Content.ReadAsStringAsync();
                    if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        var refresh = await TokenHelper.RefreshAccessToken();
                        if (!refresh)
                        {
                            MessageBox.Show("Token hết hạn, vui lòng đăng nhập lại.");
                            return false;
                        }
                        continue;
                    }
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Xóa user thành công!");
                        return true;
                    }
                    else if (response.Content.Headers.ContentType?.MediaType == "application/json")
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
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi API: " + responseString);
                        break;
                    }
                }

            }
            catch(HttpProtocolException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
                return false;
            }
            return false;
        }

        public async Task<UserResponse> UpdateUserAsync(string id, UserCreateRequest updatedUser)
        {
            var client = ApiClient.Client;
            var url = $"https://nt106.uitiot.vn/api/v1/user/{id}";

            for (int attempt = 0; attempt < 2; attempt++)
            {
                try
                {
                    var json = JsonConvert.SerializeObject(updatedUser);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PutAsync(url, content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    {
                        bool refreshed = await TokenHelper.RefreshAccessToken();
                        if (!refreshed)
                        {
                            MessageBox.Show("Token hết hạn, vui lòng đăng nhập lại.");
                            return null;
                        }
                        continue; // retry với token mới
                    }

                    if (response.IsSuccessStatusCode)
                    {
                        var user = JsonConvert.DeserializeObject<UserResponse>(responseString);
                        return user;
                    }
                    else if (response.Content.Headers.ContentType?.MediaType == "application/json")
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

                    break; // không retry nếu không phải 401
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show("Lỗi kết nối API: " + ex.Message);
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khác: " + ex.Message);
                    break;
                }
            }

            return null; // lỗi
        }

        public class MonAn
        {
            public string ten_mon_an { get; set; }
            public decimal gia { get; set; }
            public string mo_ta { get; set; }
            public string hinh_anh { get; set; }
            public string dia_chi { get; set; }
            public string NguoiDongGop { get; set; }

        }

        public async Task AddMonAn(string tenMon, string moTa, string hinhAnh, string diaChi, string giaTien)
        {
            var client = ApiClient.Client;
            var monMoi = new MonAn
            {
                ten_mon_an = tenMon,
                mo_ta = moTa,
                hinh_anh = hinhAnh,
                dia_chi = diaChi
            };
            // kiểm tra giá
            if (decimal.TryParse(giaTien.Trim(), out decimal gia))
            {
                monMoi.gia = gia;
            }
            else
            {
                MessageBox.Show("Giá không hợp lệ!");
                return;
            }

            var url = "https://nt106.uitiot.vn/api/v1/monan/add";

            string jsonBody = JsonConvert.SerializeObject(monMoi);
            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync(url, content);

                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    if (await TokenHelper.RefreshAccessToken())
                        response = await client.PostAsync(url, content);
                    else
                    {
                        MessageBox.Show("Phiên đăng nhập hết hạn!");
                        return;
                    }
                }

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Thêm món ăn thành công!");
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Thêm món ăn thất bại: " + error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

    }
}

