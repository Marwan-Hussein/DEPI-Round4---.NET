using System.ComponentModel.DataAnnotations;

namespace Day02.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required, MaxLength(80)]
        public string Name { get; set; }

        public string? MgrName { get; set; }

        // Navigation properties (NPs)
        public List<Teacher> Teachers { get; set; }
        public List<Course> Courses { get; set; }
        public List<Student> Students { get; set; }
    }
}
