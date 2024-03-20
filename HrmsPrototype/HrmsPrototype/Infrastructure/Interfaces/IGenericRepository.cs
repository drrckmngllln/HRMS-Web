using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrmsPrototype.Infrastructure.Interfaces
{
    internal interface IGenericRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync(string url);
        Task<T> GetByIdAsync(string id);
        Task AddAsync(T entity, string url);
        Task UpdateAsync(T entity, string url);
        Task DeleteAsync(string url);
        Task<IReadOnlyList<T>> SearchAsync(string value);

    }
}
