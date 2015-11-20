namespace Sonartez.Helpdesk
{
    partial class UserManager
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.grvMainInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastLoginTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColUpdateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.radioQuanLy = new System.Windows.Forms.RadioButton();
            this.radioKiemDuyet = new System.Windows.Forms.RadioButton();
            this.radioTraCuu = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkActive = new MetroFramework.Controls.MetroToggle();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMainInfo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelEdit.SuspendLayout();
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
            this.gridControl1.Location = new System.Drawing.Point(0, 204);
            this.gridControl1.LookAndFeel.SkinName = "Office 2013";
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.grvMainInfo;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(766, 246);
            this.gridControl1.TabIndex = 5;
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
            this.ColID,
            this.ColUserName,
            this.ColFullName,
            this.ColPhoneNumber,
            this.ColEmail,
            this.colLastLoginTime,
            this.ColActive,
            this.ColUpdateDate});
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
            // 
            // ColID
            // 
            this.ColID.Caption = "ID";
            this.ColID.FieldName = "UserID";
            this.ColID.Name = "ColID";
            // 
            // ColUserName
            // 
            this.ColUserName.Caption = "Tên đăng nhập";
            this.ColUserName.FieldName = "UserName";
            this.ColUserName.Name = "ColUserName";
            this.ColUserName.Visible = true;
            this.ColUserName.VisibleIndex = 0;
            // 
            // ColFullName
            // 
            this.ColFullName.Caption = "Tên nhân viên";
            this.ColFullName.FieldName = "FullName";
            this.ColFullName.Name = "ColFullName";
            this.ColFullName.Visible = true;
            this.ColFullName.VisibleIndex = 1;
            // 
            // ColPhoneNumber
            // 
            this.ColPhoneNumber.Caption = "Điện thoại";
            this.ColPhoneNumber.FieldName = "PhoneNumber";
            this.ColPhoneNumber.Name = "ColPhoneNumber";
            this.ColPhoneNumber.Visible = true;
            this.ColPhoneNumber.VisibleIndex = 2;
            // 
            // ColEmail
            // 
            this.ColEmail.Caption = "Email";
            this.ColEmail.FieldName = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.Visible = true;
            this.ColEmail.VisibleIndex = 4;
            // 
            // colLastLoginTime
            // 
            this.colLastLoginTime.Caption = "Đăng nhập lần cuối";
            this.colLastLoginTime.FieldName = "LastLogintime";
            this.colLastLoginTime.Name = "colLastLoginTime";
            // 
            // ColActive
            // 
            this.ColActive.Caption = "Kích hoạt";
            this.ColActive.FieldName = "Active";
            this.ColActive.Name = "ColActive";
            this.ColActive.Visible = true;
            this.ColActive.VisibleIndex = 3;
            // 
            // ColUpdateDate
            // 
            this.ColUpdateDate.Caption = "Update Lần cuối";
            this.ColUpdateDate.FieldName = "UpdateDate";
            this.ColUpdateDate.Name = "ColUpdateDate";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.panelEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 204);
            this.panel1.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(172, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(91, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 29);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(10, 7);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 29);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Thêm";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEdit.Controls.Add(this.radioQuanLy);
            this.panelEdit.Controls.Add(this.radioKiemDuyet);
            this.panelEdit.Controls.Add(this.radioTraCuu);
            this.panelEdit.Controls.Add(this.label7);
            this.panelEdit.Controls.Add(this.label6);
            this.panelEdit.Controls.Add(this.chkActive);
            this.panelEdit.Controls.Add(this.btnSave);
            this.panelEdit.Controls.Add(this.btnCancel);
            this.panelEdit.Controls.Add(this.label4);
            this.panelEdit.Controls.Add(this.label5);
            this.panelEdit.Controls.Add(this.txtPass);
            this.panelEdit.Controls.Add(this.txtUserName);
            this.panelEdit.Controls.Add(this.label3);
            this.panelEdit.Controls.Add(this.txtFullName);
            this.panelEdit.Controls.Add(this.label2);
            this.panelEdit.Controls.Add(this.txtEmail);
            this.panelEdit.Controls.Add(this.label1);
            this.panelEdit.Controls.Add(this.txtPhone);
            this.panelEdit.Location = new System.Drawing.Point(253, 3);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(506, 193);
            this.panelEdit.TabIndex = 11;
            // 
            // radioQuanLy
            // 
            this.radioQuanLy.AutoSize = true;
            this.radioQuanLy.Location = new System.Drawing.Point(416, 122);
            this.radioQuanLy.Name = "radioQuanLy";
            this.radioQuanLy.Size = new System.Drawing.Size(61, 17);
            this.radioQuanLy.TabIndex = 8;
            this.radioQuanLy.TabStop = true;
            this.radioQuanLy.Text = "Quản lý";
            this.radioQuanLy.UseVisualStyleBackColor = true;
            // 
            // radioKiemDuyet
            // 
            this.radioKiemDuyet.AutoSize = true;
            this.radioKiemDuyet.Location = new System.Drawing.Point(416, 78);
            this.radioKiemDuyet.Name = "radioKiemDuyet";
            this.radioKiemDuyet.Size = new System.Drawing.Size(77, 17);
            this.radioKiemDuyet.TabIndex = 7;
            this.radioKiemDuyet.TabStop = true;
            this.radioKiemDuyet.Text = "Kiểm duyệt";
            this.radioKiemDuyet.UseVisualStyleBackColor = true;
            // 
            // radioTraCuu
            // 
            this.radioTraCuu.AutoSize = true;
            this.radioTraCuu.Location = new System.Drawing.Point(416, 33);
            this.radioTraCuu.Name = "radioTraCuu";
            this.radioTraCuu.Size = new System.Drawing.Size(62, 17);
            this.radioTraCuu.TabIndex = 6;
            this.radioTraCuu.TabStop = true;
            this.radioTraCuu.Text = "Tra cứu";
            this.radioTraCuu.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nhóm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cho phép hoạt động dụng";
            // 
            // chkActive
            // 
            this.chkActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkActive.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(237, 121);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(80, 23);
            this.chkActive.TabIndex = 5;
            this.chkActive.Text = "Off";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(416, 156);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 29);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(324, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mật khẩu";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(237, 30);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(156, 22);
            this.txtPass.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(23, 30);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(192, 22);
            this.txtUserName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Điện Thoại";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(23, 75);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(192, 22);
            this.txtFullName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên Nhân Viên";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(23, 119);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(192, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(237, 75);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(156, 22);
            this.txtPhone.TabIndex = 4;
            // 
            // UserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 450);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "UserManager";
            this.Text = "Danh sách người dùng";
            this.Load += new System.EventHandler(this.UserManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMainInfo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMainInfo;
        private DevExpress.XtraGrid.Columns.GridColumn ColID;
        private DevExpress.XtraGrid.Columns.GridColumn ColUserName;
        private DevExpress.XtraGrid.Columns.GridColumn ColFullName;
        private DevExpress.XtraGrid.Columns.GridColumn ColPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn ColEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colLastLoginTime;
        private DevExpress.XtraGrid.Columns.GridColumn ColActive;
        private DevExpress.XtraGrid.Columns.GridColumn ColUpdateDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroToggle chkActive;
        private System.Windows.Forms.RadioButton radioQuanLy;
        private System.Windows.Forms.RadioButton radioKiemDuyet;
        private System.Windows.Forms.RadioButton radioTraCuu;
    }
}