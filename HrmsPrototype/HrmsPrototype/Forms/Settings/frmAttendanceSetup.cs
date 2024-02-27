using HrmsPrototype.Core.Entities.Settings;
using HrmsPrototype.Core.Notifications;
using HrmsPrototype.Infrastructure.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmsPrototype.Forms.Settings
{
    public partial class frmAttendanceSetup : Form
    {
        GenericRepository<AttendanceSetup> _attendanceSetupRepo = new GenericRepository<AttendanceSetup>();

        
        public frmAttendanceSetup()
        {
            InitializeComponent();
        }

        private async void frmAttendanceSetup_Load(object sender, EventArgs e)
        {
            await loadRecords();
            loadCategory();
        }

        private async Task loadRecords()
        {
            var attendance = await _attendanceSetupRepo.GetAllAsync("attendancesetup");
            dgv.DataSource = attendance;
            dgv.Columns["Id"].Visible = false;
            dgv.Columns["Category"].HeaderText = "Category";
            dgv.Columns["TimeIn"].HeaderText = "Time In";
            dgv.Columns["TimeOut"].HeaderText = "Time Out";
        }

        private void loadCategory()
        {
            tCategory.DataSource = Enum.GetValues(typeof(AttendanceSetupCategory));
            //tCategory.ValueMember = "Text";
            //tCategory.DisplayMember = "Value";
        }
        
        private async Task addEdit()
        {
            if (btnSave.Text == "Create")
            {
                var setup = new AttendanceSetup
                {
                    Category = (AttendanceSetupCategory)tCategory.SelectedItem,
                    TimeIn = tTimeIn.Text,
                    TimeOut = tTimeOut.Text,
                    GracePeriod = tGracePeriod.Text
                };
                await _attendanceSetupRepo.AddAsync(setup, "attendancesetup/create");
                new Toastr("Success", "Attendance setup add success");
                await loadRecords();
                txtClear();
            }
            else if (btnSave.Text == "Update")
            {
                var setup = new AttendanceSetup
                {
                    Id = Convert.ToInt32(dgv.CurrentRow.Cells["Id"].Value),
                    Category = (AttendanceSetupCategory)tCategory.SelectedItem,
                    TimeIn = tTimeIn.Text,
                    TimeOut = tTimeOut.Text,
                    GracePeriod = tGracePeriod.Text
                };
                await _attendanceSetupRepo.UpdateAsync(setup, "attendancesetup/update");
                new Toastr("Success", "Attendance setup add success");
                await loadRecords();
                txtClear();
            }
        }

        private async Task delete()
        {
            var id = dgv.CurrentRow.Cells["Id"].Value.ToString();
            await _attendanceSetupRepo.DeleteAsync("attendancesetup/" + id);
            new Toastr("Information", "Attendance setup deleted");
            btnSave.Enabled = true;
            txtClear();
        }

        private void txtClear()
        {
            tTimeIn.Clear();
            tTimeOut.Clear();
            tGracePeriod.Clear();
            btnSave.Text = "Create";

            if (dgv.Rows.Count > 0)
            {
                btnSave.Enabled = false;
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await addEdit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClear();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                await delete();
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tTimeIn.Text = dgv.CurrentRow.Cells["TimeIn"].Value.ToString();
            tTimeOut.Text = dgv.CurrentRow.Cells["TimeOut"].Value.ToString();
            tGracePeriod.Text = dgv.CurrentRow.Cells["GracePeriod"].Value.ToString();
            btnSave.Text = "Update";
            btnSave.Enabled = true;
        }
    }
}
