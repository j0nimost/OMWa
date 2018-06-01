using OMWa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.Repositories
{
    public interface IManagers: IRepository<Managers>
    {

        Task Remove(string Id);
        Task<Managers> Get(string Id);
        Task<ICollection<Managers>> Get();
        
    }
}
