using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class WorkExperience : BaseEntity
    {
        [MaxLength(100)]
        public Employee EmployeeNumber { get; set; }
        [MaxLength(100)]
        public int EmployeeNumberId { get; set; }
        [MaxLength(100)]
        public string StartDate { get; set; }
        [MaxLength(100)]
        public string EndDate { get; set; }
        [MaxLength(100)]
        public string Position { get; set; }
        [MaxLength(100)]
        public string Department { get; set; }
        [MaxLength(100)]
        public decimal MonthlySalary { get; set; }
        [MaxLength(100)]
        public string PayGrade { get; set; }
        [MaxLength(100)]
        public string StatusOfAppointment { get; set; }
        [MaxLength(100)]
        public string GovernmentService { get; set; }
    }
}