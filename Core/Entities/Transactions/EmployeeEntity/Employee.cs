using Core.Entities.Settings;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class Employee : BaseEntity
    {
        public string EmployeeNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string FullName { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public Positions Position { get; set; }
        public int PositionId { get; set; }
        public string ContractStart { get; set; }
        public string ContractEnd { get; set; }
        public EmployeeStatus Status { get; set; } = EmployeeStatus.Employed;
    }
}