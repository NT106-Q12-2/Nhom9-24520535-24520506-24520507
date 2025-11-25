using Newtonsoft.Json;
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
using static Nhom9_24520535_24520506_24520507.CreateDoAn;

namespace Nhom9_24520535_24520506_24520507
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void bt_ThemMon_Click(object sender, EventArgs e)
        {
            CreateDoAn createDoAn = new CreateDoAn();
            createDoAn.Show();
        }

        public async Task<List<MonAn>> GetMonAnAsync()
        {
            var requestBody = new
            {
                page = 1,
                pageSize = 5
            };
            var client = ApiClient.Client;
            string json = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("https://nt106.uitiot.vn/api/v1/monan/all", content);
            response.EnsureSuccessStatusCode();

            string responseJson = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<MonAn>>(responseJson);

        }

        //private void HienThiMonAn(List<MonAn> list)
        //{
        //    tabPageALL.Controls.Clear();
        //    tabPageMy.Controls.Clear();

        //    foreach (var item in list)
        //    {

        //    }
        //}

        //private void tabPageALL_Click(object sender, EventArgs e)
        //{

        //}
    }
}
