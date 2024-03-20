using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class LearningAndDevelopment : BaseEntity
    {
        [MaxLength(100)]
        public Employee EmployeeNumber { get; set; }
        [MaxLength(100)]
        public int EmployeeNumberId { get; set; }
        [MaxLength(100)]
        public string TitleOfLearningAndDevelopment { get; set; }
        [MaxLength(100)]
        public DateTime StartDate { get; set; }
        [MaxLength(100)]
        public DateTime EndDate { get; set; }
        [MaxLength(100)]
        public int NumberOfHours { get; set; }
        [MaxLength(100)]
        public string TypeOfLd { get; set; }
        [MaxLength(100)]
        public string Conducted { get; set; }
    }
}