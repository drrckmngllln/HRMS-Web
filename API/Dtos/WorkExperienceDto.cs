namespace API.Dtos;

public class WorkExperienceDto
{
    public int Id { get; set; }
    public int EmployeeNumber { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public string Position { get; set; }
    public string Department { get; set; }
    public decimal MonthlySalary { get; set; }
    public string PayGrade { get; set; }
    public string StatusOfAppointment { get; set; }
    public string GovernmentService { get; set; }
}