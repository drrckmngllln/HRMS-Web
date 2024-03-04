using HrmsPrototype.Core.Entities.Transactions;
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

namespace HrmsPrototype.Forms.Transaction.Employee.PersonalDataSheet
{
    public partial class frmPdsMain : Form
    {
        GenericRepository<Employees> _empRepo = new GenericRepository<Employees>();

        public int ID { get; set; }
        public static frmPdsMain instance;
        public frmPdsMain()
        {
            instance = this;
            InitializeComponent();
        }

        private async void frmPdsMain_Load(object sender, EventArgs e)
        {
            await loadEmployee();
            loadPersonalInformation();
        }

        private async Task loadEmployee()
        {
            var employee = await _empRepo.GetByIdAsync("employees/" + ID);
            if (employee != null)
            {
                tTitle.Text = "Personal Data Sheet: " + employee.EmployeeNumber;
            }
        }

        private void loadPersonalInformation()
        {
            var frm = new frmPersonalInformationChild();
            frm.TopLevel = false;
            panelTask.Controls.Clear();
            panelTask.Controls.Add(frm);
            frm.Show();
        }
    }
}
