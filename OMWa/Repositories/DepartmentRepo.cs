using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OMWa.DAL;
using OMWa.Models;

namespace OMWa.Repositories
{
    /// <summary>
    /// Department Repository: CRUD Operations
    /// </summary>
    public class DepartmentRepo : IDepartment
    {
        private OMWaContext context;
        public DepartmentRepo(OMWaContext context)
        {
            this.context = context;
        }

        public async Task Add(Departments entity)
        {
            await this.context.Departments.AddAsync(entity);
            await this.context.SaveChangesAsync();
        }

        public async Task<Departments> Get(Guid Id)
        {
            var dep = await this.context.Departments.Where(x => x.DepartmentId == Id).SingleOrDefaultAsync();
            return dep;

        }

        public async Task<ICollection<Departments>> Get()
        {
            var deps = await this.context.Departments.ToListAsync();
            return deps;
        }

        public async Task Remove(Guid Id)
        {
            var dep = await this.context.Departments.Where(x => x.DepartmentId == Id).SingleOrDefaultAsync();
            this.context.Departments.Remove(dep);
            await this.context.SaveChangesAsync();
            
        }

        public async Task Update(Departments entity)
        {
            var dep = await this.context.Departments.Where(x => x.DepartmentId == entity.DepartmentId).SingleOrDefaultAsync();
            this.context.Entry(dep).CurrentValues.SetValues(entity);
            await this.context.SaveChangesAsync();
        }
    }
}
