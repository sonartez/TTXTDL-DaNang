using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sonartez.Entities;

namespace Sonartez.Helpdesk
{
    public partial class CtrlInfoItem : UserControl
    {
        public TblInfor Info = new TblInfor();
        public CtrlInfoItem()
        {
            InitializeComponent();
        }

        public CtrlInfoItem(TblInfor data)
        {
            InitializeComponent();
            this.Info = data;
            txtContent.Text = data.InfoContent;
            txtDate.Text = data.UpdateDate.Value.ToString("dd/MM/yyyy hh:mm");
            txtTitle.Text = data.InfoTitle;
        }
        
    }
}
