using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Day05.Models;

namespace Day05.Data.Configurations
{
    public class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> Stu)
        {
            Stu.ToTable("Students");

            Stu.HasKey(s => s.Id);

            Stu.HasOne(S => S.Department)
                .WithMany(D => D.Students)
                .HasForeignKey(S => S.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
