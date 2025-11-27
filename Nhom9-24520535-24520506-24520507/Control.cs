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

        private void tabPageALL_Click(object sender, EventArgs e)
        {

        }
    }
}
