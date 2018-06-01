using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.Models
{
    /// <summary>
    /// Departments where Managers are in charge 
    ///         - ICollection<Employees>
    /// </summary>
    public class Departments
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Managers Managers { get; set; }
        public ICollection<Employees> Employees { get; set; }
        
    }
}
