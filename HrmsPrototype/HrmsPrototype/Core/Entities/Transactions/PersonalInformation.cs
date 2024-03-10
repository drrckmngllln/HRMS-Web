namespace HrmsPrototype.Core.Entities.Transactions
{
    internal class PersonalInformation
    {
        public int Id { get; set; }
        public int EmployeeNumber { get; set; }
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
