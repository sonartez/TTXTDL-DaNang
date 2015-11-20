using Sonartez.Entities;
using Sonartez.Hepldesk.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sonartez.Helpdesk
{
    public partial class FrmChangePass : Form
    {
        TblUser loggedUser;
        public FrmChangePass()
        {
            InitializeComponent();
        }

        public FrmChangePass(TblUser _loggedUser)
        {
            InitializeComponent();
            this.loggedUser = _loggedUser;

            label1.Text = loggedUser.UserName;
            label2.Text = loggedUser.FullName;

        }

        

        private void FrmChangePass_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNew.Text == txtNew2.Text && txtNew.Text.Trim().Length > 5)
            {


                BBLUser bblUser = new BBLUser();
                try
                {
                    if (loggedUser.Password == txtOld.Text.Trim())
                    {
                        loggedUser.Password = txtNew.Text.Trim();

                        bblUser.UpdateUser(loggedUser);

                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu hiện tại không chính xác");
                    }

                    MessageBox.Show("Lưu mật khẩu mới thành công");

                }
                catch (Exception)
                {
                    MessageBox.Show("Lưu thông tin thất bại");
                }
            }
            else {
                MessageBox.Show("Mật khẩu mới không chính xác");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
