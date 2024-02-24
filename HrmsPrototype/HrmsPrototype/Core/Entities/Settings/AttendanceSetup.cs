using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrmsPrototype.Core.Entities.Settings
{
    internal class AttendanceSetup
    {
        public int Id { get; set; }
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public string GracePeriod { get; set; }
    }
}
