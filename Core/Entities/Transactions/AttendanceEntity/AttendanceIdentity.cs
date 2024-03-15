using Core.Entities.Transactions.EmployeeEntity;

namespace Core.Entities.Transactions.AttendanceEntity;

public class AttendanceIdentity : BaseEntity
{
    public Employee EmployeeNumber { get; set; }
    public int EmployeeNumberId { get; set; }
    public byte[] Data { get; set; }
}