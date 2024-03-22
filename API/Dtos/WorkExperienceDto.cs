using System.ComponentModel.DataAnnotations;

namespace API.Dtos;

public class WorkExperienceDto
{
    public int Id { get; set; }
    [Required]
    public int EmployeeNumber { get; set; }
    [Required]
    public string StartDate { get; set; }
    [Required]
    public string EndDate { get; set; }
    [Required]
    public string Position { get; set; }
    [Required]
    public string Department { get; set; }
    [Required]
    public decimal MonthlySalary { get; set; }
    [Required]
    public string PayGrade { get; set; }
    [Required]
    public string StatusOfAppointment { get; set; }
    [Required]
    public string GovernmentService { get; set; }
}