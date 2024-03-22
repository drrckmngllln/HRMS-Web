using System.ComponentModel.DataAnnotations;
using Core.Entities.Transactions.EmployeeEntity;

namespace API.Dtos
{
    public class EmployeeDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string EmployeeNumber { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public DateTime ContractStart { get; set; }
        [Required]
        public DateTime ContractEnd { get; set; }
        [Required]
        public EmployeeStatus Status { get; set; }
    }
}