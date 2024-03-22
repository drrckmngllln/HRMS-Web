using System.ComponentModel.DataAnnotations;

namespace API.Dtos;

public class LearningAndDevelopmentDto
{
    public int Id { get; set; }
    [Required]
    public int EmployeeNumber { get; set; }
    [Required]
    public string TitleOfLearningAndDevelopment { get; set; }
    [Required]
    public string StartDate { get; set; }
    [Required]
    public string EndDate { get; set; }
    [Required]
    public int NumberOfHours { get; set; }
    [Required]
    public string TypeOfLd { get; set; }
    [Required]
    public string Conducted { get; set; }
}