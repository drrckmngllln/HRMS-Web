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
    public partial class frmPositions : Form
    {
        GenericRepository<Positions> _positionRepo = new GenericRepository<Positions>();
        public frmPositions()
        {
            InitializeComponent();
        }

        private async void frmPositions_Load(object sender, EventArgs e)
        {
            await loadRecords();
        }

        private async Task loadRecords()
        {
            var position = await _positionRepo.GetAllAsync("positions");
            dgv.DataSource = position;
            dgv.Columns["Id"].Visible = false;
        }

        private async Task searchRecords(string value)
        {
            var search = await _positionRepo.SearchAsync("positions/search?value=" + value);
            dgv.DataSource = search;
        }

        private async Task AddEdit()
        {
            if (btnSave.Text == "Create")
            {
                var position = new Positions
                {
                    Name = tName.Text
                };
                await _positionRepo.AddAsync(position, "positions/create");
                new Toastr("Success", "Position added");
                await loadRecords();
                txtClear();
            }
            else if (btnSave.Text == "Update")
            {
                var position = new Positions
                {
                    Id = Convert.ToInt32(dgv.CurrentRow.Cells["Id"].Value),
                    Name = tName.Text
                };
                await _positionRepo.UpdateAsync(position, "positions/update");
                new Toastr("Information", "Position updated");
                await loadRecords();
                txtClear();
            }
        }

        private void txtClear()
        {
            tName.Clear();
            tName.Select();
            btnSave.Text = "Create";
        }

        private async Task Delete()
        {
            var positionId = dgv.CurrentRow.Cells["Id"].Value.ToString();
            await _positionRepo.DeleteAsync("positions/" + positionId);
            new Toastr("Warning", "Position deleted");
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await AddEdit();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                await Delete();
                await loadRecords();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tName.Text = dgv.CurrentRow.Cells["Name"].Value.ToString();
            btnSave.Text = "Update";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClear();
        }

        private async void tSearch_TextChanged(object sender, EventArgs e)
        {
            if (tSearch.Text.Length > 2)
            {
                await searchRecords(tSearch.Text);
            }
            else if (tSearch.Text.Length == 0)
            {
                await loadRecords();
            }
        }

        private void tName_TextChanged(object sender, EventArgs e)
        {
            tName.Text = tName.Text.ToUpper();
            tName.SelectionStart = tName.Text.Length;
        }
    }
}
