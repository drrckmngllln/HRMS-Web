using System.Linq.Expressions;
using Core.Entities.Transactions.EmployeeEntity;

namespace Core.Specifications
{
    public class EmployeesWithRelationshipSpecifications : BaseSpecification<Employee>
    {
        public EmployeesWithRelationshipSpecifications(int id) 
        : base(x => x.Id == id)
        {
            AddInclude(x => x.Department);
            AddInclude(x => x.Position);
        }

        public EmployeesWithRelationshipSpecifications(EmployeeSpecParameters empParams) 
            : base(x => 
            (!string.IsNullOrEmpty(empParams.Search) || x.FullName.ToLower().Contains(empParams.Search)) && 
            (!empParams.DepartmentId.HasValue || x.DepartmentId == empParams.DepartmentId) && 
            (!empParams.PositionId.HasValue || x.PositionId == empParams.PositionId))
        {
            AddInclude(x => x.Department);
            AddInclude(x => x.Position);
            AddOrderBy(x => x.FullName);
            ApplyPaging(empParams.PageSize * (empParams.PageNumber - 1), empParams.PageNumber);
        }
    }
}