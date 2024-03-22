using System.ComponentModel.DataAnnotations;
using Core.Entities.Transactions.EmployeeEntity;

namespace API.Dtos;

public class PersonalInformationDto
{
    public int Id { get; set; }
    [Required]
    public int EmployeeNumber { get; set; }
    [Required]
    public string Surname { get; set; }
    [Required]
    public string Firstname { get; set; }
    [Required]
    public string Middlename { get; set; }
    [Required]
    public string DateOfBirth { get; set; }
    [Required]
    public Sex Sex { get; set; }
    [Required]
    public CivilStatus CivilStatus { get; set; }
    [Required]
    public string Height { get; set; }
    [Required]
    public string BloodType { get; set; }
    [Required]
    public string GsisIdNo { get; set; }
    [Required]
    public string PagibigIdNo { get; set; }
    [Required]
    public string PhilhealthNo { get; set; }
    [Required]
    public string SssNo { get; set; }
    [Required]
    public string TinNo { get; set; }
    [Required]
    public string AgencyEmployeeNo { get; set; }
}