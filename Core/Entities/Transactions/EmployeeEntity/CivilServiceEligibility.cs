namespace Core.Entities.Transactions.EmployeeEntity
{
    public class CivilServiceEligibility : BaseEntity
    {
        public Employee EmployeeNumber { get; set; }
        public int EmployeeNumberId { get; set; }
        public string Eligibility { get; set; }
        public decimal Rating { get; set; }
        public string DateOfExamination { get; set; }
        public string PlaceOfExamination { get; set; }
        public string LicenseNumber { get; set; }
        public string DateOfValidity { get; set; }
    }
}