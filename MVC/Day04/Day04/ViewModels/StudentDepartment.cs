using Day04.Models;
namespace Day04.ViewModels
{
    public class StudentDepartment
    {
        // Student
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Department Department { get; set; }

    }
}
