using OMWa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.Repositories
{
    public interface IDepartment: IRepository<Departments>
    {
        Task<Departments> Get(Guid Id);
        Task<ICollection<Departments>> Get();
    }
}
