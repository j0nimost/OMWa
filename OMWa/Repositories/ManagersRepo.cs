using OMWa.DAL;
using OMWa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.Repositories
{
    public class ManagersRepo : Repository<Managers>, IManagers
    {
        private OMWaContext context
        {
            get
            {
                return context as OMWaContext;
            }
        }

        public ManagersRepo(OMWaContext context) : base(context)
        {
        }
    }
}
