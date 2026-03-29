using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Day02.Models;

namespace Day02.Configurations
{
    public class TeacherConfigurations
    {
        public void Configure(EntityTypeBuilder<Teacher> Teacher)
        {
            Teacher.HasKey(T => T.Id);
            Teacher.Property(T => T.Salary)
                .HasPrecision(6, 2);

            Teacher.HasOne(T => T.Department)
                .WithMany(D => D.Teachers)
                .HasForeignKey(T => T.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            Teacher.HasOne(T => T.Course)
                .WithMany(C => C.Teachers)
                .HasForeignKey(T => T.CourseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
