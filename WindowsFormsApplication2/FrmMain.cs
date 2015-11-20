using Sonartez.Entities;
using Sonartez.Helpdesk.Bussiness;
using Sonartez.Hepldesk.Bussiness;
using System;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;

namespace Sonartez.Helpdesk
{
    public partial class FrmMain : MetroFramework.Forms.MetroForm
    {
        private Entities.TblUser loggedUser;
        private Entities.TblClient currentClient;

        // Syn functions
        BackgroundWorker worker;

        private void InitializeWorker()
        {
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;

            worker.DoWork += backgroundWorker1_DoWork;
            worker.ProgressChanged += backgroundWorker1_ProgressChanged;
            worker.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10;

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            panelDongBo.Invoke((Action)(() =>
            {
                panelDongBo.Visible = false;
                progressBar1.Value = progressBar1.Minimum;
            }));

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            panelDongBo.Invoke((Action)(() =>
            {
                panelDongBo.Visible = true;
                progressBar1.Value = progressBar1.Minimum;
            }));

            string baseHost = ConfigurationManager.AppSettings["SERVERURL"];

            string clientCode = ConfigurationManager.AppSettings["CLIENTCODE"];

            try
            {
                progressBar1.Invoke((Action)(() => progressBar1.Value = 1));
                worker.ReportProgress(1);
                // Đồng bộ user
                BBLUser userData = new BBLUser();
                userData.ServiceUpdate(baseHost);
                progressBar1.Invoke((Action)(() => progressBar1.Value = 2));
                worker.ReportProgress(2);
                // Đồng bộ Info
                BBLInfo infoData = new BBLInfo();
                infoData.ServiceUpdate(baseHost);
                progressBar1.Invoke((Action)(() => progressBar1.Value = 6));
                worker.ReportProgress(3);
                // Đồng bộ BBLClient
                BBLClient clientData = new BBLClient();
                clientData.ServiceUpdate(baseHost);
                progressBar1.Invoke((Action)(() => progressBar1.Value = 8));
                worker.ReportProgress(4);
                // Đồng bộ BBLConsultant
                BBLConsultant consultantData = new BBLConsultant();
                consultantData.ServiceUpdate(baseHost);
                progressBar1.Invoke((Action)(() => progressBar1.Value = 10));
                worker.ReportProgress(5);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        // End Syn functions
        public FrmMain()
        {
            InitializeComponent();
            InitializeWorker();
        }

        public FrmMain(Entities.TblUser loggedUser)
        {
            // TODO: Complete member initialization
            this.loggedUser = loggedUser;
            InitializeComponent();
            InitializeWorker();
        }
        //System.Threading.Timer aTimer;
        Timer timer;
        private void Form1_Load(object sender, EventArgs e)
        {
            //ctrlBanLamViec1.UpdateNewsData();
            BBLInfo info = new BBLInfo();
            ctrlQuanLyNoiDung1.currentUser = loggedUser;
            ctrlQuanLyNoiDung1.LoadData(info);

            ctrlBanLamViec1.currentUser = loggedUser;
            ctrlBanLamViec1.LoadData(info);

            BBLConsultant cons = new BBLConsultant();
            ctrlThongKe1.currentUser = loggedUser;
            ctrlThongKe1.LoadData(cons);

            panelDongBo.Visible = false;

            //timer = new Timer();
            //timer.Tick += new EventHandler(TimeTick); // Every time timer ticks, timer_Tick will be called
            //timer.Interval = (300) * (1000);             // Timer will tick every 300 seconds
            //timer.Enabled = true;                       // Enable the timer
            //timer.Start();

            if (loggedUser.Permission != Permission.Admin)
            {
                quảnLýNgươiDùngToolStripMenuItem.Visible = false;
                resetUpdateToolStripMenuItem.Visible = false;
            }
        }

        private void TimeTick(object sender, EventArgs e)
        {
            try
            {
                if (!worker.IsBusy)
                {
                    progressBar1.Value = progressBar1.Minimum;
                    worker.RunWorkerAsync();
                }
            }
            catch
            {
                panelDongBo.Visible = false;
            }
        }

        private void quảnLýNgươiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManager uUM = new UserManager();
            uUM.Show();
        }

        private void FrmMain_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void thiếtLậpMáyTrạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfig cf = new FrmConfig();
            cf.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ctrlQuanLyNoiDung1.LoadData();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đồngBộNgayVớiServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!worker.IsBusy)
                {
                    progressBar1.Value = progressBar1.Minimum;
                    worker.RunWorkerAsync();
                }
            }
            catch
            {
                panelDongBo.Visible = false;
            }
        }

        private void resetUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime mindate = DateTime.Parse("2000/01/01");
            BBLUpdate u = new BBLUpdate();
            var up = u.GetCurrent();
            up.LastActivityLogUpdate = mindate;
            up.LastClientUpdate = mindate;
            up.LastConsutantUpdate = mindate;
            up.LastInfoUpdate = mindate;
            up.LastUserUpdate = mindate;
            up.LastUserPermissionUpdate = mindate;
            up.LocalActivityLogUpdate = mindate;
            up.LocalClientUpdate = mindate;
            up.LocalConsutantUpdate = mindate;
            up.LocalInfoUpdate = mindate;
            up.LocalUserUpdate = mindate;
            u.Update(up);
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmChangePass(loggedUser).ShowDialog(this);
        }





    }
}
