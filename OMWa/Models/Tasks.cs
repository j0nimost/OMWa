using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.Models
{
  public class Tasks
  {
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid TaskId { get; set; }
    public string Title { get; set; }
    public string Details { get; set; }
    public TimeSpan? Deadline { get; set; }
    public bool IsCompleted { get; set; }
    public bool IsRescheduled { get; set; }

    public ICollection<string> JobId { get; set; }
  }
}
