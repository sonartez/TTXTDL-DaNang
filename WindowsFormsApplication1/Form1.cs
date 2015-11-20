using Newtonsoft.Json;
using Sonartez.Application.ApiClients;
using Sonartez.Services.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UserAPIClient.RunAsync().Wait();

            string jsonString = HttpGet(@"http://localhost:10539/Api/Users");
            var list = JsonConvert.DeserializeObject<List<User>>(jsonString);

        }

        static string HttpGet(string url)
        {
            HttpWebRequest req = WebRequest.Create(url)
                                 as HttpWebRequest;
            string result = null;
            using (HttpWebResponse resp = req.GetResponse()
                                          as HttpWebResponse)
            {
                StreamReader reader =
                    new StreamReader(resp.GetResponseStream());
                result = reader.ReadToEnd();
            }
            return result;
        }
        static string HttpPost(string url,string[] paramName, string[] paramVal)
        {
            HttpWebRequest req = WebRequest.Create(new Uri(url))
                                 as HttpWebRequest;
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";

            // Build a string with all the params, properly encoded.
            // We assume that the arrays paramName and paramVal are
            // of equal length:
            StringBuilder paramz = new StringBuilder();
            for (int i = 0; i < paramName.Length; i++)
            {
                paramz.Append(paramName[i]);
                paramz.Append("=");
                paramz.Append(HttpUtility.UrlEncode(paramVal[i]));
                paramz.Append("&");
            }

            // Encode the parameters as form data:
            byte[] formData =
                UTF8Encoding.UTF8.GetBytes(paramz.ToString());
            req.ContentLength = formData.Length;

            // Send the request:
            using (Stream post = req.GetRequestStream())
            {
                post.Write(formData, 0, formData.Length);
            }

            // Pick up the response:
            string result = null;
            using (HttpWebResponse resp = req.GetResponse()
                                          as HttpWebResponse)
            {
                StreamReader reader =
                    new StreamReader(resp.GetResponseStream());
                result = reader.ReadToEnd();
            }

            return result;
        }
    }
}
