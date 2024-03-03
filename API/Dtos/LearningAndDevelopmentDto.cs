namespace API.Dtos;

public class LearningAndDevelopmentDto
{
    public int Id { get; set; }
    public int EmployeeNumber { get; set; }
    public string TitleOfLearningAndDevelopment { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public int NumberOfHours { get; set; }
    public string TypeOfLd { get; set; }
    public string Conducted { get; set; }
}