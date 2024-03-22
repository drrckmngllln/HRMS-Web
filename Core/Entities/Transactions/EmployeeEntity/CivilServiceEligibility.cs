using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class CivilServiceEligibility : BaseEntity
    {
        
        public Employee EmployeeNumber { get; set; }
        public int EmployeeNumberId { get; set; }
        [MaxLength(100)]
        public string Eligibility { get; set; }
        [MaxLength(100)]
        public decimal Rating { get; set; }
        [MaxLength(100)]
        public DateTime DateOfExamination { get; set; }
        [MaxLength(100)]
        public string PlaceOfExamination { get; set; }
        [MaxLength(100)]
        public string LicenseNumber { get; set; }
        [MaxLength(100)]
        public string DateOfValidity { get; set; }
    }
}