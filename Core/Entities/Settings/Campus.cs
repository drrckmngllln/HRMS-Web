using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Settings
{
    public class Campus : BaseEntity
    {
        [MaxLength(100)]
        public string Name { get; set; }
        public string Description { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
    }
}