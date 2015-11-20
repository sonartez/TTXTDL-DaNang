using Sonartez.Entities;
using Sonartez.Helpdesk.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sonartez.Helpdesk
{
    public partial class FrmSaveHotline : Form
    {
        BBLConsultant cons;

        private Entities.TblConsultantLog cLog;

        public FrmSaveHotline()
        {
            InitializeComponent();
        }

        public FrmSaveHotline(Entities.TblConsultantLog cLog)
        {
            // TODO: Complete member initialization
            this.cLog = cLog;
            InitializeComponent();
            txtQuestion.Text = cLog.Question;
           
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {

           
            cLog.FinishType = ConsultantFinishType.Good;
            cLog.Status = ConsultantStatus.OK;
            cLog.TargetCountry = "VietNam";
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
            cLog.Status = ConsultantStatus.OK;
            cLog.TargetCountry = "VietNam";
            cLog.Question = txtQuestion.Text;
            cLog.Descriptions = txtDescription.Text;
            cons.InsertOrUpdate(cLog);
            DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, this.FindForm(), " Thông tin đã lưu thành công ", "Thành công ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            }
            catch (Exception ex)
            {

                DevExpress.XtraEditors.XtraMessageBox.Show(DevExpress.LookAndFeel.UserLookAndFeel.Default, this.FindForm(),  "Phát hiện lỗi trong quá trình lưu \n"+ ex.Message,"Không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            }
        }
    }
}
