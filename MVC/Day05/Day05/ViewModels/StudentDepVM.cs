using Day05.Models;

namespace Day05.ViewModels
{
    public class StudentDepVM
    {
        // Student
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        // Department
        public List<Department> Departments { get; set; }
    }
}
