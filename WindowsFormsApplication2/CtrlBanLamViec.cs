using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sonartez.Hepldesk.Bussiness;
using Sonartez.Entities;
using Sonartez.Helpdesk.Bussiness;
using System.Diagnostics;
using System.Configuration;

namespace Sonartez.Helpdesk
{
    public partial class CtrlBanLamViec :UserControl
    {

        IEnumerable<TblInfor> lstInfo, lstShowData;
        Boolean createNewFlag;
        public TblUser currentUser;
        TblClient currentClient;
        TblInfor currentInfo;
        BBLInfo info;
        int currentSelectedIndex = 0;

        public CtrlBanLamViec()
        {
            InitializeComponent();
            InitCombobox();
        }

        private void CtrlBanLamViec_Load(object sender, EventArgs e)
        {
            
        }

        private void InitCombobox()
        {
            cbbStatus.DataSource = InformationStatus.listValue;
            cbbType.DataSource = InformationType.listValue;
        }

        public void UpdateNewsData() {
            BBLUser user = new BBLUser();

            var lstUser = user.GetUser();

          
        }

        //private void olvNews_CellEditStarting(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        //{
        //    if (e.Column.DisplayIndex == 1)
        //    {
        //        TextBox c = (TextBox)e.Control;
        //        c.Multiline = true;
        //        c.Height = 48;
        //        e.Control = c;
        //    }
        //}

        private void txtTag_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            metroPanelInfo.Visible = false;
        }

        public void LoadData(BBLInfo _info)
        {
            

            string clientCode = ConfigurationManager.AppSettings["CLIENTCODE"];

            currentClient = new BBLClient().GetAll().FirstOrDefault(x=>x.ClientCode==clientCode);

            if (currentClient == null) {
                MessageBox.Show("Xác minh lại thiết lập Máy Trạm");
                new FrmConfig().ShowDialog();
            }

            this.info = _info;
            lstInfo = info.GetAll().Where(x=>x.IsDeleted==0);
            List<TblInfor> lst = new List<TblInfor>();

            lst.AddRange(lstInfo);

            lstInfo = lst;
            RunFilter();
        }

        private void LoadData()
        {
            if (info != null)
            {
                lstInfo = info.GetAll().Where(x => x.IsDeleted == 0);
                List<TblInfor> lst = new List<TblInfor>();

                lst.AddRange(lstInfo);

                lstInfo = lst;
                RunFilter();
            }
        }

        private void RunFilter()
        {
            if (lstInfo != null)
            {

                lstShowData = lstInfo;
                if (cbbStatus.SelectedValue.ToString() != InformationStatus.All)
                {
                    if (cbbStatus.SelectedValue.ToString() == InformationStatus.Expired)
                    {
                        lstShowData = lstShowData.Where(x => x.InfoType == InformationType.Limited && x.ExprieDate < DateTime.Now );
                    }
                    else
                    {
                        lstShowData = lstShowData.Where(x => x.Status.Equals(cbbStatus.SelectedValue.ToString()));

                        
                        //lstShowData = lstShowData.Where(x => x.Status.Equals(cbbStatus.SelectedValue.ToString()));
                    }
                }

                if (cbbType.SelectedValue.ToString() != InformationType.All)
                {
                    lstShowData = lstShowData.Where(x => x.InfoType.Equals(cbbType.SelectedValue.ToString()));
                }

                lstShowData = lstShowData.OrderByDescending(x => x.UpdateDate.Value);

                gridControl1.DataSource = lstShowData;

            }
            LoadToView(grvMainInfo.FocusedRowHandle);
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim().Length > 0 && lstShowData.Count() > 0)
            {
                string searckKey = "%" + txtSearch.Text.Trim().Replace(' ', '%') + "%";
                grvMainInfo.ActiveFilterString = "([InfoTitle] Like '" + searckKey + "' OR [InfoContent] Like '" + searckKey + "' OR [InfoTag] Like '" + searckKey + "' )";

            }
            else
            {
                grvMainInfo.ActiveFilter.Clear();
            }
        }

        private void cbbType_SelectedValueChanged(object sender, EventArgs e)
        {
            RunFilter();
        }

        private void ShowOnEditForm(TblInfor obj)
        {
           
            

            currentSelectedIndex = grvMainInfo.FocusedRowHandle;
            currentInfo = new TblInfor();
            currentInfo = obj;

            txtContent.HtmlText = currentInfo.InfoContentHtml;
            txtInfoTitle.Text = currentInfo.InfoTitle;
            txtTag.Text = currentInfo.InfoTag;

            if (currentInfo.InfoType == InformationType.Limited)
            {
                chkInfoType.Checked = true;
                dateFrom.Value = currentInfo.BeginDate.Value;
                dateTo.Value = currentInfo.ExprieDate.Value;
            }
            else
            {
                chkInfoType.Checked = false;
            }
            chkStatus.Checked = (currentInfo.Status == InformationStatus.Approved);

            
           


        }

        private void cbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RunFilter();
        }

        private void grvMainInfo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadToView(e.FocusedRowHandle);
           
        }

        private void LoadToView(int focusedRowHandle)
        {
            try
            {

                if (grvMainInfo.SelectedRowsCount > 0 && focusedRowHandle >= 0)
                {
                    //grvMainInfo.GetDataRow(e.FocusedRowHandle);

                    var obj = (TblInfor)lstShowData.ToList()[grvMainInfo.GetDataSourceRowIndex(focusedRowHandle)];
                    if (obj != null)
                    {
                        ShowOnEditForm(obj);
                    }
                    else
                    {
                        createNewFlag = false;

                        // Reset
                        txtInfoTitle.Text = string.Empty;
                        txtContent.Text = string.Empty;
                        txtTag.Text = string.Empty;
                        chkInfoType.Checked = false;
                        chkStatus.Checked = false;



                        //btnCreateInfo.Visible = true;
                        txtSearch.Focus();
                    }
                }
            }
            catch
            {
                txtInfoTitle.Text = string.Empty;
                txtContent.Text = string.Empty;
                txtTag.Text = string.Empty;
                chkInfoType.Checked = false;
                chkStatus.Checked = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSaveHotLine_Click(object sender, EventArgs e)
        {
            TblConsultantLog cLog = new TblConsultantLog();

            cLog.AnswerRef = currentInfo.InfoTitle;
            cLog.ClientCode = currentClient.ClientCode;
            cLog.ClientID = currentClient.ClientID;
            cLog.ClientName = currentClient.ClientName;
            cLog.ConsType = ConsultantType.PhoneCall;
            cLog.CreateDate = DateTime.Now;
            cLog.Descriptions = txtSearch.Text;
            cLog.FinishDate = DateTime.Now;
            cLog.TargetType = ConsultantType.PhoneCall;
            cLog.ID = currentClient.ClientCode + currentUser.UserName + DateTime.Now.ToBinary().ToString();

            cLog.Question = txtSearch.Text;
            cLog.Status = ConsultantStatus.OK;
            cLog.TargetCount = 1;
            cLog.UserID = currentUser.UserID;
            cLog.UserName = currentUser.UserName;

            FrmSaveHotline frmSaveHotLine = new FrmSaveHotline(cLog);
            frmSaveHotLine.ShowDialog();


        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Process.Start("http://google.com?gws_rd=ssl#q="+txtSearch.Text);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            TblConsultantLog cLog = new TblConsultantLog();

            cLog.AnswerRef = currentInfo.InfoTitle;
            cLog.ClientCode = currentClient.ClientCode;
            cLog.ClientID = currentClient.ClientID;
            cLog.ClientName = currentClient.ClientName;
            cLog.ConsType = ConsultantType.Anonymus;
            cLog.CreateDate = DateTime.Now;
            cLog.Descriptions = txtSearch.Text;
            cLog.FinishDate = DateTime.Now;
            cLog.TargetType = ConsultantType.Anonymus;
            cLog.ID = currentClient.ClientCode + currentUser.UserName + DateTime.Now.ToBinary().ToString();

            cLog.Question = txtSearch.Text;
            cLog.Status = ConsultantStatus.OK;
            cLog.TargetCount = 1;
            cLog.UserID = currentUser.UserID;
            cLog.UserName = currentUser.UserName;

            FrmSaveFull frmSaveHotLine = new FrmSaveFull(cLog);
            frmSaveHotLine.ShowDialog();
        }

        ContentFullScreen ctf;
        private void txtContent_DoubleClick(object sender, EventArgs e)
        {
             ctf = new ContentFullScreen();

             ctf.setInfo(currentInfo);

            
             ctf.ShowDialog();

             if (ctf.isSaved) {
                 txtContent.HtmlText = ctf.info.InfoContentHtml;
             }
             ctf.Dispose();

        }

        private void grvMainInfo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            LoadToView(e.RowHandle);
        }
    }
}
