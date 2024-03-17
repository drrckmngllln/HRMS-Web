using Core.Entities.Settings;
using Core.Parameters.SettingsParams;

namespace Core.Specifications;

public class CampusesSpecifications : BaseSpecification<Campus>
{
    public CampusesSpecifications(string search) 
        : base(x => 
            (string.IsNullOrEmpty(search)) || x.Name.ToLower().Contains(search) || x.Description.ToLower().Contains(search))
    {
        
    }

    public CampusesSpecifications(int id) 
        : base(x => x.Id == id)
    {
        
    }

}