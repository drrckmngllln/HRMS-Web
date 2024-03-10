using HrmsPrototype.Core.Notifications;
using HrmsPrototype.Entities.Settings;
using HrmsPrototype.Infrastructure.Repositories;
using Krypton.Toolkit;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmsPrototype.Forms.Settings.LibraryFilesComponent.LibraryFilesAddEdit
{
    public partial class frmDepartment : KryptonForm
    {
        GenericRepository<Departments> _repo = new GenericRepository<Departments>();
        private const string baseEndpoint = "LibraryFiles/Departments/";
        private readonly string _process;
        public int ID { get; set; }

        public static frmDepartment instance;
        public frmDepartment(string process)
        {
            instance = this;
            InitializeComponent();
            _process = process;
        }

        private async void frmDepartment_Load(object sender, EventArgs e)
        {
            if (_process == "Update")
            {
                var department = await _repo.GetByIdAsync(baseEndpoint + ID);
                tName.Text = department.Name;
                btnSave.Text = "Update";
            }
        }

        private async Task AddEdit()
        {
            if (_process == "Create")
            {
                var department = new Departments
                {
                    Name = tName.Text
                };
                await _repo.AddAsync(department, baseEndpoint + "create");
                new Toastr("Success", "Department added");
                Close();
            }
            else if (_process == "Update")
            {
                var department = new Departments
                {
                    Id = ID,
                    Name = tName.Text
                };
                await _repo.UpdateAsync(department, baseEndpoint + "update");
                new Toastr("Information", "Department updated");
                Close();
            }
        }

        private async void frmDepartment_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await AddEdit();
            }
            else if (e.KeyCode == Keys.Escape)
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
