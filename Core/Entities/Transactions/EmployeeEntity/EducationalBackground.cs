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
        public DateOnly PeriodStart { get; set; }
        [MaxLength(100)]
        public DateOnly PeriodEnd { get; set; }
        [MaxLength(100)]
        public decimal UnitsEarned { get; set; }
        [MaxLength(100)]
        public DateOnly YearGraduated { get; set; }
        [MaxLength(100)]
        public string AcademicHonors { get; set; }
    }
}