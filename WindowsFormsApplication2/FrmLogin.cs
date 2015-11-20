using Sonartez.Entities;
using Sonartez.Helpdesk.Bussiness;
using Sonartez.Hepldesk.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Sonartez.Helpdesk
{
    public partial class FrmLogin : Form
    {
        BBLUser user = new BBLUser();
        public FrmLogin()
        {
            InitializeComponent();
            CheckSetting();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().Length == 0 || txtPass.Text.Trim().Length == 0) {
                DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, this.FindForm(),"Thiếu thông tin ", "Không thể đăng nhập mà không có đủ thông tin :D " , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            string username = txtUserName.Text.Trim();
            string pass = txtPass.Text.Trim();
            try
            {
                var loggedUser = (TblUser)user.Login(username, pass);
                if (loggedUser != null)
                {
                    FrmMain frmMain = new FrmMain(loggedUser);
                    frmMain.Show();
                    this.Visible = false;
                }
                else {
                    throw new Exception("Thông tin đăng nhập không chính xác");
                }
            }
            catch (Exception ex)
            {

                DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, this.FindForm(),  "Thông báo:\n"+ ex.Message," Đăng nhập không thành công. ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CheckSetting() {
        
            // Lấy dữ liệu config

           string baseHost = ConfigurationManager.AppSettings["SERVERURL"];
           
           string clientCode = ConfigurationManager.AppSettings["CLIENTCODE"];

           if (string.IsNullOrEmpty(baseHost) || string.IsNullOrEmpty(clientCode))
           {
               FrmConfig config = new FrmConfig();
               config.ShowDialog(this);
               config.Dispose();
           }
           else
           {

               try
               {

              
               WebRequest request = WebRequest.Create(baseHost+"connect.html");
               HttpWebResponse response = (HttpWebResponse)request.GetResponse();
               if (response == null || response.StatusCode != HttpStatusCode.OK)
               {
                   MessageBox.Show("Hiện không thể kết nối máy chủ. \n Chương trình sẽ chạy với dữ liệu offline cho đến khi có kết nối với máy chủ.\n Hãy kiểm tra kết nối internet và [Thiết lập máy trạm]");
               }
               else {
                   // Đồng bộ user
                   BBLUser userData = new BBLUser();
                   userData.ServiceUpdate(baseHost);
               }
               }
               catch (Exception ex)
               {
                   MessageBox.Show("Hiện không thể kết nối máy chủ. \n Chương trình sẽ chạy với dữ liệu offline cho đến khi có kết nối với máy chủ.\n Hãy kiểm tra kết nối internet và [Thiết lập máy trạm]");
          
                  // throw;
               }
           }


            //-> Không có hiện ngay form config

            // Kiểm tra kết nối mạng

            //-> Đồng bộ User

            //-> Xác nhận làm việc offline
        }
    }
}
