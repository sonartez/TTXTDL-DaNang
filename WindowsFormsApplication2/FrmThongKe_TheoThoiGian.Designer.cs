namespace Sonartez.Helpdesk
{
    partial class FrmThongKe_TheoThoiGian
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointOptions pointOptions1 = new DevExpress.XtraCharts.PointOptions();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointOptions pointOptions2 = new DevExpress.XtraCharts.PointOptions();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel3 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.PointOptions pointOptions3 = new DevExpress.XtraCharts.PointOptions();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.chartMain = new DevExpress.XtraCharts.ChartControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.datTo = new System.Windows.Forms.DateTimePicker();
            this.cbbTime = new System.Windows.Forms.ComboBox();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.panelControl3);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(900, 560);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Biểu đồ quá trình hoạt động";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.chartMain);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 77);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(896, 435);
            this.panelControl2.TabIndex = 1;
            // 
            // chartMain
            // 
            this.chartMain.CrosshairOptions.ArgumentLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(57)))), ((int)(((byte)(205)))));
            this.chartMain.CrosshairOptions.ValueLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(57)))), ((int)(((byte)(205)))));
            xyDiagram1.AxisX.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General;
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.NumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General;
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartMain.Diagram = xyDiagram1;
            this.chartMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMain.Legend.Antialiasing = true;
            this.chartMain.Location = new System.Drawing.Point(2, 2);
            this.chartMain.Name = "chartMain";
            this.chartMain.PaletteName = "Metro";
            pointSeriesLabel1.LineVisible = true;
            pointOptions1.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General;
            pointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General;
            pointSeriesLabel1.PointOptions = pointOptions1;
            series1.Label = pointSeriesLabel1;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Name = "Series 1";
            series1.View = lineSeriesView1;
            pointSeriesLabel2.LineVisible = true;
            pointOptions2.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General;
            pointOptions2.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General;
            pointSeriesLabel2.PointOptions = pointOptions2;
            series2.Label = pointSeriesLabel2;
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.Name = "Series 2";
            series2.View = lineSeriesView2;
            this.chartMain.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            pointSeriesLabel3.LineVisible = true;
            pointOptions3.ArgumentNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General;
            pointOptions3.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.General;
            pointSeriesLabel3.PointOptions = pointOptions3;
            this.chartMain.SeriesTemplate.Label = pointSeriesLabel3;
            this.chartMain.SeriesTemplate.View = lineSeriesView3;
            this.chartMain.Size = new System.Drawing.Size(892, 431);
            this.chartMain.TabIndex = 0;
            chartTitle1.Text = "THỐNG KÊ QUÁ TRÌNH HOẠT ĐỘNG";
            this.chartMain.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.dateFrom);
            this.panelControl1.Controls.Add(this.datTo);
            this.panelControl1.Controls.Add(this.cbbTime);
            this.panelControl1.Controls.Add(this.cbbType);
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(896, 56);
            this.panelControl1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ ngày";
            // 
            // dateFrom
            // 
            this.dateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(332, 15);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(149, 22);
            this.dateFrom.TabIndex = 4;
            // 
            // datTo
            // 
            this.datTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datTo.Location = new System.Drawing.Point(539, 15);
            this.datTo.Name = "datTo";
            this.datTo.Size = new System.Drawing.Size(129, 22);
            this.datTo.TabIndex = 3;
            // 
            // cbbTime
            // 
            this.cbbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTime.FormattingEnabled = true;
            this.cbbTime.Items.AddRange(new object[] {
            "Theo Ngày",
            "Theo Tháng"});
            this.cbbTime.Location = new System.Drawing.Point(686, 14);
            this.cbbTime.Name = "cbbTime";
            this.cbbTime.Size = new System.Drawing.Size(110, 24);
            this.cbbTime.TabIndex = 2;
            // 
            // cbbType
            // 
            this.cbbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "Số lượt tư vấn / Trạm"});
            this.cbbType.Location = new System.Drawing.Point(5, 14);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(253, 24);
            this.cbbType.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(805, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "XEM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnClose);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(2, 512);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(896, 46);
            this.panelControl3.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(811, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmThongKe_TheoThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmThongKe_TheoThoiGian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biểu Đồ";
            this.Load += new System.EventHandler(this.FrmThongKe_TheoThoiGian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraCharts.ChartControl chartMain;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker datTo;
        private System.Windows.Forms.ComboBox cbbTime;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}