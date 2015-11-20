using DevExpress.XtraCharts;
using Sonartez.Helpdesk.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sonartez.Helpdesk
{
    public partial class FrmThongKe_TheoThoiGian : Form
    {
        BBLConsultant consData = new BBLConsultant();
        BBLClient clientData = new BBLClient();
        public FrmThongKe_TheoThoiGian()
        {
            InitializeComponent();

            cbbTime.SelectedIndex = 0;
            cbbType.SelectedIndex = 0;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Set view biểu đồ
                if (cbbType.SelectedIndex == 0)
                {

                    LoadBieuDoTheoTram();


                }

                if (cbbType.SelectedIndex == 1)
                {
                    LoadBieuDoTheoQuocGia();
                }
            }
            catch (Exception)
            {


            }
        }

        private void LoadBieuDoTheoQuocGia()
        {
            chartMain.Series.Clear();

            List<DateTime> timeline = new List<DateTime>();

            if (cbbTime.SelectedIndex == 0)
            {
                for (DateTime d = dateFrom.Value.Date; d <= datTo.Value.Date.AddHours(23); d = d.AddDays(1))
                {
                    timeline.Add(d.Date);
                }
            }

            var data = consData.GetAll().Where(x => x.CreateDate >= dateFrom.Value.Date && x.CreateDate <= datTo.Value.Date.AddHours(23));

            var listTram = clientData.GetAll().Where(x => x.IsDeleted == 0);



            foreach (var tram in listTram)
            {
                Series s = new Series(tram.ClientName, ViewType.Line);
                chartMain.Series.Add(s);
                foreach (var item in timeline)
                {
                    var value = data.Count(x => x.ClientCode == tram.ClientCode && x.CreateDate.Value.Date == item);
                    s.Points.Add(new SeriesPoint(item, value));
                }
            }

        }

        private void LoadBieuDoTheoTram()
        {
            chartMain.Series.Clear();

            List<DateTime> timeline = new List<DateTime>();

            if (cbbTime.SelectedIndex == 0)
            {
                for (DateTime d = dateFrom.Value.Date; d <= datTo.Value.Date.AddHours(23); d = d.AddDays(1))
                {
                    timeline.Add(d.Date);
                }
            }

            if (cbbTime.SelectedIndex == 1) {
                for (DateTime d = dateFrom.Value.Date; d <= datTo.Value.Date.AddHours(23); d = d.AddMonths(1))
                {
                    timeline.Add(d.Date);
                }
            }

            var data = consData.GetAll().Where(x => x.CreateDate >= dateFrom.Value.Date && x.CreateDate <= datTo.Value.Date.AddHours(23));

            var listTram = clientData.GetAll().Where(x => x.IsDeleted == 0);



            foreach (var tram in listTram)
            {
                Series s = new Series(tram.ClientName, ViewType.Line);
                chartMain.Series.Add(s);
                foreach (var item in timeline)
                {
                    if (cbbTime.SelectedIndex == 0)
                    {
                        var value = data.Count(x => x.ClientCode == tram.ClientCode && x.CreateDate.Value.Date == item);
                        s.Points.Add(new SeriesPoint(item.ToString("dd/MM"), value));
                    }
                    if (cbbTime.SelectedIndex == 1)
                    {
                        var value = data.Count(x => x.ClientCode == tram.ClientCode && x.CreateDate.Value.Month==item.Month);
                        s.Points.Add(new SeriesPoint(item.ToString("MM/yyyy"), value));
                    }
                }
            }



            // Create a diagram.
            //XYDiagram2D diagram = new XYDiagram2D();
            //chart.Diagram = diagram;

            //// Create a bar series.
            //BarSideBySideSeries2D series = new BarSideBySideSeries2D();
            //diagram.Series.Add(series);

            //// Add points to the series.
            //series.Points.Add(new SeriesPoint("A", 1));
            //series.Points.Add(new SeriesPoint("B", 3));
            //series.Points.Add(new SeriesPoint("C", 5));
            //series.Points.Add(new SeriesPoint("D", 2));
            //series.Points.Add(new SeriesPoint("E", 7));

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmThongKe_TheoThoiGian_Load(object sender, EventArgs e)
        {

        }
    }
}
