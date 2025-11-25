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

namespace Nhom9_24520535_24520506_24520507
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void DangNhap_Click(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
        }

        private void bt_TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
        }
    }
}
