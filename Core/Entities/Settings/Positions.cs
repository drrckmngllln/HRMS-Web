using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Settings
{
    public class Positions : BaseEntity
    {
        [MaxLength(100)]
        public string Name { get; set; }
    }
}