using Core.Entities.Transactions.EmployeeEntity;

namespace API.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public string ContractStart { get; set; }
        public string ContractEnd { get; set; }
        public EmployeeStatus Status { get; set; }
    }
}