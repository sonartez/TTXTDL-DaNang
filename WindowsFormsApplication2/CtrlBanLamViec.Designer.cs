//using BrightIdeasSoftware;
namespace Sonartez.Helpdesk
{
    partial class CtrlBanLamViec
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.btnSaveHotLine = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.grvMainInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTags = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.cbbStatus = new MetroFramework.Controls.MetroComboBox();
            this.cbbType = new MetroFramework.Controls.MetroComboBox();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroPanelInfo = new MetroFramework.Controls.MetroPanel();
            this.txtContent = new DevExpress.XtraRichEdit.RichEditControl();
            this.txtInfoTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.chkStatus = new MetroFramework.Controls.MetroToggle();
            this.txtTag = new MetroFramework.Controls.MetroTextBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.chkInfoType = new MetroFramework.Controls.MetroToggle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMainInfo)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.metroPanelInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Highlight = true;
            this.btnRefresh.Location = new System.Drawing.Point(7, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 52);
            this.btnRefresh.Style = MetroFramework.MetroColorStyle.Lime;
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Làm mới thông tin";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSaveHotLine
            // 
            this.btnSaveHotLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveHotLine.Highlight = true;
            this.btnSaveHotLine.Location = new System.Drawing.Point(304, 22);
            this.btnSaveHotLine.Name = "btnSaveHotLine";
            this.btnSaveHotLine.Size = new System.Drawing.Size(117, 52);
            this.btnSaveHotLine.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnSaveHotLine.TabIndex = 3;
            this.btnSaveHotLine.Text = "Tư Vấn Tại Chổ";
            this.btnSaveHotLine.Click += new System.EventHandler(this.btnSaveHotLine_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.btnRefresh);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(128, 588);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(7, 71);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(117, 52);
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "GOOGLE Search";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitContainerControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(128, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1000, 588);
            this.panelControl1.TabIndex = 5;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(2, 2);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.metroPanel3);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.metroPanelInfo);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(996, 584);
            this.splitContainerControl1.SplitterPosition = 558;
            this.splitContainerControl1.TabIndex = 8;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Enabled = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Enabled = false;
            this.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Enabled = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Enabled = false;
            this.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Enabled = false;
            this.gridControl1.EmbeddedNavigator.Buttons.Remove.Visible = false;
            this.gridControl1.EmbeddedNavigator.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.gridControl1.EmbeddedNavigator.TextStringFormat = "Đang chọn nội dung thứ {0} cua tất cả {1}";
            this.gridControl1.Location = new System.Drawing.Point(0, 43);
            this.gridControl1.LookAndFeel.SkinName = "Office 2013";
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.grvMainInfo;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(558, 541);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMainInfo});
            // 
            // grvMainInfo
            // 
            this.grvMainInfo.Appearance.FocusedCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grvMainInfo.Appearance.FocusedCell.Options.UseForeColor = true;
            this.grvMainInfo.Appearance.FocusedRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grvMainInfo.Appearance.FocusedRow.Options.UseForeColor = true;
            this.grvMainInfo.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grvMainInfo.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grvMainInfo.Appearance.Preview.Options.UseFont = true;
            this.grvMainInfo.Appearance.Preview.Options.UseForeColor = true;
            this.grvMainInfo.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.grvMainInfo.Appearance.SelectedRow.Options.UseForeColor = true;
            this.grvMainInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTitle,
            this.colType,
            this.colDate,
            this.colStatus,
            this.colContent,
            this.colTags,
            this.colID});
            this.grvMainInfo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grvMainInfo.GridControl = this.gridControl1;
            this.grvMainInfo.Name = "grvMainInfo";
            this.grvMainInfo.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grvMainInfo.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grvMainInfo.OptionsBehavior.Editable = false;
            this.grvMainInfo.OptionsCustomization.AllowColumnMoving = false;
            this.grvMainInfo.OptionsView.AutoCalcPreviewLineCount = true;
            this.grvMainInfo.OptionsView.ShowAutoFilterRow = true;
            this.grvMainInfo.OptionsView.ShowGroupPanel = false;
            this.grvMainInfo.OptionsView.ShowPreview = true;
            this.grvMainInfo.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.True;
            this.grvMainInfo.PreviewFieldName = "InfoContent";
            this.grvMainInfo.PreviewLineCount = 5;
            this.grvMainInfo.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.grvMainInfo.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.grvMainInfo_RowClick);
            this.grvMainInfo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvMainInfo_FocusedRowChanged);
            // 
            // colTitle
            // 
            this.colTitle.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colTitle.AppearanceCell.ForeColor = System.Drawing.Color.RoyalBlue;
            this.colTitle.AppearanceCell.Options.UseFont = true;
            this.colTitle.AppearanceCell.Options.UseForeColor = true;
            this.colTitle.Caption = "Tên";
            this.colTitle.FieldName = "InfoTitle";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 0;
            this.colTitle.Width = 198;
            // 
            // colType
            // 
            this.colType.Caption = "Loại";
            this.colType.FieldName = "InfoType";
            this.colType.Name = "colType";
            this.colType.OptionsColumn.FixedWidth = true;
            this.colType.Visible = true;
            this.colType.VisibleIndex = 1;
            this.colType.Width = 115;
            // 
            // colDate
            // 
            this.colDate.Caption = "Ngày cập nhật";
            this.colDate.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm";
            this.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDate.FieldName = "UpdateDate";
            this.colDate.Name = "colDate";
            this.colDate.OptionsColumn.FixedWidth = true;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 3;
            this.colDate.Width = 112;
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Duyệt";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.FixedWidth = true;
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 2;
            this.colStatus.Width = 102;
            // 
            // colContent
            // 
            this.colContent.Caption = "Nội dung";
            this.colContent.FieldName = "InfoContent";
            this.colContent.Name = "colContent";
            // 
            // colTags
            // 
            this.colTags.Caption = "Tags";
            this.colTags.FieldName = "InfoTag";
            this.colTags.Name = "colTags";
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.cbbStatus);
            this.metroPanel3.Controls.Add(this.cbbType);
            this.metroPanel3.Controls.Add(this.txtSearch);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(558, 43);
            this.metroPanel3.TabIndex = 6;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // cbbStatus
            // 
            this.cbbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbStatus.DisplayMember = "Display";
            this.cbbStatus.ItemHeight = 23;
            this.cbbStatus.Location = new System.Drawing.Point(419, 8);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(136, 29);
            this.cbbStatus.TabIndex = 2;
            this.cbbStatus.ValueMember = "Value";
            this.cbbStatus.SelectedValueChanged += new System.EventHandler(this.cbbStatus_SelectedIndexChanged);
            // 
            // cbbType
            // 
            this.cbbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbType.DisplayMember = "Display";
            this.cbbType.ItemHeight = 23;
            this.cbbType.Location = new System.Drawing.Point(240, 8);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(175, 29);
            this.cbbType.TabIndex = 1;
            this.cbbType.ValueMember = "Value";
            this.cbbType.SelectedValueChanged += new System.EventHandler(this.cbbType_SelectedValueChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearch.Location = new System.Drawing.Point(2, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PromptText = "Tìm kiếm";
            this.txtSearch.Size = new System.Drawing.Size(229, 29);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.UseStyleColors = true;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // metroPanelInfo
            // 
            this.metroPanelInfo.Controls.Add(this.txtContent);
            this.metroPanelInfo.Controls.Add(this.txtInfoTitle);
            this.metroPanelInfo.Controls.Add(this.metroLabel3);
            this.metroPanelInfo.Controls.Add(this.chkStatus);
            this.metroPanelInfo.Controls.Add(this.txtTag);
            this.metroPanelInfo.Controls.Add(this.dateTo);
            this.metroPanelInfo.Controls.Add(this.dateFrom);
            this.metroPanelInfo.Controls.Add(this.metroLabel2);
            this.metroPanelInfo.Controls.Add(this.chkInfoType);
            this.metroPanelInfo.Controls.Add(this.groupBox1);
            this.metroPanelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelInfo.HorizontalScrollbarBarColor = true;
            this.metroPanelInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelInfo.HorizontalScrollbarSize = 10;
            this.metroPanelInfo.Location = new System.Drawing.Point(0, 0);
            this.metroPanelInfo.Name = "metroPanelInfo";
            this.metroPanelInfo.Size = new System.Drawing.Size(433, 584);
            this.metroPanelInfo.TabIndex = 5;
            this.metroPanelInfo.VerticalScrollbarBarColor = true;
            this.metroPanelInfo.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelInfo.VerticalScrollbarSize = 10;
            // 
            // txtContent
            // 
            this.txtContent.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Location = new System.Drawing.Point(9, 104);
            this.txtContent.Name = "txtContent";
            this.txtContent.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.txtContent.Options.MailMerge.KeepLastParagraph = false;
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(414, 307);
            this.txtContent.TabIndex = 19;
            this.txtContent.Views.DraftView.Padding = new System.Windows.Forms.Padding(5);
            this.txtContent.DoubleClick += new System.EventHandler(this.txtContent_DoubleClick);
            // 
            // txtInfoTitle
            // 
            this.txtInfoTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfoTitle.BackColor = System.Drawing.Color.White;
            this.txtInfoTitle.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtInfoTitle.Location = new System.Drawing.Point(9, 69);
            this.txtInfoTitle.Name = "txtInfoTitle";
            this.txtInfoTitle.PromptText = "Tiêu đề";
            this.txtInfoTitle.Size = new System.Drawing.Size(414, 29);
            this.txtInfoTitle.TabIndex = 16;
            this.txtInfoTitle.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 459);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(185, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Thông tin đã được kiểm duyệt";
            // 
            // chkStatus
            // 
            this.chkStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStatus.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(343, 458);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(80, 23);
            this.chkStatus.TabIndex = 10;
            this.chkStatus.Text = "Off";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // txtTag
            // 
            this.txtTag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTag.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTag.Location = new System.Drawing.Point(9, 417);
            this.txtTag.Name = "txtTag";
            this.txtTag.PromptText = "Từ khóa liên quan (để tìm nhanh)";
            this.txtTag.Size = new System.Drawing.Size(416, 29);
            this.txtTag.TabIndex = 3;
            this.txtTag.UseStyleColors = true;
            this.txtTag.Click += new System.EventHandler(this.txtTag_Click);
            // 
            // dateTo
            // 
            this.dateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Enabled = false;
            this.dateTo.Location = new System.Drawing.Point(263, 40);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(161, 20);
            this.dateTo.TabIndex = 9;
            // 
            // dateFrom
            // 
            this.dateFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Enabled = false;
            this.dateFrom.Location = new System.Drawing.Point(8, 40);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(166, 20);
            this.dateFrom.TabIndex = 8;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 11);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(188, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Nội dung có giới hạn thời gian";
            // 
            // chkInfoType
            // 
            this.chkInfoType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkInfoType.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkInfoType.AutoSize = true;
            this.chkInfoType.Location = new System.Drawing.Point(343, 9);
            this.chkInfoType.Name = "chkInfoType";
            this.chkInfoType.Size = new System.Drawing.Size(80, 23);
            this.chkInfoType.TabIndex = 6;
            this.chkInfoType.Text = "Off";
            this.chkInfoType.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnSaveHotLine);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 499);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 85);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lưu kết quả";
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(9, 22);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(117, 52);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton1.TabIndex = 17;
            this.metroButton1.Text = "HOTLINE";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // CtrlBanLamViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "CtrlBanLamViec";
            this.Size = new System.Drawing.Size(1128, 588);
            this.Load += new System.EventHandler(this.CtrlBanLamViec_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMainInfo)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanelInfo.ResumeLayout(false);
            this.metroPanelInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroButton btnSaveHotLine;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroComboBox cbbStatus;
        private MetroFramework.Controls.MetroComboBox cbbType;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMainInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colContent;
        private DevExpress.XtraGrid.Columns.GridColumn colTags;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private MetroFramework.Controls.MetroPanel metroPanelInfo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroToggle chkStatus;
        private MetroFramework.Controls.MetroTextBox txtTag;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroToggle chkInfoType;
        private MetroFramework.Controls.MetroTextBox txtInfoTitle;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraRichEdit.RichEditControl txtContent;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}
