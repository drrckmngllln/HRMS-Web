using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities.Settings
{
    public class AttendanceSetup : BaseEntity
    {
        public AttendanceSetupCategory Category { get; set; }
        public int CategoryId { get; set; }
        public DateTime TimeIn { get; set; }
        [MaxLength(100)]
        public DateTime TimeOut { get; set; }
        [MaxLength(100)]
        public int GracePeriod { get; set; }
    }
}