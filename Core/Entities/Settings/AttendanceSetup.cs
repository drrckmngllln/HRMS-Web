using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.Settings
{
    public class AttendanceSetup : BaseEntity
    {
        public AttendanceSetupCategory Category { get; set; } = AttendanceSetupCategory.NonTeaching;
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public int GracePeriod { get; set; }
    }
}