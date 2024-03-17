using HrmsPrototype.Infrastructure.Interfaces;
using HrmsPrototype.Infrastructure.Repositories;
using System;
using System.Collections;
using System.Threading.Tasks;

namespace HrmsPrototype.Infrastructure.Services
{
    internal class UnitOfWork
    {
        private Hashtable _repositories;

        public Task<int> Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        //public Task<T> Repository<T>() where T : class
        //{
        //    var repo = new GenericRepository<T>();
        //    return repo;
        //}
    }
}
