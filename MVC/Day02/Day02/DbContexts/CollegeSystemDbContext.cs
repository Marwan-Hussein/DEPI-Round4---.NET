using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection;
using Day02.Models;
using Day02.Configurations;
namespace Day02.DbContexts
{
    public class CollegeSystemDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server = .; Database = CollegeSystem; Trusted_Connection = True;TrustServerCertificate=True;"
                , b => b.MigrationsAssembly("Day02")
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
