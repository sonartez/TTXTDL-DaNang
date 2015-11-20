using Sonartez.Helpdesk.Bussiness;
using Sonartez.Hepldesk.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sonartez.Helpdesk
{
    public partial class FrmSyncronize : Form
    {
        public FrmSyncronize()
        {
            InitializeComponent();
        }

        private void FrmSyncronize_Load(object sender, EventArgs e)
        {
           
        }
        private void AutoUpdateToServer()
        {
            textBox1.Text = "Starting...\n";

            string baseHost = ConfigurationManager.AppSettings["SERVERURL"];

            string clientCode = ConfigurationManager.AppSettings["CLIENTCODE"];

            try
            {


                //WebRequest request = WebRequest.Create("http://google.com/");
                //request.Timeout =   Timeout.Infinite;
                ////request.KeepAlive = true;
                //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                //if (response == null || response.StatusCode != HttpStatusCode.OK)
                //{
                //    Console.WriteLine("Hiện không thể kết nối máy chủ. \n Chương trình sẽ chạy với dữ liệu offline cho đến khi có kết nối với máy chủ.\n Hãy kiểm tra kết nối internet và [Thiết lập máy trạm]");
                //}
                //else
                //{
                // Đồng bộ user
                textBox1.Text += "Sync User ...\n";
                BBLUser userData = new BBLUser();
                userData.ServiceUpdate(baseHost);
                textBox1.Text += "Sync user is success n";
                textBox1.Text += "Sync Info ...\n";
                // Đồng bộ Info
                BBLInfo infoData = new BBLInfo();
                infoData.ServiceUpdate(baseHost);
                textBox1.Text += "Sync info is success n";
                textBox1.Text += "Sync client ...\n";
                // Đồng bộ BBLClient
                BBLClient clientData = new BBLClient();
                clientData.ServiceUpdate(baseHost);
                textBox1.Text += "Sync client is success n";
                textBox1.Text += "Sync Consultant ...\n";
                // Đồng bộ BBLConsultant
                BBLConsultant consultantData = new BBLConsultant();
                consultantData.ServiceUpdate(baseHost);
                //}
                textBox1.Text += "finish \n";
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Source);
                textBox1.Text += "Error " + ex.Message;
            }
        }

        private void FrmSyncronize_Shown(object sender, EventArgs e)
        {
            AutoUpdateToServer();
           
        }
    }
}
