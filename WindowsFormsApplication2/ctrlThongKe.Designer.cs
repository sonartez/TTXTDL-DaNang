namespace Sonartez.Helpdesk
{
    partial class ctrlThongKe
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.grvMainInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConsType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinishType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuestion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnswerRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUpdateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTargetName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTagertEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTargetCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTargetCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTargetType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTargetPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinishDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubmitDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMainInfo)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.gridControl1.Location = new System.Drawing.Point(128, 0);
            this.gridControl1.LookAndFeel.SkinName = "Office 2013";
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.grvMainInfo;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(709, 552);
            this.gridControl1.TabIndex = 8;
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
            this.colID,
            this.colCreateDate,
            this.colConsType,
            this.colFinishType,
            this.colQuestion,
            this.colDescription,
            this.colAnswerRef,
            this.colStatus,
            this.colClientName,
            this.colUpdateDate,
            this.colUserName,
            this.colTargetName,
            this.colTagertEmail,
            this.colTargetCountry,
            this.colTargetCount,
            this.colTargetType,
            this.colTargetPhoneNumber,
            this.colFinishDate,
            this.colSubmitDate,
            this.colClientID,
            this.colClientCode,
            this.colUserID});
            this.grvMainInfo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grvMainInfo.GridControl = this.gridControl1;
            this.grvMainInfo.Name = "grvMainInfo";
            this.grvMainInfo.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.grvMainInfo.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.grvMainInfo.OptionsBehavior.Editable = false;
            this.grvMainInfo.OptionsView.AutoCalcPreviewLineCount = true;
            this.grvMainInfo.OptionsView.ShowAutoFilterRow = true;
            this.grvMainInfo.OptionsView.ShowFooter = true;
            this.grvMainInfo.OptionsView.ShowPreview = true;
            this.grvMainInfo.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.True;
            this.grvMainInfo.PreviewFieldName = "Description";
            this.grvMainInfo.PreviewLineCount = 5;
            this.grvMainInfo.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colCreateDate
            // 
            this.colCreateDate.Caption = "Ngày tạo";
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 0;
            // 
            // colConsType
            // 
            this.colConsType.Caption = "Loại tư vấn";
            this.colConsType.FieldName = "ConsType";
            this.colConsType.Name = "colConsType";
            this.colConsType.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colConsType.Visible = true;
            this.colConsType.VisibleIndex = 1;
            // 
            // colFinishType
            // 
            this.colFinishType.Caption = "Tình trạng hoàn tất";
            this.colFinishType.FieldName = "FinishType";
            this.colFinishType.Name = "colFinishType";
            this.colFinishType.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colFinishType.Visible = true;
            this.colFinishType.VisibleIndex = 2;
            // 
            // colQuestion
            // 
            this.colQuestion.Caption = "Câu hỏi";
            this.colQuestion.FieldName = "Question";
            this.colQuestion.Name = "colQuestion";
            this.colQuestion.Visible = true;
            this.colQuestion.VisibleIndex = 3;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Ghi chú";
            this.colDescription.FieldName = "Descriptions";
            this.colDescription.Name = "colDescription";
            // 
            // colAnswerRef
            // 
            this.colAnswerRef.Caption = "Trả lời liên quan";
            this.colAnswerRef.FieldName = "AnswerRef";
            this.colAnswerRef.Name = "colAnswerRef";
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Tình trạng";
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 4;
            // 
            // colClientName
            // 
            this.colClientName.Caption = "Tên Trạm";
            this.colClientName.FieldName = "ClientName";
            this.colClientName.Name = "colClientName";
            this.colClientName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colClientName.Visible = true;
            this.colClientName.VisibleIndex = 5;
            // 
            // colUpdateDate
            // 
            this.colUpdateDate.Caption = "Cập nhật";
            this.colUpdateDate.FieldName = "UpdateDate";
            this.colUpdateDate.Name = "colUpdateDate";
            // 
            // colUserName
            // 
            this.colUserName.Caption = "Tên NV";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 6;
            // 
            // colTargetName
            // 
            this.colTargetName.Caption = "Tên Khách";
            this.colTargetName.FieldName = "TargetName";
            this.colTargetName.Name = "colTargetName";
            this.colTargetName.Visible = true;
            this.colTargetName.VisibleIndex = 7;
            // 
            // colTagertEmail
            // 
            this.colTagertEmail.Caption = "Email khách";
            this.colTagertEmail.FieldName = "TagertEmail";
            this.colTagertEmail.Name = "colTagertEmail";
            // 
            // colTargetCountry
            // 
            this.colTargetCountry.Caption = "Quốc gia";
            this.colTargetCountry.FieldName = "TargetCountry";
            this.colTargetCountry.Name = "colTargetCountry";
            this.colTargetCountry.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colTargetCountry.Visible = true;
            this.colTargetCountry.VisibleIndex = 8;
            // 
            // colTargetCount
            // 
            this.colTargetCount.Caption = "Số lượng";
            this.colTargetCount.FieldName = "TargetCount";
            this.colTargetCount.Name = "colTargetCount";
            this.colTargetCount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            // 
            // colTargetType
            // 
            this.colTargetType.Caption = "Loại khách";
            this.colTargetType.FieldName = "TargetType";
            this.colTargetType.Name = "colTargetType";
            this.colTargetType.Visible = true;
            this.colTargetType.VisibleIndex = 9;
            // 
            // colTargetPhoneNumber
            // 
            this.colTargetPhoneNumber.Caption = "Điện thoại ";
            this.colTargetPhoneNumber.FieldName = "TargetPhoneNumber";
            this.colTargetPhoneNumber.Name = "colTargetPhoneNumber";
            // 
            // colFinishDate
            // 
            this.colFinishDate.Caption = "Hoàn thành";
            this.colFinishDate.FieldName = "FinishDate";
            this.colFinishDate.Name = "colFinishDate";
            // 
            // colSubmitDate
            // 
            this.colSubmitDate.Caption = "Lưu máy chủ";
            this.colSubmitDate.FieldName = "SubmitDate";
            this.colSubmitDate.Name = "colSubmitDate";
            // 
            // colClientID
            // 
            this.colClientID.Caption = "ID Trạm";
            this.colClientID.FieldName = "ClientID";
            this.colClientID.Name = "colClientID";
            // 
            // colClientCode
            // 
            this.colClientCode.Caption = "Mã Trạm";
            this.colClientCode.FieldName = "ClientCode";
            this.colClientCode.Name = "colClientCode";
            // 
            // colUserID
            // 
            this.colUserID.Caption = "Mã NV";
            this.colUserID.FieldName = "UserID";
            this.colUserID.Name = "colUserID";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnEdit);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.btnRefresh);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(128, 552);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(7, 68);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(117, 52);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Biểu đồ";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
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
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Highlight = true;
            this.btnEdit.Location = new System.Drawing.Point(7, 507);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 30);
            this.btnEdit.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Chỉnh Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ctrlThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "ctrlThongKe";
            this.Size = new System.Drawing.Size(837, 552);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMainInfo)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMainInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colConsType;
        private DevExpress.XtraGrid.Columns.GridColumn colFinishType;
        private DevExpress.XtraGrid.Columns.GridColumn colQuestion;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colAnswerRef;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colClientName;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colTargetName;
        private DevExpress.XtraGrid.Columns.GridColumn colTagertEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colTargetCountry;
        private DevExpress.XtraGrid.Columns.GridColumn colTargetCount;
        private DevExpress.XtraGrid.Columns.GridColumn colTargetType;
        private DevExpress.XtraGrid.Columns.GridColumn colTargetPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colFinishDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSubmitDate;
        private DevExpress.XtraGrid.Columns.GridColumn colClientID;
        private DevExpress.XtraGrid.Columns.GridColumn colClientCode;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private MetroFramework.Controls.MetroButton btnEdit;
    }
}
