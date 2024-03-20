using System.Linq.Expressions;
using Core.Entities.Transactions.AttendanceEntity;
using Core.Parameters;

namespace Core.Specifications.Transactions
{
    public class AttendanceIdentitySpecifications : BaseSpecification<AttendanceIdentity>
    {
        public AttendanceIdentitySpecifications(AttendanceIdentitySpecParameters parameters) 
            : base(x => 
            (string.IsNullOrEmpty(parameters.Search) || x.EmployeeNumber.FullName.ToLower().Contains(parameters.Search)) &&
            (!parameters.EmployeeNumberId.HasValue || x.EmployeeNumberId == parameters.EmployeeNumberId))
        {
            AddInclude(x => x.EmployeeNumber);
            ApplyPaging(parameters.PageSize * (parameters.PageNumber - 1), parameters.PageSize);
        }
        public AttendanceIdentitySpecifications(int id)
            : base (x => x.Id == id)
        {
            AddInclude(x => x.EmployeeNumber);
        }
    }
}