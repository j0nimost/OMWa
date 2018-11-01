using OMWa.DAL;
using OMWa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.Repositories
{
    public class EmployeesRepo : Repository<Employees>, IEmployee
    {
        private OMWaContext context
        {
            get
            {
                return context as OMWaContext;
            }
        }

        public EmployeesRepo(OMWaContext context) : base(context)
        {
        }
    }
}
