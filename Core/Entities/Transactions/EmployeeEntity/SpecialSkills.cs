using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class SpecialSkills : BaseEntity
    {
        [MaxLength(100)]
        public string Skills { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
    }
}