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
using static Nhom9_24520535_24520506_24520507.Program;

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

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            
            await GlobalApi.Api.CreateUser(txtUsername.Text, txtEmail.Text, txtPassword.Text, txtFirstName.Text,
                  txtLastName.Text, cboSex.SelectedIndex, dtpBirthday.Value.Date, txtLanguage.Text, txtPhone.Text);
            
        }
    }
}
