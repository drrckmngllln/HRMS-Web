using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class OtherInformation : BaseEntity
    {
        public Employee EmployeeNumber { get; set; }
        public int EmployeeNumberId { get; set; }
        public string SpecialSkills { get; set; }
        public string NonAcademicDestinction { get; set; }
        public string Organization { get; set; }
    }
}