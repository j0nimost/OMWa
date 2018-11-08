using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.Models.DTO
{
  public class TaskDto
  {
    public TaskDto()
    {
      JobId = new HashSet<string>();
    }

    public string Title { get; set; }
    public string Details { get; set; }
    public TimeSpan? Deadline { get; set; }
    public bool IsCompleted { get; set; }
    public bool IsRescheduled { get; set; }

    public ICollection<string> JobId { get; set; }
  }
}
