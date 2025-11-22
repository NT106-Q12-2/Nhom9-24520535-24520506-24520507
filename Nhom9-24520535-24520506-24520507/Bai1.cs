using System.Net;
using System.Security.Policy;
namespace Lab4_24520535_24520506_24520507
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        public void lb_URL_Click(object sender, EventArgs e) { }

        public void bt_Get_Click(object sender, EventArgs e)
        {
            try
            {
                rtb_NoiDung.Text = getHTML(tb_URL.Text);
            }
            catch
            {
                MessageBox.Show("lỗi đọc dữ liệu HTML");
            }

        }

        private string getHTML(string szURL)
        {
            WebRequest request = WebRequest.Create(szURL);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            return responseFromServer;
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }
    }
}
