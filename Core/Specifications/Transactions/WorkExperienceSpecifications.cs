using Core.Entities.Transactions.EmployeeEntity;

namespace Core.Specifications;

public class WorkExperienceSpecifications : BaseSpecification<WorkExperience>
{
    public WorkExperienceSpecifications(int id) : base(x => x.EmployeeNumberId == id)
    {
        
    }
}