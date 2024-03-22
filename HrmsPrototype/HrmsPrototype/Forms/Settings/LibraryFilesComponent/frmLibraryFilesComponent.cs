using HrmsPrototype.Core.Entities.Settings;
using HrmsPrototype.Entities.Settings;
using HrmsPrototype.Infrastructure.Interfaces;
using HrmsPrototype.Infrastructure.Repositories;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmsPrototype.Forms.Settings.LibraryFilesComponent
{
    public partial class frmLibraryFilesComponent : Form
    {
        public string LibraryEndpoint { get; set; }
        public static frmLibraryFilesComponent instance;
        private readonly string _libraryFilesType;
        private const string BaseEndpoint = "libraryfiles/";

        public frmLibraryFilesComponent(string libraryFilesType)
        {
            instance = this;
            InitializeComponent();
            _libraryFilesType = libraryFilesType;
        }

        private async Task GetData<T>() where T : class
        {
            var _repo = new GenericRepository<T>();
            var data = await _repo.GetAllAsync(BaseEndpoint + _libraryFilesType);
            dgv.DataSource = data;
            dgv.Columns["Id"].Visible = false;
        }



        private async Task loadRecords()
        {
            if (_libraryFilesType == "Campuses")
            {
                tTitle.Text = "Campuses";
                await GetData<Campus>();
            }
            if (_libraryFilesType == "Departments")
            {
                tTitle.Text = "Departments";

                await GetData<Departments>();
            }
            if (_libraryFilesType == "Positions")
            {
                tTitle.Text = "Positions";
                await GetData<Positions>();
            }
            if (_libraryFilesType == "AttendanceSetups")
            {
                tTitle.Text = "Attendance Setups";
                await GetData<AttendanceSetup>();
            }
            if (_libraryFilesType == "LeaveSetups")
            {
                tTitle.Text = "Leave Setups";
                await GetData<LeaveSetup>();
            }
            if (_libraryFilesType == "LeaveSetups")
            {
                tTitle.Text = "Attendance Enrollment";
                await GetData<AttendanceIdentity>();
            }
            if (_libraryFilesType == "AttendanceCategory")
            {
                tTitle.Text = "Attendance Category";
                await GetData<AttendanceSetupCategory>();
            }
        }

        private async Task SearchRecords(string searchValue)
        {
            if (_libraryFilesType == "Campuses")
            {
                var repo = new GenericRepository<Campus>();
                var search = await repo.SearchAsync(BaseEndpoint + "campuses?search=" + searchValue);
                dgv.DataSource = search;
            }
            if (_libraryFilesType == "Departments")
            {
                var repo = new GenericRepository<Campus>();
                var search = await repo.SearchAsync(BaseEndpoint + "departments?search=" + searchValue);
                dgv.DataSource = search;
            }
            if (_libraryFilesType == "Positions")
            {
                var repo = new GenericRepository<Campus>();
                var search = await repo.SearchAsync(BaseEndpoint + "positions?search=" + searchValue);
                dgv.DataSource = search;
            }
            if (_libraryFilesType == "AttendanceSetups")
            {
                var repo = new GenericRepository<Campus>();
                var search = await repo.SearchAsync(BaseEndpoint + "attendancesetups?search=" + searchValue);
                dgv.DataSource = search;
            }
            if (_libraryFilesType == "AttendanceEnrollment")
            {
                var repo = new GenericRepository<Campus>();
                var search = await repo.SearchAsync(BaseEndpoint + "attendanceenrollment?search=" + searchValue);
                dgv.DataSource = search;
            }
        }


        private async void frmLibraryFilesComponent_Load(object sender, System.EventArgs e)
        {
            await loadRecords();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmLibraryFilesModule.instance.ID = Convert.ToInt32(dgv.CurrentRow.Cells["Id"].Value);
        }

        private async void tSearch_TextChanged(object sender, EventArgs e)
        {
            if (tSearch.Text.Length > 3)
            {
                await SearchRecords(tSearch.Text);
            }
            else if (tSearch.Text.Length == 0)
            {
                await loadRecords();
            }
        }
    }
}
