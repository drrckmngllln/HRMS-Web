using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class WorkExperience : BaseEntity
    {
        public Employee EmployeeNumber { get; set; }
        public int EmployeeNumberId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public decimal MonthlySalary { get; set; }
        public string PayGrade { get; set; }
        public string StatusOfAppointment { get; set; }
        public string GovernmentService { get; set; }
    }
}