using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class VoluntaryWork : BaseEntity
    {
        public Employee EmployeeNumber { get; set; }
        public int EmployeeNumberId { get; set; }
        public string NameAndAddressOfOrganization { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int NumberOfHours { get; set; }
        public string NatureOfWork { get; set; }
    }
}