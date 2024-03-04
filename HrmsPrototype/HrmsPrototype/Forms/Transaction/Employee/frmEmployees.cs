using HrmsPrototype.Core.Entities.Transactions;
using HrmsPrototype.Core.Notifications;
using HrmsPrototype.Forms.Transaction.Employee;
using HrmsPrototype.Infrastructure.Repositories;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmsPrototype.Forms.Transaction
{
    public partial class frmEmployees : Form
    {
        GenericRepository<Employees> _empRepo = new GenericRepository<Employees>();

        public static frmEmployees instance;
        public int ID { get; set; }
        public frmEmployees()
        {
            instance = this;
            InitializeComponent();
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            loadEmployeeRecords();

        }

        public void loadEmployeeRecords()
        {
            var frm = new frmEmployeeList();
            frm.TopLevel = false;
            panelTask.Controls.Clear();
            panelTask.Controls.Add(frm);
            frm.Show();
        }

        private void AddEditEmployee(string type)
        {
            if (type == "Add")
            {
                var frm = new frmAddEditEmployees(type);
                frm.TopLevel = false;
                panelTask.Controls.Clear();
                panelTask.Controls.Add(frm);
                frm.Show();
            }
            else if (type == "Update")
            {

                var frm = new frmAddEditEmployees(type);
                frmAddEditEmployees.instance.ID = ID;
                frm.TopLevel = false;
                panelTask.Controls.Clear();
                panelTask.Controls.Add(frm);
                frm.Show();
            }
        }

        private async Task deleteRecord()
        {
            await _empRepo.DeleteAsync("employees/" +  ID);
            new Toastr("Information", "Employee removed");
            loadEmployeeRecords();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            loadEmployeeRecords();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddEditEmployee("Add");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                new Toastr("Warning", "Please select data");
            }
            else
            {
                AddEditEmployee("Update");
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                new Toastr("Warning", "Please select data to delete");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete employee?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await deleteRecord();
                }
            }
        }
    }
}
