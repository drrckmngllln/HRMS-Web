using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Settings;

namespace API.Dtos
{
    public class EmployeeToReturnDto
    {
        public int Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string FullName { get; set; }
        public Department Department { get; set; }
        public Positions Position { get; set; }
        public string ContractStart { get; set; }
        public string ContractEnd { get; set; }
        public string Status { get; set; }
    }
}