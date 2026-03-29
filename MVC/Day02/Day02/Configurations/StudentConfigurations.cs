using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Day02.Models;

namespace Day02.Configurations
{
    public class StudentConfigurations
    {
        public void Configure(EntityTypeBuilder<Student> Stu)
        {
            Stu.HasKey(s => s.Id);

            Stu.HasOne(S => S.Department)
                .WithMany(D => D.Students)
                .HasForeignKey(S => S.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
