using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities.Transactions.EmployeeEntity
{
    public class PersonalInformation : BaseEntity
    {
        public Employee EmployeeNumber { get; set; }
        public int EmployeeNumberId { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string DateOfBirth { get; set; }
        public Sex Sex { get; set; }
        public CivilStatus CivilStatus { get; set; }
        public string Height { get; set; }
        public string BloodType { get; set; }
        public string GsisIdNo { get; set; }
        public string PagibigIdNo { get; set; }
        public string PhilhealthNo { get; set; }
        public string SssNo { get; set; }
        public string TinNo { get; set; }
        public string AgencyEmployeeNo { get; set; }
    }
}