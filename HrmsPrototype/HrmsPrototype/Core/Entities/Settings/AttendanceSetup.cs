using System;

namespace HrmsPrototype.Core.Entities.Settings
{
    internal class AttendanceSetup
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public int GracePeriod { get; set; }
    }
}
