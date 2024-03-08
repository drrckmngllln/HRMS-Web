using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Core.Entities.Settings
{
    public class AttendanceSetupCategory : BaseEntity
    {
        [MaxLength(100)]
        public string Name { get; set; }        
    }
}