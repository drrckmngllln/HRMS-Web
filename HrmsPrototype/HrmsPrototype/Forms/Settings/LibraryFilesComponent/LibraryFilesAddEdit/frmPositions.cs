using HrmsPrototype.Core.Entities.Settings;
using HrmsPrototype.Core.Notifications;
using HrmsPrototype.Infrastructure.Repositories;
using Krypton.Toolkit;
using System;
using System.Threading.Tasks;

namespace HrmsPrototype.Forms.Settings.LibraryFilesComponent.LibraryFilesAddEdit
{
    public partial class frmPositions : KryptonForm
    {
        GenericRepository<Positions> _repo = new GenericRepository<Positions>();
        private const string baseEndpoint = "LibraryFiles/Positions/";
        private readonly string _process;

        public int ID { get; set; }
        public static frmPositions instance;
        public frmPositions(string process)
        {
            instance = this;
            InitializeComponent();
            _process = process;
        }

        private async void frmPositions_Load(object sender, EventArgs e)
        {
            if (_process == "Update")
            {
                var position = await _repo.GetByIdAsync(baseEndpoint + ID);
                tName.Text = position.Name;
                btnSave.Text = "Update";
            }
        }

        private async Task AddEdit()
        {
            if (_process == "Create")
            {
                var position = new Positions
                {
                    Name = tName.Text
                };
                await _repo.AddAsync(position, baseEndpoint + "create");
                new Toastr("Success", "Position added");
                Close();
            }
            else if (_process == "Update")
            {
                var position = new Positions
                {
                    Id = ID,
                    Name = tName.Text
                };
                await _repo.UpdateAsync(position, baseEndpoint + "update");
                new Toastr("Information", "Department updated");
                Close();
            }
        }

        private async void frmPositions_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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
