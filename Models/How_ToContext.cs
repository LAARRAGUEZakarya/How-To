using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using How_To.Areas.Identity.Data;
using How_To.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace How_To.Data
{
    public class How_ToContext : IdentityDbContext<HowToUser>
    {
        public How_ToContext(DbContextOptions<How_ToContext> options)
            : base(options)
        {
        }
            
        public DbSet<Article> articles { get; set; }
        public DbSet<Category> categories { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
