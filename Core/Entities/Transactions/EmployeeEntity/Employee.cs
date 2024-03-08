using System.ComponentModel.DataAnnotations;
using Core.Entities.Settings;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class Employee : BaseEntity
    {
        [MaxLength(100)]
        public string EmployeeNumber { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string MiddleName { get; set; }
        [MaxLength(100)]
        public string FullName { get; set; }
        [MaxLength(100)]
        public Department Department { get; set; }
        [MaxLength(100)]
        public int DepartmentId { get; set; }
        [MaxLength(100)]
        public Positions Position { get; set; }
        [MaxLength(100)]
        public int PositionId { get; set; }
        [MaxLength(100)]
        public DateOnly ContractStart { get; set; }
        [MaxLength(100)]
        public DateOnly ContractEnd { get; set; }
        [MaxLength(100)]
        public EmployeeStatus Status { get; set; }
    }
}