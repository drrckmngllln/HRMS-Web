using System.ComponentModel.DataAnnotations;
using Core.Entities.Transactions.EmployeeEntity;

namespace API.Dtos;

public class EducationalBackgroundDto
{
    [Required]
    public int Id { get; set; }
    [Required]
    public int EmployeeNumber { get; set; }
    [Required]
    public EducationalLevel Level { get; set; }
    [Required]
    public string NameOfSchool { get; set; }
    [Required]
    public string Course { get; set; }
    [Required]
    public DateOnly PeriodStart { get; set; }
    [Required]
    public DateOnly PeriodEnd { get; set; }
    [Required]
    public decimal UnitsEarned { get; set; }
    [Required]
    public DateOnly YearGraduated { get; set; }
    [Required]
    public string AcademicHonors { get; set; }
}