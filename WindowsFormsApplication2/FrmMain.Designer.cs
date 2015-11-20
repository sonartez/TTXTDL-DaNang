namespace Sonartez.Helpdesk
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.côngCụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNgươiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thiếtLậpMáyTrạmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.đồngBộNgayVớiServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDongBo = new System.Windows.Forms.Panel();
            this.ctrlBanLamViec1 = new Sonartez.Helpdesk.CtrlBanLamViec();
            this.ctrlThongKe1 = new Sonartez.Helpdesk.ctrlThongKe();
            this.ctrlQuanLyNoiDung1 = new Sonartez.Helpdesk.CtrlQuanLyNoiDung();
            this.metroTabControl2.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panelDongBo.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Location = new System.Drawing.Point(68, 278);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.Size = new System.Drawing.Size(8, 8);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.metroTabPage1);
            this.metroTabControl2.Controls.Add(this.metroTabPage3);
            this.metroTabControl2.Controls.Add(this.metroTabPage2);
            this.metroTabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl2.Location = new System.Drawing.Point(20, 54);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 0;
            this.metroTabControl2.Size = new System.Drawing.Size(1056, 545);
            this.metroTabControl2.TabIndex = 1;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.ctrlBanLamViec1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Padding = new System.Windows.Forms.Padding(1);
            this.metroTabPage1.Size = new System.Drawing.Size(1048, 506);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Tra cứu thông tin";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.ctrlThongKe1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Padding = new System.Windows.Forms.Padding(1);
            this.metroTabPage3.Size = new System.Drawing.Size(1048, 506);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Thống kê hoạt động";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.panel2);
            this.metroTabPage2.Controls.Add(this.panel1);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Padding = new System.Windows.Forms.Padding(1);
            this.metroTabPage2.Size = new System.Drawing.Size(1048, 506);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Quản lý nội dung";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ctrlQuanLyNoiDung1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(129, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 504);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.metroButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 504);
            this.panel1.TabIndex = 4;
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(4, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(119, 50);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Làm mới thông tin";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.metroLabel1.Location = new System.Drawing.Point(-12137, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(317, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "DA NANG TOURISM INFORMATION HELPDESK";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "DA NANG TOURISM INFORMATION HELPDESK";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.côngCụToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(20, 30);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1056, 24);
            this.menuStrip2.TabIndex = 6;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // côngCụToolStripMenuItem
            // 
            this.côngCụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNgươiDùngToolStripMenuItem,
            this.thiếtLậpMáyTrạmToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.toolStripSeparator2,
            this.đồngBộNgayVớiServerToolStripMenuItem,
            this.resetUpdateToolStripMenuItem});
            this.côngCụToolStripMenuItem.Name = "côngCụToolStripMenuItem";
            this.côngCụToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.côngCụToolStripMenuItem.Text = "Công cụ";
            // 
            // quảnLýNgươiDùngToolStripMenuItem
            // 
            this.quảnLýNgươiDùngToolStripMenuItem.Name = "quảnLýNgươiDùngToolStripMenuItem";
            this.quảnLýNgươiDùngToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.quảnLýNgươiDùngToolStripMenuItem.Text = "Quản Lý ngươi dùng";
            this.quảnLýNgươiDùngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNgươiDùngToolStripMenuItem_Click);
            // 
            // thiếtLậpMáyTrạmToolStripMenuItem
            // 
            this.thiếtLậpMáyTrạmToolStripMenuItem.Name = "thiếtLậpMáyTrạmToolStripMenuItem";
            this.thiếtLậpMáyTrạmToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.thiếtLậpMáyTrạmToolStripMenuItem.Text = "Thiết lập máy trạm";
            this.thiếtLậpMáyTrạmToolStripMenuItem.Click += new System.EventHandler(this.thiếtLậpMáyTrạmToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // đồngBộNgayVớiServerToolStripMenuItem
            // 
            this.đồngBộNgayVớiServerToolStripMenuItem.Name = "đồngBộNgayVớiServerToolStripMenuItem";
            this.đồngBộNgayVớiServerToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.đồngBộNgayVớiServerToolStripMenuItem.Text = "Đồng bộ ngay với Server";
            this.đồngBộNgayVớiServerToolStripMenuItem.Click += new System.EventHandler(this.đồngBộNgayVớiServerToolStripMenuItem_Click);
            // 
            // resetUpdateToolStripMenuItem
            // 
            this.resetUpdateToolStripMenuItem.Name = "resetUpdateToolStripMenuItem";
            this.resetUpdateToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.resetUpdateToolStripMenuItem.Text = "Reset Update";
            this.resetUpdateToolStripMenuItem.Click += new System.EventHandler(this.resetUpdateToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(101, 6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(144, 10);
            this.progressBar1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đồng bộ dữ liệu...";
            // 
            // panelDongBo
            // 
            this.panelDongBo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDongBo.BackColor = System.Drawing.Color.Transparent;
            this.panelDongBo.Controls.Add(this.label2);
            this.panelDongBo.Controls.Add(this.progressBar1);
            this.panelDongBo.Location = new System.Drawing.Point(827, 31);
            this.panelDongBo.Name = "panelDongBo";
            this.panelDongBo.Size = new System.Drawing.Size(249, 24);
            this.panelDongBo.TabIndex = 5;
            // 
            // ctrlBanLamViec1
            // 
            this.ctrlBanLamViec1.BackColor = System.Drawing.Color.White;
            this.ctrlBanLamViec1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlBanLamViec1.Location = new System.Drawing.Point(1, 1);
            this.ctrlBanLamViec1.Name = "ctrlBanLamViec1";
            this.ctrlBanLamViec1.Padding = new System.Windows.Forms.Padding(1);
            this.ctrlBanLamViec1.Size = new System.Drawing.Size(1046, 504);
            this.ctrlBanLamViec1.TabIndex = 2;
            // 
            // ctrlThongKe1
            // 
            this.ctrlThongKe1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlThongKe1.Location = new System.Drawing.Point(1, 1);
            this.ctrlThongKe1.Name = "ctrlThongKe1";
            this.ctrlThongKe1.Size = new System.Drawing.Size(1046, 504);
            this.ctrlThongKe1.TabIndex = 2;
            // 
            // ctrlQuanLyNoiDung1
            // 
            this.ctrlQuanLyNoiDung1.BackColor = System.Drawing.Color.White;
            this.ctrlQuanLyNoiDung1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlQuanLyNoiDung1.Location = new System.Drawing.Point(0, 0);
            this.ctrlQuanLyNoiDung1.Name = "ctrlQuanLyNoiDung1";
            this.ctrlQuanLyNoiDung1.Size = new System.Drawing.Size(918, 504);
            this.ctrlQuanLyNoiDung1.TabIndex = 3;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 619);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroTabControl2);
            this.Controls.Add(this.panelDongBo);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.menuStrip2);
            this.DisplayHeader = false;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "DA NANG Tourism HelpDesk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl2.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panelDongBo.ResumeLayout(false);
            this.panelDongBo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem côngCụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private CtrlQuanLyNoiDung ctrlQuanLyNoiDung1;
        private System.Windows.Forms.Panel panel1;
        private CtrlBanLamViec ctrlBanLamViec1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNgươiDùngToolStripMenuItem;
        private ctrlThongKe ctrlThongKe1;
        private System.Windows.Forms.ToolStripMenuItem thiếtLậpMáyTrạmToolStripMenuItem;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem đồngBộNgayVớiServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetUpdateToolStripMenuItem;
        private System.Windows.Forms.Panel panelDongBo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

