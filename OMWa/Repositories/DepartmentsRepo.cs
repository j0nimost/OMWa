using OMWa.DAL;
using OMWa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.Repositories
{
    /// <summary>
    /// Department: Add, Get, Update and Delete
    /// </summary>
    public class DepartmentsRepo : Repository<Departments>, IDepartment
    {
        private OMWaContext context {
            get
            {
                return context as OMWaContext;
            }
        }

        public DepartmentsRepo(OMWaContext context) : base(context)
        {
        }
    }
}
