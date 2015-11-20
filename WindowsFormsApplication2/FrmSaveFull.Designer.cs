namespace Sonartez.Helpdesk
{
    partial class FrmSaveFull
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
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.btnNotOK = new MetroFramework.Controls.MetroButton();
            this.txtTgEmail = new System.Windows.Forms.TextBox();
            this.txtTgPhone = new System.Windows.Forms.TextBox();
            this.txtTgName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbCountry = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbTgType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.Label();
            this.txtUserInfo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtSL)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(88, 206);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(578, 49);
            this.txtQuestion.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(15, 280);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(651, 239);
            this.txtDescription.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.Highlight = true;
            this.btnOK.Location = new System.Drawing.Point(551, 525);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(117, 40);
            this.btnOK.Style = MetroFramework.MetroColorStyle.Green;
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "Có đủ thông tin";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnNotOK
            // 
            this.btnNotOK.Highlight = true;
            this.btnNotOK.Location = new System.Drawing.Point(3, 525);
            this.btnNotOK.Name = "btnNotOK";
            this.btnNotOK.Size = new System.Drawing.Size(117, 40);
            this.btnNotOK.Style = MetroFramework.MetroColorStyle.Red;
            this.btnNotOK.TabIndex = 8;
            this.btnNotOK.Text = "Đang Xử lý";
            this.btnNotOK.Click += new System.EventHandler(this.btnNotOK_Click);
            // 
            // txtTgEmail
            // 
            this.txtTgEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTgEmail.Location = new System.Drawing.Point(90, 147);
            this.txtTgEmail.Name = "txtTgEmail";
            this.txtTgEmail.Size = new System.Drawing.Size(188, 24);
            this.txtTgEmail.TabIndex = 4;
            // 
            // txtTgPhone
            // 
            this.txtTgPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTgPhone.Location = new System.Drawing.Point(90, 114);
            this.txtTgPhone.Name = "txtTgPhone";
            this.txtTgPhone.Size = new System.Drawing.Size(188, 24);
            this.txtTgPhone.TabIndex = 2;
            // 
            // txtTgName
            // 
            this.txtTgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTgName.Location = new System.Drawing.Point(90, 81);
            this.txtTgName.Name = "txtTgName";
            this.txtTgName.Size = new System.Drawing.Size(188, 24);
            this.txtTgName.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Thông tin đối tượng được tư vấn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Điện thoại";
            // 
            // cbbCountry
            // 
            this.cbbCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCountry.FormattingEnabled = true;
            this.cbbCountry.Location = new System.Drawing.Point(372, 83);
            this.cbbCountry.Name = "cbbCountry";
            this.cbbCountry.Size = new System.Drawing.Size(160, 24);
            this.cbbCountry.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Quốc tịch";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(323, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Loại ";
            // 
            // cbbTgType
            // 
            this.cbbTgType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTgType.FormattingEnabled = true;
            this.cbbTgType.Location = new System.Drawing.Point(372, 116);
            this.cbbTgType.Name = "cbbTgType";
            this.cbbTgType.Size = new System.Drawing.Size(160, 24);
            this.cbbTgType.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(299, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Số lượng";
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(372, 147);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(160, 22);
            this.txtSL.TabIndex = 5;
            this.txtSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "Nhân viên tư vấn";
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.AutoSize = true;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(556, 9);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(63, 16);
            this.txtDate.TabIndex = 36;
            this.txtDate.Text = "Mã Client";
            // 
            // txtUserInfo
            // 
            this.txtUserInfo.AutoSize = true;
            this.txtUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserInfo.Location = new System.Drawing.Point(23, 25);
            this.txtUserInfo.Name = "txtUserInfo";
            this.txtUserInfo.Size = new System.Drawing.Size(212, 16);
            this.txtUserInfo.TabIndex = 37;
            this.txtUserInfo.Text = "Nguyễn văn A   Ngày 00/00/00/ h:o";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 16);
            this.label15.TabIndex = 38;
            this.label15.Text = "Nội dung tư vấn";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 206);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 16);
            this.label16.TabIndex = 39;
            this.label16.Text = "Câu hỏi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Ghi chú";
            // 
            // FrmSaveFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 577);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtUserInfo);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbbTgType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbCountry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTgName);
            this.Controls.Add(this.txtTgPhone);
            this.Controls.Add(this.txtTgEmail);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnNotOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSaveFull";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[HELPDESK] Lưu Thông tin lượt tu vấn";
            this.Load += new System.EventHandler(this.FrmSaveFull_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtDescription;
        private MetroFramework.Controls.MetroButton btnOK;
        private MetroFramework.Controls.MetroButton btnNotOK;
        private System.Windows.Forms.TextBox txtTgEmail;
        private System.Windows.Forms.TextBox txtTgPhone;
        private System.Windows.Forms.TextBox txtTgName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbCountry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbTgType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown txtSL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Label txtUserInfo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
    }
}