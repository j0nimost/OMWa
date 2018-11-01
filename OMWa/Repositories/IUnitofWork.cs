using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.Repositories
{
    public interface IUnitofWork: IDisposable
    {
        IDepartment Department { get; }
        IEmployee Employee { get; }
        IManagers Managers { get; }
        void Save();
    }
}
