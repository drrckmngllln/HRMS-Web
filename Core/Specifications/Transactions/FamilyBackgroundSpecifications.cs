using Core.Entities.Transactions.EmployeeEntity;

namespace Core.Specifications;

public class FamilyBackgroundSpecifications : BaseSpecification<FamilyBackground>
{
    public FamilyBackgroundSpecifications(int id) : base(x => x.EmployeeNumberId == id)
    {
        
    }
}