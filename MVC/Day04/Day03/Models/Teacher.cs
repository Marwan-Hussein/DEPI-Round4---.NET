using System.ComponentModel.DataAnnotations;

namespace Day04.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        [Required, MaxLength(80)]
        public string Name { get; set; }

        public decimal Salary { get; set; }
        public string Address { get; set; }

        // FK
        public int DepartmentId { get; set; }

        public int CourseId { get; set; }

        // NPs
        public Course Course { get; set; }
        public Department Department { get; set; }
    }
}
