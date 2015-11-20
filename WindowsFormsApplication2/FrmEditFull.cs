using Sonartez.Entities;
using Sonartez.Helpdesk.Bussiness;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sonartez.Helpdesk
{
    public partial class FrmEditFull : Form
    {
        BBLConsultant cons;
        private Entities.TblConsultantLog cLog;
        public FrmEditFull()
        {
            InitializeComponent();
        }

        public FrmEditFull(Entities.TblConsultantLog cLog)
        {
            // TODO: Complete member initialization
            this.cLog = cLog;
            InitializeComponent();

            cbbCountry.DisplayMember = "Display";
            cbbCountry.ValueMember = "Value";
            cbbCountry.DataSource = CountryList();
            cbbCountry.SelectedValue = "VN";

            cbbTgType.DisplayMember = "Display";
            cbbTgType.ValueMember = "Value";
            cbbTgType.DataSource = ConsultantType.listValue;
            cbbTgType.SelectedValue = cLog.TargetType;

            txtDate.Text = cLog.CreateDate.Value.ToString("dd/MM/yyyy hh:mm");
            txtUserInfo.Text = cLog.UserName + " - " + cLog.ClientName + "(" + cLog.ClientCode + ")";

            txtQuestion.Text = cLog.Question;

            txtDescription.Text = cLog.Descriptions;

            if (cLog.TargetCount.HasValue)
                txtSL.Value = cLog.TargetCount.Value;
            txtTgEmail.Text = cLog.TargetEmail;
            txtTgName.Text = cLog.TargetName;
            txtTgPhone.Text = cLog.TargetPhoneNumber;
            cbbCountry.SelectedValue = cLog.TargetCountry;
            cbbTgType.SelectedValue = cLog.TargetType;
           
            
        }
        public List<listItem> CountryList()
        {
            List<listItem> slCountry = new List<listItem>();
            string Key = "";
            string Value = "";

            foreach (CultureInfo info in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                RegionInfo info2 = new RegionInfo(info.LCID);

                if (!slCountry.Exists(x => x.Display == info2.EnglishName))
                {
                    Value = info2.TwoLetterISORegionName;
                    Key = info2.EnglishName;
                    slCountry.Add(new listItem() { Display = Key, Value = Value });
                }
                
            }
            return slCountry.OrderBy(x=>x.Display).ToList();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {           
            cLog.FinishType = ConsultantFinishType.Good;
            cLog.FinishDate = DateTime.Now;
            cLog.Status = ConsultantStatus.OK;
            cLog.TargetCount = (int)txtSL.Value;
            cLog.TargetCountry = cbbCountry.Text.ToString();
            cLog.TargetEmail = txtTgEmail.Text;
            cLog.TargetName = txtTgName.Text;
            cLog.TargetPhoneNumber = txtTgPhone.Text;
            cLog.TargetType = cbbTgType.Text.ToString();
            cLog.ConsType = cbbTgType.Text.ToString();
            cLog.Question = txtQuestion.Text;
            cLog.Descriptions = txtDescription.Text;
            cons.InsertOrUpdate(cLog);
            DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, this.FindForm(), " Thông tin đã lưu thành công ", "Thành công ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            }
            catch (Exception ex)
            {

                DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, this.FindForm(),  "Phát hiện lỗi trong quá trình lưu \n"+ ex.Message,"Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
            }
        }

        private void FrmSaveHotline_Load(object sender, EventArgs e)
        {
            cons = new BBLConsultant();

           
        }

        private void btnNotOK_Click(object sender, EventArgs e)
        {
            try
            {
                cLog.FinishType = ConsultantFinishType.Incomplete;
                cLog.FinishDate = DateTime.Now;
                cLog.Status = ConsultantStatus.OK;
                cLog.TargetCount = (int)txtSL.Value;
                cLog.TargetCountry = cbbCountry.Text.ToString();
                cLog.TargetEmail = txtTgEmail.Text;
                cLog.TargetName = txtTgName.Text;
                cLog.TargetPhoneNumber = txtTgPhone.Text;
                cLog.TargetType = cbbTgType.Text.ToString();
                cLog.ConsType = cbbTgType.Text.ToString();
                cLog.Question = txtQuestion.Text;
                cLog.Descriptions = txtDescription.Text;
                cons.InsertOrUpdate(cLog);
                DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, this.FindForm(), " Thông tin đã lưu thành công ", "Thành công ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {

                DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, this.FindForm(), "Phát hiện lỗi trong quá trình lưu \n" + ex.Message, "Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void FrmSaveFull_Load(object sender, EventArgs e)
        {
            cons = new BBLConsultant();
            txtTgName.Focus();
        }
    }
}
