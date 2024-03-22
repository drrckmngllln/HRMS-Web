using System;

namespace HrmsPrototype.Core.Entities.Settings
{
    internal class AttendanceSetup
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public int GracePeriod { get; set; }
    }
}
