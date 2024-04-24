using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using coreMvcAdvancedWebApplication.Models;

namespace coreMvcAdvancedWebApplication.Data
{
    public class coreMvcAdvancedWebApplicationContext : DbContext
    {
        public coreMvcAdvancedWebApplicationContext (DbContextOptions<coreMvcAdvancedWebApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<coreMvcAdvancedWebApplication.Models.User> User { get; set; } = default!;
    }
}
