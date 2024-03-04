using Core.Entities.Transactions.EmployeeEntity;

namespace Core.Specifications;

public class OtherInformationSpecifications : BaseSpecification<OtherInformation>
{
    public OtherInformationSpecifications(int id) : base(x => x.EmployeeNumberId == id)
    {
        
    }
}