using OMWa.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.Repositories
{
    /// <summary>
    /// Department: Add, Get, Update and Delete
    /// </summary>
    public class Departments : IDepartment
    {
        //inject the Context
        private OMWaContext OMWaContext;
        public Departments(OMWaContext OMWaContext)
        {
            this.OMWaContext = OMWaContext;
        }

        public async Task Add(Departments entity)
        {
        }

        public Task<Departments> Get(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Departments>> Get()
        {
            throw new NotImplementedException();
        }

        public Task Remove(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Departments entity)
        {
            throw new NotImplementedException();
        }
    }
}
