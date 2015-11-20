using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using MetroFramework;
using System.Windows.Forms;
using Sonartez.Entities;
using Sonartez.Helpdesk.Bussiness;
using Sonartez.Hepldesk.Bussiness;
//using BrightIdeasSoftware;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;
using System.Configuration;


namespace Sonartez.Helpdesk
{
    public partial class CtrlQuanLyNoiDung : UserControl
    {
        IEnumerable<TblInfor> lstInfo, lstShowData;
        Boolean createNewFlag;
        public TblUser currentUser;
        TblClient currentClient;
        TblInfor currentInfo;
        BBLInfo info;
        int currentSelectedIndex = 0;
        public CtrlQuanLyNoiDung()
        {
           
            InitializeComponent();

            InitCombobox();

            btnEdit.Visible = false;
            btnSaveInfo.Visible = false;
            btnCancelEditInfo.Visible = false;
            btnDeleteInfo.Visible = false;

            lstInfo = new List<TblInfor>();
            //LoadData();
            createNewFlag = false;

            // hack
           

        }



        public void ShowOnlyPending()
        {
            cbbStatus.SelectedValue = InformationStatus.Pending;
        }

        public void ShowOnlyExpired()
        {
            cbbStatus.SelectedValue = InformationStatus.Expired;
        }

        private void InitCombobox()
        {
            cbbStatus.DataSource = InformationStatus.listValue;
            cbbType.DataSource = InformationType.listValue;
        }

        private void chkInfoType_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInfoType.Checked)
            {
                dateFrom.Enabled = true;
                dateTo.Enabled = true;
            }
            else
            {
                dateFrom.Enabled = false;
                dateTo.Enabled = false;
            }
        }

        public void LoadData(BBLInfo _info)
        {
            if (currentUser.Permission == Permission.Normal) chkStatus.Enabled = false;

            string clientCode = ConfigurationManager.AppSettings["CLIENTCODE"];

            currentClient = new BBLClient().GetAll().FirstOrDefault(x => x.ClientCode == clientCode);

            if (currentClient == null)
            {
                MessageBox.Show("Xác minh lại thiết lập Máy Trạm");
                new FrmConfig().ShowDialog();
            }

            this.info = _info;
            lstInfo = info.GetAll().Where(x => x.IsDeleted == 0).ToList();
            //List<TblInfor> lst = new List<TblInfor>();

            //lst.AddRange(lstInfo);

            //lstInfo = lst;
            SettingAutoSuggest();
            RunFilter();
        }

        private void SettingAutoSuggest() 
        {
            //txtInfoTitle.c 
            var source = new AutoCompleteStringCollection();
            source.AddRange(lstInfo.Select(x => x.InfoTitle).ToArray());
            txtInfoTitle.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtInfoTitle.MaskBox.AutoCompleteMode = AutoCompleteMode.Suggest;
           
            txtInfoTitle.MaskBox.AutoCompleteCustomSource = source;
        }

        public void LoadData()
        {
            if (info != null)
            {
                lstInfo = info.GetAll().Where(x=>x.IsDeleted==0);
                //List<TblInfor> lst = new List<TblInfor>();

                //lst.AddRange(lstInfo);

                //lstInfo = lst;

                SettingAutoSuggest();
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


                        lstShowData = lstShowData.Where(x => (x.InfoType == InformationType.Limited && x.ExprieDate > DateTime.Now&& x.BeginDate<DateTime.Now)|| x.InfoType!=InformationType.Limited);
                    }
                }

                if (cbbType.SelectedValue.ToString() != InformationType.All)
                {
                    lstShowData = lstShowData.Where(x => x.InfoType.Equals(cbbType.SelectedValue.ToString()));
                }

                lstShowData = lstShowData.OrderByDescending(x => x.UpdateDate.Value);

                gridControl1.DataSource = lstShowData;

            }
            ViewDataToForm(grvMainInfo.FocusedRowHandle);
        }

        private void btnCreateInfo_Click(object sender, EventArgs e)
        {
            createNewFlag = true;

            // Reset
            txtInfoTitle.Text = string.Empty;
            txtContent.HtmlText = string.Empty;
            txtTag.Text = string.Empty;
            chkInfoType.Checked = false;
            chkStatus.Checked = false;

            btnDeleteInfo.Visible = false;
            btnEdit.Visible = false;
            btnCreateInfo.Visible = false;

            btnCancelEditInfo.Visible = true;
            btnSaveInfo.Visible = true;

            gridControl1.Enabled = false;

            txtInfoTitle.Focus();
        }

        private void btnCancelEditInfo_Click(object sender, EventArgs e)
        {
            createNewFlag = false;

            // Reset
            txtInfoTitle.Text = string.Empty;
            txtContent.HtmlText = string.Empty;
            txtTag.Text = string.Empty;
            chkInfoType.Checked = false;
            chkStatus.Checked = false;

            btnDeleteInfo.Visible = false;
            btnEdit.Visible = false;
            btnCancelEditInfo.Visible = false;
            btnSaveInfo.Visible = false;

            btnCreateInfo.Visible = true;

            gridControl1.Enabled = true;
            txtSearch.Focus();
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            TblInfor newInfo = new TblInfor();

            // Check Data Input
            bool checkInputFlag = true;
            string message = "Thông báo : ";

            if (txtInfoTitle.Text.Trim().Length == 0)
            {
                checkInputFlag = false;
                message += "\n Phải nhập tiêu đề.";
            }

            if (txtContent.Text.Trim().Length == 0)
            {
                checkInputFlag = false;
                message += "\n Phải nhập nội dung.";
            }

            if (chkInfoType.Checked)
                if (dateFrom.Value == null || dateTo.Value == null || dateTo.Value < dateFrom.Value)
                {
                    checkInputFlag = false;
                    message += "\n Giới hạn ngày bắt đầu không được lớn hơn ngày kết thúc";
                }

            if (!checkInputFlag)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, this.FindForm(), message, "Không thể tạo mới", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                if (chkInfoType.Checked)
                {
                    newInfo.BeginDate = dateFrom.Value.Date;
                    newInfo.ExprieDate = dateTo.Value.Date.AddHours(23);
                }

                if (createNewFlag)
                {
                    newInfo.CreateDate = DateTime.Now;
                    newInfo.CreateUserID = currentUser.UserID;
                    newInfo.ID = Guid.NewGuid();
                }
                else
                {
                    newInfo.CreateDate = currentInfo.CreateDate;
                    newInfo.CreateUserID = currentInfo.CreateUserID;
                    newInfo.ID = currentInfo.ID;
                }
                newInfo.InfoContent = txtContent.Text.Trim();
                newInfo.InfoContentHtml = txtContent.HtmlText.Trim();
                newInfo.InfoTag = txtTag.Text.Trim();
                newInfo.InfoTitle = txtInfoTitle.Text.Trim();
                newInfo.InfoType = (chkInfoType.Checked) ? InformationType.Limited : InformationType.NoLimit;
                newInfo.Status = (chkStatus.Checked) ? InformationStatus.Approved : InformationStatus.Pending;

                newInfo.UpdateDate = DateTime.Now;
                newInfo.UpdateUserID = currentUser.UserID;
                newInfo.IsDeleted = 0;
                try
                {
                    BBLInfo b = new BBLInfo();
                    b.InsertOrUpdate(newInfo);

                    btnDeleteInfo.Visible = false;
                    btnEdit.Visible = false;
                    btnCancelEditInfo.Visible = false;
                    btnSaveInfo.Visible = false;

                    btnCreateInfo.Visible = true;

                    gridControl1.Enabled = true;
                    if (createNewFlag)
                    {
                        createNewFlag = false;
                        currentSelectedIndex = 0;
                    }
                    lstInfo = info.GetAll().Where(x=>x.IsDeleted==0);
                    LoadData();
                    grvMainInfo.FocusedRowHandle = currentSelectedIndex;

                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, this.FindForm(), ex.Message, "Có sự cố", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }


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

            btnDeleteInfo.Visible = true;
            btnEdit.Visible = true;
            btnCancelEditInfo.Visible = false;
            btnSaveInfo.Visible = false;

            btnCreateInfo.Visible = true;


        }

        private void cbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RunFilter();
        }

        private void grvMainInfo_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ViewDataToForm(e.FocusedRowHandle);
        }

        private void ViewDataToForm(int focusedRowHandle)
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
                        txtContent.HtmlText = string.Empty;
                        txtTag.Text = string.Empty;
                        chkInfoType.Checked = false;
                        chkStatus.Checked = false;

                        btnDeleteInfo.Visible = false;
                        btnEdit.Visible = false;
                        btnCancelEditInfo.Visible = false;
                        btnSaveInfo.Visible = false;

                        btnCreateInfo.Visible = true;
                        txtSearch.Focus();
                    }
                }
            }
            catch (Exception)
            {

                // Reset
                txtInfoTitle.Text = string.Empty;
                txtContent.HtmlText = string.Empty;
                txtTag.Text = string.Empty;
                chkInfoType.Checked = false;
                chkStatus.Checked = false;

                btnDeleteInfo.Visible = false;
                btnEdit.Visible = false;
                btnCancelEditInfo.Visible = false;
                btnSaveInfo.Visible = false;

                btnCreateInfo.Visible = true;
                txtSearch.Focus();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            gridControl1.Enabled = false;

            btnDeleteInfo.Visible = false;
            btnEdit.Visible = false;
            btnCancelEditInfo.Visible = true;
            btnSaveInfo.Visible = true;

            btnCreateInfo.Visible = false;
            txtInfoTitle.Focus();

        }

        private void btnDeleteInfo_Click(object sender, EventArgs e)
        {
            if (grvMainInfo.SelectedRowsCount > 0 && grvMainInfo.FocusedRowHandle >= 0)
            {
                var obj = (TblInfor)lstShowData.ToList()[grvMainInfo.GetDataSourceRowIndex(grvMainInfo.FocusedRowHandle)];
                if (obj != null)
                {
                    if (DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, this.FindForm(),  "Bạn chắc chắn muốn xóa  " + obj.InfoTitle, "Xóa thông tin",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        if (DeleteInfo(obj)) {
                            // Reset
                            txtInfoTitle.Text = string.Empty;
                            txtContent.HtmlText = string.Empty;
                            txtTag.Text = string.Empty;
                            chkInfoType.Checked = false;
                            chkStatus.Checked = false;

                            btnDeleteInfo.Visible = false;
                            btnEdit.Visible = false;
                            btnCancelEditInfo.Visible = false;
                            btnSaveInfo.Visible = false;

                            btnCreateInfo.Visible = true;
                            txtSearch.Focus();

                            LoadData(); 
                        }
                    }
                }
            }
        }

        private bool DeleteInfo(TblInfor obj)
        {
            try
            {
                obj.IsDeleted = 1;
                obj.UpdateDate = DateTime.Now;
                info.InsertOrUpdate(obj);
                return true;
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, this.FindForm(), ex.Message, "Không thể xóa " + obj.InfoTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



        internal void SetAll()
        {
            throw new NotImplementedException();
        }
        ContentFullScreen ctf;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ctf = new ContentFullScreen();
            currentInfo.InfoContentHtml = txtContent.HtmlText;
            ctf.setInfo(currentInfo);


            ctf.ShowDialog();

            if (ctf.isSaved)
            {
                txtContent.HtmlText =  ctf.info.InfoContentHtml;
            }
            ctf.Dispose();
        }

        private void grvMainInfo_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ViewDataToForm(e.RowHandle);
        }
    }
}
