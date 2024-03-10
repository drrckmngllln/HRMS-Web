using Core.Entities.Transactions.EmployeeEntity;

namespace Core.Specifications;

public class EducationalBackgroundSpecifications : BaseSpecification<EducationalBackground>
{
    public EducationalBackgroundSpecifications(int id) : base(x => x.EmployeeNumberId == id)
    {
        
    }
}