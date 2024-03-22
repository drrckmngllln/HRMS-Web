using HrmsPrototype.Core.Entities.Settings;
using HrmsPrototype.Core.Notifications;
using HrmsPrototype.Infrastructure.Repositories;
using Krypton.Toolkit;
using System;
using System.Threading.Tasks;

namespace HrmsPrototype.Forms.Settings.LibraryFilesComponent.LibraryFilesAddEdit
{
    public partial class frmAttendanceSetup : KryptonForm
    {
        GenericRepository<AttendanceSetup> _repo = new GenericRepository<AttendanceSetup>();
        GenericRepository<AttendanceSetupCategory> _categoryRepo = new GenericRepository<AttendanceSetupCategory>();

        private const string baseEndpoint = "LibraryFiles/AttendanceSetups/";
        private readonly string _process;
        public int ID { get; set; }

        public static frmAttendanceSetup instance;
        public frmAttendanceSetup(string process)
        {
            instance = this;
            InitializeComponent();
            _process = process;
        }

        private async void frmAttendanceSetup_Load(object sender, EventArgs e)
        {
            await loadCategory();

            if (_process == "Update")
            {
                //var campus = await _repo.GetByIdAsync(baseEndpoint + ID);
                //tName.Text = campus.Name;
                //tDesctiption.Text = campus.Description;
                //btnSave.Text = "Update";
            }
        }

        private async Task loadCategory()
        {
            var category = await _categoryRepo.GetAllAsync("LibraryFiles/AttendanceCategory");
            tCategory.ValueMember = "Id";
            tCategory.DisplayMember = "Name";
            tCategory.DataSource = category;
        }

        private async Task AddEdit()
        {
            if (_process == "Create")
            {
                var item = new AttendanceSetup
                {
                    Category = tCategory.SelectedValue.ToString(),
                    TimeIn = DateTime.Parse(tTimeIn.Text).ToUniversalTime(),
                    TimeOut = DateTime.Parse(tTimeOut.Text).ToUniversalTime(),
                    GracePeriod = Convert.ToInt32(tGracePeriod.Text)
                };
                await _repo.AddAsync(item, baseEndpoint + "create");
                new Toastr("Success", "Attendance setup add success");
                Close();
            }
            else if (_process == "Update")
            {
                var item = new AttendanceSetup
                {
                    Category = tCategory.SelectedValue.ToString(),
                    TimeIn = DateTime.Parse(tTimeOut.Text).ToUniversalTime(),
                    TimeOut = DateTime.Parse(tTimeOut.Text).ToUniversalTime(),
                    GracePeriod = Convert.ToInt32(tGracePeriod.Text)
                };
                await _repo.UpdateAsync(item, baseEndpoint + "update");
                new Toastr("Information", "Attendance setup updated");
                Close();
            }
        }

        private async void frmAttendanceSetup_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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
