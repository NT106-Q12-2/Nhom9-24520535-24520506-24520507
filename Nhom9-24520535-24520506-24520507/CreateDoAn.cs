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
using static Nhom9_24520535_24520506_24520507.Program;

namespace Nhom9_24520535_24520506_24520507
{
    public partial class CreateDoAn : Form
    {
        public CreateDoAn()
        {
            InitializeComponent();
        }

        private async void btnAddMonAn_Click(object sender, EventArgs e) {
            await GlobalApi.Api.AddMonAn(txtTenMonAn.Text,txtMoTa.Text,txtHinhAnh.Text,txtDiaChi.Text,txtGia.Text);
        }
    }
}
