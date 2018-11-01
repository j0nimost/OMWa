using Microsoft.EntityFrameworkCore;
using OMWa.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        //Initialize context
        public readonly OMWaContext context;
        public Repository(OMWaContext context)
        {
            this.context = context;

        }

        public void AddItem(T entity)
        {
            this.context.Set<T>().AddAsync(entity).GetAwaiter().GetResult();
        }

        public async Task<T> Get(Guid Id)
        {
            return await this.context.Set<T>().FindAsync(Id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this.context.Set<T>().ToListAsync();
        }

        public void Remove(T entity)
        {
            this.context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            this.context.Set<T>().Update(entity);
        }
    }
}
