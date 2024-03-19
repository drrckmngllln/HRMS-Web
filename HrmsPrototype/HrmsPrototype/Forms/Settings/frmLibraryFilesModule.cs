using HrmsPrototype.Core.Entities.Settings;
using HrmsPrototype.Core.Notifications;
using HrmsPrototype.Entities.Settings;
using HrmsPrototype.Forms.Settings.LibraryFilesComponent;
using HrmsPrototype.Forms.Settings.LibraryFilesComponent.Attendance;
using HrmsPrototype.Forms.Settings.LibraryFilesComponent.LibraryFilesAddEdit;
using HrmsPrototype.Infrastructure.Repositories;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HrmsPrototype.Forms.Settings
{
    public partial class frmLibraryFilesModule : Form
    {

        public static frmLibraryFilesModule instance;
        private const string baseEndpoint = "LibraryFiles/";

        public int ID { get; set; }

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

        public void OpenEnrollmentIdentityAttendance()
        {
            var frm = new frmAttendanceRegister(ID);
            frm.TopLevel = false;
            panelTask.Controls.Clear();
            panelTask.Controls.Add(frm);
            frm.Show();
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
            if (_name == "Departments")
            {
                var frm = new frmDepartment("Create");

                frm.Text = "New Department";
                frm.ShowDialog();
                OpenDepartments();
            }

            if (_name == "Campuses")
            {
                var frm = new frmCampuses("Create");
                frm.Text = "New Campus";
                frm.ShowDialog();
                OpenCampuses();
            }

            if (_name == "Positions")
            {
                var frm = new frmPositions("Create");
                frm.Text = "New Position";
                frm.ShowDialog();
                OpenPositions();
            }

            if (_name == "LeaveSetups")
            {
                var frm = new frmLeaveSetup("Create");
                frm.Text = "New Leave Setup";
                frm.ShowDialog();
                OpenLeaveSetups();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_name == "Departments")
            {
                var frm = new frmDepartment("Update");
                frmDepartment.instance.ID = ID;
                frm.Text = "Update Department";
                frm.ShowDialog();
                OpenDepartments();
            }
            if (_name == "Campuses")
            {
                var frm = new frmCampuses("Update");
                frmCampuses.instance.ID = ID;
                frm.Text = "Update Campus";
                frm.ShowDialog();
                OpenCampuses();
            }
            if (_name == "Positions")
            {
                var frm = new frmPositions("Update");
                frmPositions.instance.ID = ID;
                frm.Text = "Update Position";
                frm.ShowDialog();
                OpenPositions();
            }
            if (_name == "LeaveSetups")
            {
                var frm = new frmLeaveSetup("Update");
                frmLeaveSetup.instance.ID = ID;
                frm.Text = "Update Leave Setup";
                frm.ShowDialog();
                OpenLeaveSetups();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (_name == "Departments")
            {
                if (MessageBox.Show("Are you sure you want to delete department?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var repo = new GenericRepository<Departments>();
                    var item = new Departments
                    {
                        Id = ID,
                    };
                    await repo.DeleteAsync(baseEndpoint + "Departments/" + item);
                    new Toastr("Information", "Department deleted");
                    OpenDepartments();
                }
            }

        }
    }
}
