using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Transactions.EmployeeEntity;

namespace Core.Entities.Transactions.AttendanceEntity
{
    public class Attendance : BaseEntity
    {
        public DateTime Date { get; set; }
        public DateTime TimeIn { get; set; }
        [MaxLength(100)]
        public string TimeInRemarks { get; set; }
        public DateTime TimeOut { get; set; }
        [MaxLength(100)]
        public string TimeOutRemarks { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
    }
}