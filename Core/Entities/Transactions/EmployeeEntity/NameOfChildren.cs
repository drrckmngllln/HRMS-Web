using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class NameOfChildren : BaseEntity
    {
        public Employee EmployeeNumber { get; set; }
        public int EmployeeNumberId { get; set; }
        public string Fullname { get; set; }
        public string DateOfBirth { get; set; }
    }
}