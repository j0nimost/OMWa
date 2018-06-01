using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OMWa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OMWa.DAL
{
    /// <summary>
    /// OMWa Context used to Create Tables
    /// </summary>
    public class OMWaContext: IdentityDbContext<OMWaUsers, OMWaRoles, Guid>
    {

        public OMWaContext(DbContextOptions<OMWaContext> options)
            :base(options)
        {
        }
        

        public virtual Departments Departments { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual Managers Managers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<OMWaUsers>(c => c.ToTable("User"));
            builder.Entity<OMWaRoles>(c => c.ToTable("Roles"));

            /*builder.Entity<IdentityUser>(c =>
            {
                c.ToTable("User");
                c.HasKey(x => x.Id);
            });
            builder.Entity<IdentityRole>(c =>
            {
                c.ToTable("Roles");
                c.HasKey(x => x.Id);
            });*/

            builder.Entity<IdentityUserRole<string>>(c => {
                c.ToTable("UserRoles");
                c.HasKey(x => new { x.UserId, x.RoleId });
            });

            builder.Entity<IdentityUserClaim<string>>(c =>
            {
                c.ToTable("UserClaim");
                c.HasKey(x => new { x.Id, x.UserId });
            });

            builder.Entity<IdentityUserLogin<string>>(c =>
            {
                c.ToTable("UserLogin");
                c.HasKey(x => new { x.ProviderKey, x.UserId });
            });

            builder.Entity<IdentityRoleClaim<string>>(c =>
            {
                c.ToTable("RoleClaims");
                c.HasKey(x => new { x.Id, x.RoleId });
            });

            builder.Entity<IdentityUserToken<string>>(c =>
            {
                c.ToTable("UserTokens");
                c.HasKey(x => x.UserId);
            });

        }
    }
}
