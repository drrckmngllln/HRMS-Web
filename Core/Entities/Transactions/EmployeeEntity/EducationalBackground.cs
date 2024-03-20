using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class EducationalBackground : BaseEntity
    {
        public Employee EmployeeNumber { get; set; }
        public int EmployeeNumberId { get; set; }
        [MaxLength(100)]
        public EducationalLevel Level { get; set; }
        [MaxLength(100)]
        public string NameOfSchool { get; set; }
        [MaxLength(100)]
        public string Course { get; set; }
        [MaxLength(100)]
        public DateTime PeriodStart { get; set; }
        [MaxLength(100)]
        public DateTime PeriodEnd { get; set; }
        [MaxLength(100)]
        public decimal UnitsEarned { get; set; }
        [MaxLength(100)]
        public DateTime YearGraduated { get; set; }
        [MaxLength(100)]
        public string AcademicHonors { get; set; }
    }
}