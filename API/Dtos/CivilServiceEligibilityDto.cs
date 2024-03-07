namespace API.Dtos;

public class CivilServiceEligibilityDto
{
    public int Id { get; set; }
    public int EmployeeNumber { get; set; }
    public string Eligibility { get; set; }
    public decimal Rating { get; set; }
    public string DateOfExamination { get; set; }
    public string PlaceOfExamination { get; set; }
    public string LicenseNumber { get; set; }
    public string DateOfValidity { get; set; }
}