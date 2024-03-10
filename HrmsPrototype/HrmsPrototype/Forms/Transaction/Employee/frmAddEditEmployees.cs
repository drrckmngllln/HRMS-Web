using HrmsPrototype.Core.Entities.Settings;
using HrmsPrototype.Core.Entities.Transactions;
using HrmsPrototype.Core.Notifications;
using HrmsPrototype.Entities.Settings;
using HrmsPrototype.Infrastructure.Interfaces;
using HrmsPrototype.Infrastructure.Repositories;
using HrmsPrototype.Infrastructure.Services;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmsPrototype.Forms.Transaction
{
    public partial class frmAddEditEmployees : Form
    {
        GenericRepository<Departments> _departmentRepo = new GenericRepository<Departments>();
        GenericRepository<Positions> _positionRepo = new GenericRepository<Positions>();
        GenericRepository<Employees> _employeeRepo = new GenericRepository<Employees>();

        public int ID { get; set; }
        private readonly string _type;

        public static frmAddEditEmployees instance;
        public frmAddEditEmployees(string type)
        {
            instance = this;
            InitializeComponent();
            _type = type;
        }

        private async void frmAddEditEmployees_Load(object sender, EventArgs e)
        {
            await loadAll();
        }

        private async Task loadAll()
        {
            if (_type == "Add")
            {
                await loadDepartments();
                await loadPositions();
                loadEmployeeStatus();
            }
            else if (_type == "Update")
            {
                await loadDepartments();
                await loadPositions();
                loadEmployeeStatus();
                tTitle.Text = "Update Employee";
                var employee = await _employeeRepo.GetByIdAsync("employees/" + ID);
                if (employee != null)
                {
                    tEmployeeNumber.Text = employee.EmployeeNumber;
                    tLastName.Text = employee.LastName;
                    tFirstName.Text = employee.FirstName;
                    tMiddleName.Text = employee.MiddleName;
                    tDepartment.Text = employee.Department;
                    tPosition.Text = employee.Position;
                    tContractStart.Text = employee.ContractStart;
                    tContractEnd.Text = employee.ContractEnd;
                    tStatus.SelectedItem = (EmployeeStatus)employee.Status;
                }
            }
        }

        private async Task loadDepartments()
        {
            var departments = await _departmentRepo.GetAllAsync("departments");
            tDepartment.ValueMember = "Id";
            tDepartment.DisplayMember = "Name";
            tDepartment.DataSource = departments;
        }

        private async Task loadPositions()
        {
            var positions = await _positionRepo.GetAllAsync("positions");
            tPosition.ValueMember = "Id";
            tPosition.DisplayMember = "Name";
            tPosition.DataSource = positions;
        }

        private async Task AddEditAsync()
        {
            if (_type == "Add")
            {
                var employee = new Employees
                {
                    EmployeeNumber = tEmployeeNumber.Text,
                    LastName = tLastName.Text,
                    FirstName = tFirstName.Text,
                    MiddleName = tMiddleName.Text,
                    FullName = tLastName.Text + ", " + tFirstName.Text + " " + tMiddleName.Text,
                    Department = tDepartment.Text,
                    Position = tPosition.Text,
                    ContractStart = tContractStart.Text,
                    ContractEnd = tContractEnd.Text,
                    Status = (EmployeeStatus)tStatus.SelectedItem
                };
                await _employeeRepo.AddAsync(employee, "employees/create");
                new Toastr("Success", "Employee add success");
                CloseForm();
            }
            else if (_type == "Update")
            {
                var employee = new Employees
                {
                    Id = ID,
                    EmployeeNumber = tEmployeeNumber.Text,
                    LastName = tLastName.Text,
                    FirstName = tFirstName.Text,
                    MiddleName = tMiddleName.Text,
                    FullName = tLastName.Text + ", " + tFirstName.Text + " " + tMiddleName.Text,
                    Department = tDepartment.Text,
                    Position = tPosition.Text,
                    ContractStart = tContractStart.Text,
                    ContractEnd = tContractEnd.Text,
                    Status = (EmployeeStatus)tStatus.SelectedItem
                };
                await _employeeRepo.UpdateAsync(employee, "employees/update");
                new Toastr("Information", "Employee update success");
                CloseForm();
            }
        }

        private void CloseForm()
        {
            frmEmployees.instance.loadEmployeeRecords();
            Close();
        }

        private void loadEmployeeStatus()
        {
            tStatus.DataSource = Enum.GetValues(typeof(EmployeeStatus));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmEmployees.instance.loadEmployeeRecords();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tContractStart.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            tContractEnd.Text = dateTimePicker2.Value.ToString("yyyy-MM-dd");
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await AddEditAsync();
        }
    }
}
