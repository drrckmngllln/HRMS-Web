using Core.Entities.Settings;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<Campus> Campuses { get; set; }
        public DbSet<LeaveSetup> LeaveSetups { get; set; }
        public DbSet<AttendanceSetup> AttendanceSetups { get; set; }
    }
}