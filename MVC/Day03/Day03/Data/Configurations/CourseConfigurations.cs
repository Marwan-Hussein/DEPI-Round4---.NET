using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Day03.Models;

namespace Day03.Data.Configurations
{
    public class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> Crs)
        {
            Crs.ToTable("Courses");
            Crs.HasKey(c => c.Id);
            Crs.HasOne(C => C.Department)
                .WithMany(D => D.Courses)
                .HasForeignKey(C => C.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
