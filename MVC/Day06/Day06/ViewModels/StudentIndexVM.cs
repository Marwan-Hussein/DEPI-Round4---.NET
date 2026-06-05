using Day06.Models;

namespace Day06.ViewModels
{
    public class StudentIndexVM
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Department> Departments { get; set; } = new List<Department>();
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string SearchName { get; set; }
        public int? DepartmentId { get; set; }
    }
}
