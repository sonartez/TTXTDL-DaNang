namespace Sonartez.Helpdesk
{
    partial class CtrlInfoItem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlInfoItem));
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.BackColor = System.Drawing.Color.White;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(3, 4);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(347, 17);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Nội cmn dung";
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.BackColor = System.Drawing.Color.White;
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.HideSelection = false;
            this.txtContent.Location = new System.Drawing.Point(9, 27);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(489, 76);
            this.txtContent.TabIndex = 1;
            this.txtContent.Text = "nội dung ";
            // 
            // txtDate
            // 
            this.txtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDate.AutoSize = true;
            this.txtDate.Location = new System.Drawing.Point(353, 7);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(99, 13);
            this.txtDate.TabIndex = 2;
            this.txtDate.Text = "dd/mm/yyyy hh:mm";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1413968953_11-24.png");
            this.imageList1.Images.SetKeyName(1, "1413968964_13-24.png");
            // 
            // btnStatus
            // 
            this.btnStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.ImageIndex = 0;
            this.btnStatus.ImageList = this.imageList1;
            this.btnStatus.Location = new System.Drawing.Point(459, 2);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(39, 23);
            this.btnStatus.TabIndex = 3;
            this.btnStatus.UseVisualStyleBackColor = true;
            // 
            // CtrlInfoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Name = "CtrlInfoItem";
            this.Size = new System.Drawing.Size(501, 106);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnStatus;
    }
}
