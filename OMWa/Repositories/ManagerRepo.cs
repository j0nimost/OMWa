using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OMWa.DAL;
using OMWa.Models;

namespace OMWa.Repositories
{
    public class ManagerRepo : IManagers
    {
        private OMWaContext context;
        public ManagerRepo(OMWaContext context)
        {
            this.context = context;
        }

        public async Task Add(Managers entity)
        {
            await this.context.Managers.AddAsync(entity);
            await this.context.SaveChangesAsync();
        }

        public async Task<Managers> Get(string Id)
        {
            var manager = await this.context.Managers.Where(c => c.JobId == Id).SingleOrDefaultAsync();
            return manager;
        }

        public async Task<ICollection<Managers>> Get()
        {
            var managers = await this.context.Managers.ToListAsync();
            return managers;
        }

        public async Task Remove(string Id)
        {
            var manager = await this.context.Managers.Where(x => x.JobId == Id).SingleOrDefaultAsync();
            this.context.Managers.Remove(manager);
            await this.context.SaveChangesAsync();
        }

        public async Task Update(Managers entity)
        {
            var manager = await this.context.Managers.Where(x => x.JobId == entity.JobId).SingleOrDefaultAsync();
            this.context.Entry(manager).CurrentValues.SetValues(entity);
            await this.context.SaveChangesAsync();
        }
    }
}
