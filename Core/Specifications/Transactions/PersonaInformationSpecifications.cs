using Core.Entities.Transactions.EmployeeEntity;

namespace Core.Specifications;

public class PersonaInformationSpecifications : BaseSpecification<PersonalInformation>
{
    public PersonaInformationSpecifications(int EmployeeNumberId) : base(x => x.EmployeeNumberId == EmployeeNumberId)
    {
        
    }
}