using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.Models.DTO
{
  public class DepartmentDto
  {

    public DepartmentDto()
    {
      this.Employees = new HashSet<Employees>();
    }
    public Guid DepartmentId { get; set; }
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    public Managers Managers { get; set; }
    public ICollection<Employees> Employees { get; set; }
  }
}
