using System.Linq.Expressions;
using Core.Entities.Settings;

namespace Core.Specifications.Settings
{
    public class AttendanceCategorySpecifications : BaseSpecification<AttendanceSetupCategory>
    {
        public AttendanceCategorySpecifications(string search)
            : base(x => 
            (string.IsNullOrEmpty(search) || x.Name.ToLower().Contains(search)))
        {
            
        }
        public AttendanceCategorySpecifications(int id) 
            : base(x => x.Id == id)
        {
        }
    }
}