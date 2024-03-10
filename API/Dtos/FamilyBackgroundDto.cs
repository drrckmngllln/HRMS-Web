namespace API.Dtos;

public class FamilyBackgroundDto
{
    public int Id { get; set; }
    public int EmployeeNumber { get; set; }
    public string SpouseSurname { get; set; }
    public string SpouseFirstName { get; set; }
    public string SpouseMiddlename { get; set; }
    public string Occupation { get; set; }
    public string EmployerName { get; set; }
    public string BusinessAddress { get; set; }
    public string TelephoneNumber { get; set; }
    public string FatherSurname { get; set; }
    public string FatherFirstname { get; set; }
    public string FatherMiddlename { get; set; }
    public string MotherSurnamne { get; set; }
    public string MotherFirstname { get; set; }
    public string MotherMiddlename { get; set; }
}