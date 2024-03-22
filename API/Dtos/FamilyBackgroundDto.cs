using System.ComponentModel.DataAnnotations;

namespace API.Dtos;

public class FamilyBackgroundDto
{
    public int Id { get; set; }
    [Required]
    public int EmployeeNumber { get; set; }
    [Required]
    public string SpouseSurname { get; set; }
    [Required]
    public string SpouseFirstName { get; set; }
    [Required]
    public string SpouseMiddlename { get; set; }
    [Required]
    public string Occupation { get; set; }
    [Required]
    public string EmployerName { get; set; }
    [Required]
    public string BusinessAddress { get; set; }
    [Required]
    public string TelephoneNumber { get; set; }
    [Required]
    public string FatherSurname { get; set; }
    [Required]
    public string FatherFirstname { get; set; }
    [Required]
    public string FatherMiddlename { get; set; }
    [Required]
    public string MotherSurnamne { get; set; }
    [Required]
    public string MotherFirstname { get; set; }
    [Required]
    public string MotherMiddlename { get; set; }
}