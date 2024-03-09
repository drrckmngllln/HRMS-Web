using System.ComponentModel;
using Core.Entities.Settings;

namespace Core.Specifications;

public class AttendanceSetupSpecification : BaseSpecification<AttendanceSetup>
{
    public AttendanceSetupSpecification(string search, int? CategoryId) 
        :base(x => 
        (!CategoryId.HasValue) || x.CategoryId == CategoryId)
    {
        AddInclude(x => x.Category);
    }
    public AttendanceSetupSpecification(int id) 
        : base(x => x.Id == id)
    {
        AddInclude(x => x.Category);
    }
}