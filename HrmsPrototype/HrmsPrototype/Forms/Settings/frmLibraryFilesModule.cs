using HrmsPrototype.Core.Entities.Settings;
using HrmsPrototype.Core.Notifications;
using HrmsPrototype.Entities.Settings;
using HrmsPrototype.Forms.Settings.LibraryFilesComponent;
using HrmsPrototype.Forms.Settings.LibraryFilesComponent.LibraryFilesAddEdit;
using HrmsPrototype.Infrastructure.Repositories;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private async Task Delete<T>(T entity, string endpoint) where T : BaseEntity
        {
            var _repo = new GenericRepository<T>();
            await _repo.DeleteAsync(baseEndpoint + entity);
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
            if (_name == "Departments")
            {
                var frm = new frmDepartment("Create");
                
                frm.Text = "New Department";
                frm.ShowDialog();
                OpenDepartments();
            }

            if (_name == "Campuses")
            {

            }

            if (_name == "Positions")
            {

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
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_name == "Departments")
            {
                if (MessageBox.Show("Are you sure you want to delete department?", "Warning", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var item = new Departments
                    {
                        Id = ID,
                    };
                    await Delete(item, "Departments/");
                    new Toastr("Information", "Department deleted");
                    OpenDepartments();
                }
            }
            
        }
    }
}
