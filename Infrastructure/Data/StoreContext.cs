using System.Reflection;
using Core.Entities.Settings;
using Core.Entities.Transactions.AttendanceEntity;
using Core.Entities.Transactions.EmployeeEntity;
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

        //Employees
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PersonalInformation> PersonalInformations { get; set; }
        public DbSet<FamilyBackground> FamilyBackgrounds { get; set; }
        public DbSet<EducationalBackground> EducationalBackgrounds { get; set; }
        public DbSet<CivilServiceEligibility> CivilServiceEligibilities { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<VoluntaryWork> VoluntaryWorks { get; set; }
        public DbSet<LearningAndDevelopment> LearningAndDevelopments { get; set; }
        public DbSet<OtherInformation> OtherInformations { get; set; }
        public DbSet<NameOfChildren> NameOfChildrens { get; set; }

        // Attendance
        public DbSet<Attendance> Attendances { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            if (Database.ProviderName == "Microsoft.EntityFrameworkCore.Sqlite")
            {
                foreach (var entityType in modelBuilder.Model.GetEntityTypes())
                {
                    var properties = entityType.ClrType.GetProperties()
                    .Where(p => p.PropertyType == typeof(decimal));

                    foreach (var property in properties)
                    {
                        modelBuilder.Entity(entityType.Name).Property(property.Name)
                        .HasConversion<double>();
                    }
                }
            }
        }
    }
}