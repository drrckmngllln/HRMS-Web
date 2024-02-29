using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class NameOfChildren : BaseEntity
    {
        public string Fullname { get; set; }
        public string DateOfBirth { get; set; }
    }
}