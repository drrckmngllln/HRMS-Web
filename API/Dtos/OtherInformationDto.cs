using System.ComponentModel.DataAnnotations;

namespace API.Dtos;

public class OtherInformationDto
{
    public int Id { get; set; }
    [Required]
    public int EmployeeNumber { get; set; }
    [Required]
    public string SpecialSkills { get; set; }
    [Required]
    public string NonAcademicDestinction { get; set; }
    [Required]
    public string Organization { get; set; }
}