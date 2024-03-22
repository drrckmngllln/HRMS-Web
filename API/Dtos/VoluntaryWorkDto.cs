using System.ComponentModel.DataAnnotations;

namespace API.Dtos;

public class VoluntaryWorkDto
{
    public int Id { get; set; }
    [Required]
    public int EmployeeNumber { get; set; }
    [Required]
    public string NameAndAddressOfOrganization { get; set; }
    [Required]
    public string StartDate { get; set; }
    [Required]
    public string EndDate { get; set; }
    [Required]
    public int NumberOfHours { get; set; }
    [Required]
    public string NatureOfWork { get; set; }
}