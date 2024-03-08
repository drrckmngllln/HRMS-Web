using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class VoluntaryWork : BaseEntity
    {
        [MaxLength(100)]
        public Employee EmployeeNumber { get; set; }
        [MaxLength(100)]
        public int EmployeeNumberId { get; set; }
        [MaxLength(100)]
        public string NameAndAddressOfOrganization { get; set; }
        [MaxLength(100)]
        public string StartDate { get; set; }
        [MaxLength(100)]
        public string EndDate { get; set; }
        [MaxLength(100)]
        public int NumberOfHours { get; set; }
        [MaxLength(100)]
        public string NatureOfWork { get; set; }
    }
}