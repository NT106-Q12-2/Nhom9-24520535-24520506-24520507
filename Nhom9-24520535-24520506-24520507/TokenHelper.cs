using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Nhom9_24520535_24520506_24520507
{
    public static class TokenHelper
    {
        public static async Task<bool> RefreshAccessToken()
        {
            var client = ApiClient.Client;
            var url = "https://nt106.uitiot.vn/auth/refresh";

            var content = new MultipartFormDataContent
        {
            { new StringContent(Global.RefreshToken), "refresh_token" }
        };

            var response = await client.PostAsync(url, content);
            if (!response.IsSuccessStatusCode)
                return false;

            var data = JObject.Parse(await response.Content.ReadAsStringAsync());
            Global.AccessToken = data["access_token"]?.ToString();
            Global.TokenType = data["token_type"]?.ToString();

            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(Global.TokenType, Global.AccessToken);

            return true;
        }
    }

}
