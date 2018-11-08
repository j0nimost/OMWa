using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.Models
{
    /// <summary>
    /// 
    /// This is Users Profile including:
    ///         - Admin
    ///         - Managers
    ///         - Employees
    /// </summary>
    public class OMWaUsers: IdentityUser<Guid>
    {
        public DateTime DOJ { get; set; }
    }
}
