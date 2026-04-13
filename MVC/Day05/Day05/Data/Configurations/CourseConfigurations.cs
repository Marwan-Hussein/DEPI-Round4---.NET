using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Day05.Models;

namespace Day05.Data.Configurations
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
