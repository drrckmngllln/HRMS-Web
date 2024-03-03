using Core.Entities.Transactions.EmployeeEntity;

namespace Core.Specifications;

public class LearningAndDevelopmentSpecifications : BaseSpecification<LearningAndDevelopment>
{
    public LearningAndDevelopmentSpecifications(int id) : base(x => x.EmployeeNumberId == id)
    {
        
    }
}