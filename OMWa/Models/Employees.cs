using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.Models
{
    /// <summary>
    /// Employee Profile
    /// </summary>
    public class Employees
    {
        [Key]
        public string JobId { get; set; }
        public bool IsActive { get; set; }
        public Guid Id { get; set; }
        public OMWaUsers Users { get; set; }
        public Guid DepartmentId { get; set; }
        public Departments Departments { get; set; }
    }
}
