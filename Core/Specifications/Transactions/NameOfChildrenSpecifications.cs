using Core.Entities.Transactions.EmployeeEntity;

namespace Core.Specifications;

public class NameOfChildrenSpecifications : BaseSpecification<NameOfChildren>
{
    public NameOfChildrenSpecifications(int id) : base(x => x.EmployeeNumberId == id)
    {
        
    }
}