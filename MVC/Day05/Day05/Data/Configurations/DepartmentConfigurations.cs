using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Day05.Models;

namespace Day05.Data.Configurations
{
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> Dept)
        {
            Dept.ToTable("Departments");
            Dept.HasKey(d => d.Id);
        }
    }
}
