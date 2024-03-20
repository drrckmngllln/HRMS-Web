using HrmsPrototype.Core.Entities.Settings;
using HrmsPrototype.Core.Notifications;
using HrmsPrototype.Infrastructure.Repositories;
using Krypton.Toolkit;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmsPrototype.Forms.Settings.LibraryFilesComponent.LibraryFilesAddEdit
{
    public partial class frmCampuses : KryptonForm
    {
        GenericRepository<Campus> _repo = new GenericRepository<Campus>();

        private readonly string _process;
        private const string baseEndpoint = "LibraryFiles/Campuses/";
        public int ID { get; set; }

        public static frmCampuses instance;
        public frmCampuses(string process)
        {
            instance = this;
            InitializeComponent();
            _process = process;
        }

        private async void frmCampuses_Load(object sender, EventArgs e)
        {
            if (_process == "Update")
            {
                var campus = await _repo.GetByIdAsync(baseEndpoint + ID);
                tName.Text = campus.Name;
                tDesctiption.Text = campus.Description;
                btnSave.Text = "Update";
            }
        }

        public async Task AddEdit()
        {
            if (_process == "Create")
            {
                var campus = new Campus
                { Name = tName.Text, Description = tDesctiption.Text };
                await _repo.AddAsync(campus, baseEndpoint + "create");
                new Toastr("Success", "Campus Created");
                Close();
            }
            else if (_process == "Update")
            {
                var campus = new Campus
                {
                    Id = ID,
                    Name = tName.Text,
                    Description = tDesctiption.Text
                };
                await _repo.UpdateAsync(campus, baseEndpoint + "update");
                new Toastr("Information", "Campus Updated");
                Close();
            }
        }

        private async void frmCampuses_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
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
