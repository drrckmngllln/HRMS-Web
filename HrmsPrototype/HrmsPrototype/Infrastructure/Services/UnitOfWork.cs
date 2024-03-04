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

        public GenericRepository<T> Repository<T>() where T : class
        {

            if (_repositories == null)
            {
                _repositories = new Hashtable();
            }

            var type = typeof(T).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(GenericRepository<>);

                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType());

                _repositories.Add(type, repositoryInstance);
            }

            return (GenericRepository<T>)_repositories[type];
        }
    }
}
