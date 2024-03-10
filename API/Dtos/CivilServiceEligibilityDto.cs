using System.ComponentModel.DataAnnotations;

namespace API.Dtos;

public class CivilServiceEligibilityDto
{
    [Required]
    public int Id { get; set; }
    [Required]
    public int EmployeeNumber { get; set; }
    [Required]
    public string Eligibility { get; set; }
    [Required]
    public decimal Rating { get; set; }
    [Required]
    public DateOnly DateOfExamination { get; set; }
    [Required]
    public string PlaceOfExamination { get; set; }
    [Required]
    public string LicenseNumber { get; set; }
    [Required]
    public string DateOfValidity { get; set; }
}