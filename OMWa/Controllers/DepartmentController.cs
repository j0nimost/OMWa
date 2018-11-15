using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OMWa.Models.DTO;
using OMWa.Models;
using OMWa.Repositories;

namespace OMWa.Controllers
{
    [Produces("application/json")]
    [Route("api/department")]
    public class DepartmentController : Controller
    {
        private readonly IUnitofWork unitofWork;
        private readonly IMapper mapper;
        public DepartmentController(IUnitofWork unitofWork)
        {
           this.unitofWork = unitofWork;
        }

        public DepartmentController(IMapper mapper)
        {
            this.mapper = mapper;
        }
        // GET: api/Department
        [HttpGet]
        public IActionResult Get()
        {
            //get items
            var departments = this.unitofWork.Department.GetAll().GetAwaiter().GetResult();
            var depDto = this.mapper.Map<IEnumerable<DepartmentDto>>(departments);

            return Ok(depDto);
        }

        // GET: api/Department/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(Guid id)
        {
            var department = this.unitofWork.Department.Get(id).GetAwaiter().GetResult();
            var depDto = this.mapper.Map<DepartmentDto>(department);
            if(depDto != null)
            {
                return Ok(depDto);
            }
            return NotFound(depDto);
        }
        
        // POST: api/Department
        [HttpPost]
        public IActionResult Post([FromBody]DepartmentDto value)
        {
            //validate
            if (ModelState.IsValid)
            {
                var department = this.mapper.Map<Departments>(value);

                this.unitofWork.Department.AddItem(department);
                this.unitofWork.Save();
                return CreatedAtRoute(routeName: "Get", routeValues: new { Id = department.DepartmentId }, value: department);
            }
            return BadRequest("Invalid State");
        }
        
        // PUT: api/Department/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody]DepartmentDto value)
        {
            //map
            if (ModelState.IsValid)
            {
                var department = this.mapper.Map<Departments>(value);
                var depExists = this.unitofWork.Department.Get(id);

                if(depExists != null)
                {
                    this.unitofWork.Department.Update(department);
                    this.unitofWork.Save();
                    return NoContent();
                }
                return NotFound();
            }

            return BadRequest("Invalid State");
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            //check if exists
            var dep = this.unitofWork.Department.Get(id).GetAwaiter().GetResult();

            if (dep != null)
            {
                
                this.unitofWork.Department.Remove(dep);
                return Ok();
            }
            return BadRequest("Invalid Action");
        }
    }
}
