using System.ComponentModel.DataAnnotations;

namespace Day04.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required, MaxLength(80)]
        public string Name { get; set; }

        public int Age { get; set; }
        
        // FK
        public int DepartmentId { get; set; }

        // Navigation properties (NPs)
        public Department Department { get; set; }
        public List<StuCrsRes> StuCrsResult { get; set; }
    }
}
