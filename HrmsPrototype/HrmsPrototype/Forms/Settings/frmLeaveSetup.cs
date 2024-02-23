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
    public partial class frmLeaveSetup : Form
    {
        GenericRepository<LeaveSetup> _leaveRepo = new GenericRepository<LeaveSetup>();
        public frmLeaveSetup()
        {
            InitializeComponent();
        }

        private async void frmLeaveSetup_Load(object sender, EventArgs e)
        {
            await loadRecords();
        }

        private async Task loadRecords()
        {
            var leave = await _leaveRepo.GetAllAsync("leavesetup");
            dgv.DataSource = leave;
            dgv.Columns["Id"].Visible = false;
        }

        private void txtClear()
        {
            tType.Clear();
            tCredit.Clear();
            tType.Select();
            btnSave.Text = "Create";
        }

        private async Task AddEdit()
        {
            if (btnSave.Text == "Create")
            {
                var leave = new LeaveSetup
                {
                    Type = tType.Text,
                    Credits = Convert.ToInt32(tCredit.Text)
                };
                await _leaveRepo.AddAsync(leave, "leavesetup/create");
                new Toastr("Success", "Leave add success");
                await loadRecords();
                txtClear();
            }
            else if (btnSave.Text == "Update")
            {
                var leave = new LeaveSetup
                {
                    Id = Convert.ToInt32(dgv.CurrentRow.Cells["Id"].Value),
                    Type = tType.Text,
                    Credits = Convert.ToInt32(tCredit.Text)
                };
                await _leaveRepo.UpdateAsync(leave, "leavesetup/update");
                new Toastr("Information", "Leave update success");
                await loadRecords();
                txtClear();
            }
        }

        private async Task Delete()
        {
            var id = dgv.CurrentRow.Cells["Id"].Value.ToString();
            await _leaveRepo.DeleteAsync("leavesetup/" + id);
            new Toastr("Information", "Leave delete success");
            await loadRecords();
            txtClear();
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
            if (MessageBox.Show("Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await Delete();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tType.Text = dgv.CurrentRow.Cells["Type"].Value.ToString();
            tCredit.Text = dgv.CurrentRow.Cells["Credits"].Value.ToString();
            btnSave.Text = "Update";
        }
    }
}
