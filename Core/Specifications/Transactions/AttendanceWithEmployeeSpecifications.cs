using Core.Entities.Transactions.AttendanceEntity;
using Core.Parameters;

namespace Core.Specifications
{
    public class AttendanceWithEmployeeSpecifications : BaseSpecification<Attendance>
    {
        public AttendanceWithEmployeeSpecifications(AttendanceSpecParameters specParams) 
            : base(x => 
            (string.IsNullOrEmpty(specParams.Search) || x.Employee.FullName.ToLower().Contains(specParams.Search)) &&
            (!specParams.EmployeeId.HasValue || x.Id == specParams.EmployeeId))
        {
            AddInclude(x => x.Employee);
        }
        public AttendanceWithEmployeeSpecifications(int id) 
            :base(x => x.Id == id)
        {
            AddInclude(x => x.Employee);
        }
    }
}