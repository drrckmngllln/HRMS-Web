using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Settings
{
    public class LeaveSetup : BaseEntity
    {
        // [MaxLength(100)]
        public string Type { get; set; }
        // [MaxLength(100)]
        public int Credits { get; set; }
    }
}