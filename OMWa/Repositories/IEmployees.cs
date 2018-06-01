using OMWa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.Repositories
{
    public interface IEmployees: IRepository<Employees>
    {

        Task Remove(string Id);
        Task<Employees> Get(string Id);
        Task<ICollection<Employees>> Get();
        Task<ICollection<Employees>> GetEmployeesInDepartment(Guid Id);
    }
}
