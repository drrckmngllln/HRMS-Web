using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class OtherInformation : BaseEntity
    {
        [MaxLength(100)]
        public Employee EmployeeNumber { get; set; }
        [MaxLength(100)]
        public int EmployeeNumberId { get; set; }
        [MaxLength(100)]
        public SpecialSkills SpecialSkills { get; set; }
        [MaxLength(100)]
        public int SpecialSkillsId { get; set; }
        [MaxLength(100)]
        public NonAcademicDestinction NonAcademicDestinction { get; set; }
        [MaxLength(100)]
        public int NonAcademicDestinctionId { get; set; }
        [MaxLength(100)]
        public string Organization { get; set; }
    }
}