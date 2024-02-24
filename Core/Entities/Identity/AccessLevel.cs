using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Core.Entities.Identity
{
    public class AccessLevel : BaseEntity
    {
        public string Role { get; set; }
        public string Description { get; set; }
        public UserAuth Authorization { get; set; }
        public int AuthorizationId { get; set; }
    }
}