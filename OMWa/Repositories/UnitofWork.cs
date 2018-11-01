using OMWa.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.Repositories
{
    public class UnitofWork : IUnitofWork
    {
        private readonly OMWaContext context;

        public IEmployee Employee { get; private set; }
        public IDepartment Department { get; private set; }
        public IManagers Managers { get; private set; }

        public UnitofWork(OMWaContext context)
        {
            this.context = context;
            Employee = new EmployeesRepo(this.context);
            Department = new DepartmentsRepo(this.context);
            Managers = new ManagersRepo(this.context);
        }


        public void Dispose()
        {
            this.context.Dispose();
        }

        public void Save()
        {
            _ = this.context.SaveChangesAsync().GetAwaiter().GetResult();
        }
    }
}
