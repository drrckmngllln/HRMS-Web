using Core.Entities.Transactions.EmployeeEntity;

namespace Core.Specifications;

public class CivilServiceEligibilitySpecifications : BaseSpecification<CivilServiceEligibility>
{
    public CivilServiceEligibilitySpecifications(int id) : base(x => x.EmployeeNumberId == id)
    {
        
    }
}