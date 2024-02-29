using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class LearningAndDevelopment : BaseEntity
    {
        public Employee EmployeeNumber { get; set; }
        public int EmployeeNumberId { get; set; }
        public string TitleOfLearningAndDevelopment { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int NumberOfHours { get; set; }
        public string TypeOfLd { get; set; }
        public string Conducted { get; set; }
    }
}