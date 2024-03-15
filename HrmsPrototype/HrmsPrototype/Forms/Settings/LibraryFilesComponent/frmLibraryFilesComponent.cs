using HrmsPrototype.Core.Entities.Settings;
using HrmsPrototype.Entities.Settings;
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
            if (_libraryFilesType == "AttendanceEnrollment")
            {
                tTitle.Text = "Attendance Enrollment";
                await GetData<AttendanceIdentity>();
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
    }
}
