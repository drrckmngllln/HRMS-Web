using HrmsPrototype.Core.Entities.Transactions;
using HrmsPrototype.Core.Helpers;
using HrmsPrototype.Infrastructure.Repositories;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmsPrototype.Forms.Transaction.Employee
{
    public partial class frmEmployeeList : Form
    {
        GenericRepository<Employees> _empRepo = new GenericRepository<Employees>();
        Pagination paging = new Pagination();
        public frmEmployeeList()
        {
            InitializeComponent();
        }

        private async void frmEmployeeList_Load(object sender, EventArgs e)
        {
            await loadRecords();
        }

        private async Task loadRecords()
        {
            paging.PageSize = 10;
            var employees = await _empRepo.GetAllAsync("employees?pageSize=" + paging.PageSize + "&pageNumber=" + paging.PageNumber);
            dgv.DataSource = employees;
            dgv.Columns["Id"].Visible = false;
            dgv.Columns["EmployeeNumber"].HeaderText = "Employee Number";
            dgv.Columns["LastName"].Visible = false;
            dgv.Columns["FirstName"].Visible = false;
            dgv.Columns["MiddleName"].Visible = false;
            dgv.Columns["FullName"].HeaderText = "Name";
            dgv.Columns["FullName"].Width = 450;
            dgv.Columns["Department"].HeaderText = "Department";
            dgv.Columns["Position"].HeaderText = "Position";
            dgv.Columns["ContractStart"].HeaderText = "Contract Start";
            dgv.Columns["ContractEnd"].HeaderText = "Contract End";
            dgv.Columns["Status"].HeaderText = "Status";
        }

        private async Task searchRecords(string search)
        {
            var value = await _empRepo.SearchAsync("employees?search=" + search);
            dgv.DataSource = value;
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            btnPrev.Enabled = true;
            paging.PageNumber++;
            tPageNumber.Text = paging.PageNumber.ToString();
            await loadRecords();
            if (dgv.Rows.Count < paging.PageSize)
            {
                btnNext.Enabled = false;
            }
        }

        private async void btnPrev_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            paging.PageNumber--;
            tPageNumber.Text = paging.PageNumber.ToString();
            await loadRecords();
            if (tPageNumber.Text == "1") btnPrev.Enabled = false;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEmployees.instance.ID = Convert.ToInt32(dgv.CurrentRow.Cells["Id"].Value.ToString());
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
