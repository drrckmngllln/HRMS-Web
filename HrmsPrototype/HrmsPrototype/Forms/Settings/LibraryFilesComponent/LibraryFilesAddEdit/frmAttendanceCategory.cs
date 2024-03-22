using HrmsPrototype.Core.Entities.Settings;
using HrmsPrototype.Core.Notifications;
using HrmsPrototype.Entities.Settings;
using HrmsPrototype.Infrastructure.Repositories;
using Krypton.Toolkit;
using System;
using System.Threading.Tasks;

namespace HrmsPrototype.Forms.Settings.LibraryFilesComponent.LibraryFilesAddEdit
{
    public partial class frmAttendanceCategory : KryptonForm
    {
        GenericRepository<AttendanceSetupCategory> _repo = new GenericRepository<AttendanceSetupCategory>();
        private const string baseEndpoint = "LibraryFiles/AttendanceCategory/";
        private readonly string _process;

        public int ID { get; set; }

        public static frmAttendanceCategory instance;
        public frmAttendanceCategory(string process)
        {
            instance = this;
            InitializeComponent();
            _process = process;
        }

        private async void frmAttendanceCategory_Load(object sender, EventArgs e)
        {
            if (_process == "Update")
            {
                var department = await _repo.GetByIdAsync(baseEndpoint + ID);
                tName.Text = department.Name;
                btnSave.Text = "Update";
            }
        }

        public async Task AddEdit()
        {
            if (_process == "Create")
            {
                var category = new AttendanceSetupCategory
                {
                    Name = tName.Text
                };
                await _repo.AddAsync(category, baseEndpoint + "create");
                new Toastr("Success", "Department added");
                Close();
            }
            else if (_process == "Update")
            {
                var category = new AttendanceSetupCategory
                {
                    Id = ID,
                    Name = tName.Text
                };
                await _repo.UpdateAsync(category, baseEndpoint + "update");
                new Toastr("Information", "Department updated");
                Close();
            }
        }

        private async void frmAttendanceCategory_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                await AddEdit();
            }
            else if (e.KeyCode == System.Windows.Forms.Keys.Escape)
            {
                Close();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await AddEdit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
