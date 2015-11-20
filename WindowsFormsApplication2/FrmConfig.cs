using Sonartez.Entities;
using Sonartez.Helpdesk.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sonartez.Helpdesk
{
    public partial class FrmConfig : Form
    {
        public string baseHost = "";
        public BBLClient clientData;
        public FrmConfig()
        {
            InitializeComponent();

            baseHost = ConfigurationManager.AppSettings["SERVERURL"];
            txtServerUrl.Text = baseHost;

            txtClientCode.Text = ConfigurationManager.AppSettings["CLIENTCODE"];


        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            // Check connection to webserve

            baseHost = txtServerUrl.Text.Trim();
            if (string.IsNullOrEmpty(baseHost)) {
                txtServerUrl.Focus();
                return;
            }
            WebRequest request = WebRequest.Create(baseHost);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            if (response == null || response.StatusCode != HttpStatusCode.OK)
            {
                // Không có vô service đc
                clientData = new BBLClient();
                VerifyClient();
            }
            else
            {
                // update cái rồi mới verify

                clientData = new BBLClient();

                clientData.ServiceUpdate(baseHost);

                VerifyClient();

                
            }
        }

        private void VerifyClient()
        {
            var client = clientData.GetAll().FirstOrDefault(x => x.ClientCode == txtClientCode.Text.Trim());
            if (client != null)
            {
                // Save to configs
                System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                // Add an Application Setting.
                config.AppSettings.Settings.Remove("CLIENTCODE");
                config.AppSettings.Settings.Add("CLIENTCODE", txtClientCode.Text.Trim());

                // Save the changes in App.config file.
                config.Save(ConfigurationSaveMode.Modified);

                // Force a reload of a changed section.
                ConfigurationManager.RefreshSection("appSettings");

                lblClientInfo.Text = client.ClientName + " " + client.LocationName + ". " + client.Descriptions;
                lblClientInfo.ForeColor = Color.Green;

            }
            else {
                lblClientInfo.Text = "Không tìm thấy mã này";
                lblClientInfo.ForeColor = Color.Red;
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save to configs
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Add an Application Setting.
            config.AppSettings.Settings.Remove("CLIENTCODE");
            config.AppSettings.Settings.Add("CLIENTCODE", txtClientCode.Text.Trim());

            config.AppSettings.Settings.Remove("SERVERURL");
            config.AppSettings.Settings.Add("SERVERURL", txtServerUrl.Text.Trim());

            // Save the changes in App.config file.
            config.Save(ConfigurationSaveMode.Modified);

            // Force a reload of a changed section.
            ConfigurationManager.RefreshSection("appSettings");

        }

    }
}
