using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.Identity
{
    public class UserAuth : BaseEntity
    {
        public string Authorization { get; set; }
    }
}