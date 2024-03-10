using Core.Entities.Transactions.EmployeeEntity;

namespace Core.Specifications;

public class VoluntaryWorkSpecifications : BaseSpecification<VoluntaryWork>
{
    public VoluntaryWorkSpecifications(int id) : base(x => x.EmployeeNumberId == id)
    {
        
    }
}