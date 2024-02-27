using HrmsPrototype.Core.Entities.Settings;
using HrmsPrototype.Core.Notifications;
using HrmsPrototype.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmsPrototype.Forms.Settings
{
    public partial class frmCampus : Form
    {
        GenericRepository<Campus> _campusRepo = new GenericRepository<Campus>();
        public frmCampus()
        {
            InitializeComponent();
        }

        private async void frmCampus_Load(object sender, EventArgs e)
        {
            await loadRecords();
        }

        private async Task loadRecords()
        {
            var campus = await _campusRepo.GetAllAsync("campus");
            dgv.DataSource = campus;
            dgv.Columns["Id"].Visible = false;
        }

        private void txtClear()
        {
            tName.Clear();
            tDescription.Clear();
            tName.Select();
            btnSave.Text = "Create";
        }

        private async Task AddEdit()
        {
            if (btnSave.Text == "Create")
            {
                var campus = new Campus
                {
                    Name = tName.Text,
                    Description = tDescription.Text,
                };
                await _campusRepo.AddAsync(campus, "campus/create");
                new Toastr("Success", "Campus successfully created");
                await loadRecords();
                txtClear();
            }
            else if (btnSave.Text == "Update")
            {
                var campus = new Campus
                {
                    Id = Convert.ToInt32(dgv.CurrentRow.Cells["Id"].Value),
                    Name = tName.Text,
                    Description = tDescription.Text
                };
                await _campusRepo.UpdateAsync(campus, "campus/update");
                new Toastr("Information", "Campus updated");
                await loadRecords();
                txtClear();
            }
        }

        private async Task Delete()
        {
            var id = dgv.CurrentRow.Cells["Id"].Value.ToString();
            await _campusRepo.DeleteAsync("campus/" + id);
            new Toastr("Information", "Campus Deleted");
            await loadRecords();
        }

        private async Task searchRecords(string value)
        {
            var search = await _campusRepo.SearchAsync("campus/search?value=" + value);
            dgv.DataSource = search;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tName.Text = dgv.CurrentRow.Cells["Name"].Value.ToString();
            tDescription.Text = dgv.CurrentRow.Cells["Description"].Value.ToString();
            btnSave.Text = "Update";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await AddEdit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClear();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            await Delete();
        }

        private void tName_TextChanged(object sender, EventArgs e)
        {
            tName.Text = tName.Text.ToUpper();
            tName.SelectionStart = tName.Text.Length;
        }

        private void tDescription_TextChanged(object sender, EventArgs e)
        {
            tDescription.Text = tDescription.Text.ToUpper();
            tDescription.SelectionStart = tDescription.Text.Length;
        }

        private async void tSearch_TextChanged(object sender, EventArgs e)
        {
            if (tSearch.Text.Length > 3)
            {
                await searchRecords(tSearch.Text);
            }
            else if (tSearch.Text.Length == 0)
            {
                await loadRecords();
            }
        }
    }
}
