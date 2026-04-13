using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Day05.Models;

namespace Day05.Data.Configurations
{
    public class StuCrsResConfigurations : IEntityTypeConfiguration<StuCrsRes>
    {
        public void Configure(EntityTypeBuilder<StuCrsRes> SCR)
        {
            SCR.ToTable("StudentCourseResult");

            SCR.HasKey(x => new { x.StudentId, x.CourseId });

            SCR.HasOne(SCR => SCR.Student)
                .WithMany(S => S.StuCrsResult)
                .HasForeignKey(SCR => SCR.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            SCR.HasOne(SCR => SCR.Course)
                .WithMany(C => C.StuCrsResult)
                .HasForeignKey(SCR => SCR.CourseId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
