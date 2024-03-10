using Core.Entities.Transactions.EmployeeEntity;
using Core.Parameters;

namespace Core.Specifications
{
    public class EmployeesWithRelationshipSpecifications : BaseSpecification<Employee>
    {

        public EmployeesWithRelationshipSpecifications(EmployeeSpecParameters empParams) 
            : base(x => 
            (string.IsNullOrEmpty(empParams.Search) || x.FullName.ToLower().Contains(empParams.Search)) && 
            (!empParams.DepartmentId.HasValue || x.DepartmentId == empParams.DepartmentId) && 
            (!empParams.PositionId.HasValue || x.PositionId == empParams.PositionId))
        {
            AddInclude(x => x.Department);
            AddInclude(x => x.Position);
            AddOrderBy(x => x.FullName);
            ApplyPaging(empParams.PageSize * (empParams.PageNumber - 1), empParams.PageSize);
        }
        
        public EmployeesWithRelationshipSpecifications(int id) 
        : base(x => x.Id == id)
        {
            AddInclude(x => x.Department);
            AddInclude(x => x.Position);
        }

        
    }
}