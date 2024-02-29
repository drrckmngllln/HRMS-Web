using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class FamilyBackground : BaseEntity
    {
        public Employee EmployeeNumber { get; set; }
        public int EmployeeNumberId { get; set; }
        public string SpouseSurname { get; set; }
        public string SpouseFirstName { get; set; }
        public string SpouseMiddlename { get; set; }
        public string Occupation { get; set; }
        public string EmployerName { get; set; }
        public string BusinessAddress { get; set; }
        public string TelephoneNumber { get; set; }
        public string FatherSurname { get; set; }
        public string FatherFirstname { get; set; }
        public string FatherMiddlename { get; set; }
        public string MotherSurnamne { get; set; }
        public string MotherFirstname { get; set; }
        public string MotherMiddlename { get; set; }
        public List<NameOfChildren> NameOfChildrens { get; set; }
    }
}