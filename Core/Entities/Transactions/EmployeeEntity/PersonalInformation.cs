using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class PersonalInformation : BaseEntity
    {
        [MaxLength(100)]
        public Employee EmployeeNumber { get; set; }
        [MaxLength(100)]
        public int EmployeeNumberId { get; set; }
        [MaxLength(100)]
        public string Surname { get; set; }
        [MaxLength(100)]
        public string Firstname { get; set; }
        [MaxLength(100)]
        public string Middlename { get; set; }
        [MaxLength(100)]
        public string DateOfBirth { get; set; }
        [MaxLength(100)]
        public Sex Sex { get; set; }
        [MaxLength(100)]
        public CivilStatus CivilStatus { get; set; }
        [MaxLength(100)]
        public string Height { get; set; }
        [MaxLength(100)]
        public string BloodType { get; set; }
        [MaxLength(100)]
        public string GsisIdNo { get; set; }
        [MaxLength(100)]
        public string PagibigIdNo { get; set; }
        [MaxLength(100)]
        public string PhilhealthNo { get; set; }
        [MaxLength(100)]
        public string SssNo { get; set; }
        [MaxLength(100)]
        public string TinNo { get; set; }
        [MaxLength(100)]
        public string AgencyEmployeeNo { get; set; }
    }
}