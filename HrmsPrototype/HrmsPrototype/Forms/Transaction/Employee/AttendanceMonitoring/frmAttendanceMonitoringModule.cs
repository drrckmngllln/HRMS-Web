using DPFP;
using DPFP.Capture;
using DPFP.Verification;
using HrmsPrototype.Core.Entities.Settings;
using HrmsPrototype.Infrastructure.Repositories;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmsPrototype.Forms.Transaction.Employee.AttendanceMonitoring
{
    public partial class frmAttendanceMonitoringModule : Form, DPFP.Capture.EventHandler
    {
        private const string baseEndpoint = "Attendances/";

        private Capture Capturer;
        private Verification Verificator;

        public List<Template> FPTList = new List<DPFP.Template>();
        public List<string> OwnerList = new List<string>();

        public int ID { get; set; }
        public string LogStatus { get; set; }

        public static frmAttendanceMonitoringModule instance;
        public frmAttendanceMonitoringModule()
        {
            instance = this;
            InitializeComponent();
        }

        private void OpenEmployeeLog()
        {
            var frm = new frmEmployeeAttendanceLog();
            frmEmployeeAttendanceLog.instance.ID = ID;
            frm.TopLevel = false;
            frm.Parent = panelTask;
            panelTask.Controls.Clear();
            panelTask.Controls.Add(frm);
            frm.Show();
        }

        protected void Init()
        {
            Capturer = new Capture();                   // Create a capture operation.
            if (Capturer != null)
                Capturer.EventHandler = this;
            Verificator = new Verification();
        }

        protected void StartCapture()
        {
            if (Capturer != null)
            {
                try
                {
                    Capturer.StartCapture();
                }
                catch
                {

                }
            }
        }

        private void process(DPFP.Sample Sample)
        {

            FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);
            CompareToTemplate(features);

        }

        private void CompareToTemplate(FeatureSet featuresets)
        {
            Verification.Result results = new Verification.Result();
            for (var i = 0; i <= FPTList.Count - 1; i++)
            {
                try
                {
                    if (featuresets != null)
                    {
                        Verificator.Verify(featuresets, FPTList[i], ref results);
                        if (results.Verified)
                        {
                            tEmployeeId.Text = OwnerList[i].ToString();
                            ID = Convert.ToInt32(OwnerList[i]);
                            break;
                        }
                        else if (i == FPTList.Count - 1)
                        {
                            tEmployeeId.Text = "< fingerprint not found >";
                            break;
                        }
                        else
                        {
                            // please wait
                            continue;
                        }

                    }
                }
                catch (Exception ex)
                {

                }
            }

            if (tEmployeeId.Text != "< fingerprint not found >")
            {
                this.Invoke(new Action(OpenEmployeeLog));
                employeeIdTimer.Start();
            }
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction extractor = new DPFP.Processing.FeatureExtraction();    // Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features); // TODO: return features as a result?
            if ((feedback == DPFP.Capture.CaptureFeedback.Good))
            {
                return features;
            }
            else
                return null/* TODO Change to default(_) if this is not a reference type */;
        }

        public async Task LoadData()
        {
            FPTList.Clear();
            OwnerList.Clear();

            var _repo = new GenericRepository<AttendanceIdentity>();

            var attendances = await _repo.GetAllAsync(baseEndpoint);

            foreach (var attendance in attendances)
            {
                var ms = new MemoryStream();
                byte[] fpbytes = (byte[])attendance.Data;
                ms = new MemoryStream(fpbytes);

                var temp = new Template();
                temp.DeSerialize(ms);
                FPTList.Add(temp);
                OwnerList.Add(attendance.EmployeeNumber);
            }

        }

        private async Task initialize()
        {
            await LoadData();
            Init();
            StartCapture();

            CheckForIllegalCrossThreadCalls = false;
        }

        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {

                }
            }
        }

        #region event handler

        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            process(Sample);

        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            //throw new NotImplementedException();
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            //throw new NotImplementedException();
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            //throw new NotImplementedException();
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            //throw new NotImplementedException();
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private async void frmAttendanceMonitoringModule_Load(object sender, EventArgs e)
        {
            await initialize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tDateandTime.Text = DateTime.Now.ToString("MMMM dd, yyyy - hh:mm:ss tt");
        }

        private void tClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close biometric attendance system?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmAttendanceMonitoringModule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                tLogStatus.Text = "Time In";
                LogStatus = "Time In";
            }
            else if (e.KeyCode == Keys.F2)
            {
                tLogStatus.Text = "Time Out";
                LogStatus = "Time Out";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tLogStatus.Text = "Time In";
            LogStatus = tLogStatus.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tLogStatus.Text = "Time Out";
            LogStatus = tLogStatus.Text;
        }

        private void employeeIdTimer_Tick(object sender, EventArgs e)
        {
            tEmployeeId.Text = "...";
        }
    }
}
