using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection;
using Day04.Models;
using Day04.Data.Configurations;
namespace Day04.Data.DbContexts
{
    public class CollegeSystemDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server = .; Database = CollegeSystem; Trusted_Connection = True;TrustServerCertificate=True;"
                , b => b.MigrationsAssembly("Day04")
                );
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<StuCrsRes> StuCrsRes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
