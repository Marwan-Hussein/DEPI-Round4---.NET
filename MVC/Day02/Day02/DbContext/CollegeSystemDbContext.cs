using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection;
using Day02.Models;
using Day02.Configurations;
namespace Day02.DbContext
{
    public class CollegeSystemDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server = .; Database = CollegeSystem; Trusted_Connection = True;"
                , b => b.MigrationsAssembly("EF02")
                );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
