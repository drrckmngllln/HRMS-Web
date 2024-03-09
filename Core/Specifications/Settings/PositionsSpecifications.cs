using System.Linq.Expressions;
using Core.Entities.Settings;

namespace Core.Specifications.Settings
{
    public class PositionsSpecifications : BaseSpecification<Positions>
    {
        public PositionsSpecifications(string search) 
            : base(x => string.IsNullOrEmpty(search) || x.Name.ToLower().Contains(search))
        {
        }

        public PositionsSpecifications(int id)
            : base(x => x.Id == id)
        {
            
        }
    }
}