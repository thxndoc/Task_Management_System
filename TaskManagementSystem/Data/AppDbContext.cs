using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Models;

namespace TaskManagementSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }

        // Add models here, for example:
       // public DbSet<User> Users { get; set; }
       public DbSet<User> Users { get; set; }
       public DbSet<Project> Projects { get; set; }

    }
}
