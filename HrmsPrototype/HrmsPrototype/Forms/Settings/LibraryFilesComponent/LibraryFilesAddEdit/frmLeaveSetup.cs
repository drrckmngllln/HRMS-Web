using HrmsPrototype.Core.Entities.Settings;
using HrmsPrototype.Core.Notifications;
using HrmsPrototype.Entities.Settings;
using HrmsPrototype.Infrastructure.Repositories;
using Krypton.Toolkit;
using System;
using System.Threading.Tasks;

namespace HrmsPrototype.Forms.Settings.LibraryFilesComponent.LibraryFilesAddEdit
{
    public partial class frmLeaveSetup : KryptonForm
    {
        GenericRepository<LeaveSetup> _repo = new GenericRepository<LeaveSetup>();
        private const string baseEndpoint = "LibraryFiles/LeaveSetups/";
        private readonly string _process;
        public int ID { get; set; }

        public static frmLeaveSetup instance;
        public frmLeaveSetup(string process)
        {
            instance = this;
            InitializeComponent();
            _process = process;
        }

        private async void frmLeaveSetup_Load(object sender, EventArgs e)
        {
            if (_process == "Update")
            {
                var leaveSetup = await _repo.GetByIdAsync(baseEndpoint + ID);
                tType.Text = leaveSetup.Type;
                btnSave.Text = "Update";
            }
        }

        private async Task AddEdit()
        {
            if (_process == "Create")
            {
                var leaveSetup = new LeaveSetup
                {
                    Type = tType.Text
                };
                await _repo.AddAsync(leaveSetup, baseEndpoint + "create");
                new Toastr("Success", "Department added");
                Close();
            }
            else if (_process == "Update")
            {
                var leaveSetup = new LeaveSetup
                {
                    Id = ID,
                    Type = tType.Text
                };
                await _repo.UpdateAsync(leaveSetup, baseEndpoint + "update");
                new Toastr("Information", "Department updated");
                Close();
            }
        }
    }
}
