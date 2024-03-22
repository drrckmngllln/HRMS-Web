using System;

namespace HrmsPrototype.Core.Entities.Transactions
{
    internal class Attendance
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime TimeIn { get; set; }
        public string TimeInRemarks { get; set; }
        public DateTime TimeOut { get; set; }
        public string TimeOutRemarks { get; set; }
        public int Employee { get; set; }
    }
}
