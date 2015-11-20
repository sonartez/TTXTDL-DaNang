using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Sonartez.Entities;

namespace Sonartez.Helpdesk
{
    public partial class ContentFullScreen : DevExpress.XtraEditors.XtraForm
    {
        public TblInfor info;
        public bool isSaved;
        public ContentFullScreen()
        {
            InitializeComponent();

           
        }

        private void ContentFullScreen_Load(object sender, EventArgs e)
        {
           
         
        }
        public void setInfo(TblInfor _info) {
            this.isSaved = false;
            this.info = _info;
            this.Text = info.InfoTitle;
            this.richEditControl1.HtmlText = info.InfoContentHtml;
            richEditControl1.Document.Sections[0].Page.PaperKind = System.Drawing.Printing.PaperKind.A3Extra;
            richEditControl1.Document.Sections[0].Page.Landscape = true;
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.isSaved = true;
            this.info.InfoContentHtml = richEditControl1.HtmlText;
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.isSaved = false;
            this.Close();
        }
    }
}