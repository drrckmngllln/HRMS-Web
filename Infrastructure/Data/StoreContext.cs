using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
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
    }
}