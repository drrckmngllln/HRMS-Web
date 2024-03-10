using HrmsPrototype.Core.Entities.Transactions;
using HrmsPrototype.Core.Helpers;
using HrmsPrototype.Infrastructure.Repositories;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmsPrototype.Forms.Transaction
{
    public partial class frmEmployees : Form
    {
        GenericRepository<Employees> _empRepo = new GenericRepository<Employees>();
        Pagination paging = new Pagination();
        public frmEmployees()
        {
            InitializeComponent();
        }

        private async void frmEmployees_Load(object sender, EventArgs e)
        {
            await loadRecords();
        }

        private async Task loadRecords()
        {
            paging.PageSize = 10;

            var employees = await _empRepo.GetAllAsync("employees");
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
    }
}
