using Core.Entities.Settings;

namespace Core.Specifications;

public class LeaveSetupSpecifications : BaseSpecification<LeaveSetup>
{
    public LeaveSetupSpecifications(string search)
        : base(x => (string.IsNullOrEmpty(search) || x.Type.ToLower().Contains(search)))
    {
        
    }

    public LeaveSetupSpecifications(int id) 
        : base(x => x.Id == id)
    {
        
    }
}