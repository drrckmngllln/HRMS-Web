namespace HrmsPrototype.Core.Entities.Settings
{
    internal class AttendanceSetup : BaseEntity
    {
        public AttendanceSetupCategory Category { get; set; } = AttendanceSetupCategory.NonTeaching;
        public string TimeIn { get; set; }
        public string TimeOut { get; set; }
        public string GracePeriod { get; set; }
    }
}
