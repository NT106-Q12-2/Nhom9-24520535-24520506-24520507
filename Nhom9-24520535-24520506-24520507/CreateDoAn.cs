using Newtonsoft.Json;
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

namespace Nhom9_24520535_24520506_24520507
{
    public partial class CreateDoAn : Form
    {
        public CreateDoAn()
        {
            InitializeComponent();
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

        private async void btnAddMonAn_Click(object sender, EventArgs e) {
            await AddMonAn();
        }

        private async Task AddMonAn()
        {
            var client = ApiClient.Client;
            var monMoi = new MonAn
            {
                ten_mon_an = txtTenMonAn.Text.Trim(),
                mo_ta = txtMoTa.Text.Trim(),
                hinh_anh = txtHinhAnh.Text.Trim(),
                dia_chi = txtDiaChi.Text.Trim(),
            };
            // kiểm tra giá
            if (decimal.TryParse(txtGia.Text.Trim(), out decimal gia))
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
                    
                    ClearForm();
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

        private void ClearForm()
        {
            txtTenMonAn.Text = "";
            txtGia.Text = "";
            txtMoTa.Text = "";
            txtHinhAnh.Text = "";
            txtDiaChi.Text = "";
        }
    }
}
