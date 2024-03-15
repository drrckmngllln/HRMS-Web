using DPFP;
using DPFP.Capture;
using DPFP.Processing;
using System;
using System.Drawing;
using System.Windows.Forms;

delegate void Function();
namespace HrmsPrototype.Forms.Settings.LibraryFilesComponent.Attendance
{
    public partial class frmAttendanceRegister : Form, DPFP.Capture.EventHandler
    {
        private Capture Capturer;
        private Template Template;
        private Enrollment Enroller;
        public frmAttendanceRegister()
        {
            InitializeComponent();
        }

        private void frmAttendanceRegister_Load(object sender, EventArgs e)
        {
            Init();
            Start();
        }

        protected void MakeReport(string message)
        {
            this.Invoke(new Function(delegate ()
            {
                statusBox.Items.Insert(0, message);
            }));
        }

        protected void MakeReportStatus()
        {
            this.Invoke(new Function(delegate ()
            {
                statusBox.Items.Insert(0, "Fingerprint samples needed " + Enroller.FeaturesNeeded);
            }));
        }

        private void DrawPicture(Bitmap bitmap)
        {
            this.Invoke(new Function(delegate ()
            {
                FingerPicture.Image = new Bitmap(bitmap, FingerPicture.Size);
            }));
        }


        protected virtual void Init()
        {
            try
            {
                Capturer = new Capture();

                if (null != Capturer)
                {
                    Capturer.EventHandler = this;
                }
                else
                {
                    MakeReport("Can't initiate capture operation");
                }
            }
            catch (Exception ex)
            {
                MakeReport(ex.Message);
            }
            finally
            {
                Enroller = new Enrollment();
                MakeReportStatus();
            }
        }

        protected virtual void Process(Sample sample)
        {
            // Draw fingerprint sample image.            
            DrawPicture(ConvertSampleToBitmap(sample));
            // Process the sample and create a feature set for the enrollment purpose.
            FeatureSet features = ExtractFeatures(sample, DataPurpose.Enrollment);
            try
            {
                if (features != null)
                {
                    try
                    {
                        MakeReport("The fingerprint feature set was created.");
                        Enroller.AddFeatures(features);        // Add feature set to template.
                    }
                    finally
                    {
                        if (Enroller.TemplateStatus == Enrollment.Status.Ready)
                        {
                            OnTemplate(Enroller.Template);
                            MakeReport("Click Save, and then click Fingerprint Verification.");
                            Stop();
                        }
                        if (Enroller.TemplateStatus == Enrollment.Status.Failed)
                        {
                            Enroller.Clear();
                            Stop();
                            OnTemplate(null);
                            Start();
                        }
                        MakeReportStatus();
                    }
                }
            }
            catch { }
        }

        private void OnTemplate(Template template)
        {
            try
            {
                this.Template = template;
                if (template != null)
                    MakeReport("The fingerprint template is ready for fingerprint verification.");
                else
                {
                    MakeReport("The fingerprint template is not valid. Repeat fingerprint enrollment.");
                    Init();
                    Start();
                }
            }
            catch (Exception ex)
            {
                MakeReport(ex.Message);
            }
        }

        protected void Start()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    MakeReport("Using the fingerprint reader, scan your fingerprint.");
                }
                catch
                {
                    MakeReport("Can't initiate capture!");
                }
            }
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
                    MakeReport("Can't terminate capture!");
                }
            }
        }

        protected Bitmap ConvertSampleToBitmap(Sample Sample)
        {
            SampleConversion Convertor = new SampleConversion();  // Create a sample convertor.
            Bitmap bitmap = null;                                                           // TODO: the size doesn't matter
            Convertor.ConvertToPicture(Sample, ref bitmap);                                 // TODO: return bitmap as a result
            return bitmap;
        }

        protected DPFP.FeatureSet ExtractFeatures(Sample Sample, DataPurpose Purpose)
        {
            FeatureExtraction Extractor = new FeatureExtraction();  // Create a feature extractor
            CaptureFeedback feedback = CaptureFeedback.None;
            FeatureSet features = new FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);            // TODO: return features as a result?
            if (feedback == CaptureFeedback.Good)
                return features;
            else
                return null;
        }


        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            MakeReport("The fingerprint sample was captured.");
            MakeReport("Scan the same fingerprint again.");
            Process(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The finger was removed from the fingerprint reader.");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was touched.");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was connected.");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was disconnected.");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                MakeReport("The quality of the fingerprint sample is good.");
            else
                MakeReport("The quality of the fingerprint sample is poor.");
        }
    }
}
