using AutoMapper;
using OMWa.Models;
using OMWa.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.Mappings
{
    public class Domain : Profile
    {
        public Domain()
        {
            CreateMap<Departments, DepartmentDto>().ReverseMap();
            CreateMap<Tasks, TaskDto>().ReverseMap();
        }
    }
}
