using HrmsPrototype.Core.Entities.Transactions;
using HrmsPrototype.Infrastructure.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HrmsPrototype.Forms.Transaction.Employee.AttendanceMonitoring
{
    public partial class frmEmployeeAttendanceLog : Form
    {
        private const string attendanceEndpoint = "attendances/";
        private const string employeeEndpoint = "employees/";

        GenericRepository<Attendance> _attendanceRepo = new GenericRepository<Attendance>();
        GenericRepository<Employees> _employeeRepo = new GenericRepository<Employees>();    

        public static frmEmployeeAttendanceLog instance;
        public int ID { get; set; }
        public frmEmployeeAttendanceLog()
        {
            instance = this;
            InitializeComponent();
        }

        private void frmEmployeeAttendanceLog_Load(object sender, EventArgs e)
        {
            tDate.Text = DateTime.Now.ToString("MM-dd-yyyy");
        }

        private async Task<Employees> loadRecords()
        {
            var employees = await _employeeRepo.GetAllAsync(employeeEndpoint);
            var employee = employees.SingleOrDefault(x => x.EmployeeNumber == ID.ToString());
            return employee;
        }

        private async Task BiometricLogs()
        {
            //var date = DateTime.Now;
            //if (date < DateTime.tim)
        }
    }
}
