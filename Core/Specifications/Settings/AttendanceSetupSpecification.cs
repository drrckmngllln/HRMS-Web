using System.ComponentModel;
using Core.Entities.Settings;
using Core.Parameters.SettingsParams;

namespace Core.Specifications;

public class AttendanceSetupSpecification : BaseSpecification<AttendanceSetup>
{
    public AttendanceSetupSpecification(AttendanceSetupSpecParams parameter) 
        :base(x => 
        (string.IsNullOrEmpty(parameter.Search) || x.Category.Name.ToLower().Contains(parameter.Search)) &&
        (!parameter.CategoryId.HasValue) || x.CategoryId == parameter.CategoryId)
    {
        AddInclude(x => x.Category);
    }
    public AttendanceSetupSpecification(int id) 
        : base(x => x.Id == id)
    {
        AddInclude(x => x.Category);
    }
}