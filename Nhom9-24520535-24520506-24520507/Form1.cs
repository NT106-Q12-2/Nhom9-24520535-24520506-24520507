using Lab4_24520535_24520506_24520507;

namespace Nhom9_24520535_24520506_24520507
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_bai2_Click(object sender, EventArgs e)
        {
            Bai2 form = new Bai2();
            form.Show();
        }

        private void btn_bai1_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.Show();
        }

        private void btn_bai3_Click(object sender, EventArgs e)
        {
            Bai3 bai3 = new Bai3();
            bai3.Show();
        }
    }
}
