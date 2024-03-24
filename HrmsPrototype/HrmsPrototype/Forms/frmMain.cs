﻿using HrmsPrototype.Forms.Settings;
using HrmsPrototype.Forms.Transaction;
using HrmsPrototype.Forms.Transaction.Employee.AttendanceMonitoring;
using Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace HrmsPrototype.Forms
{
    public partial class frmMain : KryptonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            if (panelLibrary.Visible == false)
            {
                panelLibrary.Visible = true;
                var frm = new frmLibraryFilesModule();
                frm.TopLevel = false;
                panelTask.Controls.Clear();
                panelTask.Controls.Add(frm);
                frm.Show();
            }
            else
            {
                panelLibrary.Visible = false;
                panelTask.Controls.Clear();
            }
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            if (panelTransaction.Visible == false)
            {
                panelTransaction.Visible = true;
            }
            else
            {
                panelTransaction.Visible = false;
            }
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            frmLibraryFilesModule.instance.OpenDepartments();
        }

        private void btnPositions_Click(object sender, EventArgs e)
        {
            frmLibraryFilesModule.instance.OpenPositions();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLibraryFilesModule.instance.OpenCampuses();
        }

        private void btnLeaveSetup_Click(object sender, EventArgs e)
        {
            frmLibraryFilesModule.instance.OpenLeaveSetups();
        }

        private void btnAttendanceSetup_Click(object sender, EventArgs e)
        {
            frmLibraryFilesModule.instance.OpenAttendanceSetups();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            var frm = new frmEmployees();
            frm.TopLevel = false;
            panelTask.Controls.Clear();
            panelTask.Controls.Add(frm);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new frmAttendanceMonitoringModule();
            frm.Text = "Attendance Monitoring System";
            frm.ShowDialog();
        }

        private void btnAttendanceCategory_Click(object sender, EventArgs e)
        {
            frmLibraryFilesModule.instance.OpenAttendanceCategory();
        }
    }
}
