using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class NonAcademicDestinction : BaseEntity
    {
        [MaxLength(100)]
        public string Desctinction { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
    }
}