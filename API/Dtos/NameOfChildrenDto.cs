using System.ComponentModel.DataAnnotations;

namespace API.Dtos;

public class NameOfChildrenDto
{
    public int Id { get; set; }
    [Required]
    public string EmployeeNumber { get; set; }
    [Required]
    public string Fullname { get; set; }
    [Required]
    public DateTime DateOfBirth { get; set; }
}