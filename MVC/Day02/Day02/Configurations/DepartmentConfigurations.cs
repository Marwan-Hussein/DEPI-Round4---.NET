using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Day02.Models;

namespace Day02.Configurations
{
    public class DepartmentConfigurations
    {
        public void Configure(EntityTypeBuilder<Department> Dept)
        {
            Dept.HasKey(d => d.Id);
        }
    }
}
