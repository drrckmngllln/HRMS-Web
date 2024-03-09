using Core.Entities.Settings;

namespace Core.Specifications;

public class DepartmentsSpecifications : BaseSpecification<Department>
{
    public DepartmentsSpecifications(string search) 
        : base(x => (string.IsNullOrEmpty(search)) || x.Name.ToLower().Contains(search))
    {
        
    }

    public DepartmentsSpecifications(int id) : base(x => x.Id == id)
    {
    }
}