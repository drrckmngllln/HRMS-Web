namespace HrmsPrototype.Core.Entities.Settings
{
    internal class AttendanceIdentity : BaseEntity
    {
        public string EmployeeNumber { get; set; }
        public byte[] Data { get; set; }
    }
}
