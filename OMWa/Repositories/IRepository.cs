using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.Repositories
{
    public interface IRepository<T>
    {
        Task<T> Get(Guid Id);
        Task<IEnumerable<T>> GetAll();
        void AddItem(T entity);
        void Update(T entity);
        void Remove(T entity);
    }
}
