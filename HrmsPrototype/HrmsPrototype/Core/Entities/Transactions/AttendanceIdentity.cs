using HrmsPrototype.Core.Entities.Settings;

namespace HrmsPrototype.Core.Entities.Transactions
{
    internal class AttendanceIdentity
    {
        public int Id { get; set; }
        public int EmployeeNumber { get; set; }
        public byte[] Data { get; set; }
    }
}
