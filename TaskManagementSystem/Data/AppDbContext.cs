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
        // Add models here:
       public DbSet<Attachment> Attachments { get; set; }
       public DbSet<BugReport> BugReports { get; set; }
       public DbSet<Project> Projects { get; set; }
       public DbSet<Role> Roles { get; set; }
       public DbSet<SystemLog> SystemLogs { get; set; }
       public DbSet<TaskHistory> TaskHistories { get; set; }
       public DbSet<TestReport> TestReports { get; set; }
       public DbSet<TimeTracking> TimeTrackings { get; set; }
       public DbSet<User> Users { get; set; }
    }
}
