using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.Models.DTO
{
  public class ManagersDto
  {
    [Required]
    public string JobId { get; set; }
    public bool IsActive { get; set; }
    public string JobTitle { get; set; }
    public string JobRole { get; set; }
    public byte[] ProfileImage { get; set; }
    [Required]
    public Guid Id { get; set; }
    [Required]
    public Guid DepartmentId { get; set; }
  }
}
