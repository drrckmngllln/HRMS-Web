using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class EducationalBackground : BaseEntity
    {
        public Employee EmployeeNumber { get; set; }
        public int EmployeeNumberId { get; set; }
        public EducationalLevel Level { get; set; }
        public string NameOfSchool { get; set; }
        public string Course { get; set; }
        public string PeriodStart { get; set; }
        public string PeriodEnd { get; set; }
        public string UnitsEarned { get; set; }
        public string YearGraduated { get; set; }
        public string AcademicHonors { get; set; }
    }
}