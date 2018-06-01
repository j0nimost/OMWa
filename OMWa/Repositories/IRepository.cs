using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.Repositories
{
    public interface IRepository<in T>
    {
        Task Add(T entity);
        Task Update(T entity);
        Task Remove(Guid Id);
    }
}
