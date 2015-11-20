namespace Sonartez.Helpdesk
{
    partial class FrmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnManageClient = new System.Windows.Forms.Button();
            this.lblClientInfo = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServerUrl = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(339, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnManageClient);
            this.groupBox1.Controls.Add(this.lblClientInfo);
            this.groupBox1.Controls.Add(this.btnVerify);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtClientCode);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin máy trạm";
            // 
            // btnManageClient
            // 
            this.btnManageClient.Location = new System.Drawing.Point(312, 26);
            this.btnManageClient.Name = "btnManageClient";
            this.btnManageClient.Size = new System.Drawing.Size(75, 23);
            this.btnManageClient.TabIndex = 4;
            this.btnManageClient.Text = "Quản lý...";
            this.btnManageClient.UseVisualStyleBackColor = true;
            // 
            // lblClientInfo
            // 
            this.lblClientInfo.AutoSize = true;
            this.lblClientInfo.Location = new System.Drawing.Point(16, 67);
            this.lblClientInfo.Name = "lblClientInfo";
            this.lblClientInfo.Size = new System.Drawing.Size(38, 13);
            this.lblClientInfo.TabIndex = 3;
            this.lblClientInfo.Text = "Mã Số";
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(208, 26);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 23);
            this.btnVerify.TabIndex = 2;
            this.btnVerify.Text = "Xác thực";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Số";
            // 
            // txtClientCode
            // 
            this.txtClientCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientCode.Location = new System.Drawing.Point(60, 26);
            this.txtClientCode.Name = "txtClientCode";
            this.txtClientCode.Size = new System.Drawing.Size(132, 22);
            this.txtClientCode.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 46);
            this.panel1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(258, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtServerUrl);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông số Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Máy chủ dữ liệu";
            // 
            // txtServerUrl
            // 
            this.txtServerUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerUrl.Location = new System.Drawing.Point(19, 47);
            this.txtServerUrl.Name = "txtServerUrl";
            this.txtServerUrl.Size = new System.Drawing.Size(368, 22);
            this.txtServerUrl.TabIndex = 0;
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 284);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THIẾT LẬP MÁY TRẠM";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnManageClient;
        private System.Windows.Forms.Label lblClientInfo;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServerUrl;
    }
}