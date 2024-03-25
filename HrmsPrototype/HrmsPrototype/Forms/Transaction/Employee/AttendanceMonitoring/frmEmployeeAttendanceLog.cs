using HrmsPrototype.Core.Entities.Settings;
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
        GenericRepository<AttendanceSetup> _attendanceSetupRepo = new GenericRepository<AttendanceSetup>();

        public static frmEmployeeAttendanceLog instance;
        public int ID { get; set; }
        public frmEmployeeAttendanceLog()
        {
            instance = this;
            InitializeComponent();
        }

        private async void frmEmployeeAttendanceLog_Load(object sender, EventArgs e)
        {
            await BiometricLogs();
        }

        private async Task GetEmployeeLogs(string employeeNumber)
        {
            var employeeLogs = await _attendanceRepo.GetAllAsync(attendanceEndpoint + "EmployeeAttendance?search=" + employeeNumber);

            dgv.DataSource = employeeLogs;
            //dgv.Columns["Id"].Visible = false;
        }

        private async Task BiometricLogs()
        {
            if (ID != 0)
            {
                var employees = await _employeeRepo.GetAllAsync(employeeEndpoint);
                var employeeDetail = employees.SingleOrDefault(x => x.EmployeeNumber == ID.ToString());

                tEmployeeName.Text = employeeDetail.FullName;
                tDepartment.Text = employeeDetail.Department;
                tPosition.Text = employeeDetail.Position;
                tTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
                tRemarks.Text = "Static Data: On-time";
                tDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");

                if (frmAttendanceMonitoringModule.instance.LogStatus == "Time In")
                {
                    var item = new Attendance
                    {
                        Date = DateTime.Now.ToUniversalTime(),
                        TimeIn = DateTime.Now.ToString("hh:mm:ss tt"),
                        TimeInRemarks = "Static Data: On-time",
                        Employee = ID
                    };
                    await _attendanceRepo.AddAsync(item, attendanceEndpoint + "EmployeeAttendance/create");
                }
                else if (frmAttendanceMonitoringModule.instance.LogStatus == "Time Out")
                {
                    var emp = await _attendanceRepo.GetAllAsync(attendanceEndpoint + "EmployeeAttendance");
                    var empId = emp.SingleOrDefault(x => x.Employee == ID);

                    var item = new Attendance
                    {
                        Id = empId.Id,
                        Date = empId.Date,
                        TimeIn = empId.TimeIn,
                        TimeInRemarks = empId.TimeInRemarks,
                        TimeOut = DateTime.Now.ToString("hh:mm:ss tt"),
                        TimeOutRemarks = "Static Data: On-time",
                        Employee = ID
                    };
                    await _attendanceRepo.UpdateAsync(item, attendanceEndpoint + "EmployeeAttendance/update");
                }

                await GetEmployeeLogs(ID.ToString());
            }
            
        }



        private void timerAutoClose_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
