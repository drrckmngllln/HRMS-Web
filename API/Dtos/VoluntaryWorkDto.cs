namespace API.Dtos;

public class VoluntaryWorkDto
{
    public int Id { get; set; }
    public int EmployeeNumber { get; set; }
    public string NameAndAddressOfOrganization { get; set; }
    public string StartDate { get; set; }
    public string EndDate { get; set; }
    public int NumberOfHours { get; set; }
    public string NatureOfWork { get; set; }
}