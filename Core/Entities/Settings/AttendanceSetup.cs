using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Settings
{
    public class AttendanceSetup : BaseEntity
    {
        public AttendanceSetupCategory Category { get; set; }
        public int CategoryId { get; set; }
        [MaxLength(100)]
        public string TimeIn { get; set; }
        [MaxLength(100)]
        public string TimeOut { get; set; }
        [MaxLength(100)]
        public int GracePeriod { get; set; }
    }
}