using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OMWa.DAL;
using OMWa.Models;

namespace OMWa.Repositories
{
    public class EmployeeRepo : IEmployees
    {
        private OMWaContext context;
        public EmployeeRepo(OMWaContext context)
        {
            this.context = context;
        }

        public async Task Add(Employees entity)
        {
            await this.context.Employees.AddAsync(entity);
            await this.context.SaveChangesAsync();
        }

        public async Task<Employees> Get(string Id)
        {
            var emp = await this.context.Employees.Where(x => x.JobId == Id).SingleOrDefaultAsync();
            return emp;
        }

        public async Task<ICollection<Employees>> Get()
        {
            var emps = await this.context.Employees.ToListAsync();
            return emps;
        }

        public async Task<ICollection<Employees>> GetEmployeesInDepartment(Guid Id)
        {
            var emps = await this.context.Employees.Where(x => x.DepartmentId == Id).ToListAsync();
            return emps;
        }

        public async Task Remove(string Id)
        {
            var emp = await this.context.Employees.Where(x => x.JobId == Id).SingleOrDefaultAsync();
            this.context.Employees.Remove(emp);
            await this.context.SaveChangesAsync();
            
        }

        public async Task Update(Employees entity)
        {
            var emp = await this.context.Employees.Where(x => x.JobId == entity.JobId).SingleOrDefaultAsync();
            this.context.Entry(emp).CurrentValues.SetValues(entity);
            await this.context.SaveChangesAsync();
        }
    }
}
