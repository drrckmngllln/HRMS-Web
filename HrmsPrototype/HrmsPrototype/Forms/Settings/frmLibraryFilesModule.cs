using HrmsPrototype.Forms.Settings.LibraryFilesComponent;
using HrmsPrototype.Forms.Settings.LibraryFilesComponent.LibraryFilesAddEdit;
using System;
using System.Windows.Forms;

namespace HrmsPrototype.Forms.Settings
{
    public partial class frmLibraryFilesModule : Form
    {

        public static frmLibraryFilesModule instance;

        private string _name;
        public frmLibraryFilesModule()
        {
            instance = this;
            InitializeComponent();
        }

        private void frmLibraryFilesModule_Load(object sender, EventArgs e)
        {

        }

        private void OpenComponent(string name)
        {
            var frm = new frmLibraryFilesComponent(name);
            frm.TopLevel = false;
            panelTask.Controls.Clear();
            panelTask.Controls.Add(frm);
            frm.Show();
            _name = name;
        }

        public void OpenCampuses()
        {
            OpenComponent("Campuses");
        }

        public void OpenDepartments()
        {
            OpenComponent("Departments");
        }

        public void OpenPositions()
        {
            OpenComponent("Positions");
        }

        public void OpenLeaveSetups()
        {
            OpenComponent("LeaveSetups");
        }

        public void OpenAttendanceSetups()
        {
            OpenComponent("AttendanceSetups");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (_name == "Campuses")
            {
                var frm = new frmDepartment();
                frm.ShowDialog();
            }
        }
    }
}
