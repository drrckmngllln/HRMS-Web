using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class AttendanceIdentityDto
    {
        public int Id { get; set; }
        public int EmployeeNumber { get; set; }
        public byte[] Data { get; set; }
    }
}