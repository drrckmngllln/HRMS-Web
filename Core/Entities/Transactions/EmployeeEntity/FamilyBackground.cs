using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class FamilyBackground : BaseEntity
    {
        [MaxLength(100)]
        public Employee EmployeeNumber { get; set; }
        [MaxLength(100)]
        public int EmployeeNumberId { get; set; }
        [MaxLength(100)]
        public string SpouseSurname { get; set; }
        [MaxLength(100)]
        public string SpouseFirstName { get; set; }
        [MaxLength(100)]
        public string SpouseMiddlename { get; set; }
        [MaxLength(100)]
        public string Occupation { get; set; }
        [MaxLength(100)]
        public string EmployerName { get; set; }
        [MaxLength(100)]
        public string BusinessAddress { get; set; }
        [MaxLength(100)]
        public string TelephoneNumber { get; set; }
        [MaxLength(100)]
        public string FatherSurname { get; set; }
        [MaxLength(100)]
        public string FatherFirstname { get; set; }
        [MaxLength(100)]
        public string FatherMiddlename { get; set; }
        [MaxLength(100)]
        public string MotherSurnamne { get; set; }
        [MaxLength(100)]
        public string MotherFirstname { get; set; }
        [MaxLength(100)]
        public string MotherMiddlename { get; set; }
        
    }
}