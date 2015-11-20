using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sonartez.Entities;
using Sonartez.Helpdesk.Bussiness;

namespace Sonartez.Helpdesk
{
    public partial class ctrlThongKe : UserControl
    {


        IEnumerable<TblConsultantLog> lstInfo, lstShowData;
        Boolean createNewFlag;
        public TblUser currentUser;
        TblClient currentClient;
        TblInfor currentInfo;
        BBLInfo info;
        BBLConsultant cons;
        int currentSelectedIndex = 0;

        public ctrlThongKe()
        {
            InitializeComponent();
        }

        public void LoadData(BBLConsultant cons)
        {
            //currentUser = new BBLUser().GetUser().FirstOrDefault();
            currentClient = new BBLClient().GetAll().FirstOrDefault();
            this.cons = cons;
            lstInfo = cons.GetAll();
            List<TblConsultantLog> lst = new List<TblConsultantLog>();

            lst.AddRange(lstInfo);

            lstInfo = lst;
            RunFilter();
        }

        public void LoadData()
        {
            if (cons != null)
            {
                lstInfo = cons.GetAll();
                List<TblConsultantLog> lst = new List<TblConsultantLog>();

                lst.AddRange(lstInfo);

                lstInfo = lst;
            }
            else {
                cons = new BBLConsultant();
                lstInfo = cons.GetAll();
                List<TblConsultantLog> lst = new List<TblConsultantLog>();

                lst.AddRange(lstInfo);

                lstInfo = lst;
            
            }
            RunFilter();
        }

        private void RunFilter()
        {
            if (lstInfo != null)
            {

                lstShowData = lstInfo;                

                lstShowData = lstShowData.OrderByDescending(x => x.UpdateDate.Value);

                gridControl1.DataSource = lstShowData;

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FrmThongKe_TheoThoiGian frm = new FrmThongKe_TheoThoiGian();
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (grvMainInfo.SelectedRowsCount > 0 && grvMainInfo.FocusedRowHandle >= 0)
            {
                var obj = (TblConsultantLog)lstShowData.ToList()[grvMainInfo.GetDataSourceRowIndex(grvMainInfo.FocusedRowHandle)];
                if (obj != null)
                {
                    FrmEditFull frm = new FrmEditFull(obj);
                    frm.ShowDialog();
                    LoadData();
                }
            }
        }

    }
}
