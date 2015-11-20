namespace Sonartez.Helpdesk
{
    partial class FrmSaveHotline
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
            this.btnNotOK = new MetroFramework.Controls.MetroButton();
            this.btnOK = new MetroFramework.Controls.MetroButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNotOK
            // 
            this.btnNotOK.Highlight = true;
            this.btnNotOK.Location = new System.Drawing.Point(15, 476);
            this.btnNotOK.Name = "btnNotOK";
            this.btnNotOK.Size = new System.Drawing.Size(117, 40);
            this.btnNotOK.Style = MetroFramework.MetroColorStyle.Red;
            this.btnNotOK.TabIndex = 3;
            this.btnNotOK.Text = "Đang xử lý";
            this.btnNotOK.Click += new System.EventHandler(this.btnNotOK_Click);
            // 
            // btnOK
            // 
            this.btnOK.Highlight = true;
            this.btnOK.Location = new System.Drawing.Point(480, 476);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(117, 40);
            this.btnOK.Style = MetroFramework.MetroColorStyle.Green;
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Có đủ thông tin";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(15, 108);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(582, 345);
            this.txtDescription.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kết quả";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(16, 25);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(581, 55);
            this.txtQuestion.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nội dung tư vấn";
            // 
            // FrmSaveHotline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 523);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnNotOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmSaveHotline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KẾT QUẢ HỐ TRỢ HOTLINE";
            this.Load += new System.EventHandler(this.FrmSaveHotline_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnNotOK;
        private MetroFramework.Controls.MetroButton btnOK;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label3;
    }
}