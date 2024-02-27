using HrmsPrototype.Core.Notifications;
using HrmsPrototype.Entities.Settings;
using HrmsPrototype.Infrastructure.Interfaces;
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
    public partial class frmDepartments : Form
    {
        GenericRepository<Departments> _departmentRepo = new GenericRepository<Departments>();

        public frmDepartments()
        {
            InitializeComponent();
        }

        private async void frmDepartments_Load(object sender, EventArgs e)
        {
            await loadRecords();
        }

        private async Task loadRecords()
        {
            var departments = await _departmentRepo.GetAllAsync("departments");
            dgv.DataSource = departments;
            dgv.Columns["Id"].Visible = false;
        }

        private async Task AddEdit()
        {
            if (btnSave.Text == "Create")
            {
                var department = new Departments
                {
                    Name = tName.Text
                };
                await _departmentRepo.AddAsync(department, "departments/create");
                new Toastr("Success", "Department Added");
                await loadRecords();
            }
            else if (btnSave.Text == "Update")
            {
                var department = new Departments
                {
                    Id = Convert.ToInt32(dgv.CurrentRow.Cells["Id"].Value),
                    Name = tName.Text
                };
                await _departmentRepo.UpdateAsync(department, "departments/update");
                new Toastr("Information", "Department updated");
                await loadRecords();
            }
        }

        private async Task Delete()
        {
            var id = dgv.CurrentRow.Cells["Id"].Value.ToString();
            await _departmentRepo.DeleteAsync("departments/" + id);
            new Toastr("Warning", "Department deleted");
            await loadRecords();
        }

        private async Task SearchRecords(string search)
        {
            var items = await _departmentRepo.SearchAsync("departments/search?value=" + search);
            dgv.DataSource = items;
        }

        private void txtClear()
        {
            tName.Clear();
            tName.Select();
            btnSave.Text = "Create";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await AddEdit();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Text = "Update";
            tName.Text = dgv.CurrentRow.Cells["Name"].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtClear();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            await Delete();
        }

        private async void tSearch_TextChanged(object sender, EventArgs e)
        {
            if (tSearch.Text.Length > 2)
            {
                await SearchRecords(tSearch.Text);
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
            tName.SelectionLength = 0;
        }
    }
}
