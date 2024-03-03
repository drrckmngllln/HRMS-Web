using Core.Entities.Settings;

namespace Core.Specifications;

public class AttendanceSetupSpecification : BaseSpecification<AttendanceSetup>
{
    public AttendanceSetupSpecification(int id) 
        : base(x => x.Id == id)
    {
        
    }
}