using Core.Entities.Settings;
using Core.Entities.Transactions.EmployeeEntity;

namespace API.Dtos
{
    public class AttendanceDto
    {
        public DateTime Date { get; set; }
        public DateTime TimeIn { get; set; }
        public string TimeInRemarks { get; set; }
        public DateTime TimeOut { get; set; }
        public string TimeOutRemarks { get; set; }
        public string Employee { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        
    }
}