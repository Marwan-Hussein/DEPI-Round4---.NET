using System.ComponentModel.DataAnnotations;

namespace Day04.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Degree { get; set; }
        public double MinDegree { get; set; }

        // FK
        public int DepartmentId { get; set; }

        // NPs
        public Department Department { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<StuCrsRes> StuCrsResult { get; set; }
    }
}
