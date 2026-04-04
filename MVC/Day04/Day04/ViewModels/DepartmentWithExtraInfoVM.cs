using Day04.Models;

namespace Day04.ViewModels
{
    public class DepartmentWithExtraInfoVM
    {
        public string DepName { get; set; }
        public int TotStudents { get; set; }

        public string State { get; set; }
        public List<Student> StudentsEx25{ get; set; }
    }
}
