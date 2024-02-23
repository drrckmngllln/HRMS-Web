using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.Settings
{
    public class LeaveSetup : BaseEntity
    {
        public string Type { get; set; }
        public int Credits { get; set; }
    }
}