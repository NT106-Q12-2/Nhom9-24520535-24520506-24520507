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
using static Nhom9_24520535_24520506_24520507.Program;

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

                string username = tb_userName.Text;
                string password = tb_passWord.Text;

                await GlobalApi.Api.LoginUser(username, password);
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}